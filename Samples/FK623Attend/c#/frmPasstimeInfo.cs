using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FKAttendDllCSSample
{
	/// <summary>
	/// Form9 的摘要说明。
	/// </summary>
	public class frmPasstimeInfo : System.Windows.Forms.Form
	{
		public System.Windows.Forms.GroupBox Frame4;
		public System.Windows.Forms.TextBox txtGroupMatch9;
		public System.Windows.Forms.TextBox txtGroupMatch8;
		public System.Windows.Forms.TextBox txtGroupMatch7;
		public System.Windows.Forms.TextBox txtGroupMatch6;
		public System.Windows.Forms.TextBox txtGroupMatch5;
		public System.Windows.Forms.TextBox txtGroupMatch4;
		public System.Windows.Forms.TextBox txtGroupMatch3;
		public System.Windows.Forms.TextBox txtGroupMatch2;
		public System.Windows.Forms.TextBox txtGroupMatch1;
		public System.Windows.Forms.TextBox txtGroupMatch0;
		public System.Windows.Forms.Button cmdSetGroupMatch;
		public System.Windows.Forms.Button cmdGetGroupMatch;
		public System.Windows.Forms.Label _lblLabel_10;
		public System.Windows.Forms.Label lblLabel9;
		public System.Windows.Forms.ComboBox cmbDoorState;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.TextBox txtUserPassTime2;
		public System.Windows.Forms.TextBox txtUserPassTime1;
		public System.Windows.Forms.TextBox txtUserPassTime0;
		public System.Windows.Forms.TextBox txtUserID;
		public System.Windows.Forms.TextBox txtGroupID;
		public System.Windows.Forms.Button cmdGetUserPasstime;
		public System.Windows.Forms.Button cmdSetUserPassTime;
		public System.Windows.Forms.Label lblLabel3;
		public System.Windows.Forms.Label lblLabel2;
		public System.Windows.Forms.Label lblLabel1;
		public System.Windows.Forms.Label lblLabel0;
		public System.Windows.Forms.Label lblUserID;
		public System.Windows.Forms.Button cmdSetDoorState;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.Button cmdWrite;
		public System.Windows.Forms.Button cmdRead;
		public System.Windows.Forms.TextBox txtPassTimeID;
		public System.Windows.Forms.Label lblLabel8;
		public System.Windows.Forms.Label lblWeek0;
		public System.Windows.Forms.Label lblWeek6;
		public System.Windows.Forms.Label lblWeek5;
		public System.Windows.Forms.Label lblWeek4;
		public System.Windows.Forms.Label lblWeek3;
		public System.Windows.Forms.Label lblWeek2;
		public System.Windows.Forms.Label lblWeek1;
		public System.Windows.Forms.Label lblMidSep6;
		public System.Windows.Forms.TextBox txtEndHour0;
		public System.Windows.Forms.TextBox txtEndMinute0;
		public System.Windows.Forms.TextBox txtStartMinute0;
		public System.Windows.Forms.TextBox txtStartHour0;
		public System.Windows.Forms.TextBox txtEndHour4;
		public System.Windows.Forms.TextBox txtEndMinute4;
		public System.Windows.Forms.TextBox txtEndMinute3;
		public System.Windows.Forms.TextBox txtEndHour3;
		public System.Windows.Forms.TextBox txtEndHour2;
		public System.Windows.Forms.TextBox txtEndMinute2;
		public System.Windows.Forms.TextBox txtEndMinute1;
		public System.Windows.Forms.TextBox txtEndHour1;
		public System.Windows.Forms.TextBox txtStartMinute4;
		public System.Windows.Forms.TextBox txtStartHour4;
		public System.Windows.Forms.TextBox txtStartHour3;
		public System.Windows.Forms.TextBox txtStartMinute3;
		public System.Windows.Forms.TextBox txtStartMinute2;
		public System.Windows.Forms.TextBox txtStartHour2;
		public System.Windows.Forms.TextBox txtStartHour1;
		public System.Windows.Forms.TextBox txtStartMinute1;
		public System.Windows.Forms.TextBox txtStartHour5;
		public System.Windows.Forms.TextBox txtStartHour6;
		public System.Windows.Forms.TextBox txtStartMinute5;
		public System.Windows.Forms.TextBox txtStartMinute6;
		public System.Windows.Forms.TextBox txtEndHour5;
		public System.Windows.Forms.TextBox txtEndHour6;
		public System.Windows.Forms.TextBox txtEndMinute5;
		public System.Windows.Forms.TextBox txtEndMinute6;
		public System.Windows.Forms.Label lblStartSep6;
		public System.Windows.Forms.Label lblEndSep6;
		public System.Windows.Forms.Label lblEndSep5;
		public System.Windows.Forms.Label lblEndSep4;
		public System.Windows.Forms.Label lblEndSep3;
		public System.Windows.Forms.Label lblEndSep2;
		public System.Windows.Forms.Label lblEndSep1;
		public System.Windows.Forms.Label lblEndSep0;
		public System.Windows.Forms.Label lblStartSep5;
		public System.Windows.Forms.Label lblStartSep4;
		public System.Windows.Forms.Label lblStartSep3;
		public System.Windows.Forms.Label lblStartSep2;
		public System.Windows.Forms.Label lblStartSep1;
		public System.Windows.Forms.Label lblMidSep5;
		public System.Windows.Forms.Label lblMidSep4;
		public System.Windows.Forms.Label lblMidSep0;
		public System.Windows.Forms.Label lblStartSep0;
		public System.Windows.Forms.Label lblMidSep3;
		public System.Windows.Forms.Label lblMidSep2;
		public System.Windows.Forms.Label lblMidSep1;
		public System.Windows.Forms.Label lblStartTime;
		public System.Windows.Forms.Label lblEndTime;
		public System.Windows.Forms.Button cmdGetDoorState;
		public System.Windows.Forms.Label lblMessage;
		public System.Windows.Forms.GroupBox Frame3;
		public System.Windows.Forms.TextBox txtGroupNum;
		public System.Windows.Forms.TextBox txtGroupPassTime2;
		public System.Windows.Forms.TextBox txtGroupPassTime1;
		public System.Windows.Forms.TextBox txtGroupPassTime0;
		public System.Windows.Forms.Button cmdGetGroupPassTime;
		public System.Windows.Forms.Button cmdSetGroupPassTime;
		public System.Windows.Forms.Label _lblLabel_7;
		public System.Windows.Forms.Label lblLabel6;
		public System.Windows.Forms.Label lblLabel5;
		public System.Windows.Forms.Label lblLabel4;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmPasstimeInfo()
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
            this.Frame4 = new System.Windows.Forms.GroupBox();
            this.txtGroupMatch9 = new System.Windows.Forms.TextBox();
            this.txtGroupMatch8 = new System.Windows.Forms.TextBox();
            this.txtGroupMatch7 = new System.Windows.Forms.TextBox();
            this.txtGroupMatch6 = new System.Windows.Forms.TextBox();
            this.txtGroupMatch5 = new System.Windows.Forms.TextBox();
            this.txtGroupMatch4 = new System.Windows.Forms.TextBox();
            this.txtGroupMatch3 = new System.Windows.Forms.TextBox();
            this.txtGroupMatch2 = new System.Windows.Forms.TextBox();
            this.txtGroupMatch1 = new System.Windows.Forms.TextBox();
            this.txtGroupMatch0 = new System.Windows.Forms.TextBox();
            this.cmdSetGroupMatch = new System.Windows.Forms.Button();
            this.cmdGetGroupMatch = new System.Windows.Forms.Button();
            this._lblLabel_10 = new System.Windows.Forms.Label();
            this.lblLabel9 = new System.Windows.Forms.Label();
            this.cmbDoorState = new System.Windows.Forms.ComboBox();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.txtUserPassTime2 = new System.Windows.Forms.TextBox();
            this.txtUserPassTime1 = new System.Windows.Forms.TextBox();
            this.txtUserPassTime0 = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.cmdGetUserPasstime = new System.Windows.Forms.Button();
            this.cmdSetUserPassTime = new System.Windows.Forms.Button();
            this.lblLabel3 = new System.Windows.Forms.Label();
            this.lblLabel2 = new System.Windows.Forms.Label();
            this.lblLabel1 = new System.Windows.Forms.Label();
            this.lblLabel0 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.cmdSetDoorState = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.cmdWrite = new System.Windows.Forms.Button();
            this.cmdRead = new System.Windows.Forms.Button();
            this.txtPassTimeID = new System.Windows.Forms.TextBox();
            this.lblLabel8 = new System.Windows.Forms.Label();
            this.lblWeek0 = new System.Windows.Forms.Label();
            this.lblWeek6 = new System.Windows.Forms.Label();
            this.lblWeek5 = new System.Windows.Forms.Label();
            this.lblWeek4 = new System.Windows.Forms.Label();
            this.lblWeek3 = new System.Windows.Forms.Label();
            this.lblWeek2 = new System.Windows.Forms.Label();
            this.lblWeek1 = new System.Windows.Forms.Label();
            this.lblMidSep6 = new System.Windows.Forms.Label();
            this.txtEndHour0 = new System.Windows.Forms.TextBox();
            this.txtEndMinute0 = new System.Windows.Forms.TextBox();
            this.txtStartMinute0 = new System.Windows.Forms.TextBox();
            this.txtStartHour0 = new System.Windows.Forms.TextBox();
            this.txtEndHour4 = new System.Windows.Forms.TextBox();
            this.txtEndMinute4 = new System.Windows.Forms.TextBox();
            this.txtEndMinute3 = new System.Windows.Forms.TextBox();
            this.txtEndHour3 = new System.Windows.Forms.TextBox();
            this.txtEndHour2 = new System.Windows.Forms.TextBox();
            this.txtEndMinute2 = new System.Windows.Forms.TextBox();
            this.txtEndMinute1 = new System.Windows.Forms.TextBox();
            this.txtEndHour1 = new System.Windows.Forms.TextBox();
            this.txtStartMinute4 = new System.Windows.Forms.TextBox();
            this.txtStartHour4 = new System.Windows.Forms.TextBox();
            this.txtStartHour3 = new System.Windows.Forms.TextBox();
            this.txtStartMinute3 = new System.Windows.Forms.TextBox();
            this.txtStartMinute2 = new System.Windows.Forms.TextBox();
            this.txtStartHour2 = new System.Windows.Forms.TextBox();
            this.txtStartHour1 = new System.Windows.Forms.TextBox();
            this.txtStartMinute1 = new System.Windows.Forms.TextBox();
            this.txtStartHour5 = new System.Windows.Forms.TextBox();
            this.txtStartHour6 = new System.Windows.Forms.TextBox();
            this.txtStartMinute5 = new System.Windows.Forms.TextBox();
            this.txtStartMinute6 = new System.Windows.Forms.TextBox();
            this.txtEndHour5 = new System.Windows.Forms.TextBox();
            this.txtEndHour6 = new System.Windows.Forms.TextBox();
            this.txtEndMinute5 = new System.Windows.Forms.TextBox();
            this.txtEndMinute6 = new System.Windows.Forms.TextBox();
            this.lblStartSep6 = new System.Windows.Forms.Label();
            this.lblEndSep6 = new System.Windows.Forms.Label();
            this.lblEndSep5 = new System.Windows.Forms.Label();
            this.lblEndSep4 = new System.Windows.Forms.Label();
            this.lblEndSep3 = new System.Windows.Forms.Label();
            this.lblEndSep2 = new System.Windows.Forms.Label();
            this.lblEndSep1 = new System.Windows.Forms.Label();
            this.lblEndSep0 = new System.Windows.Forms.Label();
            this.lblStartSep5 = new System.Windows.Forms.Label();
            this.lblStartSep4 = new System.Windows.Forms.Label();
            this.lblStartSep3 = new System.Windows.Forms.Label();
            this.lblStartSep2 = new System.Windows.Forms.Label();
            this.lblStartSep1 = new System.Windows.Forms.Label();
            this.lblMidSep5 = new System.Windows.Forms.Label();
            this.lblMidSep4 = new System.Windows.Forms.Label();
            this.lblMidSep0 = new System.Windows.Forms.Label();
            this.lblStartSep0 = new System.Windows.Forms.Label();
            this.lblMidSep3 = new System.Windows.Forms.Label();
            this.lblMidSep2 = new System.Windows.Forms.Label();
            this.lblMidSep1 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.cmdGetDoorState = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.Frame3 = new System.Windows.Forms.GroupBox();
            this.txtGroupNum = new System.Windows.Forms.TextBox();
            this.txtGroupPassTime2 = new System.Windows.Forms.TextBox();
            this.txtGroupPassTime1 = new System.Windows.Forms.TextBox();
            this.txtGroupPassTime0 = new System.Windows.Forms.TextBox();
            this.cmdGetGroupPassTime = new System.Windows.Forms.Button();
            this.cmdSetGroupPassTime = new System.Windows.Forms.Button();
            this._lblLabel_7 = new System.Windows.Forms.Label();
            this.lblLabel6 = new System.Windows.Forms.Label();
            this.lblLabel5 = new System.Windows.Forms.Label();
            this.lblLabel4 = new System.Windows.Forms.Label();
            this.Frame4.SuspendLayout();
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.Frame3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frame4
            // 
            this.Frame4.BackColor = System.Drawing.SystemColors.Control;
            this.Frame4.Controls.Add(this.txtGroupMatch9);
            this.Frame4.Controls.Add(this.txtGroupMatch8);
            this.Frame4.Controls.Add(this.txtGroupMatch7);
            this.Frame4.Controls.Add(this.txtGroupMatch6);
            this.Frame4.Controls.Add(this.txtGroupMatch5);
            this.Frame4.Controls.Add(this.txtGroupMatch4);
            this.Frame4.Controls.Add(this.txtGroupMatch3);
            this.Frame4.Controls.Add(this.txtGroupMatch2);
            this.Frame4.Controls.Add(this.txtGroupMatch1);
            this.Frame4.Controls.Add(this.txtGroupMatch0);
            this.Frame4.Controls.Add(this.cmdSetGroupMatch);
            this.Frame4.Controls.Add(this.cmdGetGroupMatch);
            this.Frame4.Controls.Add(this._lblLabel_10);
            this.Frame4.Controls.Add(this.lblLabel9);
            this.Frame4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame4.Location = new System.Drawing.Point(414, 304);
            this.Frame4.Name = "Frame4";
            this.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame4.Size = new System.Drawing.Size(330, 173);
            this.Frame4.TabIndex = 117;
            this.Frame4.TabStop = false;
            this.Frame4.Text = "Unlock Group";
            // 
            // txtGroupMatch9
            // 
            this.txtGroupMatch9.AcceptsReturn = true;
            this.txtGroupMatch9.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupMatch9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupMatch9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupMatch9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupMatch9.Location = new System.Drawing.Point(222, 97);
            this.txtGroupMatch9.MaxLength = 0;
            this.txtGroupMatch9.Name = "txtGroupMatch9";
            this.txtGroupMatch9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupMatch9.Size = new System.Drawing.Size(41, 25);
            this.txtGroupMatch9.TabIndex = 87;
            this.txtGroupMatch9.Text = "0";
            this.txtGroupMatch9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupMatch8
            // 
            this.txtGroupMatch8.AcceptsReturn = true;
            this.txtGroupMatch8.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupMatch8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupMatch8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupMatch8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupMatch8.Location = new System.Drawing.Point(173, 97);
            this.txtGroupMatch8.MaxLength = 0;
            this.txtGroupMatch8.Name = "txtGroupMatch8";
            this.txtGroupMatch8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupMatch8.Size = new System.Drawing.Size(41, 25);
            this.txtGroupMatch8.TabIndex = 86;
            this.txtGroupMatch8.Text = "0";
            this.txtGroupMatch8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupMatch7
            // 
            this.txtGroupMatch7.AcceptsReturn = true;
            this.txtGroupMatch7.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupMatch7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupMatch7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupMatch7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupMatch7.Location = new System.Drawing.Point(124, 97);
            this.txtGroupMatch7.MaxLength = 0;
            this.txtGroupMatch7.Name = "txtGroupMatch7";
            this.txtGroupMatch7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupMatch7.Size = new System.Drawing.Size(41, 25);
            this.txtGroupMatch7.TabIndex = 85;
            this.txtGroupMatch7.Text = "0";
            this.txtGroupMatch7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupMatch6
            // 
            this.txtGroupMatch6.AcceptsReturn = true;
            this.txtGroupMatch6.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupMatch6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupMatch6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupMatch6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupMatch6.Location = new System.Drawing.Point(75, 97);
            this.txtGroupMatch6.MaxLength = 0;
            this.txtGroupMatch6.Name = "txtGroupMatch6";
            this.txtGroupMatch6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupMatch6.Size = new System.Drawing.Size(41, 25);
            this.txtGroupMatch6.TabIndex = 84;
            this.txtGroupMatch6.Text = "0";
            this.txtGroupMatch6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupMatch5
            // 
            this.txtGroupMatch5.AcceptsReturn = true;
            this.txtGroupMatch5.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupMatch5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupMatch5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupMatch5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupMatch5.Location = new System.Drawing.Point(26, 97);
            this.txtGroupMatch5.MaxLength = 0;
            this.txtGroupMatch5.Name = "txtGroupMatch5";
            this.txtGroupMatch5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupMatch5.Size = new System.Drawing.Size(41, 25);
            this.txtGroupMatch5.TabIndex = 83;
            this.txtGroupMatch5.Text = "0";
            this.txtGroupMatch5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupMatch4
            // 
            this.txtGroupMatch4.AcceptsReturn = true;
            this.txtGroupMatch4.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupMatch4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupMatch4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupMatch4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupMatch4.Location = new System.Drawing.Point(222, 41);
            this.txtGroupMatch4.MaxLength = 0;
            this.txtGroupMatch4.Name = "txtGroupMatch4";
            this.txtGroupMatch4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupMatch4.Size = new System.Drawing.Size(41, 25);
            this.txtGroupMatch4.TabIndex = 82;
            this.txtGroupMatch4.Text = "0";
            this.txtGroupMatch4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupMatch3
            // 
            this.txtGroupMatch3.AcceptsReturn = true;
            this.txtGroupMatch3.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupMatch3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupMatch3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupMatch3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupMatch3.Location = new System.Drawing.Point(173, 41);
            this.txtGroupMatch3.MaxLength = 0;
            this.txtGroupMatch3.Name = "txtGroupMatch3";
            this.txtGroupMatch3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupMatch3.Size = new System.Drawing.Size(41, 25);
            this.txtGroupMatch3.TabIndex = 81;
            this.txtGroupMatch3.Text = "0";
            this.txtGroupMatch3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupMatch2
            // 
            this.txtGroupMatch2.AcceptsReturn = true;
            this.txtGroupMatch2.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupMatch2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupMatch2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupMatch2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupMatch2.Location = new System.Drawing.Point(124, 41);
            this.txtGroupMatch2.MaxLength = 0;
            this.txtGroupMatch2.Name = "txtGroupMatch2";
            this.txtGroupMatch2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupMatch2.Size = new System.Drawing.Size(41, 25);
            this.txtGroupMatch2.TabIndex = 80;
            this.txtGroupMatch2.Text = "0";
            this.txtGroupMatch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupMatch1
            // 
            this.txtGroupMatch1.AcceptsReturn = true;
            this.txtGroupMatch1.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupMatch1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupMatch1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupMatch1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupMatch1.Location = new System.Drawing.Point(75, 41);
            this.txtGroupMatch1.MaxLength = 0;
            this.txtGroupMatch1.Name = "txtGroupMatch1";
            this.txtGroupMatch1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupMatch1.Size = new System.Drawing.Size(41, 25);
            this.txtGroupMatch1.TabIndex = 79;
            this.txtGroupMatch1.Text = "0";
            this.txtGroupMatch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupMatch0
            // 
            this.txtGroupMatch0.AcceptsReturn = true;
            this.txtGroupMatch0.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupMatch0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupMatch0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupMatch0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupMatch0.Location = new System.Drawing.Point(26, 41);
            this.txtGroupMatch0.MaxLength = 0;
            this.txtGroupMatch0.Name = "txtGroupMatch0";
            this.txtGroupMatch0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupMatch0.Size = new System.Drawing.Size(41, 25);
            this.txtGroupMatch0.TabIndex = 78;
            this.txtGroupMatch0.Text = "0";
            this.txtGroupMatch0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdSetGroupMatch
            // 
            this.cmdSetGroupMatch.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetGroupMatch.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetGroupMatch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetGroupMatch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetGroupMatch.Location = new System.Drawing.Point(146, 130);
            this.cmdSetGroupMatch.Name = "cmdSetGroupMatch";
            this.cmdSetGroupMatch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetGroupMatch.Size = new System.Drawing.Size(120, 31);
            this.cmdSetGroupMatch.TabIndex = 77;
            this.cmdSetGroupMatch.Text = "Set Match";
            this.cmdSetGroupMatch.UseVisualStyleBackColor = false;
            this.cmdSetGroupMatch.Click += new System.EventHandler(this.cmdSetGroupMatch_Click);
            // 
            // cmdGetGroupMatch
            // 
            this.cmdGetGroupMatch.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetGroupMatch.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetGroupMatch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetGroupMatch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetGroupMatch.Location = new System.Drawing.Point(16, 130);
            this.cmdGetGroupMatch.Name = "cmdGetGroupMatch";
            this.cmdGetGroupMatch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetGroupMatch.Size = new System.Drawing.Size(120, 31);
            this.cmdGetGroupMatch.TabIndex = 76;
            this.cmdGetGroupMatch.Text = "Get Match";
            this.cmdGetGroupMatch.UseVisualStyleBackColor = false;
            this.cmdGetGroupMatch.Click += new System.EventHandler(this.cmdGetGroupMatch_Click);
            // 
            // _lblLabel_10
            // 
            this._lblLabel_10.BackColor = System.Drawing.SystemColors.Control;
            this._lblLabel_10.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblLabel_10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLabel_10.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblLabel_10.Location = new System.Drawing.Point(23, 78);
            this._lblLabel_10.Name = "_lblLabel_10";
            this._lblLabel_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblLabel_10.Size = new System.Drawing.Size(234, 16);
            this._lblLabel_10.TabIndex = 100;
            this._lblLabel_10.Text = "    6          7           8          9         10";
            // 
            // lblLabel9
            // 
            this.lblLabel9.BackColor = System.Drawing.SystemColors.Control;
            this.lblLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLabel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabel9.Location = new System.Drawing.Point(22, 22);
            this.lblLabel9.Name = "lblLabel9";
            this.lblLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLabel9.Size = new System.Drawing.Size(234, 16);
            this.lblLabel9.TabIndex = 99;
            this.lblLabel9.Text = "    1          2           3          4          5";
            // 
            // cmbDoorState
            // 
            this.cmbDoorState.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDoorState.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbDoorState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoorState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoorState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbDoorState.Items.AddRange(new object[] {
            "Reset",
            "Open",
            "Close",
            "Open...Close"});
            this.cmbDoorState.Location = new System.Drawing.Point(12, 438);
            this.cmbDoorState.Name = "cmbDoorState";
            this.cmbDoorState.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDoorState.Size = new System.Drawing.Size(130, 27);
            this.cmbDoorState.TabIndex = 118;
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.SystemColors.Control;
            this.Frame2.Controls.Add(this.txtUserPassTime2);
            this.Frame2.Controls.Add(this.txtUserPassTime1);
            this.Frame2.Controls.Add(this.txtUserPassTime0);
            this.Frame2.Controls.Add(this.txtUserID);
            this.Frame2.Controls.Add(this.txtGroupID);
            this.Frame2.Controls.Add(this.cmdGetUserPasstime);
            this.Frame2.Controls.Add(this.cmdSetUserPassTime);
            this.Frame2.Controls.Add(this.lblLabel3);
            this.Frame2.Controls.Add(this.lblLabel2);
            this.Frame2.Controls.Add(this.lblLabel1);
            this.Frame2.Controls.Add(this.lblLabel0);
            this.Frame2.Controls.Add(this.lblUserID);
            this.Frame2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(414, 4);
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(330, 145);
            this.Frame2.TabIndex = 115;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "User Access";
            // 
            // txtUserPassTime2
            // 
            this.txtUserPassTime2.AcceptsReturn = true;
            this.txtUserPassTime2.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserPassTime2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPassTime2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassTime2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserPassTime2.Location = new System.Drawing.Point(272, 64);
            this.txtUserPassTime2.MaxLength = 0;
            this.txtUserPassTime2.Name = "txtUserPassTime2";
            this.txtUserPassTime2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserPassTime2.Size = new System.Drawing.Size(26, 28);
            this.txtUserPassTime2.TabIndex = 70;
            this.txtUserPassTime2.Text = "0";
            this.txtUserPassTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserPassTime1
            // 
            this.txtUserPassTime1.AcceptsReturn = true;
            this.txtUserPassTime1.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserPassTime1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPassTime1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassTime1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserPassTime1.Location = new System.Drawing.Point(203, 64);
            this.txtUserPassTime1.MaxLength = 0;
            this.txtUserPassTime1.Name = "txtUserPassTime1";
            this.txtUserPassTime1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserPassTime1.Size = new System.Drawing.Size(26, 28);
            this.txtUserPassTime1.TabIndex = 69;
            this.txtUserPassTime1.Text = "0";
            this.txtUserPassTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserPassTime0
            // 
            this.txtUserPassTime0.AcceptsReturn = true;
            this.txtUserPassTime0.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserPassTime0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPassTime0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassTime0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserPassTime0.Location = new System.Drawing.Point(136, 64);
            this.txtUserPassTime0.MaxLength = 0;
            this.txtUserPassTime0.Name = "txtUserPassTime0";
            this.txtUserPassTime0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserPassTime0.Size = new System.Drawing.Size(26, 28);
            this.txtUserPassTime0.TabIndex = 68;
            this.txtUserPassTime0.Text = "0";
            this.txtUserPassTime0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserID
            // 
            this.txtUserID.AcceptsReturn = true;
            this.txtUserID.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserID.Location = new System.Drawing.Point(128, 24);
            this.txtUserID.MaxLength = 0;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserID.Size = new System.Drawing.Size(58, 27);
            this.txtUserID.TabIndex = 67;
            this.txtUserID.Text = "1";
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupID
            // 
            this.txtGroupID.AcceptsReturn = true;
            this.txtGroupID.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupID.Location = new System.Drawing.Point(59, 64);
            this.txtGroupID.MaxLength = 0;
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupID.Size = new System.Drawing.Size(33, 28);
            this.txtGroupID.TabIndex = 66;
            this.txtGroupID.Text = "1";
            // 
            // cmdGetUserPasstime
            // 
            this.cmdGetUserPasstime.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetUserPasstime.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetUserPasstime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetUserPasstime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetUserPasstime.Location = new System.Drawing.Point(42, 104);
            this.cmdGetUserPasstime.Name = "cmdGetUserPasstime";
            this.cmdGetUserPasstime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetUserPasstime.Size = new System.Drawing.Size(120, 31);
            this.cmdGetUserPasstime.TabIndex = 65;
            this.cmdGetUserPasstime.Text = "Get User";
            this.cmdGetUserPasstime.UseVisualStyleBackColor = false;
            this.cmdGetUserPasstime.Click += new System.EventHandler(this.cmdGetUserPasstime_Click);
            // 
            // cmdSetUserPassTime
            // 
            this.cmdSetUserPassTime.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetUserPassTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetUserPassTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetUserPassTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetUserPassTime.Location = new System.Drawing.Point(178, 104);
            this.cmdSetUserPassTime.Name = "cmdSetUserPassTime";
            this.cmdSetUserPassTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetUserPassTime.Size = new System.Drawing.Size(120, 31);
            this.cmdSetUserPassTime.TabIndex = 64;
            this.cmdSetUserPassTime.Text = "Set User ";
            this.cmdSetUserPassTime.UseVisualStyleBackColor = false;
            this.cmdSetUserPassTime.Click += new System.EventHandler(this.cmdSetUserPassTime_Click);
            // 
            // lblLabel3
            // 
            this.lblLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.lblLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabel3.Location = new System.Drawing.Point(232, 67);
            this.lblLabel3.Name = "lblLabel3";
            this.lblLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLabel3.Size = new System.Drawing.Size(38, 24);
            this.lblLabel3.TabIndex = 91;
            this.lblLabel3.Text = "TZ3";
            this.lblLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLabel2
            // 
            this.lblLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.lblLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabel2.Location = new System.Drawing.Point(164, 67);
            this.lblLabel2.Name = "lblLabel2";
            this.lblLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLabel2.Size = new System.Drawing.Size(37, 24);
            this.lblLabel2.TabIndex = 90;
            this.lblLabel2.Text = "TZ2";
            this.lblLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLabel1
            // 
            this.lblLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.lblLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabel1.Location = new System.Drawing.Point(98, 67);
            this.lblLabel1.Name = "lblLabel1";
            this.lblLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLabel1.Size = new System.Drawing.Size(37, 24);
            this.lblLabel1.TabIndex = 89;
            this.lblLabel1.Text = "TZ1";
            this.lblLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLabel0
            // 
            this.lblLabel0.BackColor = System.Drawing.SystemColors.Control;
            this.lblLabel0.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLabel0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabel0.Location = new System.Drawing.Point(8, 59);
            this.lblLabel0.Name = "lblLabel0";
            this.lblLabel0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLabel0.Size = new System.Drawing.Size(48, 40);
            this.lblLabel0.TabIndex = 88;
            this.lblLabel0.Text = "Group (1~5)";
            // 
            // lblUserID
            // 
            this.lblUserID.BackColor = System.Drawing.SystemColors.Control;
            this.lblUserID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUserID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserID.Location = new System.Drawing.Point(56, 28);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserID.Size = new System.Drawing.Size(72, 25);
            this.lblUserID.TabIndex = 71;
            this.lblUserID.Text = "User ID";
            // 
            // cmdSetDoorState
            // 
            this.cmdSetDoorState.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetDoorState.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetDoorState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetDoorState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetDoorState.Location = new System.Drawing.Point(150, 434);
            this.cmdSetDoorState.Name = "cmdSetDoorState";
            this.cmdSetDoorState.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetDoorState.Size = new System.Drawing.Size(120, 33);
            this.cmdSetDoorState.TabIndex = 111;
            this.cmdSetDoorState.Text = "Set Door State";
            this.cmdSetDoorState.UseVisualStyleBackColor = false;
            this.cmdSetDoorState.Click += new System.EventHandler(this.cmdSetDoorState_Click);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.cmdWrite);
            this.Frame1.Controls.Add(this.cmdRead);
            this.Frame1.Controls.Add(this.txtPassTimeID);
            this.Frame1.Controls.Add(this.lblLabel8);
            this.Frame1.Controls.Add(this.lblWeek0);
            this.Frame1.Controls.Add(this.lblWeek6);
            this.Frame1.Controls.Add(this.lblWeek5);
            this.Frame1.Controls.Add(this.lblWeek4);
            this.Frame1.Controls.Add(this.lblWeek3);
            this.Frame1.Controls.Add(this.lblWeek2);
            this.Frame1.Controls.Add(this.lblWeek1);
            this.Frame1.Controls.Add(this.lblMidSep6);
            this.Frame1.Controls.Add(this.txtEndHour0);
            this.Frame1.Controls.Add(this.txtEndMinute0);
            this.Frame1.Controls.Add(this.txtStartMinute0);
            this.Frame1.Controls.Add(this.txtStartHour0);
            this.Frame1.Controls.Add(this.txtEndHour4);
            this.Frame1.Controls.Add(this.txtEndMinute4);
            this.Frame1.Controls.Add(this.txtEndMinute3);
            this.Frame1.Controls.Add(this.txtEndHour3);
            this.Frame1.Controls.Add(this.txtEndHour2);
            this.Frame1.Controls.Add(this.txtEndMinute2);
            this.Frame1.Controls.Add(this.txtEndMinute1);
            this.Frame1.Controls.Add(this.txtEndHour1);
            this.Frame1.Controls.Add(this.txtStartMinute4);
            this.Frame1.Controls.Add(this.txtStartHour4);
            this.Frame1.Controls.Add(this.txtStartHour3);
            this.Frame1.Controls.Add(this.txtStartMinute3);
            this.Frame1.Controls.Add(this.txtStartMinute2);
            this.Frame1.Controls.Add(this.txtStartHour2);
            this.Frame1.Controls.Add(this.txtStartHour1);
            this.Frame1.Controls.Add(this.txtStartMinute1);
            this.Frame1.Controls.Add(this.txtStartHour5);
            this.Frame1.Controls.Add(this.txtStartHour6);
            this.Frame1.Controls.Add(this.txtStartMinute5);
            this.Frame1.Controls.Add(this.txtStartMinute6);
            this.Frame1.Controls.Add(this.txtEndHour5);
            this.Frame1.Controls.Add(this.txtEndHour6);
            this.Frame1.Controls.Add(this.txtEndMinute5);
            this.Frame1.Controls.Add(this.txtEndMinute6);
            this.Frame1.Controls.Add(this.lblStartSep6);
            this.Frame1.Controls.Add(this.lblEndSep6);
            this.Frame1.Controls.Add(this.lblEndSep5);
            this.Frame1.Controls.Add(this.lblEndSep4);
            this.Frame1.Controls.Add(this.lblEndSep3);
            this.Frame1.Controls.Add(this.lblEndSep2);
            this.Frame1.Controls.Add(this.lblEndSep1);
            this.Frame1.Controls.Add(this.lblEndSep0);
            this.Frame1.Controls.Add(this.lblStartSep5);
            this.Frame1.Controls.Add(this.lblStartSep4);
            this.Frame1.Controls.Add(this.lblStartSep3);
            this.Frame1.Controls.Add(this.lblStartSep2);
            this.Frame1.Controls.Add(this.lblStartSep1);
            this.Frame1.Controls.Add(this.lblMidSep5);
            this.Frame1.Controls.Add(this.lblMidSep4);
            this.Frame1.Controls.Add(this.lblMidSep0);
            this.Frame1.Controls.Add(this.lblStartSep0);
            this.Frame1.Controls.Add(this.lblMidSep3);
            this.Frame1.Controls.Add(this.lblMidSep2);
            this.Frame1.Controls.Add(this.lblMidSep1);
            this.Frame1.Controls.Add(this.lblStartTime);
            this.Frame1.Controls.Add(this.lblEndTime);
            this.Frame1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(12, 68);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(390, 342);
            this.Frame1.TabIndex = 113;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "PassTime Info";
            // 
            // cmdWrite
            // 
            this.cmdWrite.BackColor = System.Drawing.SystemColors.Control;
            this.cmdWrite.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdWrite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWrite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdWrite.Location = new System.Drawing.Point(280, 299);
            this.cmdWrite.Name = "cmdWrite";
            this.cmdWrite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdWrite.Size = new System.Drawing.Size(75, 33);
            this.cmdWrite.TabIndex = 116;
            this.cmdWrite.Text = "Write";
            this.cmdWrite.UseVisualStyleBackColor = false;
            this.cmdWrite.Click += new System.EventHandler(this.cmdWrite_Click);
            // 
            // cmdRead
            // 
            this.cmdRead.BackColor = System.Drawing.SystemColors.Control;
            this.cmdRead.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdRead.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRead.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdRead.Location = new System.Drawing.Point(175, 299);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRead.Size = new System.Drawing.Size(83, 33);
            this.cmdRead.TabIndex = 115;
            this.cmdRead.Text = "Read";
            this.cmdRead.UseVisualStyleBackColor = false;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // txtPassTimeID
            // 
            this.txtPassTimeID.AcceptsReturn = true;
            this.txtPassTimeID.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassTimeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassTimeID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassTimeID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassTimeID.Location = new System.Drawing.Point(72, 299);
            this.txtPassTimeID.MaxLength = 0;
            this.txtPassTimeID.Name = "txtPassTimeID";
            this.txtPassTimeID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassTimeID.Size = new System.Drawing.Size(58, 27);
            this.txtPassTimeID.TabIndex = 113;
            this.txtPassTimeID.Text = "1";
            this.txtPassTimeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLabel8
            // 
            this.lblLabel8.BackColor = System.Drawing.SystemColors.Control;
            this.lblLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLabel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabel8.Location = new System.Drawing.Point(8, 291);
            this.lblLabel8.Name = "lblLabel8";
            this.lblLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLabel8.Size = new System.Drawing.Size(56, 40);
            this.lblLabel8.TabIndex = 114;
            this.lblLabel8.Text = "   TZ (1~50)";
            // 
            // lblWeek0
            // 
            this.lblWeek0.BackColor = System.Drawing.Color.Transparent;
            this.lblWeek0.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWeek0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeek0.Location = new System.Drawing.Point(34, 74);
            this.lblWeek0.Name = "lblWeek0";
            this.lblWeek0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWeek0.Size = new System.Drawing.Size(40, 20);
            this.lblWeek0.TabIndex = 112;
            this.lblWeek0.Text = "Sun";
            // 
            // lblWeek6
            // 
            this.lblWeek6.BackColor = System.Drawing.Color.Transparent;
            this.lblWeek6.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWeek6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeek6.Location = new System.Drawing.Point(34, 242);
            this.lblWeek6.Name = "lblWeek6";
            this.lblWeek6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWeek6.Size = new System.Drawing.Size(40, 20);
            this.lblWeek6.TabIndex = 111;
            this.lblWeek6.Text = "Sat";
            // 
            // lblWeek5
            // 
            this.lblWeek5.BackColor = System.Drawing.Color.Transparent;
            this.lblWeek5.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWeek5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeek5.Location = new System.Drawing.Point(34, 214);
            this.lblWeek5.Name = "lblWeek5";
            this.lblWeek5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWeek5.Size = new System.Drawing.Size(40, 20);
            this.lblWeek5.TabIndex = 110;
            this.lblWeek5.Text = "Fri";
            // 
            // lblWeek4
            // 
            this.lblWeek4.BackColor = System.Drawing.Color.Transparent;
            this.lblWeek4.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWeek4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeek4.Location = new System.Drawing.Point(34, 186);
            this.lblWeek4.Name = "lblWeek4";
            this.lblWeek4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWeek4.Size = new System.Drawing.Size(40, 20);
            this.lblWeek4.TabIndex = 109;
            this.lblWeek4.Text = "Thu";
            // 
            // lblWeek3
            // 
            this.lblWeek3.BackColor = System.Drawing.Color.Transparent;
            this.lblWeek3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWeek3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeek3.Location = new System.Drawing.Point(34, 158);
            this.lblWeek3.Name = "lblWeek3";
            this.lblWeek3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWeek3.Size = new System.Drawing.Size(40, 20);
            this.lblWeek3.TabIndex = 108;
            this.lblWeek3.Text = "Wen";
            // 
            // lblWeek2
            // 
            this.lblWeek2.BackColor = System.Drawing.Color.Transparent;
            this.lblWeek2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWeek2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeek2.Location = new System.Drawing.Point(34, 130);
            this.lblWeek2.Name = "lblWeek2";
            this.lblWeek2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWeek2.Size = new System.Drawing.Size(40, 20);
            this.lblWeek2.TabIndex = 107;
            this.lblWeek2.Text = "Tue";
            // 
            // lblWeek1
            // 
            this.lblWeek1.BackColor = System.Drawing.Color.Transparent;
            this.lblWeek1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWeek1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeek1.Location = new System.Drawing.Point(34, 102);
            this.lblWeek1.Name = "lblWeek1";
            this.lblWeek1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWeek1.Size = new System.Drawing.Size(40, 20);
            this.lblWeek1.TabIndex = 106;
            this.lblWeek1.Text = "Mon";
            // 
            // lblMidSep6
            // 
            this.lblMidSep6.AutoSize = true;
            this.lblMidSep6.BackColor = System.Drawing.Color.Transparent;
            this.lblMidSep6.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMidSep6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidSep6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMidSep6.Location = new System.Drawing.Point(200, 243);
            this.lblMidSep6.Name = "lblMidSep6";
            this.lblMidSep6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMidSep6.Size = new System.Drawing.Size(18, 19);
            this.lblMidSep6.TabIndex = 56;
            this.lblMidSep6.Text = "~";
            // 
            // txtEndHour0
            // 
            this.txtEndHour0.AcceptsReturn = true;
            this.txtEndHour0.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndHour0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndHour0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndHour0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndHour0.Location = new System.Drawing.Point(242, 74);
            this.txtEndHour0.MaxLength = 2;
            this.txtEndHour0.Name = "txtEndHour0";
            this.txtEndHour0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndHour0.Size = new System.Drawing.Size(42, 26);
            this.txtEndHour0.TabIndex = 28;
            this.txtEndHour0.Text = "0";
            this.txtEndHour0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndMinute0
            // 
            this.txtEndMinute0.AcceptsReturn = true;
            this.txtEndMinute0.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndMinute0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndMinute0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndMinute0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndMinute0.Location = new System.Drawing.Point(306, 74);
            this.txtEndMinute0.MaxLength = 2;
            this.txtEndMinute0.Name = "txtEndMinute0";
            this.txtEndMinute0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndMinute0.Size = new System.Drawing.Size(42, 26);
            this.txtEndMinute0.TabIndex = 27;
            this.txtEndMinute0.Text = "0";
            this.txtEndMinute0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartMinute0
            // 
            this.txtStartMinute0.AcceptsReturn = true;
            this.txtStartMinute0.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartMinute0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartMinute0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartMinute0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartMinute0.Location = new System.Drawing.Point(138, 74);
            this.txtStartMinute0.MaxLength = 2;
            this.txtStartMinute0.Name = "txtStartMinute0";
            this.txtStartMinute0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartMinute0.Size = new System.Drawing.Size(42, 26);
            this.txtStartMinute0.TabIndex = 26;
            this.txtStartMinute0.Text = "0";
            this.txtStartMinute0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartHour0
            // 
            this.txtStartHour0.AcceptsReturn = true;
            this.txtStartHour0.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartHour0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartHour0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartHour0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartHour0.Location = new System.Drawing.Point(74, 74);
            this.txtStartHour0.MaxLength = 2;
            this.txtStartHour0.Name = "txtStartHour0";
            this.txtStartHour0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartHour0.Size = new System.Drawing.Size(42, 26);
            this.txtStartHour0.TabIndex = 25;
            this.txtStartHour0.Text = "0";
            this.txtStartHour0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndHour4
            // 
            this.txtEndHour4.AcceptsReturn = true;
            this.txtEndHour4.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndHour4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndHour4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndHour4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndHour4.Location = new System.Drawing.Point(242, 186);
            this.txtEndHour4.MaxLength = 2;
            this.txtEndHour4.Name = "txtEndHour4";
            this.txtEndHour4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndHour4.Size = new System.Drawing.Size(42, 26);
            this.txtEndHour4.TabIndex = 24;
            this.txtEndHour4.Text = "0";
            this.txtEndHour4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndMinute4
            // 
            this.txtEndMinute4.AcceptsReturn = true;
            this.txtEndMinute4.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndMinute4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndMinute4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndMinute4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndMinute4.Location = new System.Drawing.Point(306, 186);
            this.txtEndMinute4.MaxLength = 2;
            this.txtEndMinute4.Name = "txtEndMinute4";
            this.txtEndMinute4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndMinute4.Size = new System.Drawing.Size(42, 26);
            this.txtEndMinute4.TabIndex = 23;
            this.txtEndMinute4.Text = "0";
            this.txtEndMinute4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndMinute3
            // 
            this.txtEndMinute3.AcceptsReturn = true;
            this.txtEndMinute3.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndMinute3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndMinute3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndMinute3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndMinute3.Location = new System.Drawing.Point(306, 158);
            this.txtEndMinute3.MaxLength = 2;
            this.txtEndMinute3.Name = "txtEndMinute3";
            this.txtEndMinute3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndMinute3.Size = new System.Drawing.Size(42, 26);
            this.txtEndMinute3.TabIndex = 22;
            this.txtEndMinute3.Text = "0";
            this.txtEndMinute3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndHour3
            // 
            this.txtEndHour3.AcceptsReturn = true;
            this.txtEndHour3.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndHour3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndHour3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndHour3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndHour3.Location = new System.Drawing.Point(242, 158);
            this.txtEndHour3.MaxLength = 2;
            this.txtEndHour3.Name = "txtEndHour3";
            this.txtEndHour3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndHour3.Size = new System.Drawing.Size(42, 26);
            this.txtEndHour3.TabIndex = 21;
            this.txtEndHour3.Text = "0";
            this.txtEndHour3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndHour2
            // 
            this.txtEndHour2.AcceptsReturn = true;
            this.txtEndHour2.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndHour2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndHour2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndHour2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndHour2.Location = new System.Drawing.Point(242, 130);
            this.txtEndHour2.MaxLength = 2;
            this.txtEndHour2.Name = "txtEndHour2";
            this.txtEndHour2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndHour2.Size = new System.Drawing.Size(42, 26);
            this.txtEndHour2.TabIndex = 20;
            this.txtEndHour2.Text = "0";
            this.txtEndHour2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndMinute2
            // 
            this.txtEndMinute2.AcceptsReturn = true;
            this.txtEndMinute2.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndMinute2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndMinute2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndMinute2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndMinute2.Location = new System.Drawing.Point(306, 130);
            this.txtEndMinute2.MaxLength = 2;
            this.txtEndMinute2.Name = "txtEndMinute2";
            this.txtEndMinute2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndMinute2.Size = new System.Drawing.Size(42, 26);
            this.txtEndMinute2.TabIndex = 19;
            this.txtEndMinute2.Text = "0";
            this.txtEndMinute2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndMinute1
            // 
            this.txtEndMinute1.AcceptsReturn = true;
            this.txtEndMinute1.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndMinute1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndMinute1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndMinute1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndMinute1.Location = new System.Drawing.Point(306, 102);
            this.txtEndMinute1.MaxLength = 2;
            this.txtEndMinute1.Name = "txtEndMinute1";
            this.txtEndMinute1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndMinute1.Size = new System.Drawing.Size(42, 26);
            this.txtEndMinute1.TabIndex = 18;
            this.txtEndMinute1.Text = "0";
            this.txtEndMinute1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndHour1
            // 
            this.txtEndHour1.AcceptsReturn = true;
            this.txtEndHour1.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndHour1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndHour1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndHour1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndHour1.Location = new System.Drawing.Point(242, 102);
            this.txtEndHour1.MaxLength = 2;
            this.txtEndHour1.Name = "txtEndHour1";
            this.txtEndHour1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndHour1.Size = new System.Drawing.Size(42, 26);
            this.txtEndHour1.TabIndex = 17;
            this.txtEndHour1.Text = "0";
            this.txtEndHour1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartMinute4
            // 
            this.txtStartMinute4.AcceptsReturn = true;
            this.txtStartMinute4.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartMinute4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartMinute4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartMinute4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartMinute4.Location = new System.Drawing.Point(138, 186);
            this.txtStartMinute4.MaxLength = 2;
            this.txtStartMinute4.Name = "txtStartMinute4";
            this.txtStartMinute4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartMinute4.Size = new System.Drawing.Size(42, 26);
            this.txtStartMinute4.TabIndex = 16;
            this.txtStartMinute4.Text = "0";
            this.txtStartMinute4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartHour4
            // 
            this.txtStartHour4.AcceptsReturn = true;
            this.txtStartHour4.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartHour4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartHour4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartHour4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartHour4.Location = new System.Drawing.Point(74, 186);
            this.txtStartHour4.MaxLength = 2;
            this.txtStartHour4.Name = "txtStartHour4";
            this.txtStartHour4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartHour4.Size = new System.Drawing.Size(42, 26);
            this.txtStartHour4.TabIndex = 15;
            this.txtStartHour4.Text = "0";
            this.txtStartHour4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartHour3
            // 
            this.txtStartHour3.AcceptsReturn = true;
            this.txtStartHour3.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartHour3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartHour3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartHour3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartHour3.Location = new System.Drawing.Point(74, 158);
            this.txtStartHour3.MaxLength = 2;
            this.txtStartHour3.Name = "txtStartHour3";
            this.txtStartHour3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartHour3.Size = new System.Drawing.Size(42, 26);
            this.txtStartHour3.TabIndex = 14;
            this.txtStartHour3.Text = "0";
            this.txtStartHour3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartMinute3
            // 
            this.txtStartMinute3.AcceptsReturn = true;
            this.txtStartMinute3.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartMinute3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartMinute3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartMinute3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartMinute3.Location = new System.Drawing.Point(138, 158);
            this.txtStartMinute3.MaxLength = 2;
            this.txtStartMinute3.Name = "txtStartMinute3";
            this.txtStartMinute3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartMinute3.Size = new System.Drawing.Size(42, 26);
            this.txtStartMinute3.TabIndex = 13;
            this.txtStartMinute3.Text = "0";
            this.txtStartMinute3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartMinute2
            // 
            this.txtStartMinute2.AcceptsReturn = true;
            this.txtStartMinute2.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartMinute2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartMinute2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartMinute2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartMinute2.Location = new System.Drawing.Point(138, 130);
            this.txtStartMinute2.MaxLength = 2;
            this.txtStartMinute2.Name = "txtStartMinute2";
            this.txtStartMinute2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartMinute2.Size = new System.Drawing.Size(42, 26);
            this.txtStartMinute2.TabIndex = 12;
            this.txtStartMinute2.Text = "0";
            this.txtStartMinute2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartHour2
            // 
            this.txtStartHour2.AcceptsReturn = true;
            this.txtStartHour2.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartHour2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartHour2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartHour2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartHour2.Location = new System.Drawing.Point(74, 130);
            this.txtStartHour2.MaxLength = 2;
            this.txtStartHour2.Name = "txtStartHour2";
            this.txtStartHour2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartHour2.Size = new System.Drawing.Size(42, 26);
            this.txtStartHour2.TabIndex = 11;
            this.txtStartHour2.Text = "0";
            this.txtStartHour2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartHour1
            // 
            this.txtStartHour1.AcceptsReturn = true;
            this.txtStartHour1.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartHour1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartHour1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartHour1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartHour1.Location = new System.Drawing.Point(74, 102);
            this.txtStartHour1.MaxLength = 2;
            this.txtStartHour1.Name = "txtStartHour1";
            this.txtStartHour1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartHour1.Size = new System.Drawing.Size(42, 26);
            this.txtStartHour1.TabIndex = 10;
            this.txtStartHour1.Text = "0";
            this.txtStartHour1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartMinute1
            // 
            this.txtStartMinute1.AcceptsReturn = true;
            this.txtStartMinute1.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartMinute1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartMinute1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartMinute1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartMinute1.Location = new System.Drawing.Point(138, 102);
            this.txtStartMinute1.MaxLength = 2;
            this.txtStartMinute1.Name = "txtStartMinute1";
            this.txtStartMinute1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartMinute1.Size = new System.Drawing.Size(42, 26);
            this.txtStartMinute1.TabIndex = 9;
            this.txtStartMinute1.Text = "0";
            this.txtStartMinute1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartHour5
            // 
            this.txtStartHour5.AcceptsReturn = true;
            this.txtStartHour5.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartHour5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartHour5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartHour5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartHour5.Location = new System.Drawing.Point(74, 214);
            this.txtStartHour5.MaxLength = 2;
            this.txtStartHour5.Name = "txtStartHour5";
            this.txtStartHour5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartHour5.Size = new System.Drawing.Size(42, 26);
            this.txtStartHour5.TabIndex = 8;
            this.txtStartHour5.Text = "0";
            this.txtStartHour5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartHour6
            // 
            this.txtStartHour6.AcceptsReturn = true;
            this.txtStartHour6.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartHour6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartHour6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartHour6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartHour6.Location = new System.Drawing.Point(74, 242);
            this.txtStartHour6.MaxLength = 2;
            this.txtStartHour6.Name = "txtStartHour6";
            this.txtStartHour6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartHour6.Size = new System.Drawing.Size(42, 26);
            this.txtStartHour6.TabIndex = 7;
            this.txtStartHour6.Text = "0";
            this.txtStartHour6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartMinute5
            // 
            this.txtStartMinute5.AcceptsReturn = true;
            this.txtStartMinute5.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartMinute5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartMinute5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartMinute5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartMinute5.Location = new System.Drawing.Point(138, 214);
            this.txtStartMinute5.MaxLength = 2;
            this.txtStartMinute5.Name = "txtStartMinute5";
            this.txtStartMinute5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartMinute5.Size = new System.Drawing.Size(42, 26);
            this.txtStartMinute5.TabIndex = 6;
            this.txtStartMinute5.Text = "0";
            this.txtStartMinute5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartMinute6
            // 
            this.txtStartMinute6.AcceptsReturn = true;
            this.txtStartMinute6.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartMinute6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartMinute6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartMinute6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartMinute6.Location = new System.Drawing.Point(138, 242);
            this.txtStartMinute6.MaxLength = 2;
            this.txtStartMinute6.Name = "txtStartMinute6";
            this.txtStartMinute6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartMinute6.Size = new System.Drawing.Size(42, 26);
            this.txtStartMinute6.TabIndex = 5;
            this.txtStartMinute6.Text = "0";
            this.txtStartMinute6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndHour5
            // 
            this.txtEndHour5.AcceptsReturn = true;
            this.txtEndHour5.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndHour5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndHour5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndHour5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndHour5.Location = new System.Drawing.Point(242, 214);
            this.txtEndHour5.MaxLength = 2;
            this.txtEndHour5.Name = "txtEndHour5";
            this.txtEndHour5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndHour5.Size = new System.Drawing.Size(42, 26);
            this.txtEndHour5.TabIndex = 4;
            this.txtEndHour5.Text = "0";
            this.txtEndHour5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndHour6
            // 
            this.txtEndHour6.AcceptsReturn = true;
            this.txtEndHour6.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndHour6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndHour6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndHour6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndHour6.Location = new System.Drawing.Point(242, 242);
            this.txtEndHour6.MaxLength = 2;
            this.txtEndHour6.Name = "txtEndHour6";
            this.txtEndHour6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndHour6.Size = new System.Drawing.Size(42, 26);
            this.txtEndHour6.TabIndex = 3;
            this.txtEndHour6.Text = "0";
            this.txtEndHour6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndMinute5
            // 
            this.txtEndMinute5.AcceptsReturn = true;
            this.txtEndMinute5.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndMinute5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndMinute5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndMinute5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndMinute5.Location = new System.Drawing.Point(306, 214);
            this.txtEndMinute5.MaxLength = 2;
            this.txtEndMinute5.Name = "txtEndMinute5";
            this.txtEndMinute5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndMinute5.Size = new System.Drawing.Size(42, 26);
            this.txtEndMinute5.TabIndex = 2;
            this.txtEndMinute5.Text = "0";
            this.txtEndMinute5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndMinute6
            // 
            this.txtEndMinute6.AcceptsReturn = true;
            this.txtEndMinute6.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndMinute6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndMinute6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndMinute6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndMinute6.Location = new System.Drawing.Point(306, 242);
            this.txtEndMinute6.MaxLength = 2;
            this.txtEndMinute6.Name = "txtEndMinute6";
            this.txtEndMinute6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndMinute6.Size = new System.Drawing.Size(42, 26);
            this.txtEndMinute6.TabIndex = 1;
            this.txtEndMinute6.Text = "0";
            this.txtEndMinute6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStartSep6
            // 
            this.lblStartSep6.AutoSize = true;
            this.lblStartSep6.BackColor = System.Drawing.Color.Transparent;
            this.lblStartSep6.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartSep6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartSep6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartSep6.Location = new System.Drawing.Point(122, 246);
            this.lblStartSep6.Name = "lblStartSep6";
            this.lblStartSep6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStartSep6.Size = new System.Drawing.Size(12, 19);
            this.lblStartSep6.TabIndex = 55;
            this.lblStartSep6.Text = ":";
            // 
            // lblEndSep6
            // 
            this.lblEndSep6.AutoSize = true;
            this.lblEndSep6.BackColor = System.Drawing.Color.Transparent;
            this.lblEndSep6.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndSep6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndSep6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndSep6.Location = new System.Drawing.Point(290, 246);
            this.lblEndSep6.Name = "lblEndSep6";
            this.lblEndSep6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEndSep6.Size = new System.Drawing.Size(12, 19);
            this.lblEndSep6.TabIndex = 54;
            this.lblEndSep6.Text = ":";
            // 
            // lblEndSep5
            // 
            this.lblEndSep5.AutoSize = true;
            this.lblEndSep5.BackColor = System.Drawing.Color.Transparent;
            this.lblEndSep5.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndSep5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndSep5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndSep5.Location = new System.Drawing.Point(290, 218);
            this.lblEndSep5.Name = "lblEndSep5";
            this.lblEndSep5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEndSep5.Size = new System.Drawing.Size(12, 19);
            this.lblEndSep5.TabIndex = 53;
            this.lblEndSep5.Text = ":";
            // 
            // lblEndSep4
            // 
            this.lblEndSep4.AutoSize = true;
            this.lblEndSep4.BackColor = System.Drawing.Color.Transparent;
            this.lblEndSep4.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndSep4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndSep4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndSep4.Location = new System.Drawing.Point(290, 190);
            this.lblEndSep4.Name = "lblEndSep4";
            this.lblEndSep4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEndSep4.Size = new System.Drawing.Size(12, 19);
            this.lblEndSep4.TabIndex = 52;
            this.lblEndSep4.Text = ":";
            // 
            // lblEndSep3
            // 
            this.lblEndSep3.AutoSize = true;
            this.lblEndSep3.BackColor = System.Drawing.Color.Transparent;
            this.lblEndSep3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndSep3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndSep3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndSep3.Location = new System.Drawing.Point(290, 162);
            this.lblEndSep3.Name = "lblEndSep3";
            this.lblEndSep3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEndSep3.Size = new System.Drawing.Size(12, 19);
            this.lblEndSep3.TabIndex = 51;
            this.lblEndSep3.Text = ":";
            // 
            // lblEndSep2
            // 
            this.lblEndSep2.AutoSize = true;
            this.lblEndSep2.BackColor = System.Drawing.Color.Transparent;
            this.lblEndSep2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndSep2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndSep2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndSep2.Location = new System.Drawing.Point(290, 134);
            this.lblEndSep2.Name = "lblEndSep2";
            this.lblEndSep2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEndSep2.Size = new System.Drawing.Size(12, 19);
            this.lblEndSep2.TabIndex = 50;
            this.lblEndSep2.Text = ":";
            // 
            // lblEndSep1
            // 
            this.lblEndSep1.AutoSize = true;
            this.lblEndSep1.BackColor = System.Drawing.Color.Transparent;
            this.lblEndSep1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndSep1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndSep1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndSep1.Location = new System.Drawing.Point(290, 106);
            this.lblEndSep1.Name = "lblEndSep1";
            this.lblEndSep1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEndSep1.Size = new System.Drawing.Size(12, 19);
            this.lblEndSep1.TabIndex = 49;
            this.lblEndSep1.Text = ":";
            // 
            // lblEndSep0
            // 
            this.lblEndSep0.AutoSize = true;
            this.lblEndSep0.BackColor = System.Drawing.Color.Transparent;
            this.lblEndSep0.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndSep0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndSep0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndSep0.Location = new System.Drawing.Point(290, 78);
            this.lblEndSep0.Name = "lblEndSep0";
            this.lblEndSep0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEndSep0.Size = new System.Drawing.Size(12, 19);
            this.lblEndSep0.TabIndex = 48;
            this.lblEndSep0.Text = ":";
            // 
            // lblStartSep5
            // 
            this.lblStartSep5.AutoSize = true;
            this.lblStartSep5.BackColor = System.Drawing.Color.Transparent;
            this.lblStartSep5.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartSep5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartSep5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartSep5.Location = new System.Drawing.Point(122, 218);
            this.lblStartSep5.Name = "lblStartSep5";
            this.lblStartSep5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStartSep5.Size = new System.Drawing.Size(12, 19);
            this.lblStartSep5.TabIndex = 47;
            this.lblStartSep5.Text = ":";
            // 
            // lblStartSep4
            // 
            this.lblStartSep4.AutoSize = true;
            this.lblStartSep4.BackColor = System.Drawing.Color.Transparent;
            this.lblStartSep4.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartSep4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartSep4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartSep4.Location = new System.Drawing.Point(122, 190);
            this.lblStartSep4.Name = "lblStartSep4";
            this.lblStartSep4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStartSep4.Size = new System.Drawing.Size(12, 19);
            this.lblStartSep4.TabIndex = 46;
            this.lblStartSep4.Text = ":";
            // 
            // lblStartSep3
            // 
            this.lblStartSep3.AutoSize = true;
            this.lblStartSep3.BackColor = System.Drawing.Color.Transparent;
            this.lblStartSep3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartSep3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartSep3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartSep3.Location = new System.Drawing.Point(122, 162);
            this.lblStartSep3.Name = "lblStartSep3";
            this.lblStartSep3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStartSep3.Size = new System.Drawing.Size(12, 19);
            this.lblStartSep3.TabIndex = 45;
            this.lblStartSep3.Text = ":";
            // 
            // lblStartSep2
            // 
            this.lblStartSep2.AutoSize = true;
            this.lblStartSep2.BackColor = System.Drawing.Color.Transparent;
            this.lblStartSep2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartSep2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartSep2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartSep2.Location = new System.Drawing.Point(122, 134);
            this.lblStartSep2.Name = "lblStartSep2";
            this.lblStartSep2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStartSep2.Size = new System.Drawing.Size(12, 19);
            this.lblStartSep2.TabIndex = 44;
            this.lblStartSep2.Text = ":";
            // 
            // lblStartSep1
            // 
            this.lblStartSep1.AutoSize = true;
            this.lblStartSep1.BackColor = System.Drawing.Color.Transparent;
            this.lblStartSep1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartSep1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartSep1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartSep1.Location = new System.Drawing.Point(122, 106);
            this.lblStartSep1.Name = "lblStartSep1";
            this.lblStartSep1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStartSep1.Size = new System.Drawing.Size(12, 19);
            this.lblStartSep1.TabIndex = 43;
            this.lblStartSep1.Text = ":";
            // 
            // lblMidSep5
            // 
            this.lblMidSep5.AutoSize = true;
            this.lblMidSep5.BackColor = System.Drawing.Color.Transparent;
            this.lblMidSep5.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMidSep5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidSep5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMidSep5.Location = new System.Drawing.Point(200, 215);
            this.lblMidSep5.Name = "lblMidSep5";
            this.lblMidSep5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMidSep5.Size = new System.Drawing.Size(18, 19);
            this.lblMidSep5.TabIndex = 42;
            this.lblMidSep5.Text = "~";
            // 
            // lblMidSep4
            // 
            this.lblMidSep4.AutoSize = true;
            this.lblMidSep4.BackColor = System.Drawing.Color.Transparent;
            this.lblMidSep4.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMidSep4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidSep4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMidSep4.Location = new System.Drawing.Point(200, 187);
            this.lblMidSep4.Name = "lblMidSep4";
            this.lblMidSep4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMidSep4.Size = new System.Drawing.Size(18, 19);
            this.lblMidSep4.TabIndex = 41;
            this.lblMidSep4.Text = "~";
            // 
            // lblMidSep0
            // 
            this.lblMidSep0.AutoSize = true;
            this.lblMidSep0.BackColor = System.Drawing.Color.Transparent;
            this.lblMidSep0.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMidSep0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidSep0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMidSep0.Location = new System.Drawing.Point(200, 75);
            this.lblMidSep0.Name = "lblMidSep0";
            this.lblMidSep0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMidSep0.Size = new System.Drawing.Size(18, 19);
            this.lblMidSep0.TabIndex = 36;
            this.lblMidSep0.Text = "~";
            // 
            // lblStartSep0
            // 
            this.lblStartSep0.AutoSize = true;
            this.lblStartSep0.BackColor = System.Drawing.Color.Transparent;
            this.lblStartSep0.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartSep0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartSep0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartSep0.Location = new System.Drawing.Point(122, 78);
            this.lblStartSep0.Name = "lblStartSep0";
            this.lblStartSep0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStartSep0.Size = new System.Drawing.Size(12, 19);
            this.lblStartSep0.TabIndex = 35;
            this.lblStartSep0.Text = ":";
            // 
            // lblMidSep3
            // 
            this.lblMidSep3.AutoSize = true;
            this.lblMidSep3.BackColor = System.Drawing.Color.Transparent;
            this.lblMidSep3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMidSep3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidSep3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMidSep3.Location = new System.Drawing.Point(200, 159);
            this.lblMidSep3.Name = "lblMidSep3";
            this.lblMidSep3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMidSep3.Size = new System.Drawing.Size(18, 19);
            this.lblMidSep3.TabIndex = 34;
            this.lblMidSep3.Text = "~";
            // 
            // lblMidSep2
            // 
            this.lblMidSep2.AutoSize = true;
            this.lblMidSep2.BackColor = System.Drawing.Color.Transparent;
            this.lblMidSep2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMidSep2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidSep2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMidSep2.Location = new System.Drawing.Point(200, 131);
            this.lblMidSep2.Name = "lblMidSep2";
            this.lblMidSep2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMidSep2.Size = new System.Drawing.Size(18, 19);
            this.lblMidSep2.TabIndex = 32;
            this.lblMidSep2.Text = "~";
            // 
            // lblMidSep1
            // 
            this.lblMidSep1.AutoSize = true;
            this.lblMidSep1.BackColor = System.Drawing.Color.Transparent;
            this.lblMidSep1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMidSep1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidSep1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMidSep1.Location = new System.Drawing.Point(200, 103);
            this.lblMidSep1.Name = "lblMidSep1";
            this.lblMidSep1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMidSep1.Size = new System.Drawing.Size(18, 19);
            this.lblMidSep1.TabIndex = 31;
            this.lblMidSep1.Text = "~";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.BackColor = System.Drawing.Color.Transparent;
            this.lblStartTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartTime.Location = new System.Drawing.Point(90, 50);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStartTime.Size = new System.Drawing.Size(72, 19);
            this.lblStartTime.TabIndex = 30;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.BackColor = System.Drawing.Color.Transparent;
            this.lblEndTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndTime.Location = new System.Drawing.Point(258, 50);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEndTime.Size = new System.Drawing.Size(67, 19);
            this.lblEndTime.TabIndex = 29;
            this.lblEndTime.Text = "End Time";
            // 
            // cmdGetDoorState
            // 
            this.cmdGetDoorState.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetDoorState.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetDoorState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetDoorState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetDoorState.Location = new System.Drawing.Point(282, 433);
            this.cmdGetDoorState.Name = "cmdGetDoorState";
            this.cmdGetDoorState.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetDoorState.Size = new System.Drawing.Size(120, 33);
            this.cmdGetDoorState.TabIndex = 112;
            this.cmdGetDoorState.Text = "Get Door State";
            this.cmdGetDoorState.UseVisualStyleBackColor = false;
            this.cmdGetDoorState.Click += new System.EventHandler(this.cmdGetDoorState_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(390, 28);
            this.lblMessage.TabIndex = 114;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frame3
            // 
            this.Frame3.BackColor = System.Drawing.SystemColors.Control;
            this.Frame3.Controls.Add(this.txtGroupNum);
            this.Frame3.Controls.Add(this.txtGroupPassTime2);
            this.Frame3.Controls.Add(this.txtGroupPassTime1);
            this.Frame3.Controls.Add(this.txtGroupPassTime0);
            this.Frame3.Controls.Add(this.cmdGetGroupPassTime);
            this.Frame3.Controls.Add(this.cmdSetGroupPassTime);
            this.Frame3.Controls.Add(this._lblLabel_7);
            this.Frame3.Controls.Add(this.lblLabel6);
            this.Frame3.Controls.Add(this.lblLabel5);
            this.Frame3.Controls.Add(this.lblLabel4);
            this.Frame3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame3.Location = new System.Drawing.Point(414, 154);
            this.Frame3.Name = "Frame3";
            this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame3.Size = new System.Drawing.Size(330, 146);
            this.Frame3.TabIndex = 116;
            this.Frame3.TabStop = false;
            this.Frame3.Text = "Group Access";
            // 
            // txtGroupNum
            // 
            this.txtGroupNum.AcceptsReturn = true;
            this.txtGroupNum.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupNum.Location = new System.Drawing.Point(141, 24);
            this.txtGroupNum.MaxLength = 0;
            this.txtGroupNum.Name = "txtGroupNum";
            this.txtGroupNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupNum.Size = new System.Drawing.Size(34, 27);
            this.txtGroupNum.TabIndex = 98;
            this.txtGroupNum.Text = "1";
            this.txtGroupNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupPassTime2
            // 
            this.txtGroupPassTime2.AcceptsReturn = true;
            this.txtGroupPassTime2.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupPassTime2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupPassTime2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupPassTime2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupPassTime2.Location = new System.Drawing.Point(233, 63);
            this.txtGroupPassTime2.MaxLength = 0;
            this.txtGroupPassTime2.Name = "txtGroupPassTime2";
            this.txtGroupPassTime2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupPassTime2.Size = new System.Drawing.Size(26, 28);
            this.txtGroupPassTime2.TabIndex = 94;
            this.txtGroupPassTime2.Text = "0";
            this.txtGroupPassTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupPassTime1
            // 
            this.txtGroupPassTime1.AcceptsReturn = true;
            this.txtGroupPassTime1.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupPassTime1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupPassTime1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupPassTime1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupPassTime1.Location = new System.Drawing.Point(149, 64);
            this.txtGroupPassTime1.MaxLength = 0;
            this.txtGroupPassTime1.Name = "txtGroupPassTime1";
            this.txtGroupPassTime1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupPassTime1.Size = new System.Drawing.Size(26, 28);
            this.txtGroupPassTime1.TabIndex = 93;
            this.txtGroupPassTime1.Text = "0";
            this.txtGroupPassTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupPassTime0
            // 
            this.txtGroupPassTime0.AcceptsReturn = true;
            this.txtGroupPassTime0.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupPassTime0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupPassTime0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupPassTime0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupPassTime0.Location = new System.Drawing.Point(60, 64);
            this.txtGroupPassTime0.MaxLength = 0;
            this.txtGroupPassTime0.Name = "txtGroupPassTime0";
            this.txtGroupPassTime0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupPassTime0.Size = new System.Drawing.Size(26, 28);
            this.txtGroupPassTime0.TabIndex = 92;
            this.txtGroupPassTime0.Text = "0";
            this.txtGroupPassTime0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdGetGroupPassTime
            // 
            this.cmdGetGroupPassTime.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetGroupPassTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetGroupPassTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetGroupPassTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetGroupPassTime.Location = new System.Drawing.Point(42, 104);
            this.cmdGetGroupPassTime.Name = "cmdGetGroupPassTime";
            this.cmdGetGroupPassTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetGroupPassTime.Size = new System.Drawing.Size(120, 31);
            this.cmdGetGroupPassTime.TabIndex = 74;
            this.cmdGetGroupPassTime.Text = "Get Group";
            this.cmdGetGroupPassTime.UseVisualStyleBackColor = false;
            this.cmdGetGroupPassTime.Click += new System.EventHandler(this.cmdGetGroupPassTime_Click);
            // 
            // cmdSetGroupPassTime
            // 
            this.cmdSetGroupPassTime.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetGroupPassTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetGroupPassTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetGroupPassTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetGroupPassTime.Location = new System.Drawing.Point(178, 104);
            this.cmdSetGroupPassTime.Name = "cmdSetGroupPassTime";
            this.cmdSetGroupPassTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetGroupPassTime.Size = new System.Drawing.Size(120, 31);
            this.cmdSetGroupPassTime.TabIndex = 73;
            this.cmdSetGroupPassTime.Text = "Set Group";
            this.cmdSetGroupPassTime.UseVisualStyleBackColor = false;
            this.cmdSetGroupPassTime.Click += new System.EventHandler(this.cmdSetGroupPassTime_Click);
            // 
            // _lblLabel_7
            // 
            this._lblLabel_7.BackColor = System.Drawing.SystemColors.Control;
            this._lblLabel_7.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblLabel_7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLabel_7.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblLabel_7.Location = new System.Drawing.Point(80, 16);
            this._lblLabel_7.Name = "_lblLabel_7";
            this._lblLabel_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblLabel_7.Size = new System.Drawing.Size(56, 40);
            this._lblLabel_7.TabIndex = 104;
            this._lblLabel_7.Text = "Group (1~5)";
            // 
            // lblLabel6
            // 
            this.lblLabel6.BackColor = System.Drawing.SystemColors.Control;
            this.lblLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabel6.Location = new System.Drawing.Point(191, 67);
            this.lblLabel6.Name = "lblLabel6";
            this.lblLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLabel6.Size = new System.Drawing.Size(41, 24);
            this.lblLabel6.TabIndex = 97;
            this.lblLabel6.Text = "TZ3";
            this.lblLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLabel5
            // 
            this.lblLabel5.BackColor = System.Drawing.SystemColors.Control;
            this.lblLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabel5.Location = new System.Drawing.Point(106, 67);
            this.lblLabel5.Name = "lblLabel5";
            this.lblLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLabel5.Size = new System.Drawing.Size(42, 24);
            this.lblLabel5.TabIndex = 96;
            this.lblLabel5.Text = "TZ2";
            this.lblLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLabel4
            // 
            this.lblLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.lblLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabel4.Location = new System.Drawing.Point(16, 67);
            this.lblLabel4.Name = "lblLabel4";
            this.lblLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLabel4.Size = new System.Drawing.Size(42, 24);
            this.lblLabel4.TabIndex = 95;
            this.lblLabel4.Text = "TZ1";
            this.lblLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmPasstimeInfo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(756, 489);
            this.Controls.Add(this.Frame4);
            this.Controls.Add(this.cmbDoorState);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.cmdSetDoorState);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.cmdGetDoorState);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.Frame3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPasstimeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pass Time Info";
            this.Load += new System.EventHandler(this.frmPasstimeInfo_Load);
            this.Frame4.ResumeLayout(false);
            this.Frame2.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.Frame3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
		
        private PASSCTRLTIME mPassTimeInfo;
		private USERPASSINFO mUserPassInfo;
		private GROUPPASSINFO mGroupPassInfo;
		private GROUPMATCHINFO mGroupMatchInfo;

		private TextBox[] mtxtStartHour = new TextBox [FKAttendDLL.MAX_PASSCTRL_COUNT];
		private TextBox[] mtxtStartMinute = new TextBox [FKAttendDLL.MAX_PASSCTRL_COUNT];
		private TextBox[] mtxtEndHour = new TextBox [FKAttendDLL.MAX_PASSCTRL_COUNT];
		private TextBox[] mtxtEndMinute = new TextBox [FKAttendDLL.MAX_PASSCTRL_COUNT];
	
		private TextBox[] mtxtUserPassTime = new TextBox [FKAttendDLL.MAX_USERPASSINFO_COUNT];
		private TextBox[] mtxtGroupPassTime = new TextBox [FKAttendDLL.MAX_GROUPPASSINFO_COUNT];
		private TextBox[] mtxtGroupMatch = new TextBox [FKAttendDLL.MAX_GROUPMATCHINFO_COUNT];

		int[] vValue = new int[28];

        private void frmPasstimeInfo_Load(object sender, System.EventArgs e)
        {
            int vnii;
            int vnLen;
            string vstrItem;
            string vstrName;

            mPassTimeInfo.PassCtrlTime = new PASSTIME[FKAttendDLL.MAX_PASSCTRL_COUNT];

            for (vnii = 0; vnii < FKAttendDLL.MAX_PASSCTRL_COUNT; vnii++)
            {
                mPassTimeInfo.PassCtrlTime[vnii].StartHour = 0;
                mPassTimeInfo.PassCtrlTime[vnii].StartMinute = 0;
                mPassTimeInfo.PassCtrlTime[vnii].EndHour = 0;
                mPassTimeInfo.PassCtrlTime[vnii].EndMinute = 0;
            }
            
            mUserPassInfo.UserPassID = new byte[FKAttendDLL.MAX_USERPASSINFO_COUNT];
            mGroupPassInfo.GroupPassID = new byte[FKAttendDLL.MAX_GROUPPASSINFO_COUNT];
            mGroupMatchInfo.GroupMatch = new short[FKAttendDLL.MAX_GROUPMATCHINFO_COUNT];

            foreach (object vtObject in Frame1.Controls)
            {
                if (vtObject == null)
                    continue;

                vstrName = ((Control)vtObject).Name;

                vstrItem = "txtStartHour";
                vnLen = vstrItem.Length;
                if ( (vstrName.Length > vnLen) && (vstrName.Substring(0, vnLen) == vstrItem) )
                {
                    vnii = Convert.ToInt32(vstrName.Substring(vnLen, vstrName.Length - vnLen));
                    mtxtStartHour[vnii] = (TextBox)vtObject;
                    continue;
                }
                
                vstrItem = "txtStartMinute";
                vnLen = vstrItem.Length;
                if ( (vstrName.Length > vnLen) && (vstrName.Substring(0, vnLen) == vstrItem) )
                {
                    vnii = Convert.ToInt32(vstrName.Substring(vnLen, vstrName.Length - vnLen));
                    mtxtStartMinute[vnii] = (TextBox)vtObject;
                    continue;
                }

                vstrItem = "txtEndHour";
                vnLen = vstrItem.Length;
                if ( (vstrName.Length > vnLen) && (vstrName.Substring(0, vnLen) == vstrItem) )
                {
                    vnii = Convert.ToInt32(vstrName.Substring(vnLen, vstrName.Length - vnLen));
                    mtxtEndHour[vnii] = (TextBox)vtObject;
                    continue;
                }

                vstrItem = "txtEndMinute";
                vnLen = vstrItem.Length;
                if ( (vstrName.Length > vnLen) && (vstrName.Substring(0, vnLen) == vstrItem) )
                {
                    vnii = Convert.ToInt32(vstrName.Substring(vnLen, vstrName.Length - vnLen));
                    mtxtEndMinute[vnii] = (TextBox)vtObject;
                    continue;
                }

            }

            foreach (object vtObject in Frame2.Controls)
            {
                if (vtObject == null)
                    continue;

                vstrName = ((Control)vtObject).Name;

                vstrItem = "txtUserPassTime";
                vnLen = vstrItem.Length;
                if ( (vstrName.Length > vnLen) && (vstrName.Substring(0, vnLen) == vstrItem) )
                {
                    vnii = Convert.ToInt32(vstrName.Substring(vnLen, vstrName.Length - vnLen));
                    mtxtUserPassTime[vnii] = (TextBox)vtObject;
                }
            }

            foreach (object vtObject in Frame3.Controls)
            {
                if (vtObject == null)
                    continue;

                vstrName = ((Control)vtObject).Name;

                vstrItem = "txtGroupPassTime";
                vnLen = vstrItem.Length;
                if ( (vstrName.Length > vnLen) && (vstrName.Substring(0, vnLen) == vstrItem) )
                {
                    vnii = Convert.ToInt32(vstrName.Substring(vnLen, vstrName.Length - vnLen));
                    mtxtGroupPassTime[vnii] = (TextBox)vtObject;
                }
            }

            foreach (object vtObject in Frame4.Controls)
            {
                if (vtObject == null)
                    continue;

                vstrName = ((Control)vtObject).Name;

                vstrItem = "txtGroupMatch";
                vnLen = vstrItem.Length;
                if ( (vstrName.Length > vnLen) && (vstrName.Substring(0, vnLen) == vstrItem) )
                {
                    vnii = Convert.ToInt32(vstrName.Substring(vnLen, vstrName.Length - vnLen));
                    mtxtGroupMatch[vnii] = (TextBox)vtObject;
                }
            }
            ShowValue();
            cmbDoorState.SelectedIndex = 0;
        }

		private void cmdRead_Click(object sender, System.EventArgs e)
		{
            int vnResultCode;
            int vnPassTimeID = 1;
            int vnPassTimeInfoSize = Marshal.SizeOf(typeof(PASSCTRLTIME));
            byte[] vbytPassTimeInfo = new byte[vnPassTimeInfoSize];
            
            cmdRead.Enabled = false;
            lblMessage.Text = "";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdRead.Enabled = true;
                return;
            }

            if (FKAttendDLL.IsNumeric(txtPassTimeID.Text))
                vnPassTimeID = Convert.ToInt32(txtPassTimeID.Text);
            if (vnPassTimeID < 1 || vnPassTimeID > 50)
                vnPassTimeID = 1;
            txtPassTimeID.Text = (Convert.ToString(vnPassTimeID)).Trim();

            vnResultCode = FKAttendDLL.FK_GetPassTime(
                FKAttendDLL.nCommHandleIndex,
                vnPassTimeID,
                vbytPassTimeInfo,
                vnPassTimeInfoSize);

            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = "Success!";
                mPassTimeInfo = (PASSCTRLTIME)FKAttendDLL.ConvertByteArrayToStructure(vbytPassTimeInfo, typeof(PASSCTRLTIME));
                ShowValue();
            }
            else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdRead.Enabled = true;
		}

		private void cmdWrite_Click(object sender, System.EventArgs e)
		{
            int vnResultCode;
            int vnPassTimeID;
            int vnPassTimeInfoSize = Marshal.SizeOf(typeof(PASSCTRLTIME));
            byte[] vbytPassTimeInfo = new byte[vnPassTimeInfoSize];

            cmdWrite.Enabled = false;
            lblMessage.Text = "";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdWrite.Enabled = true;
                return;
            }

            GetValue();
            
            vnPassTimeID = 1;
            if (FKAttendDLL.IsNumeric(txtPassTimeID.Text))
                vnPassTimeID = Convert.ToInt32(txtPassTimeID.Text);
            if (vnPassTimeID < 1 || vnPassTimeID > 50)
                vnPassTimeID = 1;
            txtPassTimeID.Text = vnPassTimeID.ToString().Trim();

            FKAttendDLL.ConvertStructureToByteArray(mPassTimeInfo, vbytPassTimeInfo);
            vnResultCode = FKAttendDLL.FK_SetPassTime(
                FKAttendDLL.nCommHandleIndex, 
                vnPassTimeID,
                vbytPassTimeInfo,
                vnPassTimeInfoSize);

            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
                lblMessage.Text = "Success!";
            else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdWrite.Enabled = true;
		}

		private void cmdSetDoorState_Click(object sender, System.EventArgs e)
		{
			int vnResultCode;
			int vnState = -1;

			cmdSetDoorState.Enabled = false;
			lblMessage.Text = "Setting Door ...";
			Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = FKAttendDLL.msErrorNoDevice;
				cmdSetDoorState.Enabled = true;
				return;
			}

			switch(cmbDoorState.SelectedIndex)
			{
				case 0: vnState = (int)enumDoorStatus.DOOR_CONROLRESET;break;
				case 1: vnState = (int)enumDoorStatus.DOOR_OPEND;break;
				case 2: vnState = (int)enumDoorStatus.DOOR_CLOSED;break;
				case 3: vnState = (int)enumDoorStatus.DOOR_COMMNAD;break;
			}
            vnResultCode = FKAttendDLL.FK_SetDoorStatus(FKAttendDLL.nCommHandleIndex, (int)vnState);
			if(vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
				lblMessage.Text = "Success!";
			else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
			cmdSetDoorState.Enabled = true;	
		}

		private void cmdGetDoorState_Click(object sender, System.EventArgs e)
		{
			int vnResultCode;
			int vnState =  -1;

			cmdGetDoorState.Enabled = false;
			lblMessage.Text = "Getting Door State...";
			Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = FKAttendDLL.msErrorNoDevice;
				cmdGetDoorState.Enabled = true;
				return;
			}

            vnResultCode = FKAttendDLL.FK_GetDoorStatus(FKAttendDLL.nCommHandleIndex, ref vnState);
			if(vnResultCode == (int)enumErrorCode.RUN_SUCCESS){
				if(vnState == (int)enumDoorStatus.DOOR_CONROLRESET)
					lblMessage.Text = "State Reset!";
				else if(vnState == (int)enumDoorStatus.DOOR_OPEND)
					lblMessage.Text = "Door Open!";
				else if(vnState == (int)enumDoorStatus.DOOR_CLOSED)
					lblMessage.Text = "Door Close!";
				else if(vnState == (int)enumDoorStatus.DOOR_COMMNAD)
					lblMessage.Text = "Command Open... Door Close!";
				else
					lblMessage.Text = "Door - Unknown!";
			}
			else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
			cmdGetDoorState.Enabled = true;
		}

		private void cmdGetUserPasstime_Click(object sender, System.EventArgs e)
		{
            int vnResultCode;
            UInt32 vEnrollNumber;
            int vGroupID = 0;
            int vnUserPassTimeInfoSize = Marshal.SizeOf(typeof(USERPASSINFO));
            byte[] vbytUserPassTimeInfo = new byte [vnUserPassTimeInfoSize];

			string vstrTmp = "";
			
	
			cmdGetUserPasstime.Enabled = false;
			lblMessage.Text = "Getting...";
			Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
			if (vnResultCode !=(int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = FKAttendDLL.msErrorNoDevice;
				cmdGetUserPasstime.Enabled = true;
				return;
			}

            vEnrollNumber = FKAttendDLL.GetInt(txtUserID.Text);
			vstrTmp = new string((char)0x20, 256);

            vnResultCode = FKAttendDLL.FK_GetUserPassTime(
                FKAttendDLL.nCommHandleIndex, 
                vEnrollNumber, 
                ref vGroupID, 
                vbytUserPassTimeInfo,
                vnUserPassTimeInfoSize);
			if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
			{
				txtGroupID.Text = vGroupID.ToString();
				lblMessage.Text = "Success!";
                mUserPassInfo = (USERPASSINFO)FKAttendDLL.ConvertByteArrayToStructure(vbytUserPassTimeInfo, typeof(USERPASSINFO));
				ShowValue();
			}
			else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
			cmdGetUserPasstime.Enabled = true;
		}

		private void cmdSetUserPassTime_Click(object sender, System.EventArgs e)
		{
            int vnResultCode;
            UInt32 vEnrollNumber;
			int vGroupID;
            int vnUserPassTimeInfoSize = Marshal.SizeOf(typeof(USERPASSINFO));
            byte[] vbytUserPassTimeInfo = new byte[vnUserPassTimeInfoSize];

			cmdSetUserPassTime.Enabled = false;
			lblMessage.Text = "Setting...";
			Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = FKAttendDLL.msErrorNoDevice;
				cmdSetUserPassTime.Enabled = true;
				return;
			}

			GetValue();

            FKAttendDLL.ConvertStructureToByteArray(mUserPassInfo, vbytUserPassTimeInfo);
            vEnrollNumber = FKAttendDLL.GetInt(txtUserID.Text);
			vGroupID = Convert.ToInt32(txtGroupID.Text);
            vnResultCode = FKAttendDLL.FK_SetUserPassTime(
                FKAttendDLL.nCommHandleIndex, 
                vEnrollNumber,
                vGroupID, 
                vbytUserPassTimeInfo,
                vnUserPassTimeInfoSize);
			
            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
            {
				lblMessage.Text = "Success!";
				ShowValue();
			}
			else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
			cmdSetUserPassTime.Enabled = true	;
		}

		private void cmdGetGroupPassTime_Click(object sender, System.EventArgs e)
		{
            int vnResultCode;
            int vGroupID;
            int vnGroupPassTimeInfoSize = Marshal.SizeOf(typeof(GROUPPASSINFO));
            byte[] vbytGroupPassTimeInfo = new byte[vnGroupPassTimeInfoSize];

			cmdGetGroupPassTime.Enabled = false;
			lblMessage.Text = "Getting...";
			Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = FKAttendDLL.msErrorNoDevice;
				cmdGetGroupPassTime.Enabled = true;
				return;
			}

			vGroupID = Convert.ToInt32(txtGroupNum.Text);
            vnResultCode = FKAttendDLL.FK_GetGroupPassTime(
                FKAttendDLL.nCommHandleIndex, 
                vGroupID,
                vbytGroupPassTimeInfo,
                vnGroupPassTimeInfoSize);
			if(vnResultCode ==(int)enumErrorCode.RUN_SUCCESS){
				lblMessage.Text = "Success!";
                mGroupPassInfo = (GROUPPASSINFO)FKAttendDLL.ConvertByteArrayToStructure(vbytGroupPassTimeInfo, typeof(GROUPPASSINFO));
                ShowValue();
			}
			else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
			cmdGetGroupPassTime.Enabled = true;
		}

		private void cmdSetGroupPassTime_Click(object sender, System.EventArgs e)
		{
            int vnResultCode;
            int vGroupID;
            int vnGroupPassTimeInfoSize = Marshal.SizeOf(typeof(GROUPPASSINFO));
            byte[] vbytGroupPassTimeInfo = new byte[vnGroupPassTimeInfoSize];

			cmdSetGroupPassTime.Enabled = false;
			lblMessage.Text = "Setting...";
			Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS){
				lblMessage.Text = FKAttendDLL.msErrorNoDevice;
				cmdSetGroupPassTime.Enabled = true;
				return;
			}

			GetValue();

            FKAttendDLL.ConvertStructureToByteArray(mGroupPassInfo, vbytGroupPassTimeInfo);
            
			vGroupID = Convert.ToInt32(txtGroupNum.Text);
            vnResultCode = FKAttendDLL.FK_SetGroupPassTime(
                FKAttendDLL.nCommHandleIndex,
                vGroupID, 
                vbytGroupPassTimeInfo,
                vnGroupPassTimeInfoSize);
			if(vnResultCode == (int)enumErrorCode.RUN_SUCCESS){
				lblMessage.Text = "Success!";
				ShowValue();
			}
			else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
			cmdSetGroupPassTime.Enabled = true	;
		}

		private void cmdGetGroupMatch_Click(object sender, System.EventArgs e)
		{
			int vnResultCode;
            int vnGroupMacthInfoSize = Marshal.SizeOf(typeof(GROUPMATCHINFO));
            byte[] vbytGroupMacthInfo = new byte[vnGroupMacthInfoSize];

			cmdGetGroupMatch.Enabled = false;
			lblMessage.Text = "Getting...";
			Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = FKAttendDLL.msErrorNoDevice;
				cmdGetGroupMatch.Enabled = true;
				return;
			}

            vnResultCode = FKAttendDLL.FK_GetGroupMatch(
                FKAttendDLL.nCommHandleIndex,
                vbytGroupMacthInfo,
                vnGroupMacthInfoSize);
			if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
            {
				lblMessage.Text = "Success!";
                mGroupMatchInfo = (GROUPMATCHINFO)FKAttendDLL.ConvertByteArrayToStructure(vbytGroupMacthInfo, typeof(GROUPMATCHINFO));
				
                ShowValue();
			}
			else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
			cmdGetGroupMatch.Enabled = true	;
		}

		private void cmdSetGroupMatch_Click(object sender, System.EventArgs e)
		{
            int vnResultCode;
            int vnGroupMacthInfoSize = Marshal.SizeOf(typeof(GROUPMATCHINFO));
            byte[] vbytGroupMacthInfo = new byte[vnGroupMacthInfoSize];

			cmdSetGroupMatch.Enabled = false;
			lblMessage.Text = "Setting...";
			Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
			if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
				lblMessage.Text = FKAttendDLL.msErrorNoDevice;
				cmdSetGroupMatch.Enabled = true;
				return;
			}

			GetValue();

            FKAttendDLL.ConvertStructureToByteArray(mGroupMatchInfo, vbytGroupMacthInfo);

            vnResultCode = FKAttendDLL.FK_SetGroupMatch(
                FKAttendDLL.nCommHandleIndex,
                vbytGroupMacthInfo,
                vnGroupMacthInfoSize);
			if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
            {
				lblMessage.Text = "Success!";
				ShowValue();
			}
			else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
			cmdSetGroupMatch.Enabled = true;
		}
		private void ShowValue()
		{
			int vnii;
			for(vnii = 0;vnii<FKAttendDLL.MAX_PASSCTRL_COUNT;vnii++)
			{
				mtxtStartHour[vnii].Text = mPassTimeInfo.PassCtrlTime[vnii].StartHour.ToString();
				mtxtStartMinute[vnii].Text = mPassTimeInfo.PassCtrlTime[vnii].StartMinute.ToString();
				mtxtEndHour[vnii].Text = mPassTimeInfo.PassCtrlTime[vnii].EndHour.ToString();
				mtxtEndMinute[vnii].Text = mPassTimeInfo.PassCtrlTime[vnii].EndMinute.ToString();
			}
			
			for(vnii = 0;vnii< FKAttendDLL.MAX_USERPASSINFO_COUNT;vnii++)
				mtxtUserPassTime[vnii].Text = mUserPassInfo.UserPassID[vnii].ToString();

			for(vnii = 0;vnii< FKAttendDLL.MAX_GROUPPASSINFO_COUNT;vnii++)
				mtxtGroupPassTime[vnii].Text = mGroupPassInfo.GroupPassID[vnii].ToString();

	        for(vnii = 0;vnii< FKAttendDLL.MAX_GROUPMATCHINFO_COUNT;vnii++)
		        mtxtGroupMatch[vnii].Text = mGroupMatchInfo.GroupMatch[vnii].ToString();
		}
		private void GetValue()
		{
			int vnii;
			for(vnii = 0;vnii<FKAttendDLL.MAX_PASSCTRL_COUNT;vnii++)
			{
				mPassTimeInfo.PassCtrlTime[vnii].StartHour = Convert.ToByte(mtxtStartHour[vnii].Text);
				mPassTimeInfo.PassCtrlTime[vnii].StartMinute = Convert.ToByte(mtxtStartMinute[vnii].Text);
				mPassTimeInfo.PassCtrlTime[vnii].EndHour = Convert.ToByte(mtxtEndHour[vnii].Text);
				mPassTimeInfo.PassCtrlTime[vnii].EndMinute = Convert.ToByte(mtxtEndMinute[vnii].Text);
			}
			for(vnii = 0;vnii< FKAttendDLL.MAX_USERPASSINFO_COUNT;vnii++)
				mUserPassInfo.UserPassID[vnii] = Convert.ToByte(mtxtUserPassTime[vnii].Text);

			for(vnii = 0;vnii< FKAttendDLL.MAX_GROUPPASSINFO_COUNT;vnii++)
				mGroupPassInfo.GroupPassID[vnii] = Convert.ToByte(mtxtGroupPassTime[vnii].Text);

			for(vnii = 0;vnii< FKAttendDLL.MAX_GROUPMATCHINFO_COUNT;vnii++)
				mGroupMatchInfo.GroupMatch[vnii] = Convert.ToByte(mtxtGroupMatch[vnii].Text);
		}

	}
}
