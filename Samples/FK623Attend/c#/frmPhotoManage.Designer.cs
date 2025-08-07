namespace FKAttendDllCSSample
{
    partial class frmPhotoManage
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
            this.txtEnrollNumber = new System.Windows.Forms.TextBox();
            this.cmdGetEnrollPhoto = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdSetEnrollPhoto = new System.Windows.Forms.Button();
            this.cmdDeleteEnrollPhoto = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblEnrollNum = new System.Windows.Forms.Label();
            this.axAxImage1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axAxImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEnrollNumber
            // 
            this.txtEnrollNumber.AcceptsReturn = true;
            this.txtEnrollNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtEnrollNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnrollNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEnrollNumber.Location = new System.Drawing.Point(149, 54);
            this.txtEnrollNumber.MaxLength = 30;
            this.txtEnrollNumber.Name = "txtEnrollNumber";
            this.txtEnrollNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnrollNumber.Size = new System.Drawing.Size(81, 26);
            this.txtEnrollNumber.TabIndex = 10;
            // 
            // cmdGetEnrollPhoto
            // 
            this.cmdGetEnrollPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetEnrollPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetEnrollPhoto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetEnrollPhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetEnrollPhoto.Location = new System.Drawing.Point(245, 54);
            this.cmdGetEnrollPhoto.Name = "cmdGetEnrollPhoto";
            this.cmdGetEnrollPhoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetEnrollPhoto.Size = new System.Drawing.Size(200, 28);
            this.cmdGetEnrollPhoto.TabIndex = 7;
            this.cmdGetEnrollPhoto.Text = "Get Enroll Photo";
            this.ToolTip1.SetToolTip(this.cmdGetEnrollPhoto, "Get EnrollData From Device");
            this.cmdGetEnrollPhoto.UseVisualStyleBackColor = false;
            this.cmdGetEnrollPhoto.Click += new System.EventHandler(this.cmdGetEnrollPhoto_Click);
            // 
            // cmdSetEnrollPhoto
            // 
            this.cmdSetEnrollPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetEnrollPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetEnrollPhoto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetEnrollPhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetEnrollPhoto.Location = new System.Drawing.Point(245, 83);
            this.cmdSetEnrollPhoto.Name = "cmdSetEnrollPhoto";
            this.cmdSetEnrollPhoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetEnrollPhoto.Size = new System.Drawing.Size(200, 28);
            this.cmdSetEnrollPhoto.TabIndex = 9;
            this.cmdSetEnrollPhoto.Text = "Set Enroll Photo";
            this.ToolTip1.SetToolTip(this.cmdSetEnrollPhoto, "Set EnrollData To Device");
            this.cmdSetEnrollPhoto.UseVisualStyleBackColor = false;
            this.cmdSetEnrollPhoto.Click += new System.EventHandler(this.cmdSetEnrollPhoto_Click);
            // 
            // cmdDeleteEnrollPhoto
            // 
            this.cmdDeleteEnrollPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.cmdDeleteEnrollPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdDeleteEnrollPhoto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeleteEnrollPhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdDeleteEnrollPhoto.Location = new System.Drawing.Point(245, 113);
            this.cmdDeleteEnrollPhoto.Name = "cmdDeleteEnrollPhoto";
            this.cmdDeleteEnrollPhoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDeleteEnrollPhoto.Size = new System.Drawing.Size(200, 28);
            this.cmdDeleteEnrollPhoto.TabIndex = 8;
            this.cmdDeleteEnrollPhoto.Text = "Delete Enroll Photo";
            this.ToolTip1.SetToolTip(this.cmdDeleteEnrollPhoto, "Delete Enroll Data Into Device");
            this.cmdDeleteEnrollPhoto.UseVisualStyleBackColor = false;
            this.cmdDeleteEnrollPhoto.Click += new System.EventHandler(this.cmdDeleteEnrollPhoto_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(13, 5);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(437, 30);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEnrollNum
            // 
            this.lblEnrollNum.AutoSize = true;
            this.lblEnrollNum.BackColor = System.Drawing.SystemColors.Control;
            this.lblEnrollNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEnrollNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrollNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnrollNum.Location = new System.Drawing.Point(14, 61);
            this.lblEnrollNum.Name = "lblEnrollNum";
            this.lblEnrollNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnrollNum.Size = new System.Drawing.Size(105, 19);
            this.lblEnrollNum.TabIndex = 11;
            this.lblEnrollNum.Text = "Enroll Number :";
            // 
            // axAxImage1
            // 
            this.axAxImage1.Location = new System.Drawing.Point(18, 100);
            this.axAxImage1.Name = "axAxImage1";
            this.axAxImage1.Size = new System.Drawing.Size(176, 235);
            this.axAxImage1.TabIndex = 13;
            this.axAxImage1.TabStop = false;
            // 
            // frmPhotoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 420);
            this.Controls.Add(this.axAxImage1);
            this.Controls.Add(this.txtEnrollNumber);
            this.Controls.Add(this.cmdGetEnrollPhoto);
            this.Controls.Add(this.cmdSetEnrollPhoto);
            this.Controls.Add(this.cmdDeleteEnrollPhoto);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblEnrollNum);
            this.Name = "frmPhotoManage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Manage";
            this.Load += new System.EventHandler(this.frmPhotoManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAxImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtEnrollNumber;
        public System.Windows.Forms.Button cmdGetEnrollPhoto;
        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Button cmdSetEnrollPhoto;
        public System.Windows.Forms.Button cmdDeleteEnrollPhoto;
        public System.Windows.Forms.Label lblMessage;
        public System.Windows.Forms.Label lblEnrollNum;
        private System.Windows.Forms.PictureBox axAxImage1;
    }
}