using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace FKAttendDllCSSample
{
    /// <summary>
    /// Form3 的摘要说明。
    /// </summary>
    public class frmEnroll : System.Windows.Forms.Form
    {
        public System.Windows.Forms.Button cmdBenumbManager;
        internal System.Windows.Forms.OpenFileDialog dlgOpen;
        internal System.Windows.Forms.SaveFileDialog dlgSave;
        public System.Windows.Forms.Button cmdUSBSetAllData;
        public System.Windows.Forms.Button cmdUSBGetAllData;
        internal System.Windows.Forms.Label lblDBCount;
        public System.Windows.Forms.TextBox txtEnrollNumber;
        public System.Windows.Forms.Button cmdGetEnrollData;
        public System.Windows.Forms.Button cmdEmptyEnrollData;
        public System.Windows.Forms.Button cmdDisableUser;
        public System.Windows.Forms.ComboBox cmbBackupNumber;
        public System.Windows.Forms.ComboBox cmbPrivilege;
        public System.Windows.Forms.Button cmdDel;
        public System.Windows.Forms.Button cmdClearData;
        public System.Windows.Forms.Button cmdSetEnrollData;
        public System.Windows.Forms.Button cmdDeleteEnrollData;
        public System.Windows.Forms.Button cmdModifyPrivilege;
        public System.Windows.Forms.Button cmdEnableUser;
        public System.Windows.Forms.Button cmdSetAllEnrollData;
        public System.Windows.Forms.Button cmdGetAllEnrollData;
        public System.Windows.Forms.Button cmdGetEnrollInfo;
        public System.Windows.Forms.ListBox lstEnrollData;
        public System.Windows.Forms.Label lblEnrollNum;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblPrivilege;
        public System.Windows.Forms.Label lblEnrollData;
        public System.Windows.Forms.Label lblBackupNumber;
        public System.Windows.Forms.Label lblMessage;
        internal System.Windows.Forms.HScrollBar scbAdoScroll;
        public Button cmdEnterEnroll;
        public Label labelCardOrPwd;
        public TextBox txtboxCardOrPwd;

        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmEnroll()
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
            this.cmdBenumbManager = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.cmdUSBSetAllData = new System.Windows.Forms.Button();
            this.cmdUSBGetAllData = new System.Windows.Forms.Button();
            this.lblDBCount = new System.Windows.Forms.Label();
            this.txtEnrollNumber = new System.Windows.Forms.TextBox();
            this.cmdGetEnrollData = new System.Windows.Forms.Button();
            this.cmdEmptyEnrollData = new System.Windows.Forms.Button();
            this.cmdDisableUser = new System.Windows.Forms.Button();
            this.cmbBackupNumber = new System.Windows.Forms.ComboBox();
            this.cmbPrivilege = new System.Windows.Forms.ComboBox();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdClearData = new System.Windows.Forms.Button();
            this.cmdSetEnrollData = new System.Windows.Forms.Button();
            this.cmdDeleteEnrollData = new System.Windows.Forms.Button();
            this.cmdModifyPrivilege = new System.Windows.Forms.Button();
            this.cmdEnableUser = new System.Windows.Forms.Button();
            this.cmdSetAllEnrollData = new System.Windows.Forms.Button();
            this.cmdGetAllEnrollData = new System.Windows.Forms.Button();
            this.cmdGetEnrollInfo = new System.Windows.Forms.Button();
            this.lstEnrollData = new System.Windows.Forms.ListBox();
            this.lblEnrollNum = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrivilege = new System.Windows.Forms.Label();
            this.lblEnrollData = new System.Windows.Forms.Label();
            this.lblBackupNumber = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.scbAdoScroll = new System.Windows.Forms.HScrollBar();
            this.cmdEnterEnroll = new System.Windows.Forms.Button();
            this.labelCardOrPwd = new System.Windows.Forms.Label();
            this.txtboxCardOrPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdBenumbManager
            // 
            this.cmdBenumbManager.BackColor = System.Drawing.SystemColors.Control;
            this.cmdBenumbManager.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdBenumbManager.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBenumbManager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdBenumbManager.Location = new System.Drawing.Point(306, 514);
            this.cmdBenumbManager.Name = "cmdBenumbManager";
            this.cmdBenumbManager.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdBenumbManager.Size = new System.Drawing.Size(259, 37);
            this.cmdBenumbManager.TabIndex = 83;
            this.cmdBenumbManager.Text = "Benumb All Managers";
            this.cmdBenumbManager.UseVisualStyleBackColor = false;
            this.cmdBenumbManager.Click += new System.EventHandler(this.cmdBenumbManager_Click);
            // 
            // cmdUSBSetAllData
            // 
            this.cmdUSBSetAllData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdUSBSetAllData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdUSBSetAllData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUSBSetAllData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdUSBSetAllData.Location = new System.Drawing.Point(306, 341);
            this.cmdUSBSetAllData.Name = "cmdUSBSetAllData";
            this.cmdUSBSetAllData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdUSBSetAllData.Size = new System.Drawing.Size(259, 39);
            this.cmdUSBSetAllData.TabIndex = 64;
            this.cmdUSBSetAllData.Text = "Set All Enroll Data(USB)";
            this.cmdUSBSetAllData.UseVisualStyleBackColor = false;
            this.cmdUSBSetAllData.Click += new System.EventHandler(this.cmdUSBSetAllData_Click);
            // 
            // cmdUSBGetAllData
            // 
            this.cmdUSBGetAllData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdUSBGetAllData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdUSBGetAllData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUSBGetAllData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdUSBGetAllData.Location = new System.Drawing.Point(306, 304);
            this.cmdUSBGetAllData.Name = "cmdUSBGetAllData";
            this.cmdUSBGetAllData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdUSBGetAllData.Size = new System.Drawing.Size(259, 38);
            this.cmdUSBGetAllData.TabIndex = 63;
            this.cmdUSBGetAllData.Text = "Get All Enroll Data(USB)";
            this.cmdUSBGetAllData.UseVisualStyleBackColor = false;
            this.cmdUSBGetAllData.Click += new System.EventHandler(this.cmdUSBGetAllData_Click);
            // 
            // lblDBCount
            // 
            this.lblDBCount.BackColor = System.Drawing.Color.White;
            this.lblDBCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDBCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBCount.ForeColor = System.Drawing.Color.Blue;
            this.lblDBCount.Location = new System.Drawing.Point(43, 640);
            this.lblDBCount.Name = "lblDBCount";
            this.lblDBCount.Size = new System.Drawing.Size(102, 30);
            this.lblDBCount.TabIndex = 81;
            this.lblDBCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEnrollNumber
            // 
            this.txtEnrollNumber.AcceptsReturn = true;
            this.txtEnrollNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtEnrollNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnrollNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEnrollNumber.Location = new System.Drawing.Point(153, 73);
            this.txtEnrollNumber.MaxLength = 10;
            this.txtEnrollNumber.Name = "txtEnrollNumber";
            this.txtEnrollNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnrollNumber.Size = new System.Drawing.Size(129, 26);
            this.txtEnrollNumber.TabIndex = 71;
            // 
            // cmdGetEnrollData
            // 
            this.cmdGetEnrollData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetEnrollData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetEnrollData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetEnrollData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetEnrollData.Location = new System.Drawing.Point(306, 85);
            this.cmdGetEnrollData.Name = "cmdGetEnrollData";
            this.cmdGetEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetEnrollData.Size = new System.Drawing.Size(259, 39);
            this.cmdGetEnrollData.TabIndex = 58;
            this.cmdGetEnrollData.Text = "Get Enroll Data";
            this.cmdGetEnrollData.UseVisualStyleBackColor = false;
            this.cmdGetEnrollData.Click += new System.EventHandler(this.cmdGetEnrollData_Click);
            // 
            // cmdEmptyEnrollData
            // 
            this.cmdEmptyEnrollData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdEmptyEnrollData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdEmptyEnrollData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEmptyEnrollData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdEmptyEnrollData.Location = new System.Drawing.Point(306, 554);
            this.cmdEmptyEnrollData.Name = "cmdEmptyEnrollData";
            this.cmdEmptyEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdEmptyEnrollData.Size = new System.Drawing.Size(259, 38);
            this.cmdEmptyEnrollData.TabIndex = 69;
            this.cmdEmptyEnrollData.Text = "Empty Enroll Data";
            this.cmdEmptyEnrollData.UseVisualStyleBackColor = false;
            this.cmdEmptyEnrollData.Click += new System.EventHandler(this.cmdEmptyEnrollData_Click);
            // 
            // cmdDisableUser
            // 
            this.cmdDisableUser.BackColor = System.Drawing.SystemColors.Control;
            this.cmdDisableUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdDisableUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDisableUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdDisableUser.Location = new System.Drawing.Point(436, 433);
            this.cmdDisableUser.Name = "cmdDisableUser";
            this.cmdDisableUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDisableUser.Size = new System.Drawing.Size(129, 40);
            this.cmdDisableUser.TabIndex = 67;
            this.cmdDisableUser.Text = "Disable User";
            this.cmdDisableUser.UseVisualStyleBackColor = false;
            this.cmdDisableUser.Click += new System.EventHandler(this.cmdDisableUser_Click);
            // 
            // cmbBackupNumber
            // 
            this.cmbBackupNumber.BackColor = System.Drawing.SystemColors.Window;
            this.cmbBackupNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbBackupNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackupNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBackupNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbBackupNumber.Location = new System.Drawing.Point(153, 107);
            this.cmbBackupNumber.Name = "cmbBackupNumber";
            this.cmbBackupNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBackupNumber.Size = new System.Drawing.Size(129, 27);
            this.cmbBackupNumber.TabIndex = 79;
            this.cmbBackupNumber.SelectedIndexChanged += new System.EventHandler(this.CmbBackupNumber_SelectedIndexChanged);
            // 
            // cmbPrivilege
            // 
            this.cmbPrivilege.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPrivilege.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrivilege.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrivilege.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbPrivilege.Location = new System.Drawing.Point(153, 175);
            this.cmbPrivilege.Name = "cmbPrivilege";
            this.cmbPrivilege.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbPrivilege.Size = new System.Drawing.Size(129, 27);
            this.cmbPrivilege.TabIndex = 78;
            // 
            // cmdDel
            // 
            this.cmdDel.BackColor = System.Drawing.SystemColors.Control;
            this.cmdDel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdDel.Location = new System.Drawing.Point(167, 638);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDel.Size = new System.Drawing.Size(115, 32);
            this.cmdDel.TabIndex = 57;
            this.cmdDel.Text = "Delete DB";
            this.cmdDel.UseVisualStyleBackColor = false;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
            // 
            // cmdClearData
            // 
            this.cmdClearData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdClearData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdClearData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClearData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClearData.Location = new System.Drawing.Point(306, 593);
            this.cmdClearData.Name = "cmdClearData";
            this.cmdClearData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdClearData.Size = new System.Drawing.Size(259, 39);
            this.cmdClearData.TabIndex = 70;
            this.cmdClearData.Text = "Clear All Data(E,GL,SL) ";
            this.cmdClearData.UseVisualStyleBackColor = false;
            this.cmdClearData.Click += new System.EventHandler(this.cmdClearData_Click);
            // 
            // cmdSetEnrollData
            // 
            this.cmdSetEnrollData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetEnrollData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetEnrollData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetEnrollData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetEnrollData.Location = new System.Drawing.Point(306, 124);
            this.cmdSetEnrollData.Name = "cmdSetEnrollData";
            this.cmdSetEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetEnrollData.Size = new System.Drawing.Size(259, 39);
            this.cmdSetEnrollData.TabIndex = 59;
            this.cmdSetEnrollData.Text = "Set Enroll Data";
            this.cmdSetEnrollData.UseVisualStyleBackColor = false;
            this.cmdSetEnrollData.Click += new System.EventHandler(this.cmdSetEnrollData_Click);
            // 
            // cmdDeleteEnrollData
            // 
            this.cmdDeleteEnrollData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdDeleteEnrollData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdDeleteEnrollData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeleteEnrollData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdDeleteEnrollData.Location = new System.Drawing.Point(306, 163);
            this.cmdDeleteEnrollData.Name = "cmdDeleteEnrollData";
            this.cmdDeleteEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDeleteEnrollData.Size = new System.Drawing.Size(259, 38);
            this.cmdDeleteEnrollData.TabIndex = 60;
            this.cmdDeleteEnrollData.Text = "Delete Enroll Data";
            this.cmdDeleteEnrollData.UseVisualStyleBackColor = false;
            this.cmdDeleteEnrollData.Click += new System.EventHandler(this.cmdDeleteEnrollData_Click);
            // 
            // cmdModifyPrivilege
            // 
            this.cmdModifyPrivilege.BackColor = System.Drawing.SystemColors.Control;
            this.cmdModifyPrivilege.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdModifyPrivilege.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModifyPrivilege.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdModifyPrivilege.Location = new System.Drawing.Point(306, 474);
            this.cmdModifyPrivilege.Name = "cmdModifyPrivilege";
            this.cmdModifyPrivilege.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdModifyPrivilege.Size = new System.Drawing.Size(259, 39);
            this.cmdModifyPrivilege.TabIndex = 68;
            this.cmdModifyPrivilege.Text = "ModifyPrivilege";
            this.cmdModifyPrivilege.UseVisualStyleBackColor = false;
            this.cmdModifyPrivilege.Click += new System.EventHandler(this.cmdModifyPrivilege_Click);
            // 
            // cmdEnableUser
            // 
            this.cmdEnableUser.BackColor = System.Drawing.SystemColors.Control;
            this.cmdEnableUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdEnableUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEnableUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdEnableUser.Location = new System.Drawing.Point(306, 433);
            this.cmdEnableUser.Name = "cmdEnableUser";
            this.cmdEnableUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdEnableUser.Size = new System.Drawing.Size(130, 40);
            this.cmdEnableUser.TabIndex = 66;
            this.cmdEnableUser.Text = "Enable User";
            this.cmdEnableUser.UseVisualStyleBackColor = false;
            this.cmdEnableUser.Click += new System.EventHandler(this.cmdEnableUser_Click);
            // 
            // cmdSetAllEnrollData
            // 
            this.cmdSetAllEnrollData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetAllEnrollData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetAllEnrollData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetAllEnrollData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetAllEnrollData.Location = new System.Drawing.Point(306, 253);
            this.cmdSetAllEnrollData.Name = "cmdSetAllEnrollData";
            this.cmdSetAllEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetAllEnrollData.Size = new System.Drawing.Size(259, 39);
            this.cmdSetAllEnrollData.TabIndex = 62;
            this.cmdSetAllEnrollData.Text = "Set All Enroll Data";
            this.cmdSetAllEnrollData.UseVisualStyleBackColor = false;
            this.cmdSetAllEnrollData.Click += new System.EventHandler(this.cmdSetAllEnrollData_Click);
            // 
            // cmdGetAllEnrollData
            // 
            this.cmdGetAllEnrollData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetAllEnrollData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetAllEnrollData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetAllEnrollData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetAllEnrollData.Location = new System.Drawing.Point(306, 214);
            this.cmdGetAllEnrollData.Name = "cmdGetAllEnrollData";
            this.cmdGetAllEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetAllEnrollData.Size = new System.Drawing.Size(259, 39);
            this.cmdGetAllEnrollData.TabIndex = 61;
            this.cmdGetAllEnrollData.Text = "Get All Enroll Data";
            this.cmdGetAllEnrollData.UseVisualStyleBackColor = false;
            this.cmdGetAllEnrollData.Click += new System.EventHandler(this.cmdGetAllEnrollData_Click);
            // 
            // cmdGetEnrollInfo
            // 
            this.cmdGetEnrollInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetEnrollInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetEnrollInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetEnrollInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetEnrollInfo.Location = new System.Drawing.Point(306, 393);
            this.cmdGetEnrollInfo.Name = "cmdGetEnrollInfo";
            this.cmdGetEnrollInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetEnrollInfo.Size = new System.Drawing.Size(259, 39);
            this.cmdGetEnrollInfo.TabIndex = 65;
            this.cmdGetEnrollInfo.Text = "Get Enroll Info";
            this.cmdGetEnrollInfo.UseVisualStyleBackColor = false;
            this.cmdGetEnrollInfo.Click += new System.EventHandler(this.cmdGetEnrollInfo_Click);
            // 
            // lstEnrollData
            // 
            this.lstEnrollData.BackColor = System.Drawing.SystemColors.Window;
            this.lstEnrollData.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstEnrollData.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEnrollData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstEnrollData.HorizontalScrollbar = true;
            this.lstEnrollData.ItemHeight = 15;
            this.lstEnrollData.Location = new System.Drawing.Point(18, 242);
            this.lstEnrollData.Name = "lstEnrollData";
            this.lstEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstEnrollData.Size = new System.Drawing.Size(264, 379);
            this.lstEnrollData.TabIndex = 73;
            // 
            // lblEnrollNum
            // 
            this.lblEnrollNum.AutoSize = true;
            this.lblEnrollNum.BackColor = System.Drawing.SystemColors.Control;
            this.lblEnrollNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEnrollNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrollNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnrollNum.Location = new System.Drawing.Point(18, 76);
            this.lblEnrollNum.Name = "lblEnrollNum";
            this.lblEnrollNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnrollNum.Size = new System.Drawing.Size(105, 19);
            this.lblEnrollNum.TabIndex = 80;
            this.lblEnrollNum.Text = "Enroll Number :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(172, 212);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(50, 19);
            this.lblTotal.TabIndex = 77;
            this.lblTotal.Text = "Total : ";
            // 
            // lblPrivilege
            // 
            this.lblPrivilege.AutoSize = true;
            this.lblPrivilege.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrivilege.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrivilege.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivilege.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrivilege.Location = new System.Drawing.Point(18, 178);
            this.lblPrivilege.Name = "lblPrivilege";
            this.lblPrivilege.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrivilege.Size = new System.Drawing.Size(67, 19);
            this.lblPrivilege.TabIndex = 76;
            this.lblPrivilege.Text = "Privilege :";
            // 
            // lblEnrollData
            // 
            this.lblEnrollData.AutoSize = true;
            this.lblEnrollData.BackColor = System.Drawing.SystemColors.Control;
            this.lblEnrollData.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEnrollData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrollData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnrollData.Location = new System.Drawing.Point(18, 212);
            this.lblEnrollData.Name = "lblEnrollData";
            this.lblEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnrollData.Size = new System.Drawing.Size(99, 19);
            this.lblEnrollData.TabIndex = 74;
            this.lblEnrollData.Text = "Enrolled Data :";
            // 
            // lblBackupNumber
            // 
            this.lblBackupNumber.AutoSize = true;
            this.lblBackupNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblBackupNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBackupNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBackupNumber.Location = new System.Drawing.Point(18, 110);
            this.lblBackupNumber.Name = "lblBackupNumber";
            this.lblBackupNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBackupNumber.Size = new System.Drawing.Size(117, 19);
            this.lblBackupNumber.TabIndex = 72;
            this.lblBackupNumber.Text = "Backup Number :";
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(18, 16);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(547, 31);
            this.lblMessage.TabIndex = 75;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scbAdoScroll
            // 
            this.scbAdoScroll.LargeChange = 2;
            this.scbAdoScroll.Location = new System.Drawing.Point(23, 638);
            this.scbAdoScroll.Maximum = 1;
            this.scbAdoScroll.Name = "scbAdoScroll";
            this.scbAdoScroll.Size = new System.Drawing.Size(144, 32);
            this.scbAdoScroll.TabIndex = 82;
            this.scbAdoScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scbAdoScroll_Scroll);
            // 
            // cmdEnterEnroll
            // 
            this.cmdEnterEnroll.BackColor = System.Drawing.SystemColors.Control;
            this.cmdEnterEnroll.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdEnterEnroll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEnterEnroll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdEnterEnroll.Location = new System.Drawing.Point(306, 635);
            this.cmdEnterEnroll.Name = "cmdEnterEnroll";
            this.cmdEnterEnroll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdEnterEnroll.Size = new System.Drawing.Size(259, 39);
            this.cmdEnterEnroll.TabIndex = 84;
            this.cmdEnterEnroll.Text = "Enter Enroll";
            this.cmdEnterEnroll.UseVisualStyleBackColor = false;
            this.cmdEnterEnroll.Click += new System.EventHandler(this.cmdEnterEnroll_Click);
            // 
            // labelCardOrPwd
            // 
            this.labelCardOrPwd.AutoSize = true;
            this.labelCardOrPwd.BackColor = System.Drawing.SystemColors.Control;
            this.labelCardOrPwd.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelCardOrPwd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardOrPwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCardOrPwd.Location = new System.Drawing.Point(19, 144);
            this.labelCardOrPwd.Name = "labelCardOrPwd";
            this.labelCardOrPwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCardOrPwd.Size = new System.Drawing.Size(92, 19);
            this.labelCardOrPwd.TabIndex = 85;
            this.labelCardOrPwd.Text = "CardOrPwd :";
            // 
            // txtboxCardOrPwd
            // 
            this.txtboxCardOrPwd.AcceptsReturn = true;
            this.txtboxCardOrPwd.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxCardOrPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxCardOrPwd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCardOrPwd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtboxCardOrPwd.Location = new System.Drawing.Point(153, 143);
            this.txtboxCardOrPwd.MaxLength = 10;
            this.txtboxCardOrPwd.Name = "txtboxCardOrPwd";
            this.txtboxCardOrPwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtboxCardOrPwd.Size = new System.Drawing.Size(129, 26);
            this.txtboxCardOrPwd.TabIndex = 86;
            // 
            // frmEnroll
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(584, 693);
            this.Controls.Add(this.txtboxCardOrPwd);
            this.Controls.Add(this.labelCardOrPwd);
            this.Controls.Add(this.cmdEnterEnroll);
            this.Controls.Add(this.cmdUSBGetAllData);
            this.Controls.Add(this.lblDBCount);
            this.Controls.Add(this.txtEnrollNumber);
            this.Controls.Add(this.lblEnrollNum);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrivilege);
            this.Controls.Add(this.lblEnrollData);
            this.Controls.Add(this.lblBackupNumber);
            this.Controls.Add(this.cmdGetEnrollData);
            this.Controls.Add(this.cmdEmptyEnrollData);
            this.Controls.Add(this.cmdDisableUser);
            this.Controls.Add(this.cmbBackupNumber);
            this.Controls.Add(this.cmbPrivilege);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cmdClearData);
            this.Controls.Add(this.cmdSetEnrollData);
            this.Controls.Add(this.cmdDeleteEnrollData);
            this.Controls.Add(this.cmdModifyPrivilege);
            this.Controls.Add(this.cmdEnableUser);
            this.Controls.Add(this.cmdSetAllEnrollData);
            this.Controls.Add(this.cmdGetAllEnrollData);
            this.Controls.Add(this.cmdGetEnrollInfo);
            this.Controls.Add(this.lstEnrollData);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.scbAdoScroll);
            this.Controls.Add(this.cmdBenumbManager);
            this.Controls.Add(this.cmdUSBSetAllData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Enroll Data";
            this.Closed += new System.EventHandler(this.frmEnroll_Closed);
            this.Load += new System.EventHandler(this.frmEnroll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private bool mbGetState;
        private const int FP_DATA_SIZE = 1680;
        private const int FACE_DATA_SIZE = 20080;
        private const int PWD_DATA_SIZE = 40;
        private const int PALMVEIN_DATA_SIZE = 20080;
        private byte[] mbytCurEnrollData = new byte[FACE_DATA_SIZE];
        private int mnCurPassword = 0;

        private const string mcstrAdoConn = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=false;Data Source=";
        private ADODB.Connection mAdoConnEnroll = new ADODB.Connection();
        private ADODB.Recordset mAdoRstEnroll = new ADODB.Recordset();
        private ADODB.Recordset mAdoRstTmp = new ADODB.Recordset();
        private object[] mListBoxItemBackupNumber;
        private void frmEnroll_Load(object sender, System.EventArgs e)
        {
            string vstrDBPath;
            int vnii;

            mbGetState = false;
            mListBoxItemBackupNumber = new object[] {
                enumBackupNumberType.BACKUP_FP_0, "Fp-0",
                enumBackupNumberType.BACKUP_FP_1, "Fp-1",
                enumBackupNumberType.BACKUP_FP_2, "Fp-2",
                enumBackupNumberType.BACKUP_FP_3, "Fp-3",
                enumBackupNumberType.BACKUP_FP_4, "Fp-4",
                enumBackupNumberType.BACKUP_FP_5, "Fp-5",
                enumBackupNumberType.BACKUP_FP_6, "Fp-6",
                enumBackupNumberType.BACKUP_FP_7, "Fp-7",
                enumBackupNumberType.BACKUP_FP_8, "Fp-8",
                enumBackupNumberType.BACKUP_FP_9, "Fp-9",
                enumBackupNumberType.BACKUP_PSW, "Pass",
                enumBackupNumberType.BACKUP_CARD, "Card",
                enumBackupNumberType.BACKUP_FACE, "Face",
                enumBackupNumberType.BACKUP_PALMVEIN_0, "PmVein-0",
                enumBackupNumberType.BACKUP_PALMVEIN_1, "PmVein-1", 
                //enumBackupNumberType.BACKUP_PALMVEIN_2, "PmVein-2", 
                //enumBackupNumberType.BACKUP_PALMVEIN_3, "PmVein-3",
            };

            lblMessage.Text = "";
            txtEnrollNumber.Text = "1";

            cmbBackupNumber.Items.Clear();
            for (vnii = 1; vnii <= mListBoxItemBackupNumber.GetUpperBound(0); vnii += 2)
                cmbBackupNumber.Items.Add(mListBoxItemBackupNumber[vnii]);

            cmbBackupNumber.SelectedIndex = 0;

            labelCardOrPwd.Enabled = false;
            txtboxCardOrPwd.Enabled = false;

            cmbPrivilege.Items.Clear();
            cmbPrivilege.Items.Add("User");
            cmbPrivilege.Items.Add("Manager");
            cmbPrivilege.SelectedIndex = 0;

            lstEnrollData.Items.Clear();

            DBWithItemEnable(false);

            vstrDBPath = System.Windows.Forms.Application.StartupPath + "\\datEnrollDat.mdb";
            if (!File.Exists(vstrDBPath))
            {
                dlgOpen.InitialDirectory = System.Windows.Forms.Application.StartupPath;
                dlgOpen.Filter = "DB Files (*.mdb)|*.mdb|All Files (*.*)|*.*";
                dlgOpen.FilterIndex = 1;
                if (dlgOpen.ShowDialog() != DialogResult.OK) goto lbl_end;
                vstrDBPath = dlgOpen.FileName;
                dlgOpen.FileName = "";

            }

            frmEnroll_Closed(sender, e);

            mAdoConnEnroll.CommandTimeout = 300;
            mAdoConnEnroll.ConnectionTimeout = 300;                           // Set the time out.
            mAdoConnEnroll.ConnectionString = mcstrAdoConn + vstrDBPath;


            mAdoConnEnroll.Open("", "", "", -1);
            if (mAdoConnEnroll.State != (int)ADODB.ObjectStateEnum.adStateOpen)
                goto lbl_end;

            string vstrFind;
            object obj = new object();
            try
            {
                vstrFind = "ALTER TABLE tblEnroll ADD COLUMN StringEnrollID Text(20)";
                mAdoConnEnroll.Execute(vstrFind, out obj, 0);
            }
            catch (Exception ex)
            {
            }
            //mAdoConnEnroll.Open("ALTER TABLE Attendance ADD COLUMN SignIn", "", "", -1);
            mAdoRstEnroll.CacheSize = 1000;

            mAdoRstEnroll.CursorLocation = ADODB.CursorLocationEnum.adUseClient;



            mAdoRstEnroll.Open("select * from tblEnroll", mAdoConnEnroll, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic, -1);
            if (mAdoRstEnroll.State == (int)ADODB.ObjectStateEnum.adStateOpen)
                if (!mAdoRstEnroll.BOF) mAdoRstEnroll.MoveFirst();
            AdoEnroll_MoveComplete();

            mAdoRstTmp.CacheSize = 1000;
            mAdoRstTmp.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            DBWithItemEnable(true);
        lbl_end:
            if (frmMain.gfrmMain.OpenFlag == false)
                disableButtons();
            return;
        }

        private void frmEnroll_Closed(object sender, System.EventArgs e)
        {
            if (mAdoRstEnroll.State == (int)ADODB.ObjectStateEnum.adStateOpen)
                mAdoRstEnroll.Close();
            if (mAdoConnEnroll.State == (int)ADODB.ObjectStateEnum.adStateOpen)
                mAdoConnEnroll.Close();
        }

        private void scbAdoScroll_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            if (mAdoRstEnroll.RecordCount > 0)
            {
                switch (e.Type)
                {
                    case ScrollEventType.SmallDecrement:
                        if (!mAdoRstEnroll.BOF)
                        {
                            mAdoRstEnroll.MovePrevious();
                            if (mAdoRstEnroll.BOF) mAdoRstEnroll.MoveFirst();
                        }
                        break;
                    case ScrollEventType.SmallIncrement:
                        if (!mAdoRstEnroll.EOF)
                        {
                            mAdoRstEnroll.MoveNext();
                            if (mAdoRstEnroll.EOF) mAdoRstEnroll.MoveLast();
                        }
                        break;
                    default:
                        return;
                }
            }

            AdoEnroll_MoveComplete();
        }

        private void AdoEnroll_MoveComplete()
        {
            int vnPos;
            string vStrEnrollNumber = "";
            UInt32 vEnrollNumber = 0;
            string vEnrollName = "";
            int vBackupNumber = 0;
            int vPrivilege = (int)enumMachinePrivilege.MP_NONE;

            if (mbGetState == true) return;
            vnPos = Convert.ToInt32(mAdoRstEnroll.AbsolutePosition);
            if (vnPos < 0) vnPos = 0;
            lblDBCount.Text = "  " + vnPos + "/" + mAdoRstEnroll.RecordCount;
            if (mAdoRstEnroll.RecordCount > 0)
                readEnrollDataFromDB(ref vStrEnrollNumber, ref vEnrollNumber, ref vBackupNumber, ref vPrivilege, ref vEnrollName, true);
        }

        private void cmdDel_Click(object sender, System.EventArgs e)
        {
            cmdDel.Enabled = false;
            Application.DoEvents();
            if (mAdoRstTmp.State == (int)ADODB.ObjectStateEnum.adStateOpen) mAdoRstTmp.Close();
            mAdoRstTmp.Open("Delete From tblEnroll", mAdoConnEnroll, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic, -1);
            mAdoRstEnroll.Requery(-1);
            AdoEnroll_MoveComplete();
            cmdDel.Enabled = true;
        }

        private void zeroArray(byte[] aArray)
        {
            int i;
            for (i = 0; i < aArray.Length; i++)
                aArray[i] = 0;
        }



        private void cmdGetEnrollData_Click(object sender, System.EventArgs e)
        {
            int vnResultCode;
            string vStrEnrollNumber;
            UInt32 vEnrollNumber;
            int vBackupNumber;
            int vPrivilege = (int)enumMachinePrivilege.MP_ALL;

            cmdGetEnrollData.Enabled = false;
            lstEnrollData.Items.Clear();
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdGetEnrollData.Enabled = true;
                return;
            }
            vStrEnrollNumber = txtEnrollNumber.Text;
            vEnrollNumber = FKAttendDLL.GetInt(vStrEnrollNumber);
            vBackupNumber = getCurSelBackupNumberFromCombo();

            Array.Clear(mbytCurEnrollData, 0, mbytCurEnrollData.Length);


            int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
            if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
            {

                vnResultCode = FKAttendDLL.FK_GetEnrollData_StringID(
                    FKAttendDLL.nCommHandleIndex,
                    vStrEnrollNumber,
                    vBackupNumber,
                    ref vPrivilege,
                    mbytCurEnrollData,
                    ref mnCurPassword);
            }
            else
            {
                vnResultCode = FKAttendDLL.FK_GetEnrollData(
                    FKAttendDLL.nCommHandleIndex,
                    vEnrollNumber,
                    vBackupNumber,
                    ref vPrivilege,
                    mbytCurEnrollData,
                    ref mnCurPassword);
            }
            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
            {
                if (vPrivilege == (int)enumMachinePrivilege.MP_ALL)
                    cmbPrivilege.SelectedIndex = 1;
                else
                    cmbPrivilege.SelectedIndex = 0;

                showEnrollDataToListbox(vBackupNumber, mbytCurEnrollData);

                string cardorpwd = "";
                if (vBackupNumber == 10)
                {
                    cardorpwd = CardPwdReference.GetCardOrPwdWithStr(mbytCurEnrollData);
                    lblMessage.Text = "GetEnrollData OK;Pwd is " + cardorpwd;
                    EnabledCardorPwdComponet(true);
                    txtboxCardOrPwd.Text = cardorpwd;
                }
                else if (vBackupNumber == 11)
                {
                    cardorpwd = CardPwdReference.GetCardOrPwdWithStr(mbytCurEnrollData);
                    lblMessage.Text = "GetEnrollData OK;Card is " + cardorpwd;
                    EnabledCardorPwdComponet(true);
                    txtboxCardOrPwd.Text = cardorpwd;
                }
                else
                {
                    lblMessage.Text = "GetEnrollData OK";
                }
            }
            else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdGetEnrollData.Enabled = true;
        }

        private void cmdSetEnrollData_Click(object sender, System.EventArgs e)
        {
            string vStrEnrollNumber;
            UInt32 vEnrollNumber;
            int vBackupNumber = 0;
            int vPrivilege;
            int vnResultCode;

            cmdSetEnrollData.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vStrEnrollNumber = txtEnrollNumber.Text;
            vEnrollNumber = FKAttendDLL.GetInt(vStrEnrollNumber);

            vBackupNumber = getCurSelBackupNumberFromCombo();
            if (vBackupNumber == 10)
            {
                EnabledCardorPwdComponet(true);
                mbytCurEnrollData = CardPwdReference.getPWD(txtboxCardOrPwd.Text);
                showEnrollDataToListbox(vBackupNumber, mbytCurEnrollData);
            }
            if (vBackupNumber == 11)
            {
                EnabledCardorPwdComponet(true);
                mbytCurEnrollData = CardPwdReference.getCard(txtboxCardOrPwd.Text);
                showEnrollDataToListbox(vBackupNumber, mbytCurEnrollData);
            }

            if (cmbPrivilege.SelectedIndex == 1)
                vPrivilege = (int)enumMachinePrivilege.MP_ALL;
            else
                vPrivilege = (int)enumMachinePrivilege.MP_NONE;

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdSetEnrollData.Enabled = true;
                return;
            }

            int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
            if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
            {

                vnResultCode = FKAttendDLL.FK_PutEnrollData_StringID(
                    FKAttendDLL.nCommHandleIndex,
                    vStrEnrollNumber,
                    vBackupNumber,
                    vPrivilege,
                    mbytCurEnrollData,
                    mnCurPassword);
            }
            else
            {
                vnResultCode = FKAttendDLL.FK_PutEnrollData(
                   FKAttendDLL.nCommHandleIndex,
                   vEnrollNumber,
                   vBackupNumber,
                   vPrivilege,
                   mbytCurEnrollData,
                   mnCurPassword);
            }



            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = "Saving...";
                Application.DoEvents();
                vnResultCode = FKAttendDLL.FK_SaveEnrollData(FKAttendDLL.nCommHandleIndex);
                if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
                    lblMessage.Text = "SetEnrollData OK";
            }

            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdSetEnrollData.Enabled = true;
        }

        private void cmdDeleteEnrollData_Click(object sender, System.EventArgs e)
        {
            string vStrEnrollNumber;
            UInt32 vEnrollNumber;
            int vBackupNumber;
            int vnResultCode;

            cmdDeleteEnrollData.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdDeleteEnrollData.Enabled = true;
                return;
            }

            vStrEnrollNumber = txtEnrollNumber.Text;
            vEnrollNumber = FKAttendDLL.GetInt(vStrEnrollNumber);

            vBackupNumber = getCurSelBackupNumberFromCombo();

            int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
            if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
            {
                vnResultCode = FKAttendDLL.FK_DeleteEnrollData_StringID(FKAttendDLL.nCommHandleIndex, vStrEnrollNumber, vBackupNumber);
            }
            else
            {
                vnResultCode = FKAttendDLL.FK_DeleteEnrollData(FKAttendDLL.nCommHandleIndex, vEnrollNumber, vBackupNumber);
            }
            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
                lblMessage.Text = "DeleteEnrollData OK";
            else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdDeleteEnrollData.Enabled = true;
        }

        private void cmdGetAllEnrollData_Click(object sender, System.EventArgs e)
        {
            int vnResultCode;
            UInt32 vEnrollNumber = 0;
            int vBackupNumber = 0;
            string vStrEnrollNumber;
            string vEnrollName;
            int vPrivilege = (int)enumMachinePrivilege.MP_NONE;
            int vnEnableFlag = 0;
            DialogResult vnMessRet;
            string vTitle;

            cmdGetAllEnrollData.Enabled = false;
            lstEnrollData.Items.Clear();
            vTitle = this.Text;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdGetAllEnrollData.Enabled = true; ;
                return;
            }

            vnResultCode = FKAttendDLL.FK_ReadAllUserID(FKAttendDLL.nCommHandleIndex);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
                FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
                cmdGetAllEnrollData.Enabled = true;
                return;
            }

            //---- Get Enroll data and save into database -------------
            Cursor = Cursors.WaitCursor;



            mbGetState = true;

            int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
            if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
            {
                do
                {
                    vEnrollName = new string((char)0x20, 256);
                    if (vnResultSupportStringID == FKAttendDLL.USER_ID_LENGTH13_1)
                        vStrEnrollNumber = new string((char)0x20, FKAttendDLL.USER_ID_LENGTH13_1);
                    else
                        vStrEnrollNumber = new string((char)0x20, FKAttendDLL.USER_ID_LENGTH);
                    //vStrEnrollNumber = "";
                    lbl_GetNext_String_ID:
                    vnResultCode = FKAttendDLL.FK_GetAllUserID_StringID(
                        FKAttendDLL.nCommHandleIndex,
                        ref vStrEnrollNumber,
                        ref vBackupNumber,
                        ref vPrivilege,
                        ref vnEnableFlag);
                    if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
                    {
                        if (vnResultCode == (int)enumErrorCode.RUNERR_DATAARRAY_END)
                            vnResultCode = (int)enumErrorCode.RUN_SUCCESS;
                        break;
                    }

                    vStrEnrollNumber = vStrEnrollNumber.Trim();
                lbl_Retry_String_ID:
                    vnResultCode = FKAttendDLL.FK_GetEnrollData_StringID(
                        FKAttendDLL.nCommHandleIndex,
                        vStrEnrollNumber,
                        vBackupNumber,
                        ref vPrivilege,
                        mbytCurEnrollData,
                        ref mnCurPassword);

                    if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
                    {
                        vnMessRet = MessageBox.Show(
                            FKAttendDLL.ReturnResultPrint(vnResultCode) + ": Retry (y) / Get Next (n) ?",
                            "GetEnrollData",
                            MessageBoxButtons.YesNoCancel);
                        if (vnMessRet == DialogResult.Yes)
                            goto lbl_Retry_String_ID;
                        else if (vnMessRet == DialogResult.No)
                            goto lbl_GetNext_String_ID;
                        else if (vnMessRet == DialogResult.Cancel)
                            break;

                    }

                    saveEnrollDataToDB(
                        vStrEnrollNumber,
                        0,
                        vBackupNumber,
                        vPrivilege,
                        vEnrollName);
                    this.Text = vStrEnrollNumber;
                    vStrEnrollNumber = null;
                    Application.DoEvents();
                }
                while (true);

            }
            else
            {
                do
                {
                    vEnrollName = new string((char)0x20, 256);
                lbl_GetNext:
                    vnResultCode = FKAttendDLL.FK_GetAllUserID(
                        FKAttendDLL.nCommHandleIndex,
                        ref vEnrollNumber,
                        ref vBackupNumber,
                        ref vPrivilege,
                        ref vnEnableFlag);
                    if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
                    {
                        if (vnResultCode == (int)enumErrorCode.RUNERR_DATAARRAY_END)
                            vnResultCode = (int)enumErrorCode.RUN_SUCCESS;
                        break;
                    }
                lbl_Retry:
                    vnResultCode = FKAttendDLL.FK_GetEnrollData(
                        FKAttendDLL.nCommHandleIndex,
                        vEnrollNumber,
                        vBackupNumber,
                        ref vPrivilege,
                        mbytCurEnrollData,
                        ref mnCurPassword);

                    if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
                    {
                        vnMessRet = MessageBox.Show(
                            FKAttendDLL.ReturnResultPrint(vnResultCode) + ": Retry (y) / Get Next (n) ?",
                            "GetEnrollData",
                            MessageBoxButtons.YesNoCancel);
                        if (vnMessRet == DialogResult.Yes)
                            goto lbl_Retry;
                        else if (vnMessRet == DialogResult.No)
                            goto lbl_GetNext;
                        else if (vnMessRet == DialogResult.Cancel)
                            break;

                    }

                    saveEnrollDataToDB(
                        "",
                        (UInt32)vEnrollNumber,
                        vBackupNumber,
                        vPrivilege,
                        vEnrollName);
                    this.Text = vEnrollNumber.ToString("0000#");
                    Application.DoEvents();
                }
                while (true);
            }
            mbGetState = false;
            Application.DoEvents();

            if (mAdoRstEnroll.RecordCount > 1)
            {
                mAdoRstEnroll.MoveFirst();
                mAdoRstEnroll.MoveLast();
            }

            this.Text = vTitle;
            Cursor = Cursors.Default;

            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
                lblMessage.Text = "GetAllEnrollData OK";
            else
                lblMessage.Text = "GetAllEnrollData Error : " + FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdGetAllEnrollData.Enabled = true;
        }

        private void cmdSetAllEnrollData_Click(object sender, System.EventArgs e)
        {
            int vnResultCode;
            UInt32 vEnrollNumber = 0;
            string vStrEnrollNumber = "";
            string vEnrollName = "";
            int vBackupNumber = 0;
            int vPrivilege = (int)enumMachinePrivilege.MP_NONE;
            int vnIsSuppoterd;
            DialogResult vnMessRet;
            string vStr = "";
            string vTitle;
            bool vbRet;

            cmdSetAllEnrollData.Enabled = false;
            lstEnrollData.Items.Clear();
            vTitle = this.Text;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdSetAllEnrollData.Enabled = true;
                return;
            }

            mbGetState = true;
            Cursor = Cursors.WaitCursor;

            int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
            if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
            {
                if (mAdoRstEnroll.RecordCount > 0)
                {
                    mAdoRstEnroll.MoveLast();
                    mAdoRstEnroll.MoveFirst();
                    do
                    {
                    lbl_Retry_StringID:
                        vbRet = readEnrollDataFromDB(
                            ref vStrEnrollNumber,
                            ref vEnrollNumber,
                            ref vBackupNumber,
                            ref vPrivilege,
                            ref vEnrollName,
                            false);
                        if (vbRet != true)
                        {
                            vStr = "SetAllEnrollData Error";
                            break;
                        }

                        vnIsSuppoterd = 0;
                        FKAttendDLL.FK_IsSupportedEnrollData(FKAttendDLL.nCommHandleIndex, vBackupNumber, ref vnIsSuppoterd);
                        if (vnIsSuppoterd == 0)
                        {
                            mAdoRstEnroll.MoveNext();
                            if (mAdoRstEnroll.EOF == true)
                                break;
                            else
                                goto lbl_Retry_StringID;
                        }

                        vnResultCode = FKAttendDLL.FK_PutEnrollData_StringID(
                            FKAttendDLL.nCommHandleIndex,
                            vStrEnrollNumber,
                            vBackupNumber,
                            vPrivilege,
                            mbytCurEnrollData,
                            mnCurPassword);
                        if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
                        {
                            vStr = "SetAllEnrollData Error";
                            vnMessRet = MessageBox.Show(
                                FKAttendDLL.ReturnResultPrint(vnResultCode) + ": Retry (y) / Move Next (n) ?",
                                "SetEnrollData",
                                MessageBoxButtons.YesNoCancel);
                            if (vnMessRet == DialogResult.Yes)
                                goto lbl_Retry_StringID;
                            if (vnMessRet == DialogResult.Cancel)
                                break;
                        }
                        lblMessage.Text = "ID = " + vStrEnrollNumber + ", FpNo = " + vBackupNumber + ", Count = " + mAdoRstEnroll.AbsolutePosition;

                        this.Text = mAdoRstEnroll.AbsolutePosition.ToString().Trim();
                        mAdoRstEnroll.MoveNext();
                        Application.DoEvents();
                    }
                    while (mAdoRstEnroll.EOF == false);

                }
            }
            else
            {
                if (mAdoRstEnroll.RecordCount > 0)
                {
                    mAdoRstEnroll.MoveLast();
                    mAdoRstEnroll.MoveFirst();
                    do
                    {
                    lbl_Retry:
                        vbRet = readEnrollDataFromDB(
                            ref vStrEnrollNumber,
                            ref vEnrollNumber,
                            ref vBackupNumber,
                            ref vPrivilege,
                            ref vEnrollName,
                            false);
                        if (vbRet != true)
                        {
                            vStr = "SetAllEnrollData Error";
                            break;
                        }

                        vnIsSuppoterd = 0;
                        FKAttendDLL.FK_IsSupportedEnrollData(FKAttendDLL.nCommHandleIndex, vBackupNumber, ref vnIsSuppoterd);
                        if (vnIsSuppoterd == 0)
                        {
                            mAdoRstEnroll.MoveNext();
                            if (mAdoRstEnroll.EOF == true)
                                break;
                            else
                                goto lbl_Retry;
                        }

                        vnResultCode = FKAttendDLL.FK_PutEnrollData(
                            FKAttendDLL.nCommHandleIndex,
                            vEnrollNumber,
                            vBackupNumber,
                            vPrivilege,
                            mbytCurEnrollData,
                            mnCurPassword);
                        if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
                        {
                            vStr = "SetAllEnrollData Error";
                            vnMessRet = MessageBox.Show(
                                FKAttendDLL.ReturnResultPrint(vnResultCode) + ": Retry (y) / Move Next (n) ?",
                                "SetEnrollData",
                                MessageBoxButtons.YesNoCancel);
                            if (vnMessRet == DialogResult.Yes)
                                goto lbl_Retry;
                            if (vnMessRet == DialogResult.Cancel)
                                break;
                        }
                        lblMessage.Text = "ID = " + vEnrollNumber.ToString("000#") + ", FpNo = " + vBackupNumber + ", Count = " + mAdoRstEnroll.AbsolutePosition;

                        this.Text = mAdoRstEnroll.AbsolutePosition.ToString().Trim();
                        mAdoRstEnroll.MoveNext();
                        Application.DoEvents();
                    }
                    while (mAdoRstEnroll.EOF == false);

                }
            }
            this.Text = vTitle;
            Cursor = Cursors.Default;
            mbGetState = false;

            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = "Saving...";
                Application.DoEvents();
                vnResultCode = FKAttendDLL.FK_SaveEnrollData(FKAttendDLL.nCommHandleIndex);
                if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
                    lblMessage.Text = "SetAllEnrollData OK";
                else
                    lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
            }
            else
                lblMessage.Text = vStr + " : " + FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdSetAllEnrollData.Enabled = true;
        }

        private void cmdUSBGetAllData_Click(object sender, System.EventArgs e)
        {
            int vnResultCode = 0;
            UInt32 vEnrollNumber = 0;
            string vStrEnrollNumber;
            string vEnrollName;
            int vBackupNumber = 0;
            int vPrivilege = (int)enumMachinePrivilege.MP_NONE;
            int vnEnableFlag = 0;
            string vTitle;
            string vstrFileName;

            dlgOpen.InitialDirectory = Directory.GetCurrentDirectory();
            dlgOpen.Filter = "DAT Files (*.dat)|*.dat|All Files (*.*)|*.*";
            dlgOpen.FilterIndex = 1;
            if (dlgOpen.ShowDialog() != DialogResult.OK)
                return;

            vstrFileName = dlgOpen.FileName;
            dlgOpen.FileName = "";

            cmdUSBGetAllData.Enabled = false;
            lstEnrollData.Items.Clear();
            vTitle = this.Text;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            frmSelectFKFirmwareVer vFrmSelectFKFirmwareVer = new frmSelectFKFirmwareVer();
            vFrmSelectFKFirmwareVer.ShowDialog();
            vnResultCode = FKAttendDLL.FK_SetUDiskFileFKModel(FKAttendDLL.nCommHandleIndex, vFrmSelectFKFirmwareVer.FKFirmware);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
                cmdUSBGetAllData.Enabled = true;
                return;
            }

            vnResultCode = FKAttendDLL.FK_USBReadAllEnrollDataFromFile(
                FKAttendDLL.nCommHandleIndex, vstrFileName);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
                cmdUSBGetAllData.Enabled = true;
                return;
            }
            //---- Get Enroll data and save into database -------------
            Cursor = Cursors.WaitCursor;

            mbGetState = true;
            int vnResultSupportStringID = FKAttendDLL.FK_GetUSBEnrollDataIsSupportStringID(FKAttendDLL.nCommHandleIndex);
            if (vnResultSupportStringID == FKAttendDLL.USER_ID_LENGTH13_1)
            {
                do
                {
                    vEnrollName = new string((char)0x20, 256);
                    vStrEnrollNumber = new string((char)0x20, FKAttendDLL.USER_ID_LENGTH13_1);
                    vnResultCode = FKAttendDLL.FK_USBGetOneEnrollData_StringID(
                        FKAttendDLL.nCommHandleIndex,
                        ref vStrEnrollNumber,
                        ref vBackupNumber,
                        ref vPrivilege,
                        mbytCurEnrollData,
                        ref mnCurPassword,
                        ref vnEnableFlag,
                        ref vEnrollName);


                    if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
                    {
                        if (vnResultCode == (int)enumErrorCode.RUNERR_DATAARRAY_END)
                            vnResultCode = (int)enumErrorCode.RUN_SUCCESS;
                        break;
                    }

                    vStrEnrollNumber.Trim();

                    saveEnrollDataToDB(
                        vStrEnrollNumber,
                        0,
                        vBackupNumber,
                        vPrivilege,
                        vEnrollName);

                    this.Text = vStrEnrollNumber;
                    Application.DoEvents();
                    vStrEnrollNumber = null;
                }
                while (true);
            }
            else if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
            {
                do
                {
                    vEnrollName = new string((char)0x20, 256);
                    vStrEnrollNumber = new string((char)0x20, FKAttendDLL.USER_ID_LENGTH);
                    vnResultCode = FKAttendDLL.FK_USBGetOneEnrollData_StringID(
                        FKAttendDLL.nCommHandleIndex,
                        ref vStrEnrollNumber,
                        ref vBackupNumber,
                        ref vPrivilege,
                        mbytCurEnrollData,
                        ref mnCurPassword,
                        ref vnEnableFlag,
                        ref vEnrollName);


                    if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
                    {
                        if (vnResultCode == (int)enumErrorCode.RUNERR_DATAARRAY_END)
                            vnResultCode = (int)enumErrorCode.RUN_SUCCESS;
                        break;
                    }

                    vStrEnrollNumber.Trim();

                    saveEnrollDataToDB(
                        vStrEnrollNumber,
                        0,
                        vBackupNumber,
                        vPrivilege,
                        vEnrollName);

                    this.Text = vStrEnrollNumber;
                    Application.DoEvents();
                    vStrEnrollNumber = null;
                }
                while (true);
            }
            else
            {
                do
                {
                    vEnrollName = new string((char)0x20, 256);

                    vnResultCode = FKAttendDLL.FK_USBGetOneEnrollData(
                        FKAttendDLL.nCommHandleIndex,
                        ref vEnrollNumber,
                        ref vBackupNumber,
                        ref vPrivilege,
                        mbytCurEnrollData,
                        ref mnCurPassword,
                        ref vnEnableFlag,
                        ref vEnrollName);
                    if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
                    {
                        if (vnResultCode == (int)enumErrorCode.RUNERR_DATAARRAY_END)
                            vnResultCode = (int)enumErrorCode.RUN_SUCCESS;
                        break;
                    }

                    saveEnrollDataToDB(
                        "",
                        (UInt32)vEnrollNumber,
                        vBackupNumber,
                        vPrivilege,
                        vEnrollName);

                    this.Text = vEnrollNumber.ToString("0000#");
                    Application.DoEvents();
                }
                while (true);
            }
            mbGetState = false;
            Application.DoEvents();
            if (mAdoRstEnroll.RecordCount > 1)
            {
                mAdoRstEnroll.MoveFirst();
                mAdoRstEnroll.MoveLast();
            }

            this.Text = vTitle;
            Cursor = Cursors.Default;

            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
                lblMessage.Text = "GetAllEnrollData(USB) OK";
            else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
            cmdUSBGetAllData.Enabled = true;
        }

        private void cmdUSBSetAllData_Click(object sender, System.EventArgs e)
        {
            UInt32 vEnrollNumber = 0;
            string vStrEnrollNumber = "";
            string vEnrollName = "";
            int vBackupNumber = 0;
            int vPrivilege = (int)enumMachinePrivilege.MP_NONE;
            DialogResult vnMessRet;
            string vstrMess;
            string vTitle;
            string vstrFileName;
            int vnEnableFlag;
            int vnResultCode = 0;
            bool vbRet;

            lstEnrollData.Items.Clear();

            vstrMess = "";
            dlgSave.InitialDirectory = Directory.GetCurrentDirectory();
            dlgSave.Filter = "DAT Files (*.dat)|*.dat|All Files (*.*)|*.*";
            dlgSave.FilterIndex = 1;
            if (dlgSave.ShowDialog() != DialogResult.OK)
                return;

            vstrFileName = dlgSave.FileName;
            dlgSave.FileName = "";

            cmdUSBSetAllData.Enabled = false;
            vTitle = this.Text;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            frmSelectFKFirmwareVer vFrmSelectFKFirmwareVer = new frmSelectFKFirmwareVer();
            vFrmSelectFKFirmwareVer.ShowDialog();
            vnResultCode = FKAttendDLL.FK_SetUDiskFileFKModel(FKAttendDLL.nCommHandleIndex, vFrmSelectFKFirmwareVer.FKFirmware);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
                cmdUSBSetAllData.Enabled = true;
                return;
            }

            mbGetState = true;
            Cursor = Cursors.WaitCursor;

            if (mAdoRstEnroll.RecordCount > 0)
            {
                mAdoRstEnroll.MoveLast();
                mAdoRstEnroll.MoveFirst();
                int vnResultSupportStringID = FKAttendDLL.FK_GetUSBEnrollDataIsSupportStringID(FKAttendDLL.nCommHandleIndex);
                if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
                {
                    do
                    {
                        vEnrollName = new string((char)0x20, 256);
                    lbl_Retry_String_ID:
                        vbRet = readEnrollDataFromDB(
                            ref vStrEnrollNumber,
                            ref vEnrollNumber,
                            ref vBackupNumber,
                            ref vPrivilege,
                            ref vEnrollName,
                            false);
                        if (vbRet != true)
                        {
                            vstrMess = "SetAllEnrollData(USB) Error";
                            break;
                        }

                        vnEnableFlag = 1;
                        vnResultCode = FKAttendDLL.FK_USBSetOneEnrollData_StringID(
                            FKAttendDLL.nCommHandleIndex,
                            vStrEnrollNumber,
                            vBackupNumber,
                            vPrivilege,
                            mbytCurEnrollData,
                            mnCurPassword,
                            vnEnableFlag,
                            vEnrollName);
                        if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
                        {
                            if (vnResultCode == (int)enumErrorCode.RUNERR_NOSUPPORT)   //when backup_number is not supported
                            {
                                mAdoRstEnroll.MoveNext();
                                if (mAdoRstEnroll.EOF == true)
                                    break;
                                else
                                    goto lbl_Retry_String_ID;
                            }

                            vstrMess = "USBSetOneEnrollData Error";
                            vnMessRet = MessageBox.Show(
                                FKAttendDLL.ReturnResultPrint(vnResultCode) + ": Retry (y) / Move Next (n) ?",
                                vstrMess,
                                MessageBoxButtons.YesNoCancel);
                            if (vnMessRet == DialogResult.Yes)
                                goto lbl_Retry_String_ID;
                            if (vnMessRet == DialogResult.Cancel)
                                break;
                        }

                        lblMessage.Text = "ID = " + vStrEnrollNumber + ", FpNo = " +
                            vBackupNumber + ", Count = " + mAdoRstEnroll.AbsolutePosition;

                        this.Text = mAdoRstEnroll.AbsolutePosition.ToString().Trim();
                        Application.DoEvents();
                        mAdoRstEnroll.MoveNext();
                    } while (mAdoRstEnroll.EOF == false);
                }
                else
                {

                    do
                    {
                        vEnrollName = new string((char)0x20, 256);
                    lbl_Retry:
                        vbRet = readEnrollDataFromDB(
                            ref vStrEnrollNumber,
                            ref vEnrollNumber,
                            ref vBackupNumber,
                            ref vPrivilege,
                            ref vEnrollName,
                            false);
                        if (vbRet != true)
                        {
                            vstrMess = "SetAllEnrollData(USB) Error";
                            break;
                        }

                        vnEnableFlag = 1;
                        vnResultCode = FKAttendDLL.FK_USBSetOneEnrollData(
                            FKAttendDLL.nCommHandleIndex,
                            vEnrollNumber,
                            vBackupNumber,
                            vPrivilege,
                            mbytCurEnrollData,
                            mnCurPassword,
                            vnEnableFlag,
                            vEnrollName);
                        if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
                        {
                            if (vnResultCode == (int)enumErrorCode.RUNERR_NOSUPPORT)   //when backup_number is not supported
                            {
                                mAdoRstEnroll.MoveNext();
                                if (mAdoRstEnroll.EOF == true)
                                    break;
                                else
                                    goto lbl_Retry;
                            }

                            vstrMess = "USBSetOneEnrollData Error";
                            vnMessRet = MessageBox.Show(
                                FKAttendDLL.ReturnResultPrint(vnResultCode) + ": Retry (y) / Move Next (n) ?",
                                vstrMess,
                                MessageBoxButtons.YesNoCancel);
                            if (vnMessRet == DialogResult.Yes)
                                goto lbl_Retry;
                            if (vnMessRet == DialogResult.Cancel)
                                break;
                        }

                        lblMessage.Text = "ID = " + vEnrollNumber.ToString("000#") + ", FpNo = " +
                            vBackupNumber + ", Count = " + mAdoRstEnroll.AbsolutePosition;

                        this.Text = mAdoRstEnroll.AbsolutePosition.ToString().Trim();
                        Application.DoEvents();
                        mAdoRstEnroll.MoveNext();
                    } while (mAdoRstEnroll.EOF == false);
                }
            }

            this.Text = vTitle;
            Cursor = Cursors.Default;
            mbGetState = false;

            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
            {
                vnResultCode = FKAttendDLL.FK_USBWriteAllEnrollDataToFile(FKAttendDLL.nCommHandleIndex, vstrFileName);
                if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
                    lblMessage.Text = "USBWriteAllEnrollDataToFile OK";
                else
                    lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
            }
            else
                lblMessage.Text = vstrMess;

            cmdUSBSetAllData.Enabled = true;
        }

        private void cmdGetEnrollInfo_Click(object sender, System.EventArgs e)
        {
            UInt32 vEnrollNumber = 0;
            string vStrEnrollNumber = "";
            int vBackupNumber = 0;
            string vstrBackupNumber;
            int vPrivilege = (int)enumMachinePrivilege.MP_NONE;
            string vstrPrivilege;
            int vnEnableFlag = 0;
            string vstrEnableFlag;
            int vnii;
            int vnResultCode;

            cmdGetEnrollInfo.Enabled = false;
            lblEnrollData.Text = "User IDs";
            lstEnrollData.Items.Clear();
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdGetEnrollInfo.Enabled = true;
                return;
            }

            vnResultCode = FKAttendDLL.FK_ReadAllUserID(FKAttendDLL.nCommHandleIndex);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
                FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
                cmdGetEnrollInfo.Enabled = true;
                return;
            }

            int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
            if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
            {
                vnii = 0;
                lstEnrollData.Items.Add(" No.         EnNo           Fp        Priv   Enable");
                do
                {
                    vnResultCode = FKAttendDLL.FK_GetAllUserID_StringID(FKAttendDLL.nCommHandleIndex, ref vStrEnrollNumber, ref vBackupNumber, ref vPrivilege, ref vnEnableFlag);
                    if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
                    {
                        if (vnResultCode == (int)enumErrorCode.RUNERR_DATAARRAY_END)
                            vnResultCode = (int)enumErrorCode.RUN_SUCCESS;
                        break;
                    }

                    if (vPrivilege == (int)enumMachinePrivilege.MP_ALL)
                        vstrPrivilege = "Man";
                    else
                        vstrPrivilege = "User";
                    vstrBackupNumber = FuncStringFromBackupNumber(vBackupNumber);

                    if (vnEnableFlag == 1)
                        vstrEnableFlag = "E";
                    else
                        vstrEnableFlag = "D";

                    lstEnrollData.Items.Add(vnii.ToString("000#") + "    " + vStrEnrollNumber + "      " +
                        vstrBackupNumber + "     " + vstrPrivilege + "       " + vstrEnableFlag);

                    vnii = vnii + 1;
                    lblTotal.Text = "Total : " + vnii;
                    Application.DoEvents();
                } while (true);
            }
            else
            {
                //------ Show all enroll information ----------
                vnii = 0;
                lstEnrollData.Items.Add(" No.         EnNo           Fp        Priv   Enable");
                do
                {
                    vnResultCode = FKAttendDLL.FK_GetAllUserID(FKAttendDLL.nCommHandleIndex, ref vEnrollNumber, ref vBackupNumber, ref vPrivilege, ref vnEnableFlag);
                    if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
                    {
                        if (vnResultCode == (int)enumErrorCode.RUNERR_DATAARRAY_END)
                            vnResultCode = (int)enumErrorCode.RUN_SUCCESS;
                        break;
                    }

                    if (vPrivilege == (int)enumMachinePrivilege.MP_ALL)
                        vstrPrivilege = "Man";
                    else
                        vstrPrivilege = "User";
                    vstrBackupNumber = FuncStringFromBackupNumber(vBackupNumber);

                    if (vnEnableFlag == 1)
                        vstrEnableFlag = "E";
                    else
                        vstrEnableFlag = "D";


                    lstEnrollData.Items.Add(vnii.ToString("000#") + "    " + ((UInt32)vEnrollNumber).ToString("0000000#") + "      " +
                        vstrBackupNumber + "     " + vstrPrivilege + "       " + vstrEnableFlag);

                    vnii = vnii + 1;
                    lblTotal.Text = "Total : " + vnii;
                    Application.DoEvents();
                }
                while (true);
            }
            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
                lblMessage.Text = "GetEnrollInfo OK";
            else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdGetEnrollInfo.Enabled = true;
        }

        private void FuncSetUserEnableStatus(int abEnableFlag)
        {
            string vStrEnrollNumber = "";
            UInt32 vEnrollNumber;
            int vBackupNumber;
            int vnResultCode;

            lblMessage.Text = "Working...";
            Application.DoEvents();

            vStrEnrollNumber = txtEnrollNumber.Text;
            vEnrollNumber = FKAttendDLL.GetInt(vStrEnrollNumber);
            vBackupNumber = getCurSelBackupNumberFromCombo();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                return;
            }

            int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
            if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
            {
                vnResultCode = FKAttendDLL.FK_EnableUser_StringID(FKAttendDLL.nCommHandleIndex, vStrEnrollNumber, vBackupNumber, abEnableFlag);
            }
            else
            {
                vnResultCode = FKAttendDLL.FK_EnableUser(FKAttendDLL.nCommHandleIndex, vEnrollNumber, vBackupNumber, abEnableFlag);
            }

            lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
        }
        private void cmdEnableUser_Click(object sender, System.EventArgs e)
        {
            cmdEnableUser.Enabled = false;
            FuncSetUserEnableStatus(1);
            cmdEnableUser.Enabled = true;
        }

        private void cmdDisableUser_Click(object sender, System.EventArgs e)
        {
            cmdDisableUser.Enabled = false;
            FuncSetUserEnableStatus(0);
            cmdDisableUser.Enabled = true;
        }

        private void cmdModifyPrivilege_Click(object sender, System.EventArgs e)
        {
            string vStrEnrollNumber;
            UInt32 vEnrollNumber;
            int vBackupNumber;
            int vPrivilege;
            int vnResultCode;

            cmdModifyPrivilege.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vStrEnrollNumber = txtEnrollNumber.Text;
            vEnrollNumber = FKAttendDLL.GetInt(vStrEnrollNumber);
            vBackupNumber = getCurSelBackupNumberFromCombo();
            if (cmbPrivilege.SelectedIndex == 1)
                vPrivilege = (int)enumMachinePrivilege.MP_ALL;
            else
                vPrivilege = (int)enumMachinePrivilege.MP_NONE;

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdModifyPrivilege.Enabled = true;
                return;
            }

            int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
            if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
            {
                vnResultCode = FKAttendDLL.FK_ModifyPrivilege_StringID(FKAttendDLL.nCommHandleIndex, vStrEnrollNumber, vBackupNumber, vPrivilege);
            }
            else
            {
                vnResultCode = FKAttendDLL.FK_ModifyPrivilege(FKAttendDLL.nCommHandleIndex, vEnrollNumber, vBackupNumber, vPrivilege);
            }
            lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdModifyPrivilege.Enabled = true;
        }

        private void cmdBenumbManager_Click(object sender, System.EventArgs e)
        {
            long vnResultCode;

            cmdBenumbManager.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdBenumbManager.Enabled = true;
                return;
            }

            vnResultCode = FKAttendDLL.FK_BenumbAllManager(FKAttendDLL.nCommHandleIndex);
            lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdBenumbManager.Enabled = true;
        }

        private void cmdEmptyEnrollData_Click(object sender, System.EventArgs e)
        {
            int vnResultCode;

            cmdEmptyEnrollData.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdEmptyEnrollData.Enabled = true;
                return;
            }

            vnResultCode = FKAttendDLL.FK_EmptyEnrollData(FKAttendDLL.nCommHandleIndex);
            lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdEmptyEnrollData.Enabled = true;
        }

        private void cmdClearData_Click(object sender, System.EventArgs e)
        {
            int vnResultCode;

            cmdClearData.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdClearData.Enabled = true;
                return;
            }

            vnResultCode = FKAttendDLL.FK_ClearKeeperData(FKAttendDLL.nCommHandleIndex);
            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
                lblMessage.Text = "ClearKeeperData OK";
            else
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdClearData.Enabled = true;
        }

        private void DBWithItemEnable(bool abEnableFlag)
        {
            scbAdoScroll.Enabled = abEnableFlag;
            lblDBCount.Enabled = abEnableFlag;
            cmdDel.Enabled = abEnableFlag;
            cmdGetAllEnrollData.Enabled = abEnableFlag;
            cmdSetAllEnrollData.Enabled = abEnableFlag;
            cmdUSBGetAllData.Enabled = abEnableFlag;
            cmdUSBSetAllData.Enabled = abEnableFlag;
        }

        private void disableButtons()
        {
            cmdGetEnrollData.Enabled = false;
            cmdSetEnrollData.Enabled = false;
            cmdDeleteEnrollData.Enabled = false;
            cmdGetAllEnrollData.Enabled = false;
            cmdSetAllEnrollData.Enabled = false;
            cmdGetEnrollInfo.Enabled = false;
            cmdEnableUser.Enabled = false;
            cmdDisableUser.Enabled = false;
            cmdModifyPrivilege.Enabled = false;
            cmdBenumbManager.Enabled = false;
            cmdClearData.Enabled = false;
            cmdEmptyEnrollData.Enabled = false;
            cmdEnterEnroll.Enabled = false;
        }

        private void showByteArrayToListbox(ref ListBox aListBox, byte[] abytArray, uint aLenToShow)
        {
            int i, k;
            int len;
            string strItem;

            aListBox.Items.Clear();

            len = (int)aLenToShow;
            if (len > abytArray.Length)
                len = abytArray.Length;
            for (k = 0; k < len / 8; k++)
            {
                strItem = "";
                for (i = 0; i < 8; i++)
                {
                    strItem += abytArray[k * 8 + i].ToString("X2");
                    strItem += " ";
                }
                lstEnrollData.Items.Add(strItem);
            }
            strItem = "";
            for (i = k * 8; i < len; i++)
                strItem += abytArray[i].ToString("X2") + " ";

            lstEnrollData.Items.Add(strItem);
        }

        private void showEnrollDataToListbox(int anBackupNumber, byte[] abytEnrollData)
        {
            lstEnrollData.Items.Clear();
            lblEnrollData.Text = "Enrolled Data :";
            lblTotal.Text = "";

            if ((anBackupNumber == (int)enumBackupNumberType.BACKUP_PSW) ||
                (anBackupNumber == (int)enumBackupNumberType.BACKUP_CARD))
            {
                showByteArrayToListbox(ref lstEnrollData, abytEnrollData, PWD_DATA_SIZE);
            }
            else if (anBackupNumber >= (int)enumBackupNumberType.BACKUP_FP_0 &&
                anBackupNumber <= (int)enumBackupNumberType.BACKUP_FP_9)
            {
                showByteArrayToListbox(ref lstEnrollData, abytEnrollData, FP_DATA_SIZE);
            }
            else if (anBackupNumber == (int)enumBackupNumberType.BACKUP_FACE)
            {
                showByteArrayToListbox(ref lstEnrollData, abytEnrollData, FACE_DATA_SIZE);
            }
            else if (anBackupNumber >= (int)enumBackupNumberType.BACKUP_PALMVEIN_0 && anBackupNumber <= (int)enumBackupNumberType.BACKUP_PALMVEIN_3)
            {
                showByteArrayToListbox(ref lstEnrollData, abytEnrollData, PALMVEIN_DATA_SIZE);
            }
        }

        private void convFpDataToSaveInDbForCompatibility(byte[] abytSrc, ref byte[] abytDest)
        {
            int nTempLen = abytSrc.Length / 4;
            int lenConvFpData = nTempLen * 5;
            byte[] byteConvFpData = new byte[lenConvFpData];
            byte[] byteTemp = new byte[4];
            int k, m1;

            for (k = 0; k < nTempLen; k++)
            {
                byteTemp[0] = abytSrc[k * 4];
                byteTemp[1] = abytSrc[k * 4 + 1];
                byteTemp[2] = abytSrc[k * 4 + 2];
                byteTemp[3] = abytSrc[k * 4 + 3];
                m1 = BitConverter.ToInt32(byteTemp, 0);

                byteConvFpData[k * 5] = 1;
                if (m1 < 0)
                {
                    if (m1 == -2147483648)
                    {
                        byteConvFpData[k * 5] = 2;
                        m1 = 2147483647;
                    }
                    else
                    {
                        byteConvFpData[k * 5] = 0;
                        m1 = -m1;
                    }
                }
                byteTemp = BitConverter.GetBytes(m1);
                byteConvFpData[k * 5 + 1] = byteTemp[3];
                byteConvFpData[k * 5 + 2] = byteTemp[2];
                byteConvFpData[k * 5 + 3] = byteTemp[1];
                byteConvFpData[k * 5 + 4] = byteTemp[0];
            }
            abytDest = byteConvFpData;
        }

        private void saveEnrollDataToDB(
            string astrEnrollNumber,
            UInt32 anEnrollNumber,
            int anBackupNumber,
            int anPrivilege,
            string astrEnrollName)
        {
            string vstrFind = "";
            long vnCount;
            byte[] bytEnrollData;
            UInt32 vEnrollNumber = 0;
            string vStrEnrollNumber = "";
            if (astrEnrollNumber.Length != 0)
            {
                try
                {
                    vEnrollNumber = (UInt32)FKAttendDLL.GetInt(astrEnrollNumber);
                }
                catch (Exception e)
                {
                    vEnrollNumber = 0;
                }
                if (vEnrollNumber > 0)
                    vstrFind = "select count(*) from tblEnroll where (StringEnrollID='"
                        + astrEnrollNumber + "' or EnrollNumber=" + vEnrollNumber.ToString() + ") and FingerNumber=" + anBackupNumber.ToString();
                else
                    vstrFind = "select count(*) from tblEnroll where StringEnrollID='"
                        + astrEnrollNumber + "' and FingerNumber=" + anBackupNumber.ToString();
            }
            if (anEnrollNumber != 0)
            {
                vstrFind = "select count(*) from tblEnroll where EnrollNumber="
              + anEnrollNumber.ToString() + " and FingerNumber=" + anBackupNumber.ToString();

                vStrEnrollNumber = anEnrollNumber.ToString();
            }

            if (mAdoRstTmp.State == (int)ADODB.ObjectStateEnum.adStateOpen) mAdoRstTmp.Close();
            mAdoRstTmp.Open(vstrFind, mAdoConnEnroll, ADODB.CursorTypeEnum.adOpenStatic,
        ADODB.LockTypeEnum.adLockPessimistic, -1);

            vnCount = Convert.ToInt32(mAdoRstTmp.Fields[0].Value);
            mAdoRstTmp.Close();

            vEnrollNumber = (vEnrollNumber > 0) ? vEnrollNumber : anEnrollNumber;
            vStrEnrollNumber = (astrEnrollNumber.Length > 0) ? astrEnrollNumber : anEnrollNumber.ToString();

            if (vnCount > 0)
            {
                lblMessage.Text = "Double ID : " + vStrEnrollNumber + "-" + anBackupNumber;
                lstEnrollData.Items.Add(lblMessage.Text);
                return;
            }

            object oMissing = System.Reflection.Missing.Value;
            mAdoRstEnroll.AddNew(oMissing, oMissing);
            mAdoRstEnroll.Fields["StringEnrollID"].Value = vStrEnrollNumber.Trim();
            mAdoRstEnroll.Fields["EnrollNumber"].Value = vEnrollNumber;
            mAdoRstEnroll.Fields["FingerNumber"].Value = anBackupNumber;
            mAdoRstEnroll.Fields["Privilige"].Value = anPrivilege;
            mAdoRstEnroll.Fields["EnrollName"].Value = (astrEnrollName).Trim();

            if ((anBackupNumber == (int)enumBackupNumberType.BACKUP_PSW) ||
                (anBackupNumber == (int)enumBackupNumberType.BACKUP_CARD))
            {
                bytEnrollData = new byte[PWD_DATA_SIZE];
                Array.Copy(mbytCurEnrollData, bytEnrollData, PWD_DATA_SIZE);
                mAdoRstEnroll.Fields["FPdata"].Value = bytEnrollData;
            }
            else if ((anBackupNumber >= (int)enumBackupNumberType.BACKUP_FP_0) &&
                (anBackupNumber <= (int)enumBackupNumberType.BACKUP_FP_9))
            {
                bytEnrollData = new byte[FP_DATA_SIZE];
                Array.Copy(mbytCurEnrollData, bytEnrollData, FP_DATA_SIZE);
                //{ convert fpdata for compatibility with old version database
                byte[] vbytConvFpData = new byte[1];
                convFpDataToSaveInDbForCompatibility(bytEnrollData, ref vbytConvFpData);
                //}
                mAdoRstEnroll.Fields["FPdata"].Value = vbytConvFpData;
            }
            else if (anBackupNumber == (int)enumBackupNumberType.BACKUP_FACE)
            {
                bytEnrollData = new byte[FACE_DATA_SIZE];
                Array.Copy(mbytCurEnrollData, bytEnrollData, FACE_DATA_SIZE);
                mAdoRstEnroll.Fields["FPdata"].Value = bytEnrollData;
            }
            else if (anBackupNumber >= (int)enumBackupNumberType.BACKUP_PALMVEIN_0 && anBackupNumber <= (int)enumBackupNumberType.BACKUP_PALMVEIN_3)
            {
                bytEnrollData = new byte[PALMVEIN_DATA_SIZE];
                Array.Copy(mbytCurEnrollData, bytEnrollData, PALMVEIN_DATA_SIZE);
                mAdoRstEnroll.Fields["FPdata"].Value = bytEnrollData;

            }

            mAdoRstEnroll.Update(oMissing, oMissing);
            mAdoRstEnroll.UpdateBatch(ADODB.AffectEnum.adAffectAll);
            AdoEnroll_MoveComplete();

            lblMessage.Text = vStrEnrollNumber + "-" + anBackupNumber;
            txtEnrollNumber.Text = vStrEnrollNumber.Trim();
            cmbBackupNumber.SelectedIndex = getComboItemIndexFromBackupNumber(anBackupNumber);
            if (anPrivilege == (int)enumMachinePrivilege.MP_ALL)
                cmbPrivilege.SelectedIndex = 1;
            else
                cmbPrivilege.SelectedIndex = 0;

            Application.DoEvents();
        }

        private void convFpDataAfterReadFromDbForCompatibility(byte[] abytSrc, ref byte[] abytDest)
        {
            int nTempLen = abytSrc.Length / 5;
            int lenConvFpData = nTempLen * 4;

            if (lenConvFpData < FP_DATA_SIZE)
                lenConvFpData = FP_DATA_SIZE;

            byte[] byteConvFpData = new byte[lenConvFpData];
            byte[] byteTemp = new byte[4];
            int k, m;

            for (k = 0; k < nTempLen; k++)
            {
                byteTemp[0] = abytSrc[k * 5 + 4];
                byteTemp[1] = abytSrc[k * 5 + 3];
                byteTemp[2] = abytSrc[k * 5 + 2];
                byteTemp[3] = abytSrc[k * 5 + 1];
                m = BitConverter.ToInt32(byteTemp, 0);
                if (abytSrc[k * 5] == 0)
                {
                    m = -m;
                }
                else if (abytSrc[k * 5] == 2)
                {
                    m = -2147483648;
                }
                byteTemp = BitConverter.GetBytes(m);

                byteConvFpData[k * 4 + 3] = byteTemp[3];
                byteConvFpData[k * 4 + 2] = byteTemp[2];
                byteConvFpData[k * 4 + 1] = byteTemp[1];
                byteConvFpData[k * 4 + 0] = byteTemp[0];
            }
            abytDest = byteConvFpData;
        }

        private bool readEnrollDataFromDB(
            ref String astrStringID,
            ref UInt32 anEnrollNumber,
            ref int anBackupNumber,
            ref int anPrivilege,
            ref string astrEnrollName,
            bool abdispFlag)
        {
            string vstrEnrollNumber;
            if (mAdoRstEnroll.RecordCount <= 0)
                return false;
            if (mAdoRstEnroll.AbsolutePosition <= 0)
                return false;
            try
            {
                vstrEnrollNumber = (string)mAdoRstEnroll.Fields["StringEnrollID"].Value;
            }
            catch (Exception e)
            {
                vstrEnrollNumber = "";
            }
            // if ((int)mAdoRstEnroll.Fields["EnrollNumber"].Value <= 0 && vstrEnrollNumber.Length == 0)
            //     return false;

            anEnrollNumber = Convert.ToUInt32(mAdoRstEnroll.Fields["EnrollNumber"].Value);
            astrStringID = (vstrEnrollNumber.Length == 0) ? anEnrollNumber.ToString() : vstrEnrollNumber;
            anEnrollNumber = (anEnrollNumber <= 0) ? (UInt32)FKAttendDLL.GetInt(vstrEnrollNumber) : anEnrollNumber;
            if (vstrEnrollNumber.Length == 0)
                txtEnrollNumber.Text = anEnrollNumber.ToString().Trim();
            else
                txtEnrollNumber.Text = vstrEnrollNumber.Trim();
            anBackupNumber = (int)mAdoRstEnroll.Fields["FingerNumber"].Value;
            cmbBackupNumber.SelectedIndex = getComboItemIndexFromBackupNumber(anBackupNumber);
            anPrivilege = (int)mAdoRstEnroll.Fields["Privilige"].Value;

            if (anPrivilege == (int)enumMachinePrivilege.MP_ALL)
                cmbPrivilege.SelectedIndex = 1;
            else
                cmbPrivilege.SelectedIndex = 0;

            if ((anBackupNumber >= (int)enumBackupNumberType.BACKUP_FP_0) &&
                (anBackupNumber <= (int)enumBackupNumberType.BACKUP_FP_9))
            {
                byte[] bytConvFpData = (byte[])mAdoRstEnroll.Fields["FPdata"].Value;
                byte[] bytFpData = new byte[FP_DATA_SIZE];
                if (bytConvFpData.Length < FP_DATA_SIZE)
                {
                    Array.Clear(mbytCurEnrollData, 0, mbytCurEnrollData.Length);
                }
                else
                {
                    convFpDataAfterReadFromDbForCompatibility(bytConvFpData, ref bytFpData); // convert fpdata for compatibility with old version database
                    Array.Copy(bytFpData, mbytCurEnrollData, FP_DATA_SIZE);
                }
            }
            else if ((anBackupNumber == (int)enumBackupNumberType.BACKUP_PSW) ||
                (anBackupNumber == (int)enumBackupNumberType.BACKUP_CARD))
            {

                byte[] bytPwdData = new byte[0];
                try
                {
                    bytPwdData = (byte[])mAdoRstEnroll.Fields["FPdata"].Value;
                }
                catch
                {
                    // If the value of "FPdata" field is empty, this database probably was built by old version DLL.
                    // With old version DLL the password or IDCard data is saved in "Password" field(int type).
                    bytPwdData = new byte[0];
                    mnCurPassword = (int)mAdoRstEnroll.Fields["Password"].Value;
                }

                if (bytPwdData.Length < PWD_DATA_SIZE)
                    Array.Clear(mbytCurEnrollData, 0, mbytCurEnrollData.Length);
                else
                    Array.Copy(bytPwdData, mbytCurEnrollData, PWD_DATA_SIZE);


                    byte[] bytebuffer = new byte[bytPwdData.Length];
                    Array.Copy(bytPwdData, bytebuffer, bytPwdData.Length);
                    txtboxCardOrPwd.Text = CardPwdReference.GetCardOrPwdWithStr(bytebuffer);
                
            }
            else if (anBackupNumber == (int)enumBackupNumberType.BACKUP_FACE)
            {
                byte[] bytFaceData = (byte[])mAdoRstEnroll.Fields["FPdata"].Value;
                if (bytFaceData.Length < FACE_DATA_SIZE)
                    Array.Clear(mbytCurEnrollData, 0, mbytCurEnrollData.Length);
                else
                    Array.Copy(bytFaceData, mbytCurEnrollData, FACE_DATA_SIZE);
            }

            else if (anBackupNumber >= (int)enumBackupNumberType.BACKUP_PALMVEIN_0 && anBackupNumber <= (int)enumBackupNumberType.BACKUP_PALMVEIN_3)
            {
                byte[] bytFaceData = (byte[])mAdoRstEnroll.Fields["FPdata"].Value;
                if (bytFaceData.Length < PALMVEIN_DATA_SIZE)
                    Array.Clear(mbytCurEnrollData, 0, mbytCurEnrollData.Length);
                else
                    Array.Copy(bytFaceData, mbytCurEnrollData, PALMVEIN_DATA_SIZE);

            }

            astrEnrollName = (string)mAdoRstEnroll.Fields["EnrollName"].Value;

            if (abdispFlag == true)
                showEnrollDataToListbox(anBackupNumber, mbytCurEnrollData);

            return true;
        }

        private int getCurSelBackupNumberFromCombo()
        {
            int vnIndex;

            vnIndex = cmbBackupNumber.SelectedIndex;
            if (vnIndex < 0) vnIndex = 0;
            return (int)mListBoxItemBackupNumber[vnIndex * 2];
        }

        private int getComboItemIndexFromBackupNumber(int anBackupNumber)
        {
            int vnii;

            for (vnii = 0; vnii < mListBoxItemBackupNumber.GetUpperBound(0); vnii += 2)
            {
                if ((int)mListBoxItemBackupNumber[vnii] == anBackupNumber)
                {
                    return vnii / 2;
                }

            }
            return -1;
        }

        private string FuncStringFromBackupNumber(int anBackupNumber)
        {
            int vnii;
            string vRet = "        ";

            for (vnii = 0; vnii < mListBoxItemBackupNumber.GetUpperBound(0); vnii += 2)
            {
                if ((int)mListBoxItemBackupNumber[vnii] == anBackupNumber)
                {
                    vRet = (string)mListBoxItemBackupNumber[vnii + 1];
                    if (anBackupNumber != (int)enumBackupNumberType.BACKUP_PSW && anBackupNumber != (int)enumBackupNumberType.BACKUP_CARD)
                        vRet = vRet + " ";
                    return vRet;
                }
            }
            return vRet;
        }

        private void cmdEnterEnroll_Click(object sender, EventArgs e)
        {
            string vStrEnrollNumber;
            int vBackupNumber;
            int vPrivilege;
            int vnResultCode;

            cmdEnterEnroll.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vStrEnrollNumber = txtEnrollNumber.Text;

            vBackupNumber = getCurSelBackupNumberFromCombo();
            if (cmbPrivilege.SelectedIndex == 1)
                vPrivilege = (int)enumMachinePrivilege.MP_ALL;
            else
                vPrivilege = (int)enumMachinePrivilege.MP_NONE;

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdEnterEnroll.Enabled = true;
                return;
            }

            JObject vjobj = new JObject();
            JObject vjobjparam = new JObject();
            vjobj.Add("cmd", "enter_enroll");
            vjobjparam.Add("user_id", vStrEnrollNumber);
            vjobjparam.Add("backup_number", vBackupNumber);
            vjobjparam.Add("privilege", vPrivilege);
            vjobj.Add("param", vjobjparam);
            string vstrJsonStr = vjobj.ToString();
            vnResultCode = FKAttendDLL.FK_HS_ExecJsonCmd(FKAttendDLL.nCommHandleIndex, ref vstrJsonStr);

            lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdEnterEnroll.Enabled = true;
        }

        private void CmbBackupNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBackupNumber.Text == "Card" || cmbBackupNumber.Text == "Pass")
            {
                EnabledCardorPwdComponet(true);
            }
            else
            {
                EnabledCardorPwdComponet(false);
            }
        }

        private void EnabledCardorPwdComponet(bool v)
        {
            labelCardOrPwd.Enabled = v;
            txtboxCardOrPwd.Enabled = v;
        }
    }
}
