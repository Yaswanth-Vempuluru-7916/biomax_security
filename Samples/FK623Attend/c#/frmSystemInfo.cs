using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FKAttendDllCSSample
{
    /// <summary>
    /// frmSystemInfo 的摘要说明。
    /// </summary>
    public class frmSystemInfo : System.Windows.Forms.Form
    {
        public System.Windows.Forms.Button cmdGetDeviceTime;
        public System.Windows.Forms.Button cmdGetDeviceInfo;
        public System.Windows.Forms.Button cmdPowerOn;
        public System.Windows.Forms.Button PowerOffDevice;
        public System.Windows.Forms.Button cmdSetDeviceInfo;
        public System.Windows.Forms.ComboBox cmbInfo;
        public System.Windows.Forms.TextBox txtSetDevInfo;
        public System.Windows.Forms.Button cmdGetDeviceStaus;
        public System.Windows.Forms.CheckBox chkEnableDevice;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lblMessage;
        public System.Windows.Forms.Button cmdSetDeviceTime;
        public ComboBox cmbstatus;
        public Label label2;

        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmSystemInfo()
        {
            //
            // Windows 窗体设计器支持所必需的
            //
            InitializeComponent();

            //
            // TODO: 在 InitializeComponent 调用后添加任何构造函数代码
            //
        }

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdGetDeviceTime = new System.Windows.Forms.Button();
            this.cmdGetDeviceInfo = new System.Windows.Forms.Button();
            this.cmdPowerOn = new System.Windows.Forms.Button();
            this.PowerOffDevice = new System.Windows.Forms.Button();
            this.cmdSetDeviceInfo = new System.Windows.Forms.Button();
            this.cmbInfo = new System.Windows.Forms.ComboBox();
            this.txtSetDevInfo = new System.Windows.Forms.TextBox();
            this.cmdGetDeviceStaus = new System.Windows.Forms.Button();
            this.chkEnableDevice = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmdSetDeviceTime = new System.Windows.Forms.Button();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdGetDeviceTime
            // 
            this.cmdGetDeviceTime.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetDeviceTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetDeviceTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetDeviceTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetDeviceTime.Location = new System.Drawing.Point(16, 76);
            this.cmdGetDeviceTime.Name = "cmdGetDeviceTime";
            this.cmdGetDeviceTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetDeviceTime.Size = new System.Drawing.Size(156, 45);
            this.cmdGetDeviceTime.TabIndex = 21;
            this.cmdGetDeviceTime.Text = "GetDeviceTime";
            this.cmdGetDeviceTime.UseVisualStyleBackColor = false;
            this.cmdGetDeviceTime.Click += new System.EventHandler(this.cmdGetDeviceTime_Click);
            // 
            // cmdGetDeviceInfo
            // 
            this.cmdGetDeviceInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetDeviceInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetDeviceInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetDeviceInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetDeviceInfo.Location = new System.Drawing.Point(35, 240);
            this.cmdGetDeviceInfo.Name = "cmdGetDeviceInfo";
            this.cmdGetDeviceInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetDeviceInfo.Size = new System.Drawing.Size(156, 35);
            this.cmdGetDeviceInfo.TabIndex = 26;
            this.cmdGetDeviceInfo.Text = "GetDeviceInfo";
            this.cmdGetDeviceInfo.UseVisualStyleBackColor = false;
            this.cmdGetDeviceInfo.Click += new System.EventHandler(this.cmdGetDeviceInfo_Click);
            // 
            // cmdPowerOn
            // 
            this.cmdPowerOn.BackColor = System.Drawing.SystemColors.Control;
            this.cmdPowerOn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdPowerOn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPowerOn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdPowerOn.Location = new System.Drawing.Point(217, 76);
            this.cmdPowerOn.Name = "cmdPowerOn";
            this.cmdPowerOn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdPowerOn.Size = new System.Drawing.Size(156, 45);
            this.cmdPowerOn.TabIndex = 22;
            this.cmdPowerOn.Text = "PowerOnDevice(Deprecated)";
            this.cmdPowerOn.UseVisualStyleBackColor = false;
            this.cmdPowerOn.Click += new System.EventHandler(this.cmdPowerOn_Click);
            // 
            // PowerOffDevice
            // 
            this.PowerOffDevice.BackColor = System.Drawing.SystemColors.Control;
            this.PowerOffDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.PowerOffDevice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerOffDevice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PowerOffDevice.Location = new System.Drawing.Point(217, 120);
            this.PowerOffDevice.Name = "PowerOffDevice";
            this.PowerOffDevice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PowerOffDevice.Size = new System.Drawing.Size(156, 44);
            this.PowerOffDevice.TabIndex = 25;
            this.PowerOffDevice.Text = "PowerOffDevice(Deprecated)";
            this.PowerOffDevice.UseVisualStyleBackColor = false;
            this.PowerOffDevice.Click += new System.EventHandler(this.PowerOffDevice_Click);
            // 
            // cmdSetDeviceInfo
            // 
            this.cmdSetDeviceInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetDeviceInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetDeviceInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetDeviceInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetDeviceInfo.Location = new System.Drawing.Point(217, 240);
            this.cmdSetDeviceInfo.Name = "cmdSetDeviceInfo";
            this.cmdSetDeviceInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetDeviceInfo.Size = new System.Drawing.Size(156, 35);
            this.cmdSetDeviceInfo.TabIndex = 27;
            this.cmdSetDeviceInfo.Text = "SetDeviceInfo";
            this.cmdSetDeviceInfo.UseVisualStyleBackColor = false;
            this.cmdSetDeviceInfo.Click += new System.EventHandler(this.cmdSetDeviceInfo_Click);
            // 
            // cmbInfo
            // 
            this.cmbInfo.BackColor = System.Drawing.SystemColors.Window;
            this.cmbInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbInfo.Location = new System.Drawing.Point(85, 196);
            this.cmbInfo.Name = "cmbInfo";
            this.cmbInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbInfo.Size = new System.Drawing.Size(106, 27);
            this.cmbInfo.TabIndex = 32;
            // 
            // txtSetDevInfo
            // 
            this.txtSetDevInfo.AcceptsReturn = true;
            this.txtSetDevInfo.BackColor = System.Drawing.SystemColors.Window;
            this.txtSetDevInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSetDevInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetDevInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSetDevInfo.Location = new System.Drawing.Point(287, 195);
            this.txtSetDevInfo.MaxLength = 0;
            this.txtSetDevInfo.Name = "txtSetDevInfo";
            this.txtSetDevInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSetDevInfo.Size = new System.Drawing.Size(86, 26);
            this.txtSetDevInfo.TabIndex = 29;
            // 
            // cmdGetDeviceStaus
            // 
            this.cmdGetDeviceStaus.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetDeviceStaus.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetDeviceStaus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetDeviceStaus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetDeviceStaus.Location = new System.Drawing.Point(406, 240);
            this.cmdGetDeviceStaus.Name = "cmdGetDeviceStaus";
            this.cmdGetDeviceStaus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetDeviceStaus.Size = new System.Drawing.Size(156, 35);
            this.cmdGetDeviceStaus.TabIndex = 28;
            this.cmdGetDeviceStaus.Text = "GetDeviceStatus";
            this.cmdGetDeviceStaus.UseVisualStyleBackColor = false;
            this.cmdGetDeviceStaus.Click += new System.EventHandler(this.cmdGetDeviceStaus_Click);
            // 
            // chkEnableDevice
            // 
            this.chkEnableDevice.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEnableDevice.BackColor = System.Drawing.SystemColors.Control;
            this.chkEnableDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkEnableDevice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableDevice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkEnableDevice.Location = new System.Drawing.Point(406, 76);
            this.chkEnableDevice.Name = "chkEnableDevice";
            this.chkEnableDevice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkEnableDevice.Size = new System.Drawing.Size(156, 45);
            this.chkEnableDevice.TabIndex = 23;
            this.chkEnableDevice.Text = "DisableDevice(Deprecated)";
            this.chkEnableDevice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEnableDevice.UseVisualStyleBackColor = false;
            this.chkEnableDevice.CheckedChanged += new System.EventHandler(this.chkEnableDevice_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(213, 198);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(119, 25);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "Info Value:";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(32, 199);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(47, 25);
            this.lblStatus.TabIndex = 31;
            this.lblStatus.Text = "Info : ";
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(16, 16);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(555, 30);
            this.lblMessage.TabIndex = 30;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdSetDeviceTime
            // 
            this.cmdSetDeviceTime.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetDeviceTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetDeviceTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetDeviceTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetDeviceTime.Location = new System.Drawing.Point(16, 120);
            this.cmdSetDeviceTime.Name = "cmdSetDeviceTime";
            this.cmdSetDeviceTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetDeviceTime.Size = new System.Drawing.Size(156, 44);
            this.cmdSetDeviceTime.TabIndex = 24;
            this.cmdSetDeviceTime.Text = "SetDeviceTime";
            this.cmdSetDeviceTime.UseVisualStyleBackColor = false;
            this.cmdSetDeviceTime.Click += new System.EventHandler(this.cmdSetDeviceTime_Click);
            // 
            // cmbstatus
            // 
            this.cmbstatus.BackColor = System.Drawing.SystemColors.Window;
            this.cmbstatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbstatus.Location = new System.Drawing.Point(440, 196);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbstatus.Size = new System.Drawing.Size(129, 27);
            this.cmbstatus.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(390, 199);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "status";
            // 
            // frmSystemInfo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(585, 313);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.cmdGetDeviceTime);
            this.Controls.Add(this.cmdGetDeviceInfo);
            this.Controls.Add(this.cmdPowerOn);
            this.Controls.Add(this.PowerOffDevice);
            this.Controls.Add(this.cmdSetDeviceInfo);
            this.Controls.Add(this.cmbInfo);
            this.Controls.Add(this.txtSetDevInfo);
            this.Controls.Add(this.cmdGetDeviceStaus);
            this.Controls.Add(this.chkEnableDevice);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cmdSetDeviceTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSystemInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage System Info";
            this.Load += new System.EventHandler(this.frmSystemInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private void frmSystemInfo_Load(object sender, System.EventArgs e)
        {
            cmbInfo.Items.Add("ManagerCount");
            cmbInfo.Items.Add("Machine Num");
            cmbInfo.Items.Add("Language");
            cmbInfo.Items.Add("GLogWarning");
            cmbInfo.Items.Add("ReVerifyTime");
            cmbInfo.SelectedIndex = 0;

            cmbstatus.Items.Add("Manager count");
            cmbstatus.Items.Add("User count");
            cmbstatus.Items.Add("Fp count");
            cmbstatus.Items.Add("Password count");
            cmbstatus.Items.Add("GLog count");
            cmbstatus.Items.Add("All GLog count");
            cmbstatus.Items.Add("Card count");
            cmbstatus.Items.Add("Face count");
            cmbstatus.Items.Add("Palm count");
            cmbstatus.Items.Add("MaxUser count");
            cmbstatus.Items.Add("MaxFp count");
            cmbstatus.Items.Add("MaxPassword count");
            cmbstatus.Items.Add("MaxCard count");
            cmbstatus.Items.Add("MaxFace count");
            cmbstatus.Items.Add("MaxPalm count");
            cmbstatus.Items.Add("MaxGLog count");
            cmbstatus.SelectedIndex = 0;
        }

        private void cmdGetDeviceTime_Click(object sender, System.EventArgs e)
        {
            DateTime vdwDate = DateTime.Now;
            string strDataTime;
            int vnResultCode;

            cmdGetDeviceTime.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdGetDeviceTime.Enabled = true;
                return;
            }

            vnResultCode = FKAttendDLL.FK_GetDeviceTime(FKAttendDLL.nCommHandleIndex, ref vdwDate);
            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
            {
                strDataTime = "Date = " + vdwDate.ToLongDateString() + ", Time = " + vdwDate.ToLongTimeString();
                lblMessage.Text = strDataTime;
            }
            else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);


            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdGetDeviceTime.Enabled = true;
        }

        private void cmdSetDeviceTime_Click(object sender, System.EventArgs e)
        {
            DateTime vdwDate;
            int vnResultCode;

            cmdSetDeviceTime.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdSetDeviceTime.Enabled = true;
                return;
            }

            vdwDate = DateTime.Now;
            vnResultCode = FKAttendDLL.FK_SetDeviceTime(FKAttendDLL.nCommHandleIndex, vdwDate);
            lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdSetDeviceTime.Enabled = true;
        }
        private void cmdPowerOn_Click(object sender, System.EventArgs e)
        {
            FKAttendDLL.FK_PowerOnAllDevice(FKAttendDLL.nCommHandleIndex);

        }

        private void PowerOffDevice_Click(object sender, System.EventArgs e)
        {
            int vnResultCode;

            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_PowerOffDevice(FKAttendDLL.nCommHandleIndex);
            lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
        }

        private void chkEnableDevice_Click(object sender, System.EventArgs e)
        {
            byte vnFlag;
            int vnResultCode;

            lblMessage.Text = "Working...";
            Application.DoEvents();

            if (chkEnableDevice.CheckState == CheckState.Unchecked)
                vnFlag = 1;
            else
                vnFlag = 0;


            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, vnFlag);
            lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            if (chkEnableDevice.CheckState == CheckState.Unchecked)
                chkEnableDevice.Text = "DisableDevice";
            else
                chkEnableDevice.Text = "EnableDevice";

        }

        private void cmdGetDeviceInfo_Click(object sender, System.EventArgs e)
        {
            int vnInfoIndex = 0;
            int vnValue = 0;
            long vnResultCode;

            cmdGetDeviceInfo.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (long)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdGetDeviceInfo.Enabled = true;
                return;
            }
            switch (cmbInfo.Text)
            {
                case "ManagerCount":
                    vnInfoIndex = 1;
                    break;
                case "Machine Num":
                    vnInfoIndex = 2;
                    break;
                case "Language":
                    vnInfoIndex = 3;
                    break;
                case "GLogWarning":
                    vnInfoIndex = 6;
                    break;
                case "ReVerifyTime":
                    vnInfoIndex = 8;
                    break;
                default:
                    break;
            }


            //vnInfoIndex = cmbInfo.SelectedIndex + 1;
            if (vnInfoIndex == 11)
                vnInfoIndex = 24;

            vnResultCode = FKAttendDLL.FK_GetDeviceInfo(FKAttendDLL.nCommHandleIndex, vnInfoIndex, ref vnValue);
            if (vnResultCode == (long)enumErrorCode.RUN_SUCCESS)
            {
                switch (vnInfoIndex)
                {
                    case (int)enumGetDeviceInfo.DI_MANAGERS: lblMessage.Text = "ManagerCount = " + vnValue; txtSetDevInfo.Text = vnValue.ToString(); break;
                    case (int)enumGetDeviceInfo.DI_MACHINENUM: lblMessage.Text = "Machine Num = " + vnValue; txtSetDevInfo.Text = vnValue.ToString(); break;
                    case (int)enumGetDeviceInfo.DI_LANGAUGE: lblMessage.Text = "Language = " + vnValue; txtSetDevInfo.Text = vnValue.ToString(); break;
                    case (int)enumGetDeviceInfo.DI_POWEROFF_TIME: lblMessage.Text = "PowerOffTime = " + vnValue; txtSetDevInfo.Text = vnValue.ToString(); break;
                    case (int)enumGetDeviceInfo.DI_LOCK_CTRL: lblMessage.Text = "LockOperate = " + vnValue; break;
                    case (int)enumGetDeviceInfo.DI_GLOG_WARNING: lblMessage.Text = "GLogWarning = " + vnValue; txtSetDevInfo.Text = vnValue.ToString(); break;
                    case (int)enumGetDeviceInfo.DI_SLOG_WARNING: lblMessage.Text = "SLogWarning = " + vnValue; break;
                    case (int)enumGetDeviceInfo.DI_VERIFY_INTERVALS: lblMessage.Text = "ReVerifyTime = " + vnValue; txtSetDevInfo.Text = vnValue.ToString(); break;
                    case (int)enumGetDeviceInfo.DI_RSCOM_BPS:
                        lblMessage.Text = "Baudrate(" + vnValue + ") : ";
                        if (vnValue == (int)enumBaudrate.BPS_9600)
                            lblMessage.Text = lblMessage.Text + "9600";
                        else if (vnValue == (int)enumBaudrate.BPS_19200)
                            lblMessage.Text = lblMessage.Text + "19200";
                        else if (vnValue == (int)enumBaudrate.BPS_38400)
                            lblMessage.Text = lblMessage.Text + "38400";
                        else if (vnValue == (int)enumBaudrate.BPS_57600)
                            lblMessage.Text = lblMessage.Text + "57600";
                        else if (vnValue == (int)enumBaudrate.BPS_115200)
                            lblMessage.Text = lblMessage.Text + "115200";
                        else
                            lblMessage.Text = lblMessage.Text + "--";
                        break;
                    case (int)enumGetDeviceInfo.DI_VERIFY_KIND:
                        lblMessage.Text = "VerifyKind = ";
                        if (vnValue == 0)
                            lblMessage.Text = lblMessage.Text + "F / P / C";
                        else if (vnValue == 1)
                            lblMessage.Text = lblMessage.Text + "F + P";
                        else if (vnValue == 2)
                            lblMessage.Text = lblMessage.Text + "F + C";
                        else if (vnValue == 3)
                            lblMessage.Text = lblMessage.Text + "C";
                        break;
                    case (int)enumGetDeviceInfo.DI_DATE_SEPARATE: lblMessage.Text = "DateSeperate = " + vnValue; break;
                    default: lblMessage.Text = "--"; break;
                }
            }
            else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdGetDeviceInfo.Enabled = true;
        }

        private void cmdSetDeviceInfo_Click(object sender, System.EventArgs e)
        {
            int vnInfoIndex = 0;
            int vnValue = 0;
            int vnResultCode;

            cmdSetDeviceInfo.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (long)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdSetDeviceInfo.Enabled = true;
                return;
            }

            switch (cmbInfo.Text)
            {
                case "ManagerCount":
                    vnInfoIndex = 1;
                    break;
                case "Machine Num":
                    vnInfoIndex = 2;
                    break;
                case "Language":
                    vnInfoIndex = 3;
                    break;
                case "GLogWarning":
                    vnInfoIndex = 6;
                    break;
                case "ReVerifyTime":
                    vnInfoIndex = 8;
                    break;
                default:
                    break;
            }

            //vnInfoIndex = cmbInfo.SelectedIndex + 1;
            if (FKAttendDLL.IsNumeric(txtSetDevInfo.Text))
                vnValue = Convert.ToInt32(txtSetDevInfo.Text);
            if (vnInfoIndex == 11)
            {
                vnInfoIndex = 24;
            }
            vnResultCode = FKAttendDLL.FK_SetDeviceInfo(FKAttendDLL.nCommHandleIndex, vnInfoIndex, vnValue);
            if (vnInfoIndex == (int)enumGetDeviceInfo.DI_MACHINENUM && vnResultCode == (long)enumErrorCode.RUN_SUCCESS)
            {
                frmMain.gfrmMain.txtMachineNumber.Text = vnValue.ToString();
            }
            lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdSetDeviceInfo.Enabled = true;
        }
        private void cmdGetDeviceStaus_Click(object sender, System.EventArgs e)
        {
            int vnStatusIndex = 0;
            int vnValue = 0;
            int vnResultCode;

            cmdGetDeviceStaus.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdGetDeviceStaus.Enabled = true;
                return;
            }

            switch (cmbstatus.Text)
            {
                case "Manager count":
                    vnStatusIndex = 1;
                    break;
                case "User count":
                    vnStatusIndex = 2;
                    break;
                case "Fp count":
                    vnStatusIndex = 3;
                    break;
                case "Password count":
                    vnStatusIndex = 4;
                    break;
                case "GLog count":
                    vnStatusIndex = 6;
                    break;
                case "All GLog count":
                    vnStatusIndex = 8;
                    break;
                case "Card count":
                    vnStatusIndex = 9;
                    break;
                case "Face count":
                    vnStatusIndex = 10;
                    break;
                case "Palm count":
                    vnStatusIndex = 40;
                    break;
                case "MaxUser count":
                    vnStatusIndex = 200;
                    break;
                case "MaxFp count":
                    vnStatusIndex = 201;
                    break;
                case "MaxPassword count":
                    vnStatusIndex = 202;
                    break;
                case "MaxCard count":
                    vnStatusIndex = 203;
                    break;
                case "MaxFace count":
                    vnStatusIndex = 204;
                    break;
                case "MaxPalm count":
                    vnStatusIndex = 205;
                    break;
                case "MaxGLog count":
                    vnStatusIndex = 207;
                    break;
                default:
                    break;
            }
            //vnStatusIndex = cmbSatus.SelectedIndex + 1;
            //vnStatusIndex = Convert.ToInt32(cmbInfo.Text);
            vnResultCode = FKAttendDLL.FK_GetDeviceStatus(FKAttendDLL.nCommHandleIndex, vnStatusIndex, ref vnValue);
            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
            {
                switch (vnStatusIndex)
                {
                    case (int)enumGetDeviceStatus.GET_MANAGERS: lblMessage.Text = "Manager count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_USERS: lblMessage.Text = "User count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_FPS: lblMessage.Text = "Fp count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_PSWS: lblMessage.Text = "Password count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_SLOGS: lblMessage.Text = "SLog count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_GLOGS: lblMessage.Text = "GLog count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_ASLOGS: lblMessage.Text = "All SLog count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_AGLOGS: lblMessage.Text = "All GLog count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_CARDS: lblMessage.Text = "Card count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_FACES: lblMessage.Text = "Face count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_PVS: lblMessage.Text = "Palm count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_MAXUSERS: lblMessage.Text = "MaxUser count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_MAXFPS: lblMessage.Text = "MaxFp count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_MAXPSWS: lblMessage.Text = "MaxPassword count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_MAXCARDS: lblMessage.Text = "MaxCard count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_MAXFACES: lblMessage.Text = "MaxFace count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_MAXPVS: lblMessage.Text = "MaxPalm count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_MAXSLOGS: lblMessage.Text = "MaxSLog count = " + vnValue; break;
                    case (int)enumGetDeviceStatus.GET_MAXGLOGS: lblMessage.Text = "MaxGLog count = " + vnValue; break;

                    default: lblMessage.Text = "--"; break;
                }
            }
            else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);


            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdGetDeviceStaus.Enabled = true;
        }

    }
}
