using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace FKAttendDllCSSample
{
  public partial class frmPostShiftInfo : Form
  {
    public frmPostShiftInfo()
    {
      InitializeComponent();
    }

    private byte[] mbytShiftInfo = new byte[FKAttendDLL.SIZE_POST_SHIFT_INFO_V2];
    private byte[] mbytUserInfo = new byte[FKAttendDLL.SIZE_USER_INFO_V2];
    private byte[] mbytUserInfo_StringID = new byte[FKAttendDLL.SIZE_USER_INFO_V3];
    private byte[] mbytUserInfo_StringID13_1 = new byte[FKAttendDLL.SIZE_USER_INFO_V4];
    private POST_SHIFT_INFO mPostShiftInfo;
    private USER_INFO mUserInfo;
    private USER_INFO_STRING_ID mUserInfo_StringID;
    private USER_INFO_STRING_ID_13_1 mUserInfo_StringID13_1;
    private const string mcstrAdoConn = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=false;Data Source=";
    private OleDbConnection mConn = new OleDbConnection();
    private void GetPostShiftInfo()
    {
      int k = 0;

      FKAttendDLL.StringToByteArrayUtf16(txtCompanyName.Text, mPostShiftInfo.CompanyName);

      for (k = 1; k <= FKAttendDLL.MAX_SHIFT_COUNT; k++)
      {
        mPostShiftInfo.ShiftTime[k - 1].AMStartH = Convert.ToByte(dgvShift.Rows[k - 1].Cells[1].Value);
        mPostShiftInfo.ShiftTime[k - 1].AMStartM = Convert.ToByte(dgvShift.Rows[k - 1].Cells[2].Value);
        mPostShiftInfo.ShiftTime[k - 1].AMEndH = Convert.ToByte(dgvShift.Rows[k - 1].Cells[3].Value);
        mPostShiftInfo.ShiftTime[k - 1].AMEndM = Convert.ToByte(dgvShift.Rows[k - 1].Cells[4].Value);

        mPostShiftInfo.ShiftTime[k - 1].PMStartH = Convert.ToByte(dgvShift.Rows[k - 1].Cells[5].Value);
        mPostShiftInfo.ShiftTime[k - 1].PMStartM = Convert.ToByte(dgvShift.Rows[k - 1].Cells[6].Value);
        mPostShiftInfo.ShiftTime[k - 1].PMEndH = Convert.ToByte(dgvShift.Rows[k - 1].Cells[7].Value);
        mPostShiftInfo.ShiftTime[k - 1].PMEndM = Convert.ToByte(dgvShift.Rows[k - 1].Cells[8].Value);

        mPostShiftInfo.ShiftTime[k - 1].OVStartH = Convert.ToByte(dgvShift.Rows[k - 1].Cells[9].Value);
        mPostShiftInfo.ShiftTime[k - 1].OVStartM = Convert.ToByte(dgvShift.Rows[k - 1].Cells[10].Value);
        mPostShiftInfo.ShiftTime[k - 1].OVEndH = Convert.ToByte(dgvShift.Rows[k - 1].Cells[11].Value);
        mPostShiftInfo.ShiftTime[k - 1].OVEndM = Convert.ToByte(dgvShift.Rows[k - 1].Cells[12].Value);
      }

      for (k = 1; k <= FKAttendDLL.MAX_POST_COUNT; k++)
      {
        string strPost = "";
        try
        {
          strPost = System.Convert.ToString(dgvPost.Rows[k - 1].Cells[1].Value);
        }
        catch (Exception)
        {
          strPost = "";
        }

        FKAttendDLL.StringToByteArrayUtf16(strPost, mPostShiftInfo.PostInfo[k - 1].PostName);
      }

      SavePostInfoToDb();
      SaveShiftInfoToDb();
    }



    private void RefreshPostShiftInfoFromDb()
    {
      DataSet dsPost = new DataSet();
      DataSet dsShift = new DataSet();
      OleDbDataAdapter dadapt = default(OleDbDataAdapter);

      if (mConn.State != ConnectionState.Open)
        return;

      dadapt = new OleDbDataAdapter("select * from tblPostName", mConn);
      dadapt.Fill(dsPost);
      dgvPost.DataSource = dsPost.Tables[0];

      dadapt = new OleDbDataAdapter("select * from tblShiftTime", mConn);
      dadapt.Fill(dsShift);
      dgvShift.DataSource = dsShift.Tables[0];
    }

    private void SavePostInfoToDb()
    {
      int k = 0;
      OleDbCommand cmd = new OleDbCommand();

      if (mConn.State != ConnectionState.Open)
        return;


      try
      {
        cmd.Connection = mConn;
        cmd.CommandText = "DELETE FROM tblPostName";
        cmd.ExecuteNonQuery();

        for (k = 1; k <= FKAttendDLL.MAX_POST_COUNT; k++)
        {
          string strPost = "";

          strPost = System.Convert.ToString(FKAttendDLL.ByteArrayUtf16ToString(mPostShiftInfo.PostInfo[k - 1].PostName));
          if (strPost.Length > 0)
          {
            cmd.CommandText = "INSERT INTO tblPostName([No], PostName) " + " VALUES(" + System.Convert.ToString(k) + ", \'" + strPost + "\')";
            cmd.ExecuteNonQuery();
          }
          else
          {
            cmd.CommandText = "INSERT INTO tblPostName([No], PostName) " + " VALUES(" + System.Convert.ToString(k) + ", \'\')";
            cmd.ExecuteNonQuery();
          }
        }
      }
      catch (Exception)
      {
        return;
      }
    }

    private void SaveShiftInfoToDb()
    {
      int k = 0;
      OleDbCommand cmd = new OleDbCommand();

      if (mConn.State != ConnectionState.Open)
        return;

      try
      {
        cmd.Connection = mConn;
        cmd.CommandText = "DELETE FROM tblShiftTime";
        cmd.ExecuteNonQuery();

        for (k = 1; k <= FKAttendDLL.MAX_SHIFT_COUNT; k++)
        {
          cmd.CommandText = "INSERT INTO tblShiftTime(ShiftNo" +
              ", TimeSH1, TimeSM1, TimeEH1, TimeEM1" +
              ", TimeSH2, TimeSM2, TimeEH2, TimeEM2" +
              ", TimeSH3, TimeSM3, TimeEH3, TimeEM3) " +
              " VALUES(" + System.Convert.ToString(k) + ", "
              + mPostShiftInfo.ShiftTime[k - 1].AMStartH + ", " + mPostShiftInfo.ShiftTime[k - 1].AMStartM + ", " + mPostShiftInfo.ShiftTime[k - 1].AMEndH + ", " + mPostShiftInfo.ShiftTime[k - 1].AMEndM + ", "
              + mPostShiftInfo.ShiftTime[k - 1].PMStartH + ", " + mPostShiftInfo.ShiftTime[k - 1].PMStartM + ", " + mPostShiftInfo.ShiftTime[k - 1].PMEndH + ", " + mPostShiftInfo.ShiftTime[k - 1].PMEndM + ", "
              + mPostShiftInfo.ShiftTime[k - 1].OVStartH + ", " + mPostShiftInfo.ShiftTime[k - 1].OVStartM + ", " + mPostShiftInfo.ShiftTime[k - 1].OVEndH + ", " + mPostShiftInfo.ShiftTime[k - 1].OVEndM + ")";
          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception)
      {

      }
    }

    private void ShowPostShiftInfo()
    {
      SavePostInfoToDb();
      SaveShiftInfoToDb();

      txtCompanyName.Text = FKAttendDLL.ByteArrayUtf16ToString(mPostShiftInfo.CompanyName);
      RefreshPostShiftInfoFromDb();
    }

    private void SetupGridUserShiftOfMonth()
    {
      int k = 0;
      string[] rowVal = new string[31];

      dgvUserShiftOfMonth.ColumnCount = 31;
      for (k = 1; k <= 31; k++)
      {
        dgvUserShiftOfMonth.Columns[k - 1].Name = "" + System.Convert.ToString(k);
        dgvUserShiftOfMonth.Columns[k - 1].Width = 24;
        rowVal[k - 1] = "" + System.Convert.ToString(0);
      }
      dgvUserShiftOfMonth.Rows.Add(rowVal);
    }

    private int GetShiftNumOfDayOfUser(int aDay)
    {
      if (aDay < 1 || aDay > 31)
        return 0;

      return Convert.ToInt32(dgvUserShiftOfMonth.Rows[0].Cells[aDay - 1].Value);
    }

    private void SetShiftNumOfDayOfUser(int aDay, int aShiftNumber)
    {
      if (aDay < 1 || aDay > 31)
        return;

      dgvUserShiftOfMonth.Rows[0].Cells[aDay - 1].Value = "" + System.Convert.ToString(aShiftNumber);
    }

    private void cmdGetUserInfo_Click(object sender, EventArgs e)
    {
      int ii;
      int vnResultCode = 0;
      string vStrEnrollNumber = "";
      UInt32 vnEnrollNumber = 0;
      int vUserInfoLen = 0;

      cmdGetUserInfo.Enabled = false;
      lblMessage.Text = "Getting UserInfo ...";
      System.Windows.Forms.Application.DoEvents();

      vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        cmdGetUserInfo.Enabled = true;
        return;
      }
      vStrEnrollNumber = txtEnrollNumber.Text.Trim();
      vnEnrollNumber = FKAttendDLL.GetInt(vStrEnrollNumber);

      int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
      if (vnResultSupportStringID == (int)FKAttendDLL.USER_ID_LENGTH13_1)
      {
        mUserInfo_StringID13_1.YearAssigned = Convert.ToInt16(cmbUserShiftYear.Text);
        mUserInfo_StringID13_1.MonthAssigned = Convert.ToByte(cmbUserShiftMonth.Text);
        FKAttendDLL.ConvertStructureToByteArray(mUserInfo_StringID13_1, mbytUserInfo_StringID13_1);

        vUserInfoLen = FKAttendDLL.SIZE_USER_INFO_V4;// = Convert.ToInt32(Marshal.SizeOf(mUserInfo));
        vnResultCode = FKAttendDLL.FK_GetUserInfoEx_StringID(FKAttendDLL.nCommHandleIndex, vStrEnrollNumber, mbytUserInfo_StringID13_1, ref vUserInfoLen);

        if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
        {
          mUserInfo_StringID13_1 = (USER_INFO_STRING_ID_13_1)FKAttendDLL.ConvertByteArrayToStructure(mbytUserInfo_StringID13_1, typeof(USER_INFO_STRING_ID_13_1));

          txtUserName.Text = FKAttendDLL.ByteArrayUtf16ToString(mUserInfo_StringID13_1.UserName);
          txtPostID.Text = (mUserInfo_StringID13_1.PostId).ToString();
          for (ii = 1; ii <= FKAttendDLL.MAX_DAY_IN_MONTH; ii++)
            SetShiftNumOfDayOfUser(ii, mUserInfo_StringID13_1.ShiftId[ii - 1]);

          lblMessage.Text = "EnrollNumber=" + vStrEnrollNumber + "  " + "Message=" + "OK";
        }
        else
        {
          lblMessage.Text = "EnrollNumber=" + vStrEnrollNumber + "  " + "Message=" + FKAttendDLL.ReturnResultPrint(vnResultCode);
        }

      }
      else if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
      {
        mUserInfo_StringID.YearAssigned = Convert.ToInt16(cmbUserShiftYear.Text);
        mUserInfo_StringID.MonthAssigned = Convert.ToByte(cmbUserShiftMonth.Text);
        FKAttendDLL.ConvertStructureToByteArray(mUserInfo_StringID, mbytUserInfo_StringID);

        vUserInfoLen = FKAttendDLL.SIZE_USER_INFO_V3;// = Convert.ToInt32(Marshal.SizeOf(mUserInfo));
        vnResultCode = FKAttendDLL.FK_GetUserInfoEx_StringID(FKAttendDLL.nCommHandleIndex, vStrEnrollNumber, mbytUserInfo_StringID, ref vUserInfoLen);

        if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
        {
          mUserInfo_StringID = (USER_INFO_STRING_ID)FKAttendDLL.ConvertByteArrayToStructure(mbytUserInfo_StringID, typeof(USER_INFO_STRING_ID));

          txtUserName.Text = FKAttendDLL.ByteArrayUtf16ToString(mUserInfo_StringID.UserName);
          txtPostID.Text = (mUserInfo_StringID.PostId).ToString();
          for (ii = 1; ii <= FKAttendDLL.MAX_DAY_IN_MONTH; ii++)
            SetShiftNumOfDayOfUser(ii, mUserInfo_StringID.ShiftId[ii - 1]);

          lblMessage.Text = "EnrollNumber=" + vStrEnrollNumber + "  " + "Message=" + "OK";
        }
        else
        {
          lblMessage.Text = "EnrollNumber=" + vStrEnrollNumber + "  " + "Message=" + FKAttendDLL.ReturnResultPrint(vnResultCode);
        }

      }
      else
      {
        mUserInfo.YearAssigned = Convert.ToInt16(cmbUserShiftYear.Text);
        mUserInfo.MonthAssigned = Convert.ToByte(cmbUserShiftMonth.Text);
        FKAttendDLL.ConvertStructureToByteArray(mUserInfo, mbytUserInfo);

        vUserInfoLen = FKAttendDLL.SIZE_USER_INFO_V2;// = Convert.ToInt32(Marshal.SizeOf(mUserInfo));
        vnResultCode = FKAttendDLL.FK_GetUserInfoEx(FKAttendDLL.nCommHandleIndex, vnEnrollNumber, mbytUserInfo, ref vUserInfoLen);

        if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
        {
          mUserInfo = (USER_INFO)FKAttendDLL.ConvertByteArrayToStructure(mbytUserInfo, typeof(USER_INFO));

          txtUserName.Text = FKAttendDLL.ByteArrayUtf16ToString(mUserInfo.UserName);
          txtPostID.Text = (mUserInfo.PostId).ToString();
          for (ii = 1; ii <= FKAttendDLL.MAX_DAY_IN_MONTH; ii++)
            SetShiftNumOfDayOfUser(ii, mUserInfo.ShiftId[ii - 1]);

          lblMessage.Text = "EnrollNumber=" + ((UInt32)vnEnrollNumber).ToString() + "  " + "Message=" + "OK";
        }
        else
        {
          lblMessage.Text = "EnrollNumber=" + ((UInt32)vnEnrollNumber).ToString() + "  " + "Message=" + FKAttendDLL.ReturnResultPrint(vnResultCode);
        }
      }
      System.Windows.Forms.Application.DoEvents();

      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
      cmdGetUserInfo.Enabled = true;
    }

    private void cmdSetUserInfo_Click(object sender, EventArgs e)
    {
      int ii;
      int vnResultCode = 0;
      UInt32 vnEnrollNumber = 0;
      string vStrEnrollNumber = "";
      int vUserInfoLen = 0;

      cmdSetUserInfo.Enabled = false;
      lblMessage.Text = "Setting UserInfo ...";
      System.Windows.Forms.Application.DoEvents();

      vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        cmdSetUserInfo.Enabled = true;
        return;
      }

      vStrEnrollNumber = txtEnrollNumber.Text.Trim();
      vnEnrollNumber = FKAttendDLL.GetInt(vStrEnrollNumber);

      int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
      if (vnResultSupportStringID == (int)FKAttendDLL.USER_ID_LENGTH13_1)
      {
        mUserInfo_StringID13_1.Init();
        mUserInfo_StringID13_1.Size = FKAttendDLL.SIZE_USER_INFO_V4; // must set this field
        mUserInfo_StringID13_1.Ver = FKAttendDLL.VER4_USER_INFO;     // must set this field

        //mUserInfo_StringID.UserId = vnEnrollNumber;
        try
        {
          FKAttendDLL.StringToByteArrayUtf16(Convert.ToString(txtUserName.Text), mUserInfo_StringID13_1.UserName); // convert string to byte array as locale setting ()

          mUserInfo_StringID13_1.PostId = Convert.ToByte(txtPostID.Text);
        }
        catch (Exception ex)
        {

        }
        mUserInfo_StringID13_1.YearAssigned = Convert.ToInt16(cmbUserShiftYear.Text);
        mUserInfo_StringID13_1.MonthAssigned = Convert.ToByte(cmbUserShiftMonth.Text);

        for (ii = 1; ii <= FKAttendDLL.MAX_DAY_IN_MONTH; ii++)
          mUserInfo_StringID13_1.ShiftId[ii - 1] = Convert.ToByte(GetShiftNumOfDayOfUser(ii));

        vUserInfoLen = FKAttendDLL.SIZE_USER_INFO_V4;// = Convert.ToInt32(Marshal.SizeOf(mUserInfo));

        FKAttendDLL.ConvertStructureToByteArray(mUserInfo_StringID13_1, mbytUserInfo_StringID13_1);
        vnResultCode = FKAttendDLL.FK_SetUserInfoEx_StringID(FKAttendDLL.nCommHandleIndex, vStrEnrollNumber, mbytUserInfo_StringID13_1, vUserInfoLen);
        if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
        {
          lblMessage.Text = "EnrollNumber=" + vStrEnrollNumber + "  " + "Message=" + "OK";
        }
        else
        {
          lblMessage.Text = "EnrollNumber=" + vStrEnrollNumber + "  " + "Message=" + FKAttendDLL.ReturnResultPrint(vnResultCode);
        }

      }
      else if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
      {
        mUserInfo_StringID.Init();
        mUserInfo_StringID.Size = FKAttendDLL.SIZE_USER_INFO_V3; // must set this field
        mUserInfo_StringID.Ver = FKAttendDLL.VER3_USER_INFO;     // must set this field

        //mUserInfo_StringID.UserId = vnEnrollNumber;
        try
        {
          FKAttendDLL.StringToByteArrayUtf16(Convert.ToString(txtUserName.Text), mUserInfo_StringID.UserName); // convert string to byte array as locale setting ()

          mUserInfo_StringID.PostId = Convert.ToByte(txtPostID.Text);
        }
        catch (Exception ex)
        {
        }
        mUserInfo_StringID.YearAssigned = Convert.ToInt16(cmbUserShiftYear.Text);
        mUserInfo_StringID.MonthAssigned = Convert.ToByte(cmbUserShiftMonth.Text);

        for (ii = 1; ii <= FKAttendDLL.MAX_DAY_IN_MONTH; ii++)
          mUserInfo_StringID.ShiftId[ii - 1] = Convert.ToByte(GetShiftNumOfDayOfUser(ii));

        vUserInfoLen = FKAttendDLL.SIZE_USER_INFO_V3;// = Convert.ToInt32(Marshal.SizeOf(mUserInfo));

        FKAttendDLL.ConvertStructureToByteArray(mUserInfo_StringID, mbytUserInfo_StringID);
        vnResultCode = FKAttendDLL.FK_SetUserInfoEx_StringID(FKAttendDLL.nCommHandleIndex, vStrEnrollNumber, mbytUserInfo_StringID, vUserInfoLen);
        if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
        {
          lblMessage.Text = "EnrollNumber=" + vStrEnrollNumber + "  " + "Message=" + "OK";
        }
        else
        {
          lblMessage.Text = "EnrollNumber=" + vStrEnrollNumber + "  " + "Message=" + FKAttendDLL.ReturnResultPrint(vnResultCode);
        }

      }
      else
      {

        mUserInfo.Size = FKAttendDLL.SIZE_USER_INFO_V2; // must set this field
        mUserInfo.Ver = FKAttendDLL.VER2_USER_INFO;     // must set this field

        mUserInfo.UserId = vnEnrollNumber;
        try
        {
          FKAttendDLL.StringToByteArrayUtf16(Convert.ToString(txtUserName.Text), mUserInfo.UserName); // convert string to byte array as locale setting ()

          mUserInfo.PostId = Convert.ToByte(txtPostID.Text);
        }
        catch (Exception ex)
        {
        }
        mUserInfo.YearAssigned = Convert.ToInt16(cmbUserShiftYear.Text);
        mUserInfo.MonthAssigned = Convert.ToByte(cmbUserShiftMonth.Text);

        for (ii = 1; ii <= FKAttendDLL.MAX_DAY_IN_MONTH; ii++)
          mUserInfo.ShiftId[ii - 1] = Convert.ToByte(GetShiftNumOfDayOfUser(ii));

        vUserInfoLen = FKAttendDLL.SIZE_USER_INFO_V2;// = Convert.ToInt32(Marshal.SizeOf(mUserInfo));

        FKAttendDLL.ConvertStructureToByteArray(mUserInfo, mbytUserInfo);
        vnResultCode = FKAttendDLL.FK_SetUserInfoEx(FKAttendDLL.nCommHandleIndex, vnEnrollNumber, mbytUserInfo, vUserInfoLen);
        if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
        {
          lblMessage.Text = "EnrollNumber=" + ((UInt32)vnEnrollNumber).ToString() + "  " + "Message=" + "OK";
        }
        else
        {
          lblMessage.Text = "EnrollNumber=" + ((UInt32)vnEnrollNumber).ToString() + "  " + "Message=" + FKAttendDLL.ReturnResultPrint(vnResultCode);
        }

      }
      System.Windows.Forms.Application.DoEvents();
      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
      cmdSetUserInfo.Enabled = true;
    }

    private void cmdGetShiftInfo_Click(object sender, EventArgs e)
    {
      int vnResultCode = 0;
      int vShiftLen = 0;

      cmdGetShiftInfo.Enabled = false;
      lblMessage.Text = "Getting ShiftInfo ...";

      vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        cmdGetShiftInfo.Enabled = true;
        return;
      }

      vShiftLen = FKAttendDLL.SIZE_POST_SHIFT_INFO_V2;   // = System.Convert.ToInt32(Marshal.SizeOf(mPostShiftInfo));
      vnResultCode = FKAttendDLL.FK_GetPostShiftInfo(FKAttendDLL.nCommHandleIndex, mbytShiftInfo, ref vShiftLen);
      if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
      {
        mPostShiftInfo = (POST_SHIFT_INFO)FKAttendDLL.ConvertByteArrayToStructure(mbytShiftInfo, typeof(POST_SHIFT_INFO));
        ShowPostShiftInfo();

        lblMessage.Text = "Message=" + "OK";
      }
      else
      {
        lblMessage.Text = "Message=" + FKAttendDLL.ReturnResultPrint(vnResultCode);
      }
      System.Windows.Forms.Application.DoEvents();

      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
      cmdGetShiftInfo.Enabled = true;
    }

    private void cmdSetShiftInfo_Click(object sender, EventArgs e)
    {
      int vnResultCode = 0;
      int vnShiftLen = 0;

      cmdSetShiftInfo.Enabled = false;
      lblMessage.Text = "Setting ShiftInfo ...";
      System.Windows.Forms.Application.DoEvents();

      vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        cmdSetShiftInfo.Enabled = true;
        return;
      }

      GetPostShiftInfo();

      vnShiftLen = FKAttendDLL.SIZE_POST_SHIFT_INFO_V2;  // = System.Convert.ToInt32(Marshal.SizeOf(mPostShiftInfo));
      mPostShiftInfo.Size = FKAttendDLL.SIZE_POST_SHIFT_INFO_V2;  // must set this field
      mPostShiftInfo.Ver = FKAttendDLL.VER2_POST_SHIFT_INFO;      // must set this field
      if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
      {
        FKAttendDLL.ConvertStructureToByteArray(mPostShiftInfo, mbytShiftInfo);
      }

      vnResultCode = FKAttendDLL.FK_SetPostShiftInfo(FKAttendDLL.nCommHandleIndex, mbytShiftInfo, vnShiftLen);
      if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = "Message=" + "OK";
      }
      else
      {
        lblMessage.Text = "Message=" + FKAttendDLL.ReturnResultPrint(vnResultCode);
      }
      System.Windows.Forms.Application.DoEvents();

      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
      cmdSetShiftInfo.Enabled = true;
    }

    private void frmPostShiftInfo_Load(object sender, EventArgs e)
    {
      try
      {
        mPostShiftInfo.Init();
        mUserInfo.Init();

        string vstrDBPath = "";

        SetupGridUserShiftOfMonth();

        //{ set user shift year/month combobox
        int k;
        for (k = 0; k <= 20; k++)
        {
          cmbUserShiftYear.Items.Add(Convert.ToString(2005 + k));
        }
        cmbUserShiftYear.SelectedText = Convert.ToString(DateTime.Now.Year);

        for (k = 1; k <= 12; k++)
        {
          cmbUserShiftMonth.Items.Add(Convert.ToString(k));
        }
        cmbUserShiftMonth.SelectedText = Convert.ToString(DateTime.Now.Month);
        //}

        vstrDBPath = System.IO.Directory.GetCurrentDirectory() + "\\datEnrollDat.mdb";
        if (System.IO.File.Exists(vstrDBPath) == false)
        {
          dlgOpen.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
          dlgOpen.ShowReadOnly = false;
          dlgOpen.Filter = "DB Files (*.mdb)|*.mdb|All Files (*.*)|*.*";
          dlgOpen.FilterIndex = 1;
          dlgOpen.ShowDialog();
          vstrDBPath = Convert.ToString(dlgOpen.FileName);
          dlgOpen.FileName = null;
          if (vstrDBPath.Length <= 0 || System.IO.File.Exists(vstrDBPath) == false)
            return;
        }

        mConn.ConnectionString = mcstrAdoConn + vstrDBPath;
        mConn.Open();
        if (mConn.State != ConnectionState.Open)
          return;

        RefreshPostShiftInfoFromDb();
      }
      catch (System.Exception)
      {

      }
    }
  }
}
