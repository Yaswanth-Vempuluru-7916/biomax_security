
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace FKAttendDllCSSample
{
    class CardPwdReference
    {
        public static string GetCardOrPwdWithStr(byte[] byteCurrEnrollDate)
        {
            byte[] mbyeCurEnrollDate = new byte[20080];
            Array.Copy(byteCurrEnrollDate, mbyeCurEnrollDate, byteCurrEnrollDate.Length);
            byte[] head = new byte[8];
            byte[] data = new byte[byteCurrEnrollDate.Length - 8];
            string strhead = "";
            int len = mbyeCurEnrollDate.Length;
            for (int i = 0; i < mbyeCurEnrollDate.Length; i++)
            {
                if (mbyeCurEnrollDate[i] == 0)
                {
                    len = i - 8;
                    break;
                }
                if (i < 8)
                {
                    head[i] = mbyeCurEnrollDate[i];
                    if (i == 7) strhead = Encoding.ASCII.GetString(head);
                }
                else
                {
                    data[i - 8] = mbyeCurEnrollDate[i];
                }
            }
            if (len < 1) MessageBox.Show("Card Or Pass is NULL");
            byte[] tdata = new byte[len];
            Array.Copy(data, tdata, tdata.Length);
            if (strhead.StartsWith("IDC"))
            {
                Int64 temp = Convert.ToInt64(Encoding.ASCII.GetString(tdata));
                if (temp < 0)
                {
                    temp = 0xffffffff + temp + 1;

                }
                return temp.ToString();
                //showmsg("card:" + Encoding.ASCII.GetString(tdata));
            }
            else if (strhead.StartsWith("PWD"))
            {
                byte[] pwd = new byte[tdata.Length];
                CardPwdReference.FKHS3760_DecryptPwd(tdata, ref pwd, pwd.Length);
                //showmsg("password:" + Encoding.ASCII.GetString(pwd).Replace("\0", ""));
                string temp = Encoding.ASCII.GetString(pwd);
                return temp;
                //return Convert.ToInt32(temp.Substring(0, temp.IndexOf('\0')));
            }
            return "show card or pwd fail";
        }

        private const int PWD_DATA_SIZE = 40;
        public static byte[] getPWD(string pwd)
        {
            //PWD_HS1:  IDC_HS1:;
            byte[] bpwd = new byte[PWD_DATA_SIZE];
            byte[] head = Encoding.ASCII.GetBytes("PWD_HS1:");
            byte[] spwd = Encoding.ASCII.GetBytes(pwd);
            byte[] temp = new byte[32 - spwd.Length];
            byte[] mpwd = MergerArray(spwd, temp);
            temp = new byte[32];
            CardPwdReference.FKHS3760_EncryptPwd(ref mpwd, ref temp, 32);
            bpwd = MergerArray(head, temp);
            return bpwd;
        }

        public static byte[] getCard(string card)
        {
            Int64 tmp = Convert.ToInt64(card);
            if (tmp > int.MaxValue)
            {
                tmp = tmp - 0xffffffff - 1;
                card = tmp.ToString();
            }
            //PWD_HS1:  IDC_HS1:;
            byte[] bcard = new byte[PWD_DATA_SIZE];
            byte[] head = Encoding.ASCII.GetBytes("IDC_HS1:");
            byte[] scard = Encoding.ASCII.GetBytes(card);
            byte[] temp = new byte[32 - scard.Length];
            byte[] mcard = MergerArray(scard, temp);
            bcard = MergerArray(head, mcard);
            return bcard;
        }

        public static byte[] MergerArray(byte[] First, byte[] Second)
        {
            byte[] result = new byte[First.Length + Second.Length];
            First.CopyTo(result, 0);
            Second.CopyTo(result, First.Length);
            return result;
        }

        public static void FKHS3760_EncryptPwd(ref byte[] apOrgPwdData, ref byte[] apEncPwdData, int aPwdLen)
        {
            int i;

            gPassEncryptKey = 12415;
            for (i = 0; i < aPwdLen; i++)
                apEncPwdData[i] = Encrypt_1Byte(apOrgPwdData[i]);
        }

        public static int gPassEncryptKey;
        public static byte Encrypt_1Byte(byte aByteData)
        {
            int U0 = 28904;
            int U1 = 35756;
            byte vCrytData;

            vCrytData = (byte)(aByteData ^ (byte)(gPassEncryptKey >> 8));
            gPassEncryptKey = (vCrytData + gPassEncryptKey) * U0 + U1;
            return vCrytData;
        }

        public static void FKHS3760_DecryptPwd(byte[] apEncPwdData, ref byte[] apOrgPwdData, int aPwdLen)
        {
            int i;

            gPassEncryptKey = 12415;
            for (i = 0; i < aPwdLen; i++)
                apOrgPwdData[i] = Decrypt_1Byte(apEncPwdData[i]);
        }

        public static byte Decrypt_1Byte(byte aByteData)
        {
            int U0 = 28904;
            int U1 = 35756;
            byte vCrytData;

            vCrytData = (byte)(aByteData ^ (byte)(gPassEncryptKey >> 8));
            gPassEncryptKey = (aByteData + gPassEncryptKey) * U0 + U1;
            return vCrytData;
        }

        //=================================jalali Util==========================================================
        public class tStruct_Date
        {
            public int year = 0;
            public int month = 0;
            public int day = 0;

            public const int jalaYear = 1372;//1304;
            private int[] Nmonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            private static int[] Table = { 0, 3, 6, 2, 5, 1, 4, 6, 1, 3, 5, 0 };
            public tStruct_Date()
            {
            }
            public tStruct_Date(int y, int m, int d)
            {
                year = y;
                month = m;
                day = d;
            }

            public bool Equals(tStruct_Date obj)
            {
                if (obj == null || obj.day == 0 || obj.month == 0 || obj.year == 0)
                    return false;
                if (this.day == 0 || this.month == 0 || this.year == 0)
                    return false;
                if (obj.year == this.year && obj.month == this.month && obj.day == this.day)
                    return true;
                else
                    return false;
            }

            private static bool CheckValidInput(int Input)
            {
                if (Input >= tStruct_Date.jalaYear && Input <= 2099)
                    return true;
                else
                    return false;
            }

            public static bool IsLeapYear(int Year)
            {
                Year = (Year + 1) & 0x0003;
                if (Year == 0)
                    return true;
                else
                    return false;
            }

            public int toBigint()
            {
                int days = 0;
                for (int i = 1900; i < year; i++)
                {
                    if ((i % 400 == 0) || ((i % 4 == 0) && (i % 100 != 0)))
                        days += 366;
                    else days += 365;
                }
                for (int i = 0; i < month - 1; i++)
                {
                    days += Nmonth[i];
                    if (i == 1 && ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))))
                        days++;
                }
                days += day;
                return days - 1;
            }

            public static int MMod(int numerator, int denominator)
            {
                return ((numerator % denominator) + denominator) % denominator;
            }

            public static int persian_jdn(int iYear, int iMonth, int iDay)
            {
                int PERSIAN_EPOCH = 1948321; //The JDN of 1 Farvardin 1
                int epbase;
                int epyear;
                int mdays;
                int temp;
                if (iYear >= 0)
                    epbase = iYear - 474;
                else
                    epbase = iYear - 473;

                epyear = 474 + MMod(epbase, 2820);
                if (iMonth <= 7)
                    mdays = (iMonth - 1) * 31;
                else
                    mdays = (iMonth - 1) * 30 + 6;

                temp = iDay + mdays + (((epbase / 2820) * 1029983 + (PERSIAN_EPOCH - 1)));
                return temp + (((((epyear * 682) - 110) / 2816) + (epyear - 1) * 365));
            }

            public static int Ceil(int num, int x)
            {
                if (num % x == 0) return num / x;
                else return num / x + 1;
            }

            public static string jdn_persianstr(int jdn)
            {
                int depoch;
                int cycle, cyear, ycycle, aux1, aux2, yday, iYear, iMonth, iDay;
                depoch = jdn - persian_jdn(475, 1, 1);
                cycle = depoch / 1029983;
                cyear = MMod(depoch, 1029983);
                if (cyear == 1029982)
                    ycycle = 2820;
                else
                {
                    aux1 = cyear / 366;
                    aux2 = MMod(cyear, 366);
                    ycycle = ((((2134 * aux1) + (2816 * aux2) + 2815) / 1028522)) + aux1 + 1;
                }
                iYear = ycycle + (2820 * cycle) + 474;
                if (iYear <= 0)
                    iYear = iYear - 1;
                yday = (jdn - persian_jdn(iYear, 1, 1)) + 1;
                if (yday <= 186)
                    iMonth = Ceil(yday, 31);
                else
                    iMonth = Ceil((yday - 6), 30);
                iDay = (jdn - persian_jdn(iYear, iMonth, 1)) + 1;
                //sprintf("%04d/%02d/%02d",iYear, iMonth,iDay);
                return new DateTime(iYear, iMonth, iDay).ToString("yyyy/MM/dd");
            }

            public static tStruct_Date jdn_persian(int jdn)
            {
                int depoch;
                int cycle, cyear, ycycle, aux1, aux2, yday, iYear, iMonth, iDay;
                depoch = jdn - persian_jdn(475, 1, 1);
                cycle = depoch / 1029983;
                cyear = MMod(depoch, 1029983);
                if (cyear == 1029982)
                    ycycle = 2820;
                else
                {
                    aux1 = cyear / 366;
                    aux2 = MMod(cyear, 366);
                    ycycle = ((((2134 * aux1) + (2816 * aux2) + 2815) / 1028522)) + aux1 + 1;
                }
                iYear = ycycle + (2820 * cycle) + 474;
                if (iYear <= 0)
                    iYear = iYear - 1;
                yday = (jdn - persian_jdn(iYear, 1, 1)) + 1;
                if (yday <= 186)
                    iMonth = Ceil(yday, 31);
                else
                    iMonth = Ceil((yday - 6), 30);
                iDay = (jdn - persian_jdn(iYear, iMonth, 1)) + 1;
                //sprintf("%04d/%02d/%02d",iYear, iMonth,iDay);
                return new tStruct_Date(iYear, iMonth, iDay);
            }

            public static int getjalaliWeekday(int CurrentYear, int Month, int Day)
            {
                int TempYear;
                int AccValue;
                if (!CheckValidInput(CurrentYear))/* Return Error if input not Valid*/
                    return -1;
                TempYear = tStruct_Date.jalaYear;/*Comparation start with year 1990*/
                AccValue = 0;/*Init AccValue to 0*/
                             /* If TempYear is a leap year AccValue +2, else AccValue+1 */
                while (TempYear != CurrentYear)
                {
                    AccValue++;
                    if (IsLeapYear(TempYear))
                        AccValue++;
                    TempYear++;
                }
                if (Month != 12)
                    AccValue += Table[Month - 1];
                AccValue += Day;
                AccValue = AccValue % 7;
                return AccValue;
            }
        }
    }

    public class Database
    {
        private OleDbConnection oleConn = null;
        private string ConnStr = "";
        private int _DBType = 0;

        private string _Err = "";
        public string Err
        {
            get { return _Err; }
        }

        const int CommandTimeout = 36000;

        public Database(string ConnectionString)
        {
            ConnStr = ConnectionString;
            _DBType = 255;
        }

        public void Open()
        {
            Open(ConnStr);
        }

        public void Open(string ConnectionString)
        {
            ConnStr = ConnectionString;
            Open(_DBType, ConnStr);
        }

        public void Open(int DBType, string ConnectionString)
        {
            _DBType = DBType;
            ConnStr = ConnectionString;
            Close();
            switch (_DBType)
            {
                case 1:
                case 2:
                    break;
                case 255:
                    oleConn = new OleDbConnection(ConnStr);
                    oleConn.Open();
                    break;
            }
        }

        public void SetConnStr(string ConnectionString)
        {
            ConnStr = ConnectionString;
        }

        public void Close()
        {
            if (oleConn != null)
            {
                oleConn.Close();
                oleConn = null;
            }
        }

        public bool IsOpen
        {
            get
            {
                return ((oleConn != null) && (oleConn.State == ConnectionState.Open));
            }
        }

        public int ExecSQL(string SQLQuery)
        {
            SQLQuery = SQLQuery.Trim();
            int ret = 0;
            if (!IsOpen) Open();
            switch (_DBType)
            {
                case 1:
                case 2:
                case 255:
                    OleDbCommand oleCmd = new OleDbCommand(SQLQuery, oleConn);
                    oleCmd.CommandTimeout = CommandTimeout;
                    ret = oleCmd.ExecuteNonQuery();
                    break;
            }
            return ret;
        }

        public int ExecSQL(List<string> SQLQuery)
        {
            int ret = 0;
            string sql = "";
            try
            {
                if (!IsOpen) Open();
                switch (_DBType)
                {
                    case 1:
                    case 2:
                    case 255:
                        OleDbCommand oleCmd;
                        OleDbTransaction oleTran = oleConn.BeginTransaction();
                        try
                        {
                            for (int i = 0; i < SQLQuery.Count; i++)
                            {
                                sql = SQLQuery[i].Trim();
                                if (sql == "") continue;
                                oleCmd = new OleDbCommand(sql, oleConn);
                                oleCmd.CommandTimeout = CommandTimeout;
                                oleCmd.Transaction = oleTran;
                                oleCmd.ExecuteNonQuery();
                            }
                            oleTran.Commit();
                        }
                        catch (Exception E)
                        {
                            ret = 1;
                            oleTran.Rollback();
                            _Err = E.Message;
                        }
                        break;
                }
            }
            catch (Exception E)
            {
                ret = -1;
                _Err = E.Message;
            }
            return ret;
        }

        public int ExecSQL(string SQLQuery, bool HideError)
        {
            int ret = 0;
            if (HideError)
            {
                try
                {
                    ret = ExecSQL(SQLQuery);
                }
                catch
                {
                }
            }
            else
            {
                ret = ExecSQL(SQLQuery);
            }
            return ret;
        }

        public string ExecSQLMsg(string SQLQuery)
        {
            string ret = "";
            DataTableReader dr = GetDataReader(SQLQuery);
            if (dr.Read()) ret = dr[0].ToString();
            dr.Close();
            return ret.Trim();
        }

        public bool UpdateByteData(string sql, string picField, byte[] Data)
        {
            bool ret = false;
            try
            {
                if (!IsOpen) Open();
                switch (_DBType)
                {
                    case 1:
                    case 2:
                    case 255:
                        OleDbCommand OleDbCmd;
                        if (Data == null)
                        {
                            sql = sql.Replace("@" + picField, "null");
                            OleDbCmd = new OleDbCommand(sql, oleConn);
                            OleDbCmd.CommandTimeout = CommandTimeout;
                        }
                        else
                        {
                            OleDbCmd = new OleDbCommand(sql, oleConn);
                            OleDbCmd.CommandTimeout = CommandTimeout;
                            OleDbParameter OleDbParam = new OleDbParameter("@" + picField, SqlDbType.Image);
                            OleDbParam.Value = Data;
                            OleDbCmd.Parameters.Add(OleDbParam);
                        }
                        ret = OleDbCmd.ExecuteNonQuery() > 0;
                        break;
                }
            }
            catch (Exception E)
            {
                _Err = E.Message;
            }
            return ret;
        }

        public DataTableReader GetDataReader(string SQLQuery)
        {
            DataSet ds = GetDataSet(SQLQuery);
            return ds.CreateDataReader();
        }

        public DataSet GetDataSet(string SQLQuery)
        {
            DataSet ds = new DataSet();
            if (SQLQuery == "")
            {
                ds = null;
            }
            else
            {
                if (!IsOpen)
                {
                    if (ConnStr == "")
                    {
                        OpenFileDialog dlgOpen = new OpenFileDialog();
                        dlgOpen.InitialDirectory = System.Windows.Forms.Application.StartupPath;
                        dlgOpen.Filter = "DB Files (*.mdb)|*.mdb|All Files (*.*)|*.*";
                        dlgOpen.FilterIndex = 1;
                        if (dlgOpen.ShowDialog() == DialogResult.OK)
                        {
                            ConnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=false;Data Source=" + dlgOpen.FileName;
                            Open(ConnStr);
                        }
                        else return null;
                    }
                    else
                        Open();
                }
                switch (_DBType)
                {
                    case 1:
                    case 2:
                    case 255:
                        OleDbDataAdapter oleDA = new OleDbDataAdapter(SQLQuery, oleConn);
                        if (oleDA.SelectCommand != null) oleDA.SelectCommand.CommandTimeout = CommandTimeout;
                        if (oleDA.DeleteCommand != null) oleDA.DeleteCommand.CommandTimeout = CommandTimeout;
                        if (oleDA.UpdateCommand != null) oleDA.UpdateCommand.CommandTimeout = CommandTimeout;
                        oleDA.Fill(ds, "DataSource");
                        oleDA.Dispose();
                        oleDA = null;
                        break;
                }
            }
            return ds;
        }

        public DataTable GetDataTable(string SQLQuery)
        {
            DataTable dt = new DataTable();
            if (SQLQuery == "")
            {
                dt = null;
            }
            else
            {
                if (!IsOpen) Open();
                switch (_DBType)
                {
                    case 1:
                    case 2:
                    case 255:
                        OleDbDataAdapter oleDA = new OleDbDataAdapter(SQLQuery, oleConn);
                        if (oleDA.SelectCommand != null) oleDA.SelectCommand.CommandTimeout = CommandTimeout;
                        if (oleDA.DeleteCommand != null) oleDA.DeleteCommand.CommandTimeout = CommandTimeout;
                        if (oleDA.UpdateCommand != null) oleDA.UpdateCommand.CommandTimeout = CommandTimeout;
                        oleDA.Fill(dt);
                        oleDA.Dispose();
                        oleDA = null;
                        break;
                }
            }
            return dt;
        }
    }

    public class TIDAndName
    {
        private string _id;
        private string _name;

        public TIDAndName(string id, string name)
        {
            _id = id;
            _name = name;
        }

        public TIDAndName(int id, string name)
        {
            _id = id.ToString();
            _name = name;
        }

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
