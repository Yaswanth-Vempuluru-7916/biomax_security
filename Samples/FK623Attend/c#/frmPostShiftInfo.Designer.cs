namespace FKAttendDllCSSample
{
    partial class frmPostShiftInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdGetShiftInfo = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmdSetShiftInfo = new System.Windows.Forms.Button();
            this.dgvUserShiftOfMonth = new System.Windows.Forms.DataGridView();
            this.txtEnrollNumber = new System.Windows.Forms.TextBox();
            this.Label102 = new System.Windows.Forms.Label();
            this.txtPostID = new System.Windows.Forms.TextBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmdGetUserInfo = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.cmdSetUserInfo = new System.Windows.Forms.Button();
            this.dgvPost = new System.Windows.Forms.DataGridView();
            this.dgvShift = new System.Windows.Forms.DataGridView();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.cmbUserShiftMonth = new System.Windows.Forms.ComboBox();
            this.cmbUserShiftYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label99 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.frmPostGroup = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserShiftOfMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).BeginInit();
            this.Frame1.SuspendLayout();
            this.frmPostGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdGetShiftInfo
            // 
            this.cmdGetShiftInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetShiftInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetShiftInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetShiftInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetShiftInfo.Location = new System.Drawing.Point(435, 380);
            this.cmdGetShiftInfo.Name = "cmdGetShiftInfo";
            this.cmdGetShiftInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetShiftInfo.Size = new System.Drawing.Size(154, 30);
            this.cmdGetShiftInfo.TabIndex = 1;
            this.cmdGetShiftInfo.Text = "Get Shift Info";
            this.cmdGetShiftInfo.UseVisualStyleBackColor = false;
            this.cmdGetShiftInfo.Click += new System.EventHandler(this.cmdGetShiftInfo_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(25, 106);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(186, 19);
            this.Label3.TabIndex = 47;
            this.Label3.Text = "Shift setting in a month :";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(148, 83);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(90, 19);
            this.Label1.TabIndex = 47;
            this.Label1.Text = "PostID :";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdSetShiftInfo
            // 
            this.cmdSetShiftInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetShiftInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetShiftInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetShiftInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetShiftInfo.Location = new System.Drawing.Point(597, 380);
            this.cmdSetShiftInfo.Name = "cmdSetShiftInfo";
            this.cmdSetShiftInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetShiftInfo.Size = new System.Drawing.Size(154, 30);
            this.cmdSetShiftInfo.TabIndex = 2;
            this.cmdSetShiftInfo.Text = "Set Shift Info";
            this.cmdSetShiftInfo.UseVisualStyleBackColor = false;
            this.cmdSetShiftInfo.Click += new System.EventHandler(this.cmdSetShiftInfo_Click);
            // 
            // dgvUserShiftOfMonth
            // 
            this.dgvUserShiftOfMonth.AllowUserToAddRows = false;
            this.dgvUserShiftOfMonth.AllowUserToDeleteRows = false;
            this.dgvUserShiftOfMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserShiftOfMonth.Location = new System.Drawing.Point(25, 128);
            this.dgvUserShiftOfMonth.Name = "dgvUserShiftOfMonth";
            this.dgvUserShiftOfMonth.RowHeadersVisible = false;
            this.dgvUserShiftOfMonth.Size = new System.Drawing.Size(785, 47);
            this.dgvUserShiftOfMonth.TabIndex = 46;
            // 
            // txtEnrollNumber
            // 
            this.txtEnrollNumber.AcceptsReturn = true;
            this.txtEnrollNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtEnrollNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnrollNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEnrollNumber.Location = new System.Drawing.Point(246, 22);
            this.txtEnrollNumber.MaxLength = 0;
            this.txtEnrollNumber.Name = "txtEnrollNumber";
            this.txtEnrollNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnrollNumber.Size = new System.Drawing.Size(142, 26);
            this.txtEnrollNumber.TabIndex = 16;
            this.txtEnrollNumber.Text = "1";
            this.txtEnrollNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label102
            // 
            this.Label102.BackColor = System.Drawing.SystemColors.Control;
            this.Label102.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label102.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label102.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label102.Location = new System.Drawing.Point(138, 384);
            this.Label102.Name = "Label102";
            this.Label102.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label102.Size = new System.Drawing.Size(107, 19);
            this.Label102.TabIndex = 6;
            this.Label102.Text = "Company Name";
            // 
            // txtPostID
            // 
            this.txtPostID.AcceptsReturn = true;
            this.txtPostID.BackColor = System.Drawing.SystemColors.Window;
            this.txtPostID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostID.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPostID.Location = new System.Drawing.Point(246, 82);
            this.txtPostID.MaxLength = 0;
            this.txtPostID.Name = "txtPostID";
            this.txtPostID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPostID.Size = new System.Drawing.Size(79, 20);
            this.txtPostID.TabIndex = 15;
            this.txtPostID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserName
            // 
            this.txtUserName.AcceptsReturn = true;
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserName.Location = new System.Drawing.Point(246, 52);
            this.txtUserName.MaxLength = 0;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserName.Size = new System.Drawing.Size(124, 26);
            this.txtUserName.TabIndex = 14;
            // 
            // cmdGetUserInfo
            // 
            this.cmdGetUserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetUserInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetUserInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetUserInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetUserInfo.Location = new System.Drawing.Point(436, 22);
            this.cmdGetUserInfo.Name = "cmdGetUserInfo";
            this.cmdGetUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetUserInfo.Size = new System.Drawing.Size(154, 35);
            this.cmdGetUserInfo.TabIndex = 8;
            this.cmdGetUserInfo.Text = "Get UserInfo";
            this.cmdGetUserInfo.UseVisualStyleBackColor = false;
            this.cmdGetUserInfo.Click += new System.EventHandler(this.cmdGetUserInfo_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.AcceptsReturn = true;
            this.txtCompanyName.BackColor = System.Drawing.SystemColors.Window;
            this.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCompanyName.Location = new System.Drawing.Point(257, 383);
            this.txtCompanyName.MaxLength = 0;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCompanyName.Size = new System.Drawing.Size(170, 26);
            this.txtCompanyName.TabIndex = 3;
            // 
            // cmdSetUserInfo
            // 
            this.cmdSetUserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetUserInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetUserInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetUserInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetUserInfo.Location = new System.Drawing.Point(596, 22);
            this.cmdSetUserInfo.Name = "cmdSetUserInfo";
            this.cmdSetUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetUserInfo.Size = new System.Drawing.Size(154, 35);
            this.cmdSetUserInfo.TabIndex = 9;
            this.cmdSetUserInfo.Text = "Set UserInfo";
            this.cmdSetUserInfo.UseVisualStyleBackColor = false;
            this.cmdSetUserInfo.Click += new System.EventHandler(this.cmdSetUserInfo_Click);
            // 
            // dgvPost
            // 
            this.dgvPost.AllowUserToAddRows = false;
            this.dgvPost.AllowUserToDeleteRows = false;
            this.dgvPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPost.Location = new System.Drawing.Point(24, 32);
            this.dgvPost.Name = "dgvPost";
            this.dgvPost.RowHeadersWidth = 20;
            this.dgvPost.Size = new System.Drawing.Size(258, 331);
            this.dgvPost.TabIndex = 7;
            // 
            // dgvShift
            // 
            this.dgvShift.AllowUserToAddRows = false;
            this.dgvShift.AllowUserToDeleteRows = false;
            this.dgvShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShift.Location = new System.Drawing.Point(291, 32);
            this.dgvShift.Name = "dgvShift";
            this.dgvShift.Size = new System.Drawing.Size(518, 331);
            this.dgvShift.TabIndex = 8;
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.cmbUserShiftMonth);
            this.Frame1.Controls.Add(this.cmbUserShiftYear);
            this.Frame1.Controls.Add(this.label5);
            this.Frame1.Controls.Add(this.Label3);
            this.Frame1.Controls.Add(this.label4);
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Controls.Add(this.dgvUserShiftOfMonth);
            this.Frame1.Controls.Add(this.txtEnrollNumber);
            this.Frame1.Controls.Add(this.txtPostID);
            this.Frame1.Controls.Add(this.txtUserName);
            this.Frame1.Controls.Add(this.cmdSetUserInfo);
            this.Frame1.Controls.Add(this.cmdGetUserInfo);
            this.Frame1.Controls.Add(this.Label99);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(20, 465);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(831, 190);
            this.Frame1.TabIndex = 82;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "User Information";
            // 
            // cmbUserShiftMonth
            // 
            this.cmbUserShiftMonth.FormattingEnabled = true;
            this.cmbUserShiftMonth.Location = new System.Drawing.Point(673, 80);
            this.cmbUserShiftMonth.Name = "cmbUserShiftMonth";
            this.cmbUserShiftMonth.Size = new System.Drawing.Size(75, 25);
            this.cmbUserShiftMonth.TabIndex = 48;
            // 
            // cmbUserShiftYear
            // 
            this.cmbUserShiftYear.FormattingEnabled = true;
            this.cmbUserShiftYear.Location = new System.Drawing.Point(495, 80);
            this.cmbUserShiftYear.Name = "cmbUserShiftYear";
            this.cmbUserShiftYear.Size = new System.Drawing.Size(75, 25);
            this.cmbUserShiftYear.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(594, 83);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Month :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(432, 83);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Year :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label99
            // 
            this.Label99.AutoSize = true;
            this.Label99.BackColor = System.Drawing.SystemColors.Control;
            this.Label99.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label99.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label99.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label99.Location = new System.Drawing.Point(150, 54);
            this.Label99.Name = "Label99";
            this.Label99.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label99.Size = new System.Drawing.Size(90, 19);
            this.Label99.TabIndex = 45;
            this.Label99.Text = "UserName :";
            this.Label99.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(129, 27);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(112, 19);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "EnrollNumber :";
            // 
            // frmPostGroup
            // 
            this.frmPostGroup.BackColor = System.Drawing.SystemColors.Control;
            this.frmPostGroup.Controls.Add(this.dgvShift);
            this.frmPostGroup.Controls.Add(this.dgvPost);
            this.frmPostGroup.Controls.Add(this.txtCompanyName);
            this.frmPostGroup.Controls.Add(this.cmdSetShiftInfo);
            this.frmPostGroup.Controls.Add(this.cmdGetShiftInfo);
            this.frmPostGroup.Controls.Add(this.Label102);
            this.frmPostGroup.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmPostGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.frmPostGroup.Location = new System.Drawing.Point(21, 36);
            this.frmPostGroup.Name = "frmPostGroup";
            this.frmPostGroup.Padding = new System.Windows.Forms.Padding(0);
            this.frmPostGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frmPostGroup.Size = new System.Drawing.Size(829, 423);
            this.frmPostGroup.TabIndex = 81;
            this.frmPostGroup.TabStop = false;
            this.frmPostGroup.Text = "Shift Information";
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(23, 4);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(828, 30);
            this.lblMessage.TabIndex = 83;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPostShiftInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(870, 645);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.frmPostGroup);
            this.Controls.Add(this.lblMessage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPostShiftInfo";
            this.ShowIcon = false;
            this.Text = "Setting Post & Shift information";
            this.Load += new System.EventHandler(this.frmPostShiftInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserShiftOfMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).EndInit();
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.frmPostGroup.ResumeLayout(false);
            this.frmPostGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Button cmdGetShiftInfo;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Button cmdSetShiftInfo;
        internal System.Windows.Forms.DataGridView dgvUserShiftOfMonth;
        public System.Windows.Forms.TextBox txtEnrollNumber;
        public System.Windows.Forms.Label Label102;
        public System.Windows.Forms.TextBox txtPostID;
        public System.Windows.Forms.OpenFileDialog dlgOpen;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.Button cmdGetUserInfo;
        public System.Windows.Forms.TextBox txtCompanyName;
        public System.Windows.Forms.Button cmdSetUserInfo;
        internal System.Windows.Forms.DataGridView dgvPost;
        internal System.Windows.Forms.DataGridView dgvShift;
        public System.Windows.Forms.GroupBox Frame1;
        public System.Windows.Forms.Label Label99;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.GroupBox frmPostGroup;
        public System.Windows.Forms.Label lblMessage;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUserShiftYear;
        private System.Windows.Forms.ComboBox cmbUserShiftMonth;
        public System.Windows.Forms.Label label5;


    }
}