namespace FKRealSvrOcxTcpSample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.txtHostPort = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lvwLogList = new System.Windows.Forms.ListView();
            this.txtActiveId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPortNo = new System.Windows.Forms.TextBox();
            this.lblPortNo = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.btnBsCs = new System.Windows.Forms.Button();
            this.txtHostIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AxRealSvrOcxTcp1 = new AxRealSvrOcxTcpLib.AxRealSvrOcxTcp();
            this.axAxImage1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AxRealSvrOcxTcp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAxImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(695, 412);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(92, 29);
            this.btnClearList.TabIndex = 13;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnClosePort
            // 
            this.btnClosePort.Location = new System.Drawing.Point(600, 413);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(89, 27);
            this.btnClosePort.TabIndex = 14;
            this.btnClosePort.Text = "Close Port";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(512, 413);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(82, 27);
            this.btnOpenPort.TabIndex = 15;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // txtHostPort
            // 
            this.txtHostPort.Location = new System.Drawing.Point(304, 415);
            this.txtHostPort.Name = "txtHostPort";
            this.txtHostPort.Size = new System.Drawing.Size(78, 22);
            this.txtHostPort.TabIndex = 12;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(226, 418);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 16);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Host Port : ";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(12, 18);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(1017, 22);
            this.txtStatus.TabIndex = 10;
            this.txtStatus.Text = "Status";
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(9, 62);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 16);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total : ";
            // 
            // lvwLogList
            // 
            this.lvwLogList.FullRowSelect = true;
            this.lvwLogList.GridLines = true;
            this.lvwLogList.HideSelection = false;
            this.lvwLogList.Location = new System.Drawing.Point(12, 84);
            this.lvwLogList.MultiSelect = false;
            this.lvwLogList.Name = "lvwLogList";
            this.lvwLogList.Size = new System.Drawing.Size(853, 279);
            this.lvwLogList.TabIndex = 8;
            this.lvwLogList.UseCompatibleStateImageBehavior = false;
            this.lvwLogList.View = System.Windows.Forms.View.Details;
            // 
            // txtActiveId
            // 
            this.txtActiveId.Location = new System.Drawing.Point(941, 415);
            this.txtActiveId.Name = "txtActiveId";
            this.txtActiveId.Size = new System.Drawing.Size(78, 22);
            this.txtActiveId.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(836, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Open Door ID : ";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.Location = new System.Drawing.Point(689, 369);
            this.txtPassword.MaxLength = 0;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(68, 26);
            this.txtPassword.TabIndex = 26;
            this.txtPassword.Text = "0";
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(557, 372);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPassword.Size = new System.Drawing.Size(132, 20);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "Password :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPortNo
            // 
            this.txtPortNo.AcceptsReturn = true;
            this.txtPortNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtPortNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPortNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPortNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPortNo.Location = new System.Drawing.Point(460, 369);
            this.txtPortNo.MaxLength = 0;
            this.txtPortNo.Name = "txtPortNo";
            this.txtPortNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPortNo.Size = new System.Drawing.Size(68, 26);
            this.txtPortNo.TabIndex = 22;
            this.txtPortNo.Text = "5005";
            // 
            // lblPortNo
            // 
            this.lblPortNo.BackColor = System.Drawing.Color.Transparent;
            this.lblPortNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPortNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPortNo.Location = new System.Drawing.Point(328, 372);
            this.lblPortNo.Name = "lblPortNo";
            this.lblPortNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPortNo.Size = new System.Drawing.Size(132, 21);
            this.lblPortNo.TabIndex = 24;
            this.lblPortNo.Text = "Port Number :";
            this.lblPortNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.AcceptsReturn = true;
            this.txtIPAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIPAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIPAddress.Location = new System.Drawing.Point(152, 369);
            this.txtIPAddress.MaxLength = 0;
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIPAddress.Size = new System.Drawing.Size(146, 26);
            this.txtIPAddress.TabIndex = 21;
            this.txtIPAddress.Text = "192.168.1.104";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblIPAddress.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIPAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIPAddress.Location = new System.Drawing.Point(20, 372);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIPAddress.Size = new System.Drawing.Size(132, 21);
            this.lblIPAddress.TabIndex = 23;
            this.lblIPAddress.Text = "IP Address :";
            this.lblIPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBsCs
            // 
            this.btnBsCs.Location = new System.Drawing.Point(408, 413);
            this.btnBsCs.Name = "btnBsCs";
            this.btnBsCs.Size = new System.Drawing.Size(86, 27);
            this.btnBsCs.TabIndex = 27;
            this.btnBsCs.Text = "Set BS/CS";
            this.btnBsCs.UseVisualStyleBackColor = true;
            this.btnBsCs.Click += new System.EventHandler(this.btnBsCs_Click);
            // 
            // txtHostIP
            // 
            this.txtHostIP.Location = new System.Drawing.Point(99, 415);
            this.txtHostIP.Name = "txtHostIP";
            this.txtHostIP.Size = new System.Drawing.Size(103, 22);
            this.txtHostIP.TabIndex = 29;
            this.txtHostIP.Text = "192.168.1.100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Host IP : ";
            // 
            // AxRealSvrOcxTcp1
            // 
            this.AxRealSvrOcxTcp1.Enabled = true;
            this.AxRealSvrOcxTcp1.Location = new System.Drawing.Point(512, 46);
            this.AxRealSvrOcxTcp1.Name = "AxRealSvrOcxTcp1";
            this.AxRealSvrOcxTcp1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AxRealSvrOcxTcp1.OcxState")));
            this.AxRealSvrOcxTcp1.Size = new System.Drawing.Size(32, 32);
            this.AxRealSvrOcxTcp1.TabIndex = 30;
            this.AxRealSvrOcxTcp1.Visible = false;
            this.AxRealSvrOcxTcp1.OnReceiveGLogDataExtend += new AxRealSvrOcxTcpLib._DRealSvrOcxTcpEvents_OnReceiveGLogDataExtendEventHandler(this.AxRealSvrOcxTcp1_OnReceiveGLogDataExtend);
            this.AxRealSvrOcxTcp1.OnReceiveGLogTextAndImage += new AxRealSvrOcxTcpLib._DRealSvrOcxTcpEvents_OnReceiveGLogTextAndImageEventHandler(this.AxRealSvrOcxTcp1_OnReceiveGLogTextAndImage);
            this.AxRealSvrOcxTcp1.OnReceiveGLogTextOnDoorOpen += new AxRealSvrOcxTcpLib._DRealSvrOcxTcpEvents_OnReceiveGLogTextOnDoorOpenEventHandler(this.AxRealSvrOcxTcp1_OnReceiveGLogTextOnDoorOpen);
            // 
            // axAxImage1
            // 
            this.axAxImage1.BackColor = System.Drawing.Color.White;
            this.axAxImage1.Location = new System.Drawing.Point(890, 84);
            this.axAxImage1.Name = "axAxImage1";
            this.axAxImage1.Size = new System.Drawing.Size(138, 182);
            this.axAxImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.axAxImage1.TabIndex = 31;
            this.axAxImage1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 451);
            this.Controls.Add(this.axAxImage1);
            this.Controls.Add(this.AxRealSvrOcxTcp1);
            this.Controls.Add(this.txtHostIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBsCs);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPortNo);
            this.Controls.Add(this.lblPortNo);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.txtActiveId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnClosePort);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.txtHostPort);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lvwLogList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FKRealSvrOcxCSSample (ver 2.8.8.0)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AxRealSvrOcxTcp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAxImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnClearList;
        internal System.Windows.Forms.Button btnClosePort;
        internal System.Windows.Forms.Button btnOpenPort;
        internal System.Windows.Forms.TextBox txtHostPort;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtStatus;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.ListView lvwLogList;
        internal System.Windows.Forms.TextBox txtActiveId;
        internal System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.TextBox txtPortNo;
        public System.Windows.Forms.Label lblPortNo;
        public System.Windows.Forms.TextBox txtIPAddress;
        public System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Button btnBsCs;
        internal System.Windows.Forms.TextBox txtHostIP;
        internal System.Windows.Forms.Label label3;
        private AxRealSvrOcxTcpLib.AxRealSvrOcxTcp AxRealSvrOcxTcp1;
        private System.Windows.Forms.PictureBox axAxImage1;
    }
}

