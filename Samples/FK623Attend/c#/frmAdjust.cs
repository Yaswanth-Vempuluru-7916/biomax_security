using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FKAttendDllCSSample
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmAdjust : System.Windows.Forms.Form
	{
		public System.Windows.Forms.TextBox txtRestoredHour;
		public System.Windows.Forms.TextBox txtAdjustedHour;
		public System.Windows.Forms.TextBox txtRestoredMinute;
		public System.Windows.Forms.TextBox txtAdjustedMinute;
		public System.Windows.Forms.Button cmdSetAdjustInfo;
		public System.Windows.Forms.Button cmdGetAdjustInfo;
		public System.Windows.Forms.TextBox txtAdjustedDay;
		public System.Windows.Forms.TextBox txtRestoredDay;
		public System.Windows.Forms.TextBox txtAdjustedMonth;
		public System.Windows.Forms.TextBox txtRestoredMonth;
		public System.Windows.Forms.ComboBox cmbAdjustedState;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label4;
        public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label lblChangeFlag;
		public System.Windows.Forms.Label Label42;
		public System.Windows.Forms.Label Label43;
		public System.Windows.Forms.Label lblMessage;
		public System.Windows.Forms.ComboBox cmbRestoredState;
        public Label label7;
        public Label label8;
        public Label label2;
        public Label label9;
        public Label label10;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmAdjust()
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
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.txtRestoredHour = new System.Windows.Forms.TextBox();
            this.txtAdjustedHour = new System.Windows.Forms.TextBox();
            this.txtRestoredMinute = new System.Windows.Forms.TextBox();
            this.txtAdjustedMinute = new System.Windows.Forms.TextBox();
            this.cmdSetAdjustInfo = new System.Windows.Forms.Button();
            this.cmdGetAdjustInfo = new System.Windows.Forms.Button();
            this.txtAdjustedDay = new System.Windows.Forms.TextBox();
            this.txtRestoredDay = new System.Windows.Forms.TextBox();
            this.txtAdjustedMonth = new System.Windows.Forms.TextBox();
            this.txtRestoredMonth = new System.Windows.Forms.TextBox();
            this.cmbAdjustedState = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblChangeFlag = new System.Windows.Forms.Label();
            this.Label42 = new System.Windows.Forms.Label();
            this.Label43 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmbRestoredState = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRestoredHour
            // 
            this.txtRestoredHour.AcceptsReturn = true;
            this.txtRestoredHour.BackColor = System.Drawing.SystemColors.Window;
            this.txtRestoredHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRestoredHour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestoredHour.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRestoredHour.Location = new System.Drawing.Point(209, 124);
            this.txtRestoredHour.MaxLength = 32;
            this.txtRestoredHour.Name = "txtRestoredHour";
            this.txtRestoredHour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRestoredHour.Size = new System.Drawing.Size(34, 26);
            this.txtRestoredHour.TabIndex = 51;
            // 
            // txtAdjustedHour
            // 
            this.txtAdjustedHour.AcceptsReturn = true;
            this.txtAdjustedHour.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdjustedHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdjustedHour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjustedHour.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAdjustedHour.Location = new System.Drawing.Point(209, 84);
            this.txtAdjustedHour.MaxLength = 32;
            this.txtAdjustedHour.Name = "txtAdjustedHour";
            this.txtAdjustedHour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdjustedHour.Size = new System.Drawing.Size(34, 26);
            this.txtAdjustedHour.TabIndex = 46;
            // 
            // txtRestoredMinute
            // 
            this.txtRestoredMinute.AcceptsReturn = true;
            this.txtRestoredMinute.BackColor = System.Drawing.SystemColors.Window;
            this.txtRestoredMinute.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRestoredMinute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestoredMinute.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRestoredMinute.Location = new System.Drawing.Point(258, 124);
            this.txtRestoredMinute.MaxLength = 32;
            this.txtRestoredMinute.Name = "txtRestoredMinute";
            this.txtRestoredMinute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRestoredMinute.Size = new System.Drawing.Size(34, 26);
            this.txtRestoredMinute.TabIndex = 52;
            // 
            // txtAdjustedMinute
            // 
            this.txtAdjustedMinute.AcceptsReturn = true;
            this.txtAdjustedMinute.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdjustedMinute.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdjustedMinute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjustedMinute.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAdjustedMinute.Location = new System.Drawing.Point(258, 84);
            this.txtAdjustedMinute.MaxLength = 32;
            this.txtAdjustedMinute.Name = "txtAdjustedMinute";
            this.txtAdjustedMinute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdjustedMinute.Size = new System.Drawing.Size(34, 26);
            this.txtAdjustedMinute.TabIndex = 47;
            // 
            // cmdSetAdjustInfo
            // 
            this.cmdSetAdjustInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetAdjustInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetAdjustInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetAdjustInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetAdjustInfo.Location = new System.Drawing.Point(262, 173);
            this.cmdSetAdjustInfo.Name = "cmdSetAdjustInfo";
            this.cmdSetAdjustInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetAdjustInfo.Size = new System.Drawing.Size(115, 28);
            this.cmdSetAdjustInfo.TabIndex = 55;
            this.cmdSetAdjustInfo.Text = "Set";
            this.cmdSetAdjustInfo.UseVisualStyleBackColor = false;
            this.cmdSetAdjustInfo.Click += new System.EventHandler(this.cmdSetAdjustInfo_Click);
            // 
            // cmdGetAdjustInfo
            // 
            this.cmdGetAdjustInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetAdjustInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetAdjustInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetAdjustInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetAdjustInfo.Location = new System.Drawing.Point(142, 173);
            this.cmdGetAdjustInfo.Name = "cmdGetAdjustInfo";
            this.cmdGetAdjustInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetAdjustInfo.Size = new System.Drawing.Size(115, 28);
            this.cmdGetAdjustInfo.TabIndex = 54;
            this.cmdGetAdjustInfo.Text = "Get";
            this.cmdGetAdjustInfo.UseVisualStyleBackColor = false;
            this.cmdGetAdjustInfo.Click += new System.EventHandler(this.cmdGetAdjustInfo_Click);
            // 
            // txtAdjustedDay
            // 
            this.txtAdjustedDay.AcceptsReturn = true;
            this.txtAdjustedDay.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdjustedDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdjustedDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjustedDay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAdjustedDay.Location = new System.Drawing.Point(158, 84);
            this.txtAdjustedDay.MaxLength = 32;
            this.txtAdjustedDay.Name = "txtAdjustedDay";
            this.txtAdjustedDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdjustedDay.Size = new System.Drawing.Size(34, 26);
            this.txtAdjustedDay.TabIndex = 45;
            // 
            // txtRestoredDay
            // 
            this.txtRestoredDay.AcceptsReturn = true;
            this.txtRestoredDay.BackColor = System.Drawing.SystemColors.Window;
            this.txtRestoredDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRestoredDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestoredDay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRestoredDay.Location = new System.Drawing.Point(158, 124);
            this.txtRestoredDay.MaxLength = 32;
            this.txtRestoredDay.Name = "txtRestoredDay";
            this.txtRestoredDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRestoredDay.Size = new System.Drawing.Size(34, 26);
            this.txtRestoredDay.TabIndex = 50;
            // 
            // txtAdjustedMonth
            // 
            this.txtAdjustedMonth.AcceptsReturn = true;
            this.txtAdjustedMonth.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdjustedMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdjustedMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjustedMonth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAdjustedMonth.Location = new System.Drawing.Point(110, 84);
            this.txtAdjustedMonth.MaxLength = 32;
            this.txtAdjustedMonth.Name = "txtAdjustedMonth";
            this.txtAdjustedMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdjustedMonth.Size = new System.Drawing.Size(34, 26);
            this.txtAdjustedMonth.TabIndex = 44;
            // 
            // txtRestoredMonth
            // 
            this.txtRestoredMonth.AcceptsReturn = true;
            this.txtRestoredMonth.BackColor = System.Drawing.SystemColors.Window;
            this.txtRestoredMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRestoredMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestoredMonth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRestoredMonth.Location = new System.Drawing.Point(110, 124);
            this.txtRestoredMonth.MaxLength = 32;
            this.txtRestoredMonth.Name = "txtRestoredMonth";
            this.txtRestoredMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRestoredMonth.Size = new System.Drawing.Size(34, 26);
            this.txtRestoredMonth.TabIndex = 49;
            // 
            // cmbAdjustedState
            // 
            this.cmbAdjustedState.BackColor = System.Drawing.SystemColors.Window;
            this.cmbAdjustedState.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbAdjustedState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdjustedState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdjustedState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbAdjustedState.Items.AddRange(new object[] {
            "None",
            "-1",
            "+1"});
            this.cmbAdjustedState.Location = new System.Drawing.Point(305, 84);
            this.cmbAdjustedState.Name = "cmbAdjustedState";
            this.cmbAdjustedState.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbAdjustedState.Size = new System.Drawing.Size(83, 27);
            this.cmbAdjustedState.TabIndex = 48;
            this.cmbAdjustedState.SelectedIndexChanged += new System.EventHandler(this.cmbAdjustedState_SelectedIndexChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.SystemColors.Control;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(245, 127);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(12, 19);
            this.Label6.TabIndex = 65;
            this.Label6.Text = ":";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.SystemColors.Control;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(245, 87);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(12, 19);
            this.Label5.TabIndex = 64;
            this.Label5.Text = ":";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(144, 128);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(15, 19);
            this.Label4.TabIndex = 63;
            this.Label4.Text = "-";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(144, 88);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(15, 19);
            this.Label3.TabIndex = 62;
            this.Label3.Text = "-";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(110, 60);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(37, 19);
            this.Label1.TabIndex = 60;
            this.Label1.Text = "MM";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblChangeFlag
            // 
            this.lblChangeFlag.AutoSize = true;
            this.lblChangeFlag.BackColor = System.Drawing.SystemColors.Control;
            this.lblChangeFlag.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblChangeFlag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeFlag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChangeFlag.Location = new System.Drawing.Point(298, 60);
            this.lblChangeFlag.Name = "lblChangeFlag";
            this.lblChangeFlag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblChangeFlag.Size = new System.Drawing.Size(90, 19);
            this.lblChangeFlag.TabIndex = 58;
            this.lblChangeFlag.Text = "Change State";
            this.lblChangeFlag.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label42
            // 
            this.Label42.AutoSize = true;
            this.Label42.BackColor = System.Drawing.Color.Transparent;
            this.Label42.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label42.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label42.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label42.Location = new System.Drawing.Point(22, 87);
            this.Label42.Name = "Label42";
            this.Label42.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label42.Size = new System.Drawing.Size(83, 19);
            this.Label42.TabIndex = 57;
            this.Label42.Text = "Adjusted on";
            // 
            // Label43
            // 
            this.Label43.AutoSize = true;
            this.Label43.BackColor = System.Drawing.Color.Transparent;
            this.Label43.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label43.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label43.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label43.Location = new System.Drawing.Point(22, 128);
            this.Label43.Name = "Label43";
            this.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label43.Size = new System.Drawing.Size(83, 19);
            this.Label43.TabIndex = 56;
            this.Label43.Text = "Restored on";
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(14, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(361, 28);
            this.lblMessage.TabIndex = 59;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbRestoredState
            // 
            this.cmbRestoredState.BackColor = System.Drawing.SystemColors.Window;
            this.cmbRestoredState.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbRestoredState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRestoredState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRestoredState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbRestoredState.Items.AddRange(new object[] {
            "None",
            "-1",
            "+1"});
            this.cmbRestoredState.Location = new System.Drawing.Point(305, 124);
            this.cmbRestoredState.Name = "cmbRestoredState";
            this.cmbRestoredState.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbRestoredState.Size = new System.Drawing.Size(83, 27);
            this.cmbRestoredState.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(158, 60);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(31, 19);
            this.label7.TabIndex = 60;
            this.label7.Text = "DD";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(144, 60);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(15, 19);
            this.label8.TabIndex = 62;
            this.label8.Text = "-";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(209, 60);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 60;
            this.label2.Text = "HH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(258, 60);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(37, 19);
            this.label9.TabIndex = 60;
            this.label9.Text = "MM";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(245, 60);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(12, 19);
            this.label10.TabIndex = 64;
            this.label10.Text = ":";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmAdjust
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(470, 230);
            this.Controls.Add(this.txtRestoredHour);
            this.Controls.Add(this.txtAdjustedHour);
            this.Controls.Add(this.txtRestoredMinute);
            this.Controls.Add(this.txtAdjustedMinute);
            this.Controls.Add(this.txtAdjustedDay);
            this.Controls.Add(this.txtRestoredDay);
            this.Controls.Add(this.txtAdjustedMonth);
            this.Controls.Add(this.txtRestoredMonth);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblChangeFlag);
            this.Controls.Add(this.Label42);
            this.Controls.Add(this.Label43);
            this.Controls.Add(this.cmdSetAdjustInfo);
            this.Controls.Add(this.cmdGetAdjustInfo);
            this.Controls.Add(this.cmbAdjustedState);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cmbRestoredState);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdjust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adjuste/Restore Info";
            this.Load += new System.EventHandler(this.frmAdjust_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void cmdGetAdjustInfo_Click(object sender, System.EventArgs e)
		{
			int vAdjustedState = 0;
			int vAdjustedHour = 0, vAdjustedMonth = 0, vAdjustedDay = 0, vAdjustedMinute = 0;
			int vRestoredState = 0;
			int vRestoredHour = 0, vRestoredMonth = 0, vRestoredDay = 0, vRestoredMinute = 0;
			int vbRet;

			lblMessage.Text = "";
			Application.DoEvents();

            vbRet = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
			if (vbRet != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = FKAttendDLL.msErrorNoDevice;
				return;
			}

            vbRet = FKAttendDLL.FK_GetAdjustInfo(
                FKAttendDLL.nCommHandleIndex, 
                ref vAdjustedState, 
                ref vAdjustedMonth, ref vAdjustedDay, ref vAdjustedHour, ref vAdjustedMinute, 
                ref vRestoredState, 
                ref vRestoredMonth, ref vRestoredDay, ref vRestoredHour, ref vRestoredMinute);
			if (vbRet == (int)enumErrorCode.RUN_SUCCESS)
			{
				if (vAdjustedState < 3)
					cmbAdjustedState.SelectedIndex = vAdjustedState;
				else
					cmbAdjustedState.SelectedIndex = 0;
	            
				txtAdjustedMonth.Text = vAdjustedMonth.ToString();
				txtAdjustedDay.Text = vAdjustedDay.ToString();
				txtAdjustedHour.Text = vAdjustedHour.ToString();
				txtAdjustedMinute.Text = vAdjustedMinute.ToString();

				if (vRestoredState < 3)
					cmbRestoredState.SelectedIndex = vRestoredState;
				else
					cmbRestoredState.SelectedIndex = 0;
	            
				txtRestoredMonth.Text = vRestoredMonth.ToString();
				txtRestoredDay.Text = vRestoredDay.ToString();
				txtRestoredHour.Text = vRestoredHour.ToString();
				txtRestoredMinute.Text = vRestoredMinute.ToString();
				lblMessage.Text = "Success!";
			}
			else
			{
				lblMessage.Text = "Failed";
			}

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
		}

		private void cmdSetAdjustInfo_Click(object sender, System.EventArgs e)
		{
			int vAdjustedState;
			int  vAdjustedHour, vAdjustedMonth, vAdjustedDay, vAdjustedMinute;
			int  vRestoredState;
			int  vRestoredHour, vRestoredMonth, vRestoredDay, vRestoredMinute;
			int vbRet;

			lblMessage.Text = "";
			Application.DoEvents();

            vbRet = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
			if (vbRet != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = FKAttendDLL.msErrorNoDevice;
				return;
			}

			vAdjustedState = cmbAdjustedState.SelectedIndex;
			vAdjustedMonth = Convert.ToInt32(txtAdjustedMonth.Text);
			vAdjustedDay = Convert.ToInt32(txtAdjustedDay.Text);
			vAdjustedHour = Convert.ToInt32(txtAdjustedHour.Text);
			vAdjustedMinute = Convert.ToInt32(txtAdjustedMinute.Text);

			vRestoredState = cmbRestoredState.SelectedIndex;
			vRestoredMonth = Convert.ToInt32(txtRestoredMonth.Text);
			vRestoredDay = Convert.ToInt32(txtRestoredDay.Text);
			vRestoredHour = Convert.ToInt32(txtRestoredHour.Text);
			vRestoredMinute = Convert.ToInt32(txtRestoredMinute.Text);

            vbRet = FKAttendDLL.FK_SetAdjustInfo(
                FKAttendDLL.nCommHandleIndex, 
                vAdjustedState, 
                vAdjustedMonth, vAdjustedDay, vAdjustedHour, vAdjustedMinute, 
                vRestoredState, 
                vRestoredMonth, vRestoredDay, vRestoredHour, vRestoredMinute);
			if (vbRet == (int)enumErrorCode.RUN_SUCCESS)
				lblMessage.Text = "Success!";
			else
			{
				lblMessage.Text = "Failed!";
			}

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
		}

		private void cmbAdjustedState_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cmbAdjustedState.SelectedIndex == 0)cmbRestoredState.SelectedIndex = 0;
			if (cmbAdjustedState.SelectedIndex == 1) cmbRestoredState.SelectedIndex = 2;
			if (cmbAdjustedState.SelectedIndex == 2) cmbRestoredState.SelectedIndex = 1;
		}

		private void frmAdjust_Load(object sender, System.EventArgs e)
		{
			cmbAdjustedState.SelectedIndex = 0;
			cmbRestoredState.SelectedIndex = 0;
			txtAdjustedMonth.Text = "1";
			txtAdjustedDay.Text = "1";
			txtAdjustedHour.Text = "0";
			txtAdjustedMinute.Text = "0";
			txtRestoredMonth.Text = "1";
			txtRestoredDay.Text = "1";
			txtRestoredHour.Text = "0";
			txtRestoredMinute.Text = "0";
		}
	}
}
