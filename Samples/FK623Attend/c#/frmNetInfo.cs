using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FKAttendDllCSSample
{
	/// <summary>
	/// Form4 的摘要说明。
	/// </summary>
	public class frmNetInfo : System.Windows.Forms.Form
	{
		public System.Windows.Forms.Button cmbSetNetInfo;
		public System.Windows.Forms.Button cmbGetNetInfo;
		public System.Windows.Forms.CheckBox chkSerReq;
		public System.Windows.Forms.TextBox txtServerPort;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.TextBox txtServerIP;
		public System.Windows.Forms.Label lblSerVerIP;
		public System.Windows.Forms.Label lblMessage;
		public System.Windows.Forms.ToolTip ToolTip1;
		private System.ComponentModel.IContainer components;

		public frmNetInfo()
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
            this.components = new System.ComponentModel.Container();
            this.cmbSetNetInfo = new System.Windows.Forms.Button();
            this.cmbGetNetInfo = new System.Windows.Forms.Button();
            this.chkSerReq = new System.Windows.Forms.CheckBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.lblSerVerIP = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cmbSetNetInfo
            // 
            this.cmbSetNetInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmbSetNetInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbSetNetInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSetNetInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbSetNetInfo.Location = new System.Drawing.Point(233, 189);
            this.cmbSetNetInfo.Name = "cmbSetNetInfo";
            this.cmbSetNetInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSetNetInfo.Size = new System.Drawing.Size(113, 33);
            this.cmbSetNetInfo.TabIndex = 12;
            this.cmbSetNetInfo.Text = "Set NetInfo";
            this.cmbSetNetInfo.UseVisualStyleBackColor = false;
            this.cmbSetNetInfo.Click += new System.EventHandler(this.cmbSetNetInfo_Click);
            // 
            // cmbGetNetInfo
            // 
            this.cmbGetNetInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmbGetNetInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbGetNetInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetNetInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbGetNetInfo.Location = new System.Drawing.Point(108, 189);
            this.cmbGetNetInfo.Name = "cmbGetNetInfo";
            this.cmbGetNetInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbGetNetInfo.Size = new System.Drawing.Size(113, 33);
            this.cmbGetNetInfo.TabIndex = 11;
            this.cmbGetNetInfo.Text = "Get NetInfo";
            this.cmbGetNetInfo.UseVisualStyleBackColor = false;
            this.cmbGetNetInfo.Click += new System.EventHandler(this.cmbGetNetInfo_Click);
            // 
            // chkSerReq
            // 
            this.chkSerReq.BackColor = System.Drawing.SystemColors.Control;
            this.chkSerReq.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkSerReq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSerReq.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkSerReq.Location = new System.Drawing.Point(196, 141);
            this.chkSerReq.Name = "chkSerReq";
            this.chkSerReq.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSerReq.Size = new System.Drawing.Size(145, 33);
            this.chkSerReq.TabIndex = 10;
            this.chkSerReq.Text = "ServerRequest";
            this.chkSerReq.UseVisualStyleBackColor = false;
            // 
            // txtServerPort
            // 
            this.txtServerPort.AcceptsReturn = true;
            this.txtServerPort.BackColor = System.Drawing.SystemColors.Window;
            this.txtServerPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServerPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerPort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtServerPort.Location = new System.Drawing.Point(196, 109);
            this.txtServerPort.MaxLength = 32;
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServerPort.Size = new System.Drawing.Size(150, 27);
            this.txtServerPort.TabIndex = 9;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(36, 109);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(90, 19);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Server Port : ";
            // 
            // txtServerIP
            // 
            this.txtServerIP.AcceptsReturn = true;
            this.txtServerIP.BackColor = System.Drawing.SystemColors.Window;
            this.txtServerIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServerIP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerIP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtServerIP.Location = new System.Drawing.Point(196, 69);
            this.txtServerIP.MaxLength = 32;
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServerIP.Size = new System.Drawing.Size(150, 27);
            this.txtServerIP.TabIndex = 8;
            // 
            // lblSerVerIP
            // 
            this.lblSerVerIP.AutoSize = true;
            this.lblSerVerIP.BackColor = System.Drawing.SystemColors.Control;
            this.lblSerVerIP.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSerVerIP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerVerIP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSerVerIP.Location = new System.Drawing.Point(36, 69);
            this.lblSerVerIP.Name = "lblSerVerIP";
            this.lblSerVerIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSerVerIP.Size = new System.Drawing.Size(133, 19);
            this.lblSerVerIP.TabIndex = 15;
            this.lblSerVerIP.Text = "Server IP Address : ";
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(36, 23);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(313, 28);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmNetInfo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
            this.ClientSize = new System.Drawing.Size(384, 238);
            this.Controls.Add(this.cmbGetNetInfo);
            this.Controls.Add(this.chkSerReq);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.lblSerVerIP);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cmbSetNetInfo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Location = new System.Drawing.Point(4, 25);
            this.Name = "frmNetInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get && Set Net Information";
            this.Load += new System.EventHandler(this.frmNetInfo_Load);
            this.Closed += new System.EventHandler(this.frmNetInfo_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void cmbGetNetInfo_Click(object sender, System.EventArgs e)
		{
			int vnResultCode;
			string vstrServerIP = "";
			int vnServerPort = 0;
			int vnServerRequest = 0;


			cmbGetNetInfo.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
			if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = FKAttendDLL.msErrorNoDevice;
				cmbGetNetInfo.Enabled = true;
				return;
			}

            vnResultCode = FKAttendDLL.FK_GetServerNetInfo(FKAttendDLL.nCommHandleIndex, ref vstrServerIP, ref vnServerPort, ref vnServerRequest);

			if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
			{
				txtServerIP.Text = vstrServerIP;
				txtServerPort.Text = Convert.ToString(vnServerPort);
				if (vnServerRequest == 1)
					chkSerReq.CheckState = CheckState.Checked;
				else
					chkSerReq.CheckState = CheckState.Unchecked;
				
			}

            lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
			cmbGetNetInfo.Enabled = true;
		}

		private void cmbSetNetInfo_Click(object sender, System.EventArgs e)
		{
			int vnResultCode;
			string vstrServerIP;
			int vnServerPort;
			int  vnServerRequest;

			cmbSetNetInfo.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);

			if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = FKAttendDLL.msErrorNoDevice;
				cmbSetNetInfo.Enabled = true;
				return;
			}

			vstrServerIP = (txtServerIP.Text).Trim();
			vnServerPort = Convert.ToInt32((txtServerPort.Text).Trim());
			if (chkSerReq.CheckState == CheckState.Checked)
				vnServerRequest = 1;
			else
				vnServerRequest = 0;

            vnResultCode = FKAttendDLL.FK_SetServerNetInfo(FKAttendDLL.nCommHandleIndex, vstrServerIP, vnServerPort, vnServerRequest);
            lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);

			cmbSetNetInfo.Enabled = true;
		}

		private void frmNetInfo_Load(object sender, System.EventArgs e)
		{
			txtServerIP.Text = "0.0.0.0";
			txtServerPort.Text = Convert.ToString(0);
		}

		private void frmNetInfo_Closed(object sender, System.EventArgs e)
		{
			 frmMain.gfrmMain.Visible = true;
		}
	}
}
