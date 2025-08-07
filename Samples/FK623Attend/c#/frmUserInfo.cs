using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace FKAttendDllCSSample
{
	/// <summary>
	/// Form6 的摘要说明。
	/// </summary>
	public class frmUserInfo : System.Windows.Forms.Form
    {
		public System.Windows.Forms.TextBox txtEnrollNumber;
		public System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.Button cmdGetUserNameVID;
        public System.Windows.Forms.Button cmdSetUserNameVID;
		public System.Windows.Forms.Label lblMessage;
		public System.Windows.Forms.Label lblEnrollNum;
		public System.Windows.Forms.Label Label3;
        public TextBox txtVID;
        public Label label1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
        /// 

       
        public const int VER_USERCUSTOMINFO_V1		= 1;
        public const int SIZE_USERCUSTOMINFO_V1 = 644;

       // public const int SIZE_USERCUSTOMINFO_V1 = 644;
        public const int SIZE_USERVID = 64;

        public static string EXTCMD_GET_USERCUSTOMINFO = "GetUserCustomInfo";
        public static string EXTCMD_SET_USERCUSTOMINFO = "SetUserCustomInfo";
        public Button cmdGetUserName;
        public Button cmdSetUserName;

        struct ExtCmd_USERVID
        {
        
            public ExtCmdStructHeader CmdHeader;
            public UInt32    UserID;		//4
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = SIZE_USERVID)]
            public byte[] UserVID;		//64
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = SIZE_USERVID*2)]
            public byte[] UserName;		//64
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = SIZE_USERVID*7)]
            public byte[] resered;		//4
            public void Init(string asCmdCode,UInt32 aUserID)
            {
                CmdHeader = new ExtCmdStructHeader();
                CmdHeader.Init(asCmdCode, VER_USERCUSTOMINFO_V1, SIZE_USERCUSTOMINFO_V1);
                UserVID = new byte[SIZE_USERVID];
                UserName = new byte[SIZE_USERVID*2];
                resered = new byte[SIZE_USERVID*7];
                UserID = aUserID;
            }

            public void SetUserVID(string usrVId)
            {
                FKAttendDLL.StringToByteArrayUtf16(usrVId, UserVID);
            }

            public string GetUserVID()
            {
                return FKAttendDLL.ByteArrayUtf16ToString(UserVID);
            }
            
            public void SetUserName(string usrName)
            {
                FKAttendDLL.StringToByteArrayUtf16(usrName, UserName);
            }

            public string GetUserName()
            {
                return FKAttendDLL.ByteArrayUtf16ToString(UserName);
            }

        }


    
		private System.ComponentModel.Container components = null;

		public frmUserInfo()
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
      this.txtEnrollNumber = new System.Windows.Forms.TextBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.cmdGetUserNameVID = new System.Windows.Forms.Button();
      this.cmdSetUserNameVID = new System.Windows.Forms.Button();
      this.lblMessage = new System.Windows.Forms.Label();
      this.lblEnrollNum = new System.Windows.Forms.Label();
      this.Label3 = new System.Windows.Forms.Label();
      this.txtVID = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.cmdGetUserName = new System.Windows.Forms.Button();
      this.cmdSetUserName = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtEnrollNumber
      // 
      this.txtEnrollNumber.AcceptsReturn = true;
      this.txtEnrollNumber.BackColor = System.Drawing.SystemColors.Window;
      this.txtEnrollNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.txtEnrollNumber.ForeColor = System.Drawing.SystemColors.WindowText;
      this.txtEnrollNumber.Location = new System.Drawing.Point(119, 60);
      this.txtEnrollNumber.MaxLength = 30;
      this.txtEnrollNumber.Name = "txtEnrollNumber";
      this.txtEnrollNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.txtEnrollNumber.Size = new System.Drawing.Size(114, 26);
      this.txtEnrollNumber.TabIndex = 21;
      // 
      // txtName
      // 
      this.txtName.AcceptsReturn = true;
      this.txtName.BackColor = System.Drawing.SystemColors.Window;
      this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
      this.txtName.Location = new System.Drawing.Point(119, 93);
      this.txtName.MaxLength = 10;
      this.txtName.Name = "txtName";
      this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.txtName.Size = new System.Drawing.Size(114, 26);
      this.txtName.TabIndex = 33;
      // 
      // cmdGetUserNameVID
      // 
      this.cmdGetUserNameVID.BackColor = System.Drawing.SystemColors.Control;
      this.cmdGetUserNameVID.Cursor = System.Windows.Forms.Cursors.Default;
      this.cmdGetUserNameVID.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdGetUserNameVID.Location = new System.Drawing.Point(272, 168);
      this.cmdGetUserNameVID.Name = "cmdGetUserNameVID";
      this.cmdGetUserNameVID.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cmdGetUserNameVID.Size = new System.Drawing.Size(169, 32);
      this.cmdGetUserNameVID.TabIndex = 18;
      this.cmdGetUserNameVID.Text = "Get User Name, VID";
      this.cmdGetUserNameVID.UseVisualStyleBackColor = false;
      this.cmdGetUserNameVID.Click += new System.EventHandler(this.cmdGetUserNameVID_Click);
      // 
      // cmdSetUserNameVID
      // 
      this.cmdSetUserNameVID.BackColor = System.Drawing.SystemColors.Control;
      this.cmdSetUserNameVID.Cursor = System.Windows.Forms.Cursors.Default;
      this.cmdSetUserNameVID.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSetUserNameVID.Location = new System.Drawing.Point(272, 129);
      this.cmdSetUserNameVID.Name = "cmdSetUserNameVID";
      this.cmdSetUserNameVID.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cmdSetUserNameVID.Size = new System.Drawing.Size(169, 32);
      this.cmdSetUserNameVID.TabIndex = 17;
      this.cmdSetUserNameVID.Text = "Set User Name , VID";
      this.cmdSetUserNameVID.UseVisualStyleBackColor = false;
      this.cmdSetUserNameVID.Click += new System.EventHandler(this.cmdSetUserNameVID_Click);
      // 
      // lblMessage
      // 
      this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
      this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
      this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblMessage.Location = new System.Drawing.Point(15, 14);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lblMessage.Size = new System.Drawing.Size(426, 33);
      this.lblMessage.TabIndex = 27;
      this.lblMessage.Text = "Message";
      this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblEnrollNum
      // 
      this.lblEnrollNum.AutoSize = true;
      this.lblEnrollNum.BackColor = System.Drawing.SystemColors.Control;
      this.lblEnrollNum.Cursor = System.Windows.Forms.Cursors.Default;
      this.lblEnrollNum.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblEnrollNum.Location = new System.Drawing.Point(9, 64);
      this.lblEnrollNum.Name = "lblEnrollNum";
      this.lblEnrollNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lblEnrollNum.Size = new System.Drawing.Size(105, 19);
      this.lblEnrollNum.TabIndex = 24;
      this.lblEnrollNum.Text = "Enroll Number :";
      this.lblEnrollNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Label3
      // 
      this.Label3.AutoSize = true;
      this.Label3.BackColor = System.Drawing.SystemColors.Control;
      this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.Location = new System.Drawing.Point(11, 96);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.Label3.Size = new System.Drawing.Size(53, 19);
      this.Label3.TabIndex = 23;
      this.Label3.Text = "Name :";
      this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtVID
      // 
      this.txtVID.AcceptsReturn = true;
      this.txtVID.BackColor = System.Drawing.SystemColors.Window;
      this.txtVID.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.txtVID.ForeColor = System.Drawing.SystemColors.WindowText;
      this.txtVID.Location = new System.Drawing.Point(120, 126);
      this.txtVID.MaxLength = 10;
      this.txtVID.Name = "txtVID";
      this.txtVID.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.txtVID.Size = new System.Drawing.Size(114, 26);
      this.txtVID.TabIndex = 37;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.SystemColors.Control;
      this.label1.Cursor = System.Windows.Forms.Cursors.Default;
      this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label1.Location = new System.Drawing.Point(12, 129);
      this.label1.Name = "label1";
      this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.label1.Size = new System.Drawing.Size(75, 19);
      this.label1.TabIndex = 36;
      this.label1.Text = "Virtual ID :";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cmdGetUserName
      // 
      this.cmdGetUserName.BackColor = System.Drawing.SystemColors.Control;
      this.cmdGetUserName.Cursor = System.Windows.Forms.Cursors.Default;
      this.cmdGetUserName.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdGetUserName.Location = new System.Drawing.Point(272, 89);
      this.cmdGetUserName.Name = "cmdGetUserName";
      this.cmdGetUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cmdGetUserName.Size = new System.Drawing.Size(169, 30);
      this.cmdGetUserName.TabIndex = 39;
      this.cmdGetUserName.Text = "Get User Name";
      this.cmdGetUserName.UseVisualStyleBackColor = false;
      this.cmdGetUserName.Click += new System.EventHandler(this.cmdGetUserName_Click);
      // 
      // cmdSetUserName
      // 
      this.cmdSetUserName.BackColor = System.Drawing.SystemColors.Control;
      this.cmdSetUserName.Cursor = System.Windows.Forms.Cursors.Default;
      this.cmdSetUserName.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSetUserName.Location = new System.Drawing.Point(272, 50);
      this.cmdSetUserName.Name = "cmdSetUserName";
      this.cmdSetUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cmdSetUserName.Size = new System.Drawing.Size(169, 30);
      this.cmdSetUserName.TabIndex = 38;
      this.cmdSetUserName.Text = "Set User Name";
      this.cmdSetUserName.UseVisualStyleBackColor = false;
      this.cmdSetUserName.Click += new System.EventHandler(this.cmdSetUserName_Click);
      // 
      // frmUserInfo
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
      this.ClientSize = new System.Drawing.Size(458, 219);
      this.Controls.Add(this.cmdGetUserName);
      this.Controls.Add(this.cmdSetUserName);
      this.Controls.Add(this.txtVID);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtEnrollNumber);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.cmdGetUserNameVID);
      this.Controls.Add(this.cmdSetUserNameVID);
      this.Controls.Add(this.lblMessage);
      this.Controls.Add(this.lblEnrollNum);
      this.Controls.Add(this.Label3);
      this.Font = new System.Drawing.Font("Times New Roman", 12F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Location = new System.Drawing.Point(2, 28);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmUserInfo";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "User Information";
      this.Load += new System.EventHandler(this.frmUserInfo_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

		}
		#endregion
		const short NAMESIZE = 400;
		private int[] glngUserName = new int[NAMESIZE];


       

		private void frmUserInfo_Load(object sender, System.EventArgs e)
		{
			txtEnrollNumber.Text = "1";
		}
		
		private void cmdGetUserNameVID_Click(object sender, System.EventArgs e)
		{

             UInt32 vEnrollNumber;
             string vStrEnrollNumber;
           
            int vnResultCode;

            cmdGetUserNameVID.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdGetUserNameVID.Enabled = true;
                return;
            }
            int vSize = SIZE_USERCUSTOMINFO_V1 + 64;
            byte[] bytExtCmd_USERVID = new byte[vSize];
            ExtCmd_USERVID vExtCmd_USERVID = new ExtCmd_USERVID();

            vStrEnrollNumber = txtEnrollNumber.Text;
            vEnrollNumber = FKAttendDLL.GetInt(vStrEnrollNumber);

            vExtCmd_USERVID.Init(EXTCMD_GET_USERCUSTOMINFO, vEnrollNumber);

            FKAttendDLL.ConvertStructureToByteArray(vExtCmd_USERVID, bytExtCmd_USERVID);

            vnResultCode = FKAttendDLL.FK_ExtCommand(FKAttendDLL.nCommHandleIndex, bytExtCmd_USERVID);

            vExtCmd_USERVID = (ExtCmd_USERVID)FKAttendDLL.ConvertByteArrayToStructure(bytExtCmd_USERVID, typeof(ExtCmd_USERVID));
            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
            {
                txtName.Text = vExtCmd_USERVID.GetUserName();
                txtVID.Text = vExtCmd_USERVID.GetUserVID();

                lblMessage.Text = "GetUserName, VID OK";
            }
            else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdGetUserNameVID.Enabled = true;	
        


	       
		}

		private void cmdSetUserNameVID_Click(object sender, System.EventArgs e)
		{
            UInt32 vEnrollNumber;
            int vnResultCode;
            string vStrEnrollNumber;
            cmdSetUserNameVID.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                 cmdSetUserNameVID.Enabled = true;
                return;
            }

            //ExtCmd_USERVID 
            int vSize = SIZE_USERCUSTOMINFO_V1 + 64;
            byte[] bytExtCmd_USERVID = new byte[vSize];
            ExtCmd_USERVID vExtCmd_USERVID = new ExtCmd_USERVID();

            vStrEnrollNumber = txtEnrollNumber.Text;
            vEnrollNumber = FKAttendDLL.GetInt(vStrEnrollNumber);

            vExtCmd_USERVID.Init(EXTCMD_SET_USERCUSTOMINFO, vEnrollNumber);
            vExtCmd_USERVID.SetUserVID((txtVID.Text).Trim());
            vExtCmd_USERVID.SetUserName((txtName.Text).Trim());

            FKAttendDLL.ConvertStructureToByteArray(vExtCmd_USERVID, bytExtCmd_USERVID);

            vnResultCode = FKAttendDLL.FK_ExtCommand(FKAttendDLL.nCommHandleIndex, bytExtCmd_USERVID);

            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
                lblMessage.Text = "SetUserName, VID OK";
            else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdSetUserNameVID.Enabled = true;	

			
		}
        
        private void cmdGetUserName_Click(object sender, System.EventArgs e)
        {
            string vStrEnrollNumber = "";
            UInt32 vEnrollNumber;
            string vName;
            int vnResultCode;

            cmdGetUserName.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdGetUserName.Enabled = true;
                return;
            }

            vStrEnrollNumber = txtEnrollNumber.Text.Trim();
            vEnrollNumber = FKAttendDLL.GetInt(vStrEnrollNumber);

            vName = new string((char)0x20, 256);

            int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
            if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
                vnResultCode = FKAttendDLL.FK_GetUserName_StringID(FKAttendDLL.nCommHandleIndex, vStrEnrollNumber, ref vName);
            else
                 vnResultCode = FKAttendDLL.FK_GetUserName(FKAttendDLL.nCommHandleIndex, vEnrollNumber, ref vName);

            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
            {
                txtName.Text = vName;
                lblMessage.Text = "GetUserName OK";
            }
            else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdGetUserName.Enabled = true;
        }

        private void cmdSetUserName_Click(object sender, System.EventArgs e)
        {
            string vStrEnrollNumber = "";
            UInt32 vEnrollNumber;
            int vnResultCode;

            cmdSetUserName.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdSetUserName.Enabled = true;
                return;
            }

            vStrEnrollNumber = txtEnrollNumber.Text.Trim();
            vEnrollNumber = FKAttendDLL.GetInt(vStrEnrollNumber);

            int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
            if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
                vnResultCode = FKAttendDLL.FK_SetUserName_StringID(FKAttendDLL.nCommHandleIndex, vStrEnrollNumber, (txtName.Text).Trim());
            else
                vnResultCode = FKAttendDLL.FK_SetUserName(FKAttendDLL.nCommHandleIndex, vEnrollNumber, (txtName.Text).Trim());


            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
                lblMessage.Text = "SetUserName OK";
            else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdSetUserName.Enabled = true;
        }
	}
}
