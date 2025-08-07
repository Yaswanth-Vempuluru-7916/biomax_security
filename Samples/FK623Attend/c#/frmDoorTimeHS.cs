using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FKAttendDllCSSample
{
    public partial class frmDoorTimeHS : Form
    {
        public frmDoorTimeHS()
        {
            InitializeComponent();
        }

        private TextBox[] mtxtStartHour;
        private TextBox[] mtxtStartMinute;
        private TextBox[] mtxtEndHour;
        private TextBox[] mtxtEndMinute;

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

        private void ShowWeekOpenDoorValue(WEEK_OPEN_DOOR_TIME aWeekOpenDoorTime)
        {
          
            txtTimeZone1.Text = Convert.ToString(aWeekOpenDoorTime.WeekPassTime[0]);
            txtTimeZone2.Text = Convert.ToString(aWeekOpenDoorTime.WeekPassTime[1]);
            txtTimeZone3.Text = Convert.ToString(aWeekOpenDoorTime.WeekPassTime[2]);
            txtTimeZone4.Text = Convert.ToString(aWeekOpenDoorTime.WeekPassTime[3]);
            txtTimeZone5.Text = Convert.ToString(aWeekOpenDoorTime.WeekPassTime[4]);
            txtTimeZone6.Text = Convert.ToString(aWeekOpenDoorTime.WeekPassTime[5]);
            txtTimeZone7.Text = Convert.ToString(aWeekOpenDoorTime.WeekPassTime[6]);
        }

        private void GetWeekOpenDoorTimeValue(ref WEEK_OPEN_DOOR_TIME aWeekOpenDoorTime)
        {
            aWeekOpenDoorTime.Type = (UInt32)cmdCType.SelectedIndex + 1;

            aWeekOpenDoorTime.WeekPassTime[0] = (byte)FKAttendDLL.GetInt(txtTimeZone1.Text);
            aWeekOpenDoorTime.WeekPassTime[1] = (byte)FKAttendDLL.GetInt(txtTimeZone2.Text);
            aWeekOpenDoorTime.WeekPassTime[2] = (byte)FKAttendDLL.GetInt(txtTimeZone3.Text);
            aWeekOpenDoorTime.WeekPassTime[3] = (byte)FKAttendDLL.GetInt(txtTimeZone4.Text);
            aWeekOpenDoorTime.WeekPassTime[4] = (byte)FKAttendDLL.GetInt(txtTimeZone5.Text);
            aWeekOpenDoorTime.WeekPassTime[5] = (byte)FKAttendDLL.GetInt(txtTimeZone6.Text);
            aWeekOpenDoorTime.WeekPassTime[6] = (byte)FKAttendDLL.GetInt(txtTimeZone7.Text);
        }

        private void cmdReadWeekOpenDoorTime_Click(object sender, EventArgs e)
        {
            byte[] bytOpenDoorTime = new byte[FKAttendDLL.SIZE_WEEK_OPEN_DOOR_TIME_STRUCT];
            WEEK_OPEN_DOOR_TIME vOpenDoorTime = new WEEK_OPEN_DOOR_TIME();
            int nFKRetCode;

            vOpenDoorTime.Init();

            vOpenDoorTime.Type = (UInt32)cmdCType.SelectedIndex + 1;

            cmdReadWeekOpenDoorTime.Enabled = false;
            lblMessage.Text = "Working ...";
            Application.DoEvents();

            nFKRetCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdReadWeekOpenDoorTime.Enabled = true;
                return;
            }
            FKAttendDLL.ConvertStructureToByteArray(vOpenDoorTime, bytOpenDoorTime);
            nFKRetCode = FKAttendDLL.FK_HS_GetWeekOpenDoorTime(FKAttendDLL.nCommHandleIndex, bytOpenDoorTime);
            if (nFKRetCode == (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = "Success !";
                vOpenDoorTime = (WEEK_OPEN_DOOR_TIME)FKAttendDLL.ConvertByteArrayToStructure(bytOpenDoorTime, typeof(WEEK_OPEN_DOOR_TIME));
                ShowWeekOpenDoorValue(vOpenDoorTime);
            }
            else
            {
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(nFKRetCode);
            }

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdReadWeekOpenDoorTime.Enabled = true;
        }

        private void cmdWriteWeekOpenDoorTime_Click(object sender, EventArgs e)
        {
            byte[] bytOpenDoorTime = new byte[FKAttendDLL.SIZE_WEEK_OPEN_DOOR_TIME_STRUCT];
            WEEK_OPEN_DOOR_TIME vOpenDoorTime = new WEEK_OPEN_DOOR_TIME();
            int nFKRetCode;

            vOpenDoorTime.Init();
            GetWeekOpenDoorTimeValue(ref vOpenDoorTime);
            
            cmdWriteWeekOpenDoorTime.Enabled = false;
            lblMessage.Text = "Working ...";
            Application.DoEvents();

            nFKRetCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdWriteWeekOpenDoorTime.Enabled = true;
                return;
            }

            FKAttendDLL.ConvertStructureToByteArray(vOpenDoorTime, bytOpenDoorTime);
            nFKRetCode = FKAttendDLL.FK_HS_SetWeekOpenDoorTime(FKAttendDLL.nCommHandleIndex, bytOpenDoorTime);
            if (nFKRetCode == (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = "Success !";                
            }
            else
            {
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(nFKRetCode);
            }

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdWriteWeekOpenDoorTime.Enabled = true;
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

    }
}
