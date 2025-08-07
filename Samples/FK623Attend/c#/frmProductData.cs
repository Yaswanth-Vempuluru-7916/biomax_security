using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FKAttendDllCSSample
{
	/// <summary>
	/// Form8 的摘要说明。
	/// </summary>
	public class frmProductData : System.Windows.Forms.Form
	{
		public System.Windows.Forms.TextBox txtProductCode;
		public System.Windows.Forms.Button cmdGetData;
		public System.Windows.Forms.TextBox txtBackupNo;
		public System.Windows.Forms.TextBox txtSerialNo;
		public System.Windows.Forms.Label lblBackuplNo;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label lblSerialNo;
		public System.Windows.Forms.Label lblMessage;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmProductData()
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
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.cmdGetData = new System.Windows.Forms.Button();
            this.txtBackupNo = new System.Windows.Forms.TextBox();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.lblBackuplNo = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProductCode
            // 
            this.txtProductCode.AcceptsReturn = true;
            this.txtProductCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProductCode.Location = new System.Drawing.Point(173, 132);
            this.txtProductCode.MaxLength = 32;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductCode.Size = new System.Drawing.Size(214, 28);
            this.txtProductCode.TabIndex = 19;
            // 
            // cmdGetData
            // 
            this.cmdGetData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetData.Location = new System.Drawing.Point(267, 173);
            this.cmdGetData.Name = "cmdGetData";
            this.cmdGetData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetData.Size = new System.Drawing.Size(121, 44);
            this.cmdGetData.TabIndex = 18;
            this.cmdGetData.Text = "Get";
            this.cmdGetData.UseVisualStyleBackColor = false;
            this.cmdGetData.Click += new System.EventHandler(this.cmdGetData_Click);
            // 
            // txtBackupNo
            // 
            this.txtBackupNo.AcceptsReturn = true;
            this.txtBackupNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtBackupNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBackupNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBackupNo.Location = new System.Drawing.Point(173, 92);
            this.txtBackupNo.MaxLength = 32;
            this.txtBackupNo.Name = "txtBackupNo";
            this.txtBackupNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBackupNo.Size = new System.Drawing.Size(214, 27);
            this.txtBackupNo.TabIndex = 17;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.AcceptsReturn = true;
            this.txtSerialNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtSerialNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerialNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSerialNo.Location = new System.Drawing.Point(173, 52);
            this.txtSerialNo.MaxLength = 32;
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSerialNo.Size = new System.Drawing.Size(214, 27);
            this.txtSerialNo.TabIndex = 16;
            // 
            // lblBackuplNo
            // 
            this.lblBackuplNo.AutoSize = true;
            this.lblBackuplNo.BackColor = System.Drawing.SystemColors.Control;
            this.lblBackuplNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBackuplNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackuplNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBackuplNo.Location = new System.Drawing.Point(37, 100);
            this.lblBackuplNo.Name = "lblBackuplNo";
            this.lblBackuplNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBackuplNo.Size = new System.Drawing.Size(117, 19);
            this.lblBackuplNo.TabIndex = 23;
            this.lblBackuplNo.Text = "Backup Number :";
            this.lblBackuplNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(37, 140);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(102, 19);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Product Code :";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.BackColor = System.Drawing.SystemColors.Control;
            this.lblSerialNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSerialNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSerialNo.Location = new System.Drawing.Point(37, 60);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSerialNo.Size = new System.Drawing.Size(104, 19);
            this.lblSerialNo.TabIndex = 21;
            this.lblSerialNo.Text = "Serial Number :";
            this.lblSerialNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(21, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(367, 28);
            this.lblMessage.TabIndex = 20;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmProductData
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(413, 229);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtBackupNo);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.lblBackuplNo);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblSerialNo);
            this.Controls.Add(this.cmdGetData);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void cmdGetData_Click(object sender, System.EventArgs e)
		{
		    string vstrData = "";
			long vnResultCode;

			cmdGetData.Enabled = false;
			txtSerialNo.Text = "";
			txtBackupNo.Text = "";
			txtProductCode.Text = "";
			lblMessage.Text = "Waiting...";
			Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
			if (vnResultCode != (long)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = FKAttendDLL.msErrorNoDevice;
				cmdGetData.Enabled = true;
				return;
			}

			vnResultCode = FuncGetProductData((long)enumProductInfo.PRODUCT_SERIALNUMBER, ref vstrData);
			if (vnResultCode == (long)enumErrorCode.RUN_SUCCESS)
			{
				txtSerialNo.Text = vstrData;

				vnResultCode = FuncGetProductData((long)enumProductInfo.PRODUCT_BACKUPNUMBER, ref vstrData);
				if (vnResultCode == (long)enumErrorCode.RUN_SUCCESS)
				{
					txtBackupNo.Text = vstrData;

					vnResultCode = FuncGetProductData((long)enumProductInfo.PRODUCT_CODE, ref vstrData);
					if (vnResultCode == (long)enumErrorCode.RUN_SUCCESS)
						txtProductCode.Text = vstrData;
					
				}
			}

			if(vnResultCode == (long)enumErrorCode.RUN_SUCCESS)
				lblMessage.Text = "GetProductData OK";

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
			cmdGetData.Enabled = true;
		}

		private long FuncGetProductData(long anIndex, ref string astrItem)
		{	
			long vnResultCode;
			string vstrData = new string((char)0x20, 256);

            vnResultCode = FKAttendDLL.FK_GetProductData(FKAttendDLL.nCommHandleIndex, (int)anIndex, ref vstrData);
			if(vnResultCode != (long)enumErrorCode.RUN_SUCCESS)
			{
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
				return vnResultCode;
			}
			astrItem = vstrData.Trim();
			return vnResultCode;
		}
	}
}
