using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace FKAttendDllCSSample
{
  public partial class frmPassTimeHS : Form
  {
    public frmPassTimeHS()
    {
      InitializeComponent();
    }

    private TextBox[] mtxtStartHour;
    private TextBox[] mtxtStartMinute;
    private TextBox[] mtxtEndHour;
    private TextBox[] mtxtEndMinute;

    public const int SIZE_USERSID = 16;
    public const int SIZE_USERSID13_1 = 32;

    public const int VER_USERDOORINFO_V1 = 2;
    public const int SIZE_USERDOORINFO_V1 = 20;
    public const int VER_USERDOORINFO_V3 = 3;
    public const int SIZE_USERDOORINFO_V3 = 32;
    public const int VER_USERDOORINFO_V4 = 4;
    public const int SIZE_USERDOORINFO_V4 = 48;

    public const String EXTCMD_GET_USERDOORINFO = "ECMD_GetUserDoorInfo";
    public const String EXTCMD_SET_USERDOORINFO = "ECMD_SetUserDoorInfo";

    struct ExtCmd_USERDOORINFO
    {
      public ExtCmdStructHeader CmdHeader;
      public UInt32 UserID;		//4
      public byte Reserved;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
      public byte[] WeekPassTime;
      public short StartYear;
      public byte StartMonth;
      public byte StartDay;
      public short EndYear;
      public byte EndMonth;
      public byte EndDay;
      public void Init(String asCmdCode, UInt32 anUserID)
      {
        CmdHeader = new ExtCmdStructHeader();
        CmdHeader.Init(asCmdCode, VER_USERDOORINFO_V1, SIZE_USERDOORINFO_V1);
        WeekPassTime = new byte[7];
        UserID = anUserID;
        Reserved = 0;
        StartYear = 0;
        StartMonth = 0;
        StartDay = 0;
        EndYear = 0;
        EndMonth = 0;
        EndDay = 0;
      }
    }

    struct ExtCmd_USERDOORINFO_V3
    {
      public ExtCmdStructHeader CmdHeader;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = SIZE_USERSID)]
      public byte[] UserID;
      public byte Reserved;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
      public byte[] WeekPassTime;
      public short StartYear;
      public byte StartMonth;
      public byte StartDay;
      public short EndYear;
      public byte EndMonth;
      public byte EndDay;
      public void Init(String asCmdCode, string anUserID)
      {
        CmdHeader = new ExtCmdStructHeader();
        CmdHeader.Init(asCmdCode, VER_USERDOORINFO_V3, SIZE_USERDOORINFO_V3);
        WeekPassTime = new byte[7];
        UserID = new byte[SIZE_USERSID];
        Array.Copy(Encoding.UTF8.GetBytes(anUserID), UserID, anUserID.Length > SIZE_USERSID ? SIZE_USERSID : anUserID.Length);
        Reserved = 0;
        StartYear = 0;
        StartMonth = 0;
        StartDay = 0;
        EndYear = 0;
        EndMonth = 0;
        EndDay = 0;
      }
    }


    struct ExtCmd_USERDOORINFO_V4
    {
      public ExtCmdStructHeader CmdHeader;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = SIZE_USERSID13_1)]
      public byte[] UserID;
      public byte Reserved;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
      public byte[] WeekPassTime;
      public short StartYear;
      public byte StartMonth;
      public byte StartDay;
      public short EndYear;
      public byte EndMonth;
      public byte EndDay;
      public void Init(String asCmdCode, string anUserID)
      {
        CmdHeader = new ExtCmdStructHeader();
        CmdHeader.Init(asCmdCode, VER_USERDOORINFO_V4, SIZE_USERDOORINFO_V4);
        WeekPassTime = new byte[7];
        UserID = new byte[SIZE_USERSID13_1];
        Array.Copy(Encoding.UTF8.GetBytes(anUserID), UserID, anUserID.Length > SIZE_USERSID13_1 ? SIZE_USERSID13_1 : anUserID.Length);
        Reserved = 0;
        StartYear = 0;
        StartMonth = 0;
        StartDay = 0;
        EndYear = 0;
        EndMonth = 0;
        EndDay = 0;
      }
    }

    private void frmPassTimeHS_Load(object sender, EventArgs e)
    {
      int k;

      mtxtStartHour = new TextBox[6];
      mtxtStartMinute = new TextBox[6];
      mtxtEndHour = new TextBox[6];
      mtxtEndMinute = new TextBox[6];

      mtxtStartHour[0] = txtStartHour1;
      mtxtStartHour[1] = txtStartHour2;
      mtxtStartHour[2] = txtStartHour3;
      mtxtStartHour[3] = txtStartHour4;
      mtxtStartHour[4] = txtStartHour5;
      mtxtStartHour[5] = txtStartHour6;

      mtxtStartMinute[0] = txtStartMinute1;
      mtxtStartMinute[1] = txtStartMinute2;
      mtxtStartMinute[2] = txtStartMinute3;
      mtxtStartMinute[3] = txtStartMinute4;
      mtxtStartMinute[4] = txtStartMinute5;
      mtxtStartMinute[5] = txtStartMinute6;

      mtxtEndHour[0] = txtEndHour1;
      mtxtEndHour[1] = txtEndHour2;
      mtxtEndHour[2] = txtEndHour3;
      mtxtEndHour[3] = txtEndHour4;
      mtxtEndHour[4] = txtEndHour5;
      mtxtEndHour[5] = txtEndHour6;

      mtxtEndMinute[0] = txtEndMinute1;
      mtxtEndMinute[1] = txtEndMinute2;
      mtxtEndMinute[2] = txtEndMinute3;
      mtxtEndMinute[3] = txtEndMinute4;
      mtxtEndMinute[4] = txtEndMinute5;
      mtxtEndMinute[5] = txtEndMinute6;

      for (k = 0; k < FKAttendDLL.TIME_ZONE_COUNT; k++)
      {
        cmbTZN.Items.Add(k + 1);
      }
      for (k = 0; k < FKAttendDLL.TIME_SLOT_COUNT; k++)
      {
        mtxtStartHour[k].Text = "";
        mtxtStartMinute[k].Text = "";
        mtxtEndHour[k].Text = "";
        mtxtEndMinute[k].Text = "";
      }
    }

    private void ShowTimeZoneValue(TIME_ZONE aTimeZone)
    {
      int k;

      cmbTZN.SelectedIndex = aTimeZone.TimeZoneId - 1;
      for (k = 0; k < FKAttendDLL.TIME_SLOT_COUNT; k++)
      {
        mtxtStartHour[k].Text = Convert.ToString(aTimeZone.TimeSlots[k].StartHour);
        mtxtStartMinute[k].Text = Convert.ToString(aTimeZone.TimeSlots[k].StartMinute);
        mtxtEndHour[k].Text = Convert.ToString(aTimeZone.TimeSlots[k].EndHour);
        mtxtEndMinute[k].Text = Convert.ToString(aTimeZone.TimeSlots[k].EndMinute);
      }
    }

    private void GetTimeZoneValue(ref TIME_ZONE aTimeZone)
    {
      int k;

      aTimeZone.TimeZoneId = cmbTZN.SelectedIndex + 1;
      for (k = 0; k < FKAttendDLL.TIME_SLOT_COUNT; k++)
      {
        aTimeZone.TimeSlots[k].StartHour = (byte)FKAttendDLL.GetInt(mtxtStartHour[k].Text);
        aTimeZone.TimeSlots[k].StartMinute = (byte)FKAttendDLL.GetInt(mtxtStartMinute[k].Text);
        aTimeZone.TimeSlots[k].EndHour = (byte)FKAttendDLL.GetInt(mtxtEndHour[k].Text);
        aTimeZone.TimeSlots[k].EndMinute = (byte)FKAttendDLL.GetInt(mtxtEndMinute[k].Text);
      }
    }

    private void cmdReadTimeZone_Click(object sender, EventArgs e)
    {
      byte[] bytTimeZone = new byte[FKAttendDLL.SIZE_TIME_ZONE_STRUCT];
      TIME_ZONE vTimeZone = new TIME_ZONE();
      int TimeZoneId;
      int nFKRetCode;

      cmdReadTimeZone.Enabled = false;
      lblMessage.Text = "Working ...";
      Application.DoEvents();

      nFKRetCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        cmdReadTimeZone.Enabled = true;
        return;
      }

      TimeZoneId = cmbTZN.SelectedIndex + 1;
      if ((TimeZoneId < 1) || (TimeZoneId > FKAttendDLL.TIME_ZONE_COUNT))
      {
        TimeZoneId = 1;
        cmbTZN.SelectedIndex = 0;
      }
      vTimeZone.Init();
      vTimeZone.TimeZoneId = TimeZoneId;
      FKAttendDLL.ConvertStructureToByteArray(vTimeZone, bytTimeZone);
      nFKRetCode = FKAttendDLL.FK_HS_GetTimeZone(FKAttendDLL.nCommHandleIndex, bytTimeZone);
      if (nFKRetCode == (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = "Success !";
        vTimeZone = (TIME_ZONE)FKAttendDLL.ConvertByteArrayToStructure(bytTimeZone, typeof(TIME_ZONE));
        ShowTimeZoneValue(vTimeZone);
      }
      else
      {
        lblMessage.Text = FKAttendDLL.ReturnResultPrint(nFKRetCode);
      }

      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
      cmdReadTimeZone.Enabled = true;
    }

    private void cmdWriteTimeZone_Click(object sender, EventArgs e)
    {
      byte[] bytTimeZone = new byte[FKAttendDLL.SIZE_TIME_ZONE_STRUCT];
      TIME_ZONE vTimeZone = new TIME_ZONE();
      int nFKRetCode;

      cmdWriteTimeZone.Enabled = false;
      lblMessage.Text = "Working ...";
      Application.DoEvents();

      nFKRetCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        cmdWriteTimeZone.Enabled = true;
        return;
      }

      vTimeZone.Init();
      GetTimeZoneValue(ref vTimeZone);
      if ((vTimeZone.TimeZoneId < 1) || (vTimeZone.TimeZoneId > FKAttendDLL.TIME_ZONE_COUNT))
      {
        vTimeZone.TimeZoneId = 1;
        cmbTZN.SelectedIndex = 0;
      }
      FKAttendDLL.ConvertStructureToByteArray(vTimeZone, bytTimeZone);
      nFKRetCode = FKAttendDLL.FK_HS_SetTimeZone(FKAttendDLL.nCommHandleIndex, bytTimeZone);
      if (nFKRetCode == (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = "Success !";
      }
      else
      {
        lblMessage.Text = FKAttendDLL.ReturnResultPrint(nFKRetCode);
      }

      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
      cmdWriteTimeZone.Enabled = true;
    }

    private void ShowUserWeekPassTimeValue(USER_WEEK_PASS_TIME aUserWeekPassTime)
    {
      txtEnrollNumber.Text = Convert.ToString(aUserWeekPassTime.UserId);

      txtTimeZone1.Text = Convert.ToString(aUserWeekPassTime.WeekPassTime[0]);
      txtTimeZone2.Text = Convert.ToString(aUserWeekPassTime.WeekPassTime[1]);
      txtTimeZone3.Text = Convert.ToString(aUserWeekPassTime.WeekPassTime[2]);
      txtTimeZone4.Text = Convert.ToString(aUserWeekPassTime.WeekPassTime[3]);
      txtTimeZone5.Text = Convert.ToString(aUserWeekPassTime.WeekPassTime[4]);
      txtTimeZone6.Text = Convert.ToString(aUserWeekPassTime.WeekPassTime[5]);
      txtTimeZone7.Text = Convert.ToString(aUserWeekPassTime.WeekPassTime[6]);
    }

    private void GetUserWeekPassTimeValue(ref USER_WEEK_PASS_TIME aUserWeekPassTime)
    {
      aUserWeekPassTime.UserId = FKAttendDLL.GetInt(txtEnrollNumber.Text);

      aUserWeekPassTime.WeekPassTime[0] = (byte)FKAttendDLL.GetInt(txtTimeZone1.Text);
      aUserWeekPassTime.WeekPassTime[1] = (byte)FKAttendDLL.GetInt(txtTimeZone2.Text);
      aUserWeekPassTime.WeekPassTime[2] = (byte)FKAttendDLL.GetInt(txtTimeZone3.Text);
      aUserWeekPassTime.WeekPassTime[3] = (byte)FKAttendDLL.GetInt(txtTimeZone4.Text);
      aUserWeekPassTime.WeekPassTime[4] = (byte)FKAttendDLL.GetInt(txtTimeZone5.Text);
      aUserWeekPassTime.WeekPassTime[5] = (byte)FKAttendDLL.GetInt(txtTimeZone6.Text);
      aUserWeekPassTime.WeekPassTime[6] = (byte)FKAttendDLL.GetInt(txtTimeZone7.Text);
    }

    private void cmdReadUserWeekPassTime_Click(object sender, EventArgs e)
    {
      byte[] bytUserPassTime = new byte[FKAttendDLL.SIZE_USER_WEEK_PASS_TIME_STRUCT];
      USER_WEEK_PASS_TIME vUserPassTime = new USER_WEEK_PASS_TIME();
      int nFKRetCode;

      vUserPassTime.Init();
      vUserPassTime.UserId = FKAttendDLL.GetInt(txtEnrollNumber.Text);

      cmdReadUserWeekPassTime.Enabled = false;
      lblMessage.Text = "Working ...";
      Application.DoEvents();

      nFKRetCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        cmdReadUserWeekPassTime.Enabled = true;
        return;
      }
      FKAttendDLL.ConvertStructureToByteArray(vUserPassTime, bytUserPassTime);
      nFKRetCode = FKAttendDLL.FK_HS_GetUserWeekPassTime(FKAttendDLL.nCommHandleIndex, bytUserPassTime);
      if (nFKRetCode == (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = "Success !";
        vUserPassTime = (USER_WEEK_PASS_TIME)FKAttendDLL.ConvertByteArrayToStructure(bytUserPassTime, typeof(USER_WEEK_PASS_TIME));
        ShowUserWeekPassTimeValue(vUserPassTime);
      }
      else
      {
        lblMessage.Text = FKAttendDLL.ReturnResultPrint(nFKRetCode);
      }

      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
      cmdReadUserWeekPassTime.Enabled = true;
    }

    private void cmdWriteUserWeekPassTime_Click(object sender, EventArgs e)
    {
      byte[] bytUserPassTime = new byte[FKAttendDLL.SIZE_USER_WEEK_PASS_TIME_STRUCT];
      USER_WEEK_PASS_TIME vUserPassTime = new USER_WEEK_PASS_TIME();
      int nFKRetCode;

      vUserPassTime.Init();
      GetUserWeekPassTimeValue(ref vUserPassTime);

      cmdWriteUserWeekPassTime.Enabled = false;
      lblMessage.Text = "Working ...";
      Application.DoEvents();

      nFKRetCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        cmdWriteUserWeekPassTime.Enabled = true;
        return;
      }

      FKAttendDLL.ConvertStructureToByteArray(vUserPassTime, bytUserPassTime);
      nFKRetCode = FKAttendDLL.FK_HS_SetUserWeekPassTime(FKAttendDLL.nCommHandleIndex, bytUserPassTime);
      if (nFKRetCode == (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = "Success !";
      }
      else
      {
        lblMessage.Text = FKAttendDLL.ReturnResultPrint(nFKRetCode);
      }

      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
      cmdWriteUserWeekPassTime.Enabled = true;
    }

    private void cmdSetDoorState_Click(object sender, System.EventArgs e)
    {
      int vnResultCode;
      int vnState = -1;

      cmdSetDoorState.Enabled = false;
      lblMessage.Text = "Setting Door ...";
      Application.DoEvents();

      vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        cmdSetDoorState.Enabled = true;
        return;
      }

      switch (cmbDoorState.SelectedIndex)
      {
        case 0: vnState = (int)enumDoorStatus.DOOR_CONROLRESET; break;
        case 1: vnState = (int)enumDoorStatus.DOOR_OPEND; break;
        case 2: vnState = (int)enumDoorStatus.DOOR_CLOSED; break;
        case 3: vnState = (int)enumDoorStatus.DOOR_COMMNAD; break;
      }
      vnResultCode = FKAttendDLL.FK_SetDoorStatus(FKAttendDLL.nCommHandleIndex, (int)vnState);
      if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
        lblMessage.Text = "Success!";
      else
        lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
      cmdSetDoorState.Enabled = true;
    }

    private void cmdGetDoorState_Click(object sender, System.EventArgs e)
    {
      int vnResultCode;
      int vnState = -1;

      cmdGetDoorState.Enabled = false;
      lblMessage.Text = "Getting Door State...";
      Application.DoEvents();

      vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        cmdGetDoorState.Enabled = true;
        return;
      }

      vnResultCode = FKAttendDLL.FK_GetDoorStatus(FKAttendDLL.nCommHandleIndex, ref vnState);
      if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
      {
        if (vnState == (int)enumDoorStatus.DOOR_CONROLRESET)
          lblMessage.Text = "State Reset!";
        else if (vnState == (int)enumDoorStatus.DOOR_OPEND)
          lblMessage.Text = "Door Open!";
        else if (vnState == (int)enumDoorStatus.DOOR_CLOSED)
          lblMessage.Text = "Door Close!";
        else if (vnState == (int)enumDoorStatus.DOOR_COMMNAD)
          lblMessage.Text = "Command Open... Door Close!";
        else
          lblMessage.Text = "Door - Unknown!";
      }
      else
        lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
      cmdGetDoorState.Enabled = true;
    }

    private void cmdReadDoorInfo_Click(object sender, EventArgs e)
    {

      UInt32 vEnrollNumber;
      int vnResultCode;
      string vStrEnrollNumber;
      cmdReadDoorInfo.Enabled = false;
      lblMessage.Text = "Working...";
      Application.DoEvents();

      vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        cmdReadDoorInfo.Enabled = true;
        return;
      }

      int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
      if (vnResultSupportStringID < (int)enumErrorCode.RUN_SUCCESS)
      {
        int vSize = SIZE_USERDOORINFO_V1 + 64;
        byte[] bytExtCmd_USERDOORINFO = new byte[vSize];
        ExtCmd_USERDOORINFO vExtCmd_USERDOORINFO = new ExtCmd_USERDOORINFO();

        vStrEnrollNumber = txtEnrollNumber.Text;
        vEnrollNumber = FKAttendDLL.GetInt(vStrEnrollNumber);

        vExtCmd_USERDOORINFO.Init(EXTCMD_GET_USERDOORINFO, vEnrollNumber);
        FKAttendDLL.ConvertStructureToByteArray(vExtCmd_USERDOORINFO, bytExtCmd_USERDOORINFO);

        vnResultCode = FKAttendDLL.FK_ExtCommand(FKAttendDLL.nCommHandleIndex, bytExtCmd_USERDOORINFO);

        if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
        {
          vExtCmd_USERDOORINFO = (ExtCmd_USERDOORINFO)FKAttendDLL.ConvertByteArrayToStructure(bytExtCmd_USERDOORINFO, typeof(ExtCmd_USERDOORINFO));
          lblMessage.Text = "ReadDoorInfo OK";

          txtStartYear.Text = Convert.ToString(vExtCmd_USERDOORINFO.StartYear);
          txtStartMonth.Text = Convert.ToString(vExtCmd_USERDOORINFO.StartMonth);
          txtStartDay.Text = Convert.ToString(vExtCmd_USERDOORINFO.StartDay);
          txtEndYear.Text = Convert.ToString(vExtCmd_USERDOORINFO.EndYear);
          txtEndMonth.Text = Convert.ToString(vExtCmd_USERDOORINFO.EndMonth);
          txtEndDay.Text = Convert.ToString(vExtCmd_USERDOORINFO.EndDay);

          txtTimeZone1.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[0]);
          txtTimeZone2.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[1]);
          txtTimeZone3.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[2]);
          txtTimeZone4.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[3]);
          txtTimeZone5.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[4]);
          txtTimeZone6.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[5]);
          txtTimeZone7.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[6]);
        }
        else
          lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

      }
      else if (vnResultSupportStringID == FKAttendDLL.USER_ID_LENGTH13_1)
      {
        int vSize = SIZE_USERDOORINFO_V4 + 64;
        byte[] bytExtCmd_USERDOORINFO = new byte[vSize];
        ExtCmd_USERDOORINFO_V4 vExtCmd_USERDOORINFO = new ExtCmd_USERDOORINFO_V4();

        vStrEnrollNumber = txtEnrollNumber.Text;
        vExtCmd_USERDOORINFO.Init(EXTCMD_GET_USERDOORINFO, vStrEnrollNumber);
        FKAttendDLL.ConvertStructureToByteArray(vExtCmd_USERDOORINFO, bytExtCmd_USERDOORINFO);

        vnResultCode = FKAttendDLL.FK_ExtCommand(FKAttendDLL.nCommHandleIndex, bytExtCmd_USERDOORINFO);

        if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
        {
          vExtCmd_USERDOORINFO = (ExtCmd_USERDOORINFO_V4)FKAttendDLL.ConvertByteArrayToStructure(bytExtCmd_USERDOORINFO, typeof(ExtCmd_USERDOORINFO_V4));
          lblMessage.Text = "ReadDoorInfo OK";

          txtStartYear.Text = Convert.ToString(vExtCmd_USERDOORINFO.StartYear);
          txtStartMonth.Text = Convert.ToString(vExtCmd_USERDOORINFO.StartMonth);
          txtStartDay.Text = Convert.ToString(vExtCmd_USERDOORINFO.StartDay);
          txtEndYear.Text = Convert.ToString(vExtCmd_USERDOORINFO.EndYear);
          txtEndMonth.Text = Convert.ToString(vExtCmd_USERDOORINFO.EndMonth);
          txtEndDay.Text = Convert.ToString(vExtCmd_USERDOORINFO.EndDay);

          txtTimeZone1.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[0]);
          txtTimeZone2.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[1]);
          txtTimeZone3.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[2]);
          txtTimeZone4.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[3]);
          txtTimeZone5.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[4]);
          txtTimeZone6.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[5]);
          txtTimeZone7.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[6]);
        }
        else
          lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
      }
      else
      {
        int vSize = SIZE_USERDOORINFO_V3 + 64;
        byte[] bytExtCmd_USERDOORINFO = new byte[vSize];
        ExtCmd_USERDOORINFO_V3 vExtCmd_USERDOORINFO = new ExtCmd_USERDOORINFO_V3();

        vStrEnrollNumber = txtEnrollNumber.Text;
        vExtCmd_USERDOORINFO.Init(EXTCMD_GET_USERDOORINFO, vStrEnrollNumber);
        FKAttendDLL.ConvertStructureToByteArray(vExtCmd_USERDOORINFO, bytExtCmd_USERDOORINFO);

        vnResultCode = FKAttendDLL.FK_ExtCommand(FKAttendDLL.nCommHandleIndex, bytExtCmd_USERDOORINFO);

        if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
        {
          vExtCmd_USERDOORINFO = (ExtCmd_USERDOORINFO_V3)FKAttendDLL.ConvertByteArrayToStructure(bytExtCmd_USERDOORINFO, typeof(ExtCmd_USERDOORINFO_V3));
          lblMessage.Text = "ReadDoorInfo OK";

          txtStartYear.Text = Convert.ToString(vExtCmd_USERDOORINFO.StartYear);
          txtStartMonth.Text = Convert.ToString(vExtCmd_USERDOORINFO.StartMonth);
          txtStartDay.Text = Convert.ToString(vExtCmd_USERDOORINFO.StartDay);
          txtEndYear.Text = Convert.ToString(vExtCmd_USERDOORINFO.EndYear);
          txtEndMonth.Text = Convert.ToString(vExtCmd_USERDOORINFO.EndMonth);
          txtEndDay.Text = Convert.ToString(vExtCmd_USERDOORINFO.EndDay);

          txtTimeZone1.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[0]);
          txtTimeZone2.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[1]);
          txtTimeZone3.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[2]);
          txtTimeZone4.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[3]);
          txtTimeZone5.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[4]);
          txtTimeZone6.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[5]);
          txtTimeZone7.Text = Convert.ToString(vExtCmd_USERDOORINFO.WeekPassTime[6]);
        }
        else
          lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
      }

      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
      cmdReadDoorInfo.Enabled = true;

    }

    private void cmdWriteDoorInfo_Click(object sender, EventArgs e)
    {
      UInt32 vEnrollNumber;
      int vnResultCode;
      string vStrEnrollNumber;
      cmdWriteDoorInfo.Enabled = false;
      lblMessage.Text = "Working...";
      Application.DoEvents();

      vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        cmdWriteDoorInfo.Enabled = true;
        return;
      }

      if (FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex) < (int)enumErrorCode.RUN_SUCCESS)
      {
        int vSize = SIZE_USERDOORINFO_V1 + 64;
        byte[] bytExtCmd_USERDOORINFO = new byte[vSize];
        ExtCmd_USERDOORINFO vExtCmd_USERDOORINFO = new ExtCmd_USERDOORINFO();

        vStrEnrollNumber = txtEnrollNumber.Text;
        vEnrollNumber = FKAttendDLL.GetInt(vStrEnrollNumber);

        vExtCmd_USERDOORINFO.Init(EXTCMD_SET_USERDOORINFO, vEnrollNumber);


        vExtCmd_USERDOORINFO.WeekPassTime[0] = (byte)FKAttendDLL.GetInt(txtTimeZone1.Text);
        vExtCmd_USERDOORINFO.WeekPassTime[1] = (byte)FKAttendDLL.GetInt(txtTimeZone2.Text);
        vExtCmd_USERDOORINFO.WeekPassTime[2] = (byte)FKAttendDLL.GetInt(txtTimeZone3.Text);
        vExtCmd_USERDOORINFO.WeekPassTime[3] = (byte)FKAttendDLL.GetInt(txtTimeZone4.Text);
        vExtCmd_USERDOORINFO.WeekPassTime[4] = (byte)FKAttendDLL.GetInt(txtTimeZone5.Text);
        vExtCmd_USERDOORINFO.WeekPassTime[5] = (byte)FKAttendDLL.GetInt(txtTimeZone6.Text);
        vExtCmd_USERDOORINFO.WeekPassTime[6] = (byte)FKAttendDLL.GetInt(txtTimeZone7.Text);

        vExtCmd_USERDOORINFO.StartYear = (short)FKAttendDLL.GetInt(txtStartYear.Text);
        vExtCmd_USERDOORINFO.StartMonth = (byte)FKAttendDLL.GetInt(txtStartMonth.Text);
        vExtCmd_USERDOORINFO.StartDay = (byte)FKAttendDLL.GetInt(txtStartDay.Text);
        vExtCmd_USERDOORINFO.EndYear = (short)FKAttendDLL.GetInt(txtEndYear.Text);
        vExtCmd_USERDOORINFO.EndMonth = (byte)FKAttendDLL.GetInt(txtEndMonth.Text);
        vExtCmd_USERDOORINFO.EndDay = (byte)FKAttendDLL.GetInt(txtEndDay.Text);

        FKAttendDLL.ConvertStructureToByteArray(vExtCmd_USERDOORINFO, bytExtCmd_USERDOORINFO);

        vnResultCode = FKAttendDLL.FK_ExtCommand(FKAttendDLL.nCommHandleIndex, bytExtCmd_USERDOORINFO);
        if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
        {
          lblMessage.Text = "WriteDoorInfo OK";
        }
        else
          lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
      }
      else
      {
        int vSize = SIZE_USERDOORINFO_V3 + 64;
        byte[] bytExtCmd_USERDOORINFO = new byte[vSize];
        ExtCmd_USERDOORINFO_V3 vExtCmd_USERDOORINFO = new ExtCmd_USERDOORINFO_V3();

        vStrEnrollNumber = txtEnrollNumber.Text;

        vExtCmd_USERDOORINFO.Init(EXTCMD_SET_USERDOORINFO, vStrEnrollNumber);


        vExtCmd_USERDOORINFO.WeekPassTime[0] = (byte)FKAttendDLL.GetInt(txtTimeZone1.Text);
        vExtCmd_USERDOORINFO.WeekPassTime[1] = (byte)FKAttendDLL.GetInt(txtTimeZone2.Text);
        vExtCmd_USERDOORINFO.WeekPassTime[2] = (byte)FKAttendDLL.GetInt(txtTimeZone3.Text);
        vExtCmd_USERDOORINFO.WeekPassTime[3] = (byte)FKAttendDLL.GetInt(txtTimeZone4.Text);
        vExtCmd_USERDOORINFO.WeekPassTime[4] = (byte)FKAttendDLL.GetInt(txtTimeZone5.Text);
        vExtCmd_USERDOORINFO.WeekPassTime[5] = (byte)FKAttendDLL.GetInt(txtTimeZone6.Text);
        vExtCmd_USERDOORINFO.WeekPassTime[6] = (byte)FKAttendDLL.GetInt(txtTimeZone7.Text);

        vExtCmd_USERDOORINFO.StartYear = (short)FKAttendDLL.GetInt(txtStartYear.Text);
        vExtCmd_USERDOORINFO.StartMonth = (byte)FKAttendDLL.GetInt(txtStartMonth.Text);
        vExtCmd_USERDOORINFO.StartDay = (byte)FKAttendDLL.GetInt(txtStartDay.Text);
        vExtCmd_USERDOORINFO.EndYear = (short)FKAttendDLL.GetInt(txtEndYear.Text);
        vExtCmd_USERDOORINFO.EndMonth = (byte)FKAttendDLL.GetInt(txtEndMonth.Text);
        vExtCmd_USERDOORINFO.EndDay = (byte)FKAttendDLL.GetInt(txtEndDay.Text);

        FKAttendDLL.ConvertStructureToByteArray(vExtCmd_USERDOORINFO, bytExtCmd_USERDOORINFO);

        vnResultCode = FKAttendDLL.FK_ExtCommand(FKAttendDLL.nCommHandleIndex, bytExtCmd_USERDOORINFO);
        if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
        {
          lblMessage.Text = "WriteDoorInfo OK";
        }
        else
          lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
      }

      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);

      cmdWriteDoorInfo.Enabled = true;

    }

  }
}
