using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FKAttendDllCSSample
{
	/// <summary>
	/// Form2 的摘要说明。
	/// </summary>
	public class frmBellInfo : System.Windows.Forms.Form
	{
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.TextBox txtHour23;
		public System.Windows.Forms.TextBox txtMinute23;
		public System.Windows.Forms.TextBox txtMinute22;
		public System.Windows.Forms.TextBox txtHour22;
		public System.Windows.Forms.TextBox txtHour21;
		public System.Windows.Forms.TextBox txtMinute21;
		public System.Windows.Forms.TextBox txtMinute20;
		public System.Windows.Forms.TextBox txtHour20;
		public System.Windows.Forms.TextBox txtHour19;
		public System.Windows.Forms.TextBox txtMinute19;
		public System.Windows.Forms.TextBox txtMinute18;
		public System.Windows.Forms.TextBox txtHour18;
		public System.Windows.Forms.TextBox txtHour17;
		public System.Windows.Forms.TextBox txtMinute17;
		public System.Windows.Forms.TextBox txtMinute16;
		public System.Windows.Forms.TextBox txtHour16;
		public System.Windows.Forms.CheckBox chkValid23;
		public System.Windows.Forms.CheckBox chkValid22;
		public System.Windows.Forms.CheckBox chkValid21;
		public System.Windows.Forms.CheckBox chkValid20;
		public System.Windows.Forms.CheckBox chkValid19;
		public System.Windows.Forms.CheckBox chkValid18;
		public System.Windows.Forms.CheckBox chkValid17;
		public System.Windows.Forms.CheckBox chkValid16;
		public System.Windows.Forms.Label Label2_40;
		public System.Windows.Forms.Label Label2_47;
		public System.Windows.Forms.Label Label2_46;
		public System.Windows.Forms.Label Label2_45;
		public System.Windows.Forms.Label Label2_44;
		public System.Windows.Forms.Label Label2_43;
		public System.Windows.Forms.Label Label2_42;
		public System.Windows.Forms.Label Label2_41;
		public System.Windows.Forms.Label Label2_39;
		public System.Windows.Forms.Label Label2_38;
		public System.Windows.Forms.Label Label2_37;
		public System.Windows.Forms.Label Label2_36;
		public System.Windows.Forms.Label Label2_35;
		public System.Windows.Forms.Label Label2_34;
		public System.Windows.Forms.Label Label2_33;
		public System.Windows.Forms.Label Label2_32;
		public System.Windows.Forms.TextBox txtHour15;
		public System.Windows.Forms.TextBox txtMinute15;
		public System.Windows.Forms.TextBox txtMinute14;
		public System.Windows.Forms.TextBox txtHour14;
		public System.Windows.Forms.TextBox txtHour13;
		public System.Windows.Forms.TextBox txtMinute13;
		public System.Windows.Forms.TextBox txtMinute12;
		public System.Windows.Forms.TextBox txtHour12;
		public System.Windows.Forms.TextBox txtHour11;
		public System.Windows.Forms.TextBox txtMinute11;
		public System.Windows.Forms.TextBox txtMinute10;
		public System.Windows.Forms.TextBox txtHour10;
		public System.Windows.Forms.TextBox txtHour9;
		public System.Windows.Forms.TextBox txtMinute9;
		public System.Windows.Forms.TextBox txtMinute8;
		public System.Windows.Forms.TextBox txtHour8;
		public System.Windows.Forms.CheckBox chkValid15;
		public System.Windows.Forms.CheckBox chkValid14;
		public System.Windows.Forms.CheckBox chkValid13;
		public System.Windows.Forms.CheckBox chkValid12;
		public System.Windows.Forms.CheckBox chkValid11;
		public System.Windows.Forms.CheckBox chkValid10;
		public System.Windows.Forms.CheckBox chkValid9;
		public System.Windows.Forms.CheckBox chkValid8;
		public System.Windows.Forms.Label Label2_24;
		public System.Windows.Forms.Label Label2_31;
		public System.Windows.Forms.Label Label2_30;
		public System.Windows.Forms.Label Label2_29;
		public System.Windows.Forms.Label Label2_28;
		public System.Windows.Forms.Label Label2_27;
		public System.Windows.Forms.Label Label2_26;
		public System.Windows.Forms.Label Label2_25;
		public System.Windows.Forms.Label Label2_23;
		public System.Windows.Forms.Label Label2_22;
		public System.Windows.Forms.Label Label2_21;
		public System.Windows.Forms.Label Label2_20;
		public System.Windows.Forms.Label Label2_19;
		public System.Windows.Forms.Label Label2_18;
		public System.Windows.Forms.Label Label2_17;
		public System.Windows.Forms.Label Label2_16;
		public System.Windows.Forms.TextBox txtBellCount;
		public System.Windows.Forms.TextBox txtHour7;
		public System.Windows.Forms.TextBox txtMinute7;
		public System.Windows.Forms.TextBox txtMinute6;
		public System.Windows.Forms.TextBox txtHour6;
		public System.Windows.Forms.TextBox txtHour5;
		public System.Windows.Forms.TextBox txtMinute5;
		public System.Windows.Forms.TextBox txtMinute4;
		public System.Windows.Forms.TextBox txtHour4;
		public System.Windows.Forms.TextBox txtHour3;
		public System.Windows.Forms.TextBox txtMinute3;
		public System.Windows.Forms.TextBox txtMinute2;
		public System.Windows.Forms.TextBox txtHour2;
		public System.Windows.Forms.TextBox txtHour1;
		public System.Windows.Forms.TextBox txtMinute1;
		public System.Windows.Forms.TextBox txtMinute0;
		public System.Windows.Forms.TextBox txtHour0;
		public System.Windows.Forms.CheckBox chkValid7;
		public System.Windows.Forms.CheckBox chkValid6;
		public System.Windows.Forms.CheckBox chkValid5;
		public System.Windows.Forms.CheckBox chkValid4;
		public System.Windows.Forms.CheckBox chkValid3;
		public System.Windows.Forms.CheckBox chkValid2;
		public System.Windows.Forms.CheckBox chkValid1;
		public System.Windows.Forms.CheckBox chkValid0;
		public System.Windows.Forms.Button cmdWrite;
		public System.Windows.Forms.Button cmdRead;
		public System.Windows.Forms.Label Label2_8;
		public System.Windows.Forms.Label Label2_15;
		public System.Windows.Forms.Label Label2_14;
		public System.Windows.Forms.Label Label2_13;
		public System.Windows.Forms.Label Label2_12;
		public System.Windows.Forms.Label Label2_11;
		public System.Windows.Forms.Label Label2_10;
		public System.Windows.Forms.Label Label2_9;
		public System.Windows.Forms.Label lblCaption0;
		public System.Windows.Forms.Label Label2_7;
		public System.Windows.Forms.Label Label2_6;
		public System.Windows.Forms.Label Label2_5;
		public System.Windows.Forms.Label Label2_4;
		public System.Windows.Forms.Label Label2_3;
		public System.Windows.Forms.Label Label2_2;
		public System.Windows.Forms.Label Label2_1;
		public System.Windows.Forms.Label Label2_0;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label lblMessage;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmBellInfo()
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
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtHour23 = new System.Windows.Forms.TextBox();
            this.txtMinute23 = new System.Windows.Forms.TextBox();
            this.txtMinute22 = new System.Windows.Forms.TextBox();
            this.txtHour22 = new System.Windows.Forms.TextBox();
            this.txtHour21 = new System.Windows.Forms.TextBox();
            this.txtMinute21 = new System.Windows.Forms.TextBox();
            this.txtMinute20 = new System.Windows.Forms.TextBox();
            this.txtHour20 = new System.Windows.Forms.TextBox();
            this.txtHour19 = new System.Windows.Forms.TextBox();
            this.txtMinute19 = new System.Windows.Forms.TextBox();
            this.txtMinute18 = new System.Windows.Forms.TextBox();
            this.txtHour18 = new System.Windows.Forms.TextBox();
            this.txtHour17 = new System.Windows.Forms.TextBox();
            this.txtMinute17 = new System.Windows.Forms.TextBox();
            this.txtMinute16 = new System.Windows.Forms.TextBox();
            this.txtHour16 = new System.Windows.Forms.TextBox();
            this.chkValid23 = new System.Windows.Forms.CheckBox();
            this.chkValid22 = new System.Windows.Forms.CheckBox();
            this.chkValid21 = new System.Windows.Forms.CheckBox();
            this.chkValid20 = new System.Windows.Forms.CheckBox();
            this.chkValid19 = new System.Windows.Forms.CheckBox();
            this.chkValid18 = new System.Windows.Forms.CheckBox();
            this.chkValid17 = new System.Windows.Forms.CheckBox();
            this.chkValid16 = new System.Windows.Forms.CheckBox();
            this.Label2_40 = new System.Windows.Forms.Label();
            this.Label2_47 = new System.Windows.Forms.Label();
            this.Label2_46 = new System.Windows.Forms.Label();
            this.Label2_45 = new System.Windows.Forms.Label();
            this.Label2_44 = new System.Windows.Forms.Label();
            this.Label2_43 = new System.Windows.Forms.Label();
            this.Label2_42 = new System.Windows.Forms.Label();
            this.Label2_41 = new System.Windows.Forms.Label();
            this.Label2_39 = new System.Windows.Forms.Label();
            this.Label2_38 = new System.Windows.Forms.Label();
            this.Label2_37 = new System.Windows.Forms.Label();
            this.Label2_36 = new System.Windows.Forms.Label();
            this.Label2_35 = new System.Windows.Forms.Label();
            this.Label2_34 = new System.Windows.Forms.Label();
            this.Label2_33 = new System.Windows.Forms.Label();
            this.Label2_32 = new System.Windows.Forms.Label();
            this.txtHour15 = new System.Windows.Forms.TextBox();
            this.txtMinute15 = new System.Windows.Forms.TextBox();
            this.txtMinute14 = new System.Windows.Forms.TextBox();
            this.txtHour14 = new System.Windows.Forms.TextBox();
            this.txtHour13 = new System.Windows.Forms.TextBox();
            this.txtMinute13 = new System.Windows.Forms.TextBox();
            this.txtMinute12 = new System.Windows.Forms.TextBox();
            this.txtHour12 = new System.Windows.Forms.TextBox();
            this.txtHour11 = new System.Windows.Forms.TextBox();
            this.txtMinute11 = new System.Windows.Forms.TextBox();
            this.txtMinute10 = new System.Windows.Forms.TextBox();
            this.txtHour10 = new System.Windows.Forms.TextBox();
            this.txtHour9 = new System.Windows.Forms.TextBox();
            this.txtMinute9 = new System.Windows.Forms.TextBox();
            this.txtMinute8 = new System.Windows.Forms.TextBox();
            this.txtHour8 = new System.Windows.Forms.TextBox();
            this.chkValid15 = new System.Windows.Forms.CheckBox();
            this.chkValid14 = new System.Windows.Forms.CheckBox();
            this.chkValid13 = new System.Windows.Forms.CheckBox();
            this.chkValid12 = new System.Windows.Forms.CheckBox();
            this.chkValid11 = new System.Windows.Forms.CheckBox();
            this.chkValid10 = new System.Windows.Forms.CheckBox();
            this.chkValid9 = new System.Windows.Forms.CheckBox();
            this.chkValid8 = new System.Windows.Forms.CheckBox();
            this.Label2_24 = new System.Windows.Forms.Label();
            this.Label2_31 = new System.Windows.Forms.Label();
            this.Label2_30 = new System.Windows.Forms.Label();
            this.Label2_29 = new System.Windows.Forms.Label();
            this.Label2_28 = new System.Windows.Forms.Label();
            this.Label2_27 = new System.Windows.Forms.Label();
            this.Label2_26 = new System.Windows.Forms.Label();
            this.Label2_25 = new System.Windows.Forms.Label();
            this.Label2_23 = new System.Windows.Forms.Label();
            this.Label2_22 = new System.Windows.Forms.Label();
            this.Label2_21 = new System.Windows.Forms.Label();
            this.Label2_20 = new System.Windows.Forms.Label();
            this.Label2_19 = new System.Windows.Forms.Label();
            this.Label2_18 = new System.Windows.Forms.Label();
            this.Label2_17 = new System.Windows.Forms.Label();
            this.Label2_16 = new System.Windows.Forms.Label();
            this.txtBellCount = new System.Windows.Forms.TextBox();
            this.txtHour7 = new System.Windows.Forms.TextBox();
            this.txtMinute7 = new System.Windows.Forms.TextBox();
            this.txtMinute6 = new System.Windows.Forms.TextBox();
            this.txtHour6 = new System.Windows.Forms.TextBox();
            this.txtHour5 = new System.Windows.Forms.TextBox();
            this.txtMinute5 = new System.Windows.Forms.TextBox();
            this.txtMinute4 = new System.Windows.Forms.TextBox();
            this.txtHour4 = new System.Windows.Forms.TextBox();
            this.txtHour3 = new System.Windows.Forms.TextBox();
            this.txtMinute3 = new System.Windows.Forms.TextBox();
            this.txtMinute2 = new System.Windows.Forms.TextBox();
            this.txtHour2 = new System.Windows.Forms.TextBox();
            this.txtHour1 = new System.Windows.Forms.TextBox();
            this.txtMinute1 = new System.Windows.Forms.TextBox();
            this.txtMinute0 = new System.Windows.Forms.TextBox();
            this.txtHour0 = new System.Windows.Forms.TextBox();
            this.chkValid7 = new System.Windows.Forms.CheckBox();
            this.chkValid6 = new System.Windows.Forms.CheckBox();
            this.chkValid5 = new System.Windows.Forms.CheckBox();
            this.chkValid4 = new System.Windows.Forms.CheckBox();
            this.chkValid3 = new System.Windows.Forms.CheckBox();
            this.chkValid2 = new System.Windows.Forms.CheckBox();
            this.chkValid1 = new System.Windows.Forms.CheckBox();
            this.chkValid0 = new System.Windows.Forms.CheckBox();
            this.cmdWrite = new System.Windows.Forms.Button();
            this.cmdRead = new System.Windows.Forms.Button();
            this.Label2_8 = new System.Windows.Forms.Label();
            this.Label2_15 = new System.Windows.Forms.Label();
            this.Label2_14 = new System.Windows.Forms.Label();
            this.Label2_13 = new System.Windows.Forms.Label();
            this.Label2_12 = new System.Windows.Forms.Label();
            this.Label2_11 = new System.Windows.Forms.Label();
            this.Label2_10 = new System.Windows.Forms.Label();
            this.Label2_9 = new System.Windows.Forms.Label();
            this.lblCaption0 = new System.Windows.Forms.Label();
            this.Label2_7 = new System.Windows.Forms.Label();
            this.Label2_6 = new System.Windows.Forms.Label();
            this.Label2_5 = new System.Windows.Forms.Label();
            this.Label2_4 = new System.Windows.Forms.Label();
            this.Label2_3 = new System.Windows.Forms.Label();
            this.Label2_2 = new System.Windows.Forms.Label();
            this.Label2_1 = new System.Windows.Forms.Label();
            this.Label2_0 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(452, 66);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(202, 20);
            this.Label4.TabIndex = 257;
            this.Label4.Text = "Point   UseFlag   Start Time";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(232, 66);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(202, 20);
            this.Label3.TabIndex = 256;
            this.Label3.Text = "Point   UseFlag   Start Time";
            // 
            // txtHour23
            // 
            this.txtHour23.AcceptsReturn = true;
            this.txtHour23.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour23.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour23.Location = new System.Drawing.Point(546, 287);
            this.txtHour23.MaxLength = 0;
            this.txtHour23.Name = "txtHour23";
            this.txtHour23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour23.Size = new System.Drawing.Size(42, 28);
            this.txtHour23.TabIndex = 238;
            // 
            // txtMinute23
            // 
            this.txtMinute23.AcceptsReturn = true;
            this.txtMinute23.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute23.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute23.Location = new System.Drawing.Point(606, 287);
            this.txtMinute23.MaxLength = 0;
            this.txtMinute23.Name = "txtMinute23";
            this.txtMinute23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute23.Size = new System.Drawing.Size(42, 28);
            this.txtMinute23.TabIndex = 239;
            // 
            // txtMinute22
            // 
            this.txtMinute22.AcceptsReturn = true;
            this.txtMinute22.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute22.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute22.Location = new System.Drawing.Point(606, 259);
            this.txtMinute22.MaxLength = 0;
            this.txtMinute22.Name = "txtMinute22";
            this.txtMinute22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute22.Size = new System.Drawing.Size(42, 28);
            this.txtMinute22.TabIndex = 236;
            // 
            // txtHour22
            // 
            this.txtHour22.AcceptsReturn = true;
            this.txtHour22.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour22.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour22.Location = new System.Drawing.Point(546, 259);
            this.txtHour22.MaxLength = 0;
            this.txtHour22.Name = "txtHour22";
            this.txtHour22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour22.Size = new System.Drawing.Size(42, 28);
            this.txtHour22.TabIndex = 235;
            // 
            // txtHour21
            // 
            this.txtHour21.AcceptsReturn = true;
            this.txtHour21.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour21.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour21.Location = new System.Drawing.Point(546, 231);
            this.txtHour21.MaxLength = 0;
            this.txtHour21.Name = "txtHour21";
            this.txtHour21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour21.Size = new System.Drawing.Size(42, 28);
            this.txtHour21.TabIndex = 232;
            // 
            // txtMinute21
            // 
            this.txtMinute21.AcceptsReturn = true;
            this.txtMinute21.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute21.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute21.Location = new System.Drawing.Point(606, 231);
            this.txtMinute21.MaxLength = 0;
            this.txtMinute21.Name = "txtMinute21";
            this.txtMinute21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute21.Size = new System.Drawing.Size(42, 28);
            this.txtMinute21.TabIndex = 233;
            // 
            // txtMinute20
            // 
            this.txtMinute20.AcceptsReturn = true;
            this.txtMinute20.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute20.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute20.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute20.Location = new System.Drawing.Point(606, 203);
            this.txtMinute20.MaxLength = 0;
            this.txtMinute20.Name = "txtMinute20";
            this.txtMinute20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute20.Size = new System.Drawing.Size(42, 28);
            this.txtMinute20.TabIndex = 230;
            // 
            // txtHour20
            // 
            this.txtHour20.AcceptsReturn = true;
            this.txtHour20.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour20.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour20.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour20.Location = new System.Drawing.Point(546, 203);
            this.txtHour20.MaxLength = 0;
            this.txtHour20.Name = "txtHour20";
            this.txtHour20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour20.Size = new System.Drawing.Size(42, 28);
            this.txtHour20.TabIndex = 229;
            // 
            // txtHour19
            // 
            this.txtHour19.AcceptsReturn = true;
            this.txtHour19.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour19.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour19.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour19.Location = new System.Drawing.Point(546, 175);
            this.txtHour19.MaxLength = 0;
            this.txtHour19.Name = "txtHour19";
            this.txtHour19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour19.Size = new System.Drawing.Size(42, 28);
            this.txtHour19.TabIndex = 226;
            // 
            // txtMinute19
            // 
            this.txtMinute19.AcceptsReturn = true;
            this.txtMinute19.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute19.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute19.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute19.Location = new System.Drawing.Point(606, 175);
            this.txtMinute19.MaxLength = 0;
            this.txtMinute19.Name = "txtMinute19";
            this.txtMinute19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute19.Size = new System.Drawing.Size(42, 28);
            this.txtMinute19.TabIndex = 227;
            // 
            // txtMinute18
            // 
            this.txtMinute18.AcceptsReturn = true;
            this.txtMinute18.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute18.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute18.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute18.Location = new System.Drawing.Point(606, 148);
            this.txtMinute18.MaxLength = 0;
            this.txtMinute18.Name = "txtMinute18";
            this.txtMinute18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute18.Size = new System.Drawing.Size(42, 28);
            this.txtMinute18.TabIndex = 224;
            // 
            // txtHour18
            // 
            this.txtHour18.AcceptsReturn = true;
            this.txtHour18.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour18.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour18.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour18.Location = new System.Drawing.Point(546, 148);
            this.txtHour18.MaxLength = 0;
            this.txtHour18.Name = "txtHour18";
            this.txtHour18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour18.Size = new System.Drawing.Size(42, 28);
            this.txtHour18.TabIndex = 223;
            // 
            // txtHour17
            // 
            this.txtHour17.AcceptsReturn = true;
            this.txtHour17.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour17.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour17.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour17.Location = new System.Drawing.Point(546, 120);
            this.txtHour17.MaxLength = 0;
            this.txtHour17.Name = "txtHour17";
            this.txtHour17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour17.Size = new System.Drawing.Size(42, 28);
            this.txtHour17.TabIndex = 220;
            // 
            // txtMinute17
            // 
            this.txtMinute17.AcceptsReturn = true;
            this.txtMinute17.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute17.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute17.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute17.Location = new System.Drawing.Point(606, 120);
            this.txtMinute17.MaxLength = 0;
            this.txtMinute17.Name = "txtMinute17";
            this.txtMinute17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute17.Size = new System.Drawing.Size(42, 28);
            this.txtMinute17.TabIndex = 221;
            // 
            // txtMinute16
            // 
            this.txtMinute16.AcceptsReturn = true;
            this.txtMinute16.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute16.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute16.Location = new System.Drawing.Point(606, 92);
            this.txtMinute16.MaxLength = 0;
            this.txtMinute16.Name = "txtMinute16";
            this.txtMinute16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute16.Size = new System.Drawing.Size(42, 28);
            this.txtMinute16.TabIndex = 218;
            // 
            // txtHour16
            // 
            this.txtHour16.AcceptsReturn = true;
            this.txtHour16.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour16.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour16.Location = new System.Drawing.Point(546, 92);
            this.txtHour16.MaxLength = 0;
            this.txtHour16.Name = "txtHour16";
            this.txtHour16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour16.Size = new System.Drawing.Size(42, 28);
            this.txtHour16.TabIndex = 217;
            // 
            // chkValid23
            // 
            this.chkValid23.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid23.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid23.Location = new System.Drawing.Point(520, 290);
            this.chkValid23.Name = "chkValid23";
            this.chkValid23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid23.Size = new System.Drawing.Size(14, 20);
            this.chkValid23.TabIndex = 237;
            this.chkValid23.Text = "";
            this.chkValid23.UseVisualStyleBackColor = false;
            // 
            // chkValid22
            // 
            this.chkValid22.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid22.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid22.Location = new System.Drawing.Point(520, 262);
            this.chkValid22.Name = "chkValid22";
            this.chkValid22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid22.Size = new System.Drawing.Size(14, 20);
            this.chkValid22.TabIndex = 234;
            this.chkValid22.Text = "";
            this.chkValid22.UseVisualStyleBackColor = false;
            // 
            // chkValid21
            // 
            this.chkValid21.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid21.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid21.Location = new System.Drawing.Point(520, 234);
            this.chkValid21.Name = "chkValid21";
            this.chkValid21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid21.Size = new System.Drawing.Size(14, 20);
            this.chkValid21.TabIndex = 231;
            this.chkValid21.Text = "";
            this.chkValid21.UseVisualStyleBackColor = false;
            // 
            // chkValid20
            // 
            this.chkValid20.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid20.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid20.Location = new System.Drawing.Point(520, 206);
            this.chkValid20.Name = "chkValid20";
            this.chkValid20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid20.Size = new System.Drawing.Size(14, 20);
            this.chkValid20.TabIndex = 228;
            this.chkValid20.Text = "";
            this.chkValid20.UseVisualStyleBackColor = false;
            // 
            // chkValid19
            // 
            this.chkValid19.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid19.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid19.Location = new System.Drawing.Point(520, 178);
            this.chkValid19.Name = "chkValid19";
            this.chkValid19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid19.Size = new System.Drawing.Size(14, 20);
            this.chkValid19.TabIndex = 225;
            this.chkValid19.Text = "";
            this.chkValid19.UseVisualStyleBackColor = false;
            // 
            // chkValid18
            // 
            this.chkValid18.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid18.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid18.Location = new System.Drawing.Point(520, 151);
            this.chkValid18.Name = "chkValid18";
            this.chkValid18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid18.Size = new System.Drawing.Size(14, 20);
            this.chkValid18.TabIndex = 222;
            this.chkValid18.Text = "";
            this.chkValid18.UseVisualStyleBackColor = false;
            // 
            // chkValid17
            // 
            this.chkValid17.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid17.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid17.Location = new System.Drawing.Point(520, 123);
            this.chkValid17.Name = "chkValid17";
            this.chkValid17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid17.Size = new System.Drawing.Size(14, 20);
            this.chkValid17.TabIndex = 219;
            this.chkValid17.Text = "";
            this.chkValid17.UseVisualStyleBackColor = false;
            // 
            // chkValid16
            // 
            this.chkValid16.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid16.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid16.Location = new System.Drawing.Point(520, 96);
            this.chkValid16.Name = "chkValid16";
            this.chkValid16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid16.Size = new System.Drawing.Size(14, 20);
            this.chkValid16.TabIndex = 216;
            this.chkValid16.Text = "";
            this.chkValid16.UseVisualStyleBackColor = false;
            // 
            // Label2_40
            // 
            this.Label2_40.BackColor = System.Drawing.Color.Transparent;
            this.Label2_40.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_40.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_40.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_40.Location = new System.Drawing.Point(596, 96);
            this.Label2_40.Name = "Label2_40";
            this.Label2_40.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_40.Size = new System.Drawing.Size(6, 20);
            this.Label2_40.TabIndex = 255;
            this.Label2_40.Text = ":";
            this.Label2_40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_47
            // 
            this.Label2_47.BackColor = System.Drawing.Color.Transparent;
            this.Label2_47.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_47.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_47.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_47.Location = new System.Drawing.Point(596, 290);
            this.Label2_47.Name = "Label2_47";
            this.Label2_47.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_47.Size = new System.Drawing.Size(6, 20);
            this.Label2_47.TabIndex = 254;
            this.Label2_47.Text = ":";
            this.Label2_47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_46
            // 
            this.Label2_46.BackColor = System.Drawing.Color.Transparent;
            this.Label2_46.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_46.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_46.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_46.Location = new System.Drawing.Point(596, 262);
            this.Label2_46.Name = "Label2_46";
            this.Label2_46.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_46.Size = new System.Drawing.Size(6, 20);
            this.Label2_46.TabIndex = 253;
            this.Label2_46.Text = ":";
            this.Label2_46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_45
            // 
            this.Label2_45.BackColor = System.Drawing.Color.Transparent;
            this.Label2_45.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_45.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_45.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_45.Location = new System.Drawing.Point(596, 234);
            this.Label2_45.Name = "Label2_45";
            this.Label2_45.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_45.Size = new System.Drawing.Size(6, 20);
            this.Label2_45.TabIndex = 252;
            this.Label2_45.Text = ":";
            this.Label2_45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_44
            // 
            this.Label2_44.BackColor = System.Drawing.Color.Transparent;
            this.Label2_44.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_44.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_44.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_44.Location = new System.Drawing.Point(596, 206);
            this.Label2_44.Name = "Label2_44";
            this.Label2_44.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_44.Size = new System.Drawing.Size(6, 20);
            this.Label2_44.TabIndex = 251;
            this.Label2_44.Text = ":";
            this.Label2_44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_43
            // 
            this.Label2_43.BackColor = System.Drawing.Color.Transparent;
            this.Label2_43.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_43.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_43.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_43.Location = new System.Drawing.Point(596, 178);
            this.Label2_43.Name = "Label2_43";
            this.Label2_43.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_43.Size = new System.Drawing.Size(6, 20);
            this.Label2_43.TabIndex = 250;
            this.Label2_43.Text = ":";
            this.Label2_43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_42
            // 
            this.Label2_42.BackColor = System.Drawing.Color.Transparent;
            this.Label2_42.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_42.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_42.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_42.Location = new System.Drawing.Point(596, 151);
            this.Label2_42.Name = "Label2_42";
            this.Label2_42.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_42.Size = new System.Drawing.Size(6, 20);
            this.Label2_42.TabIndex = 249;
            this.Label2_42.Text = ":";
            this.Label2_42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_41
            // 
            this.Label2_41.BackColor = System.Drawing.Color.Transparent;
            this.Label2_41.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_41.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_41.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_41.Location = new System.Drawing.Point(596, 123);
            this.Label2_41.Name = "Label2_41";
            this.Label2_41.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_41.Size = new System.Drawing.Size(6, 20);
            this.Label2_41.TabIndex = 248;
            this.Label2_41.Text = ":";
            this.Label2_41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_39
            // 
            this.Label2_39.BackColor = System.Drawing.Color.Transparent;
            this.Label2_39.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_39.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_39.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_39.Location = new System.Drawing.Point(450, 290);
            this.Label2_39.Name = "Label2_39";
            this.Label2_39.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_39.Size = new System.Drawing.Size(66, 20);
            this.Label2_39.TabIndex = 247;
            this.Label2_39.Text = "Point 24:";
            // 
            // Label2_38
            // 
            this.Label2_38.BackColor = System.Drawing.Color.Transparent;
            this.Label2_38.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_38.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_38.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_38.Location = new System.Drawing.Point(450, 262);
            this.Label2_38.Name = "Label2_38";
            this.Label2_38.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_38.Size = new System.Drawing.Size(66, 20);
            this.Label2_38.TabIndex = 246;
            this.Label2_38.Text = "Point 23:";
            // 
            // Label2_37
            // 
            this.Label2_37.BackColor = System.Drawing.Color.Transparent;
            this.Label2_37.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_37.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_37.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_37.Location = new System.Drawing.Point(450, 234);
            this.Label2_37.Name = "Label2_37";
            this.Label2_37.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_37.Size = new System.Drawing.Size(66, 20);
            this.Label2_37.TabIndex = 245;
            this.Label2_37.Text = "Point 22:";
            // 
            // Label2_36
            // 
            this.Label2_36.BackColor = System.Drawing.Color.Transparent;
            this.Label2_36.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_36.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_36.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_36.Location = new System.Drawing.Point(450, 206);
            this.Label2_36.Name = "Label2_36";
            this.Label2_36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_36.Size = new System.Drawing.Size(66, 20);
            this.Label2_36.TabIndex = 244;
            this.Label2_36.Text = "Point 21:";
            // 
            // Label2_35
            // 
            this.Label2_35.BackColor = System.Drawing.Color.Transparent;
            this.Label2_35.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_35.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_35.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_35.Location = new System.Drawing.Point(450, 178);
            this.Label2_35.Name = "Label2_35";
            this.Label2_35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_35.Size = new System.Drawing.Size(66, 20);
            this.Label2_35.TabIndex = 243;
            this.Label2_35.Text = "Point 20:";
            // 
            // Label2_34
            // 
            this.Label2_34.BackColor = System.Drawing.Color.Transparent;
            this.Label2_34.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_34.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_34.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_34.Location = new System.Drawing.Point(450, 151);
            this.Label2_34.Name = "Label2_34";
            this.Label2_34.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_34.Size = new System.Drawing.Size(66, 20);
            this.Label2_34.TabIndex = 242;
            this.Label2_34.Text = "Point 19:";
            // 
            // Label2_33
            // 
            this.Label2_33.BackColor = System.Drawing.Color.Transparent;
            this.Label2_33.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_33.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_33.Location = new System.Drawing.Point(450, 123);
            this.Label2_33.Name = "Label2_33";
            this.Label2_33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_33.Size = new System.Drawing.Size(66, 20);
            this.Label2_33.TabIndex = 241;
            this.Label2_33.Text = "Point 18:";
            // 
            // Label2_32
            // 
            this.Label2_32.BackColor = System.Drawing.Color.Transparent;
            this.Label2_32.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_32.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_32.Location = new System.Drawing.Point(450, 96);
            this.Label2_32.Name = "Label2_32";
            this.Label2_32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_32.Size = new System.Drawing.Size(66, 20);
            this.Label2_32.TabIndex = 240;
            this.Label2_32.Text = "Point 17:";
            // 
            // txtHour15
            // 
            this.txtHour15.AcceptsReturn = true;
            this.txtHour15.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour15.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour15.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour15.Location = new System.Drawing.Point(326, 287);
            this.txtHour15.MaxLength = 0;
            this.txtHour15.Name = "txtHour15";
            this.txtHour15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour15.Size = new System.Drawing.Size(42, 28);
            this.txtHour15.TabIndex = 198;
            // 
            // txtMinute15
            // 
            this.txtMinute15.AcceptsReturn = true;
            this.txtMinute15.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute15.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute15.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute15.Location = new System.Drawing.Point(386, 287);
            this.txtMinute15.MaxLength = 0;
            this.txtMinute15.Name = "txtMinute15";
            this.txtMinute15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute15.Size = new System.Drawing.Size(42, 28);
            this.txtMinute15.TabIndex = 199;
            // 
            // txtMinute14
            // 
            this.txtMinute14.AcceptsReturn = true;
            this.txtMinute14.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute14.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute14.Location = new System.Drawing.Point(386, 259);
            this.txtMinute14.MaxLength = 0;
            this.txtMinute14.Name = "txtMinute14";
            this.txtMinute14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute14.Size = new System.Drawing.Size(42, 28);
            this.txtMinute14.TabIndex = 196;
            // 
            // txtHour14
            // 
            this.txtHour14.AcceptsReturn = true;
            this.txtHour14.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour14.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour14.Location = new System.Drawing.Point(326, 259);
            this.txtHour14.MaxLength = 0;
            this.txtHour14.Name = "txtHour14";
            this.txtHour14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour14.Size = new System.Drawing.Size(42, 28);
            this.txtHour14.TabIndex = 195;
            // 
            // txtHour13
            // 
            this.txtHour13.AcceptsReturn = true;
            this.txtHour13.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour13.Location = new System.Drawing.Point(326, 231);
            this.txtHour13.MaxLength = 0;
            this.txtHour13.Name = "txtHour13";
            this.txtHour13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour13.Size = new System.Drawing.Size(42, 28);
            this.txtHour13.TabIndex = 192;
            // 
            // txtMinute13
            // 
            this.txtMinute13.AcceptsReturn = true;
            this.txtMinute13.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute13.Location = new System.Drawing.Point(386, 231);
            this.txtMinute13.MaxLength = 0;
            this.txtMinute13.Name = "txtMinute13";
            this.txtMinute13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute13.Size = new System.Drawing.Size(42, 28);
            this.txtMinute13.TabIndex = 193;
            // 
            // txtMinute12
            // 
            this.txtMinute12.AcceptsReturn = true;
            this.txtMinute12.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute12.Location = new System.Drawing.Point(386, 203);
            this.txtMinute12.MaxLength = 0;
            this.txtMinute12.Name = "txtMinute12";
            this.txtMinute12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute12.Size = new System.Drawing.Size(42, 28);
            this.txtMinute12.TabIndex = 190;
            // 
            // txtHour12
            // 
            this.txtHour12.AcceptsReturn = true;
            this.txtHour12.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour12.Location = new System.Drawing.Point(326, 203);
            this.txtHour12.MaxLength = 0;
            this.txtHour12.Name = "txtHour12";
            this.txtHour12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour12.Size = new System.Drawing.Size(42, 28);
            this.txtHour12.TabIndex = 189;
            // 
            // txtHour11
            // 
            this.txtHour11.AcceptsReturn = true;
            this.txtHour11.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour11.Location = new System.Drawing.Point(326, 175);
            this.txtHour11.MaxLength = 0;
            this.txtHour11.Name = "txtHour11";
            this.txtHour11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour11.Size = new System.Drawing.Size(42, 28);
            this.txtHour11.TabIndex = 186;
            // 
            // txtMinute11
            // 
            this.txtMinute11.AcceptsReturn = true;
            this.txtMinute11.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute11.Location = new System.Drawing.Point(386, 175);
            this.txtMinute11.MaxLength = 0;
            this.txtMinute11.Name = "txtMinute11";
            this.txtMinute11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute11.Size = new System.Drawing.Size(42, 28);
            this.txtMinute11.TabIndex = 187;
            // 
            // txtMinute10
            // 
            this.txtMinute10.AcceptsReturn = true;
            this.txtMinute10.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute10.Location = new System.Drawing.Point(386, 148);
            this.txtMinute10.MaxLength = 0;
            this.txtMinute10.Name = "txtMinute10";
            this.txtMinute10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute10.Size = new System.Drawing.Size(42, 28);
            this.txtMinute10.TabIndex = 184;
            // 
            // txtHour10
            // 
            this.txtHour10.AcceptsReturn = true;
            this.txtHour10.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour10.Location = new System.Drawing.Point(326, 148);
            this.txtHour10.MaxLength = 0;
            this.txtHour10.Name = "txtHour10";
            this.txtHour10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour10.Size = new System.Drawing.Size(42, 28);
            this.txtHour10.TabIndex = 183;
            // 
            // txtHour9
            // 
            this.txtHour9.AcceptsReturn = true;
            this.txtHour9.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour9.Location = new System.Drawing.Point(326, 120);
            this.txtHour9.MaxLength = 0;
            this.txtHour9.Name = "txtHour9";
            this.txtHour9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour9.Size = new System.Drawing.Size(42, 28);
            this.txtHour9.TabIndex = 180;
            // 
            // txtMinute9
            // 
            this.txtMinute9.AcceptsReturn = true;
            this.txtMinute9.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute9.Location = new System.Drawing.Point(386, 120);
            this.txtMinute9.MaxLength = 0;
            this.txtMinute9.Name = "txtMinute9";
            this.txtMinute9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute9.Size = new System.Drawing.Size(42, 28);
            this.txtMinute9.TabIndex = 181;
            // 
            // txtMinute8
            // 
            this.txtMinute8.AcceptsReturn = true;
            this.txtMinute8.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute8.Location = new System.Drawing.Point(386, 92);
            this.txtMinute8.MaxLength = 0;
            this.txtMinute8.Name = "txtMinute8";
            this.txtMinute8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute8.Size = new System.Drawing.Size(42, 28);
            this.txtMinute8.TabIndex = 178;
            // 
            // txtHour8
            // 
            this.txtHour8.AcceptsReturn = true;
            this.txtHour8.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour8.Location = new System.Drawing.Point(326, 92);
            this.txtHour8.MaxLength = 0;
            this.txtHour8.Name = "txtHour8";
            this.txtHour8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour8.Size = new System.Drawing.Size(42, 28);
            this.txtHour8.TabIndex = 177;
            // 
            // chkValid15
            // 
            this.chkValid15.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid15.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid15.Location = new System.Drawing.Point(300, 290);
            this.chkValid15.Name = "chkValid15";
            this.chkValid15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid15.Size = new System.Drawing.Size(14, 20);
            this.chkValid15.TabIndex = 197;
            this.chkValid15.Text = "";
            this.chkValid15.UseVisualStyleBackColor = false;
            // 
            // chkValid14
            // 
            this.chkValid14.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid14.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid14.Location = new System.Drawing.Point(300, 262);
            this.chkValid14.Name = "chkValid14";
            this.chkValid14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid14.Size = new System.Drawing.Size(14, 20);
            this.chkValid14.TabIndex = 194;
            this.chkValid14.Text = "";
            this.chkValid14.UseVisualStyleBackColor = false;
            // 
            // chkValid13
            // 
            this.chkValid13.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid13.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid13.Location = new System.Drawing.Point(300, 234);
            this.chkValid13.Name = "chkValid13";
            this.chkValid13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid13.Size = new System.Drawing.Size(14, 20);
            this.chkValid13.TabIndex = 191;
            this.chkValid13.Text = "";
            this.chkValid13.UseVisualStyleBackColor = false;
            // 
            // chkValid12
            // 
            this.chkValid12.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid12.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid12.Location = new System.Drawing.Point(300, 206);
            this.chkValid12.Name = "chkValid12";
            this.chkValid12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid12.Size = new System.Drawing.Size(14, 20);
            this.chkValid12.TabIndex = 188;
            this.chkValid12.Text = "";
            this.chkValid12.UseVisualStyleBackColor = false;
            // 
            // chkValid11
            // 
            this.chkValid11.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid11.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid11.Location = new System.Drawing.Point(300, 178);
            this.chkValid11.Name = "chkValid11";
            this.chkValid11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid11.Size = new System.Drawing.Size(14, 20);
            this.chkValid11.TabIndex = 185;
            this.chkValid11.Text = "";
            this.chkValid11.UseVisualStyleBackColor = false;
            // 
            // chkValid10
            // 
            this.chkValid10.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid10.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid10.Location = new System.Drawing.Point(300, 151);
            this.chkValid10.Name = "chkValid10";
            this.chkValid10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid10.Size = new System.Drawing.Size(14, 20);
            this.chkValid10.TabIndex = 182;
            this.chkValid10.Text = "";
            this.chkValid10.UseVisualStyleBackColor = false;
            // 
            // chkValid9
            // 
            this.chkValid9.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid9.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid9.Location = new System.Drawing.Point(300, 123);
            this.chkValid9.Name = "chkValid9";
            this.chkValid9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid9.Size = new System.Drawing.Size(14, 20);
            this.chkValid9.TabIndex = 179;
            this.chkValid9.Text = "";
            this.chkValid9.UseVisualStyleBackColor = false;
            // 
            // chkValid8
            // 
            this.chkValid8.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid8.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid8.Location = new System.Drawing.Point(300, 96);
            this.chkValid8.Name = "chkValid8";
            this.chkValid8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid8.Size = new System.Drawing.Size(14, 20);
            this.chkValid8.TabIndex = 176;
            this.chkValid8.Text = "";
            this.chkValid8.UseVisualStyleBackColor = false;
            // 
            // Label2_24
            // 
            this.Label2_24.BackColor = System.Drawing.Color.Transparent;
            this.Label2_24.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_24.Location = new System.Drawing.Point(376, 96);
            this.Label2_24.Name = "Label2_24";
            this.Label2_24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_24.Size = new System.Drawing.Size(6, 20);
            this.Label2_24.TabIndex = 215;
            this.Label2_24.Text = ":";
            this.Label2_24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_31
            // 
            this.Label2_31.BackColor = System.Drawing.Color.Transparent;
            this.Label2_31.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_31.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_31.Location = new System.Drawing.Point(376, 290);
            this.Label2_31.Name = "Label2_31";
            this.Label2_31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_31.Size = new System.Drawing.Size(6, 20);
            this.Label2_31.TabIndex = 214;
            this.Label2_31.Text = ":";
            this.Label2_31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_30
            // 
            this.Label2_30.BackColor = System.Drawing.Color.Transparent;
            this.Label2_30.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_30.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_30.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_30.Location = new System.Drawing.Point(376, 262);
            this.Label2_30.Name = "Label2_30";
            this.Label2_30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_30.Size = new System.Drawing.Size(6, 20);
            this.Label2_30.TabIndex = 213;
            this.Label2_30.Text = ":";
            this.Label2_30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_29
            // 
            this.Label2_29.BackColor = System.Drawing.Color.Transparent;
            this.Label2_29.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_29.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_29.Location = new System.Drawing.Point(376, 234);
            this.Label2_29.Name = "Label2_29";
            this.Label2_29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_29.Size = new System.Drawing.Size(6, 20);
            this.Label2_29.TabIndex = 212;
            this.Label2_29.Text = ":";
            this.Label2_29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_28
            // 
            this.Label2_28.BackColor = System.Drawing.Color.Transparent;
            this.Label2_28.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_28.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_28.Location = new System.Drawing.Point(376, 206);
            this.Label2_28.Name = "Label2_28";
            this.Label2_28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_28.Size = new System.Drawing.Size(6, 20);
            this.Label2_28.TabIndex = 211;
            this.Label2_28.Text = ":";
            this.Label2_28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_27
            // 
            this.Label2_27.BackColor = System.Drawing.Color.Transparent;
            this.Label2_27.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_27.Location = new System.Drawing.Point(376, 178);
            this.Label2_27.Name = "Label2_27";
            this.Label2_27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_27.Size = new System.Drawing.Size(6, 20);
            this.Label2_27.TabIndex = 210;
            this.Label2_27.Text = ":";
            this.Label2_27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_26
            // 
            this.Label2_26.BackColor = System.Drawing.Color.Transparent;
            this.Label2_26.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_26.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_26.Location = new System.Drawing.Point(376, 151);
            this.Label2_26.Name = "Label2_26";
            this.Label2_26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_26.Size = new System.Drawing.Size(6, 20);
            this.Label2_26.TabIndex = 209;
            this.Label2_26.Text = ":";
            this.Label2_26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_25
            // 
            this.Label2_25.BackColor = System.Drawing.Color.Transparent;
            this.Label2_25.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_25.Location = new System.Drawing.Point(376, 123);
            this.Label2_25.Name = "Label2_25";
            this.Label2_25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_25.Size = new System.Drawing.Size(6, 20);
            this.Label2_25.TabIndex = 208;
            this.Label2_25.Text = ":";
            this.Label2_25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_23
            // 
            this.Label2_23.BackColor = System.Drawing.Color.Transparent;
            this.Label2_23.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_23.Location = new System.Drawing.Point(230, 290);
            this.Label2_23.Name = "Label2_23";
            this.Label2_23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_23.Size = new System.Drawing.Size(66, 20);
            this.Label2_23.TabIndex = 207;
            this.Label2_23.Text = "Point 16:";
            // 
            // Label2_22
            // 
            this.Label2_22.BackColor = System.Drawing.Color.Transparent;
            this.Label2_22.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_22.Location = new System.Drawing.Point(230, 262);
            this.Label2_22.Name = "Label2_22";
            this.Label2_22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_22.Size = new System.Drawing.Size(66, 20);
            this.Label2_22.TabIndex = 206;
            this.Label2_22.Text = "Point 15:";
            // 
            // Label2_21
            // 
            this.Label2_21.BackColor = System.Drawing.Color.Transparent;
            this.Label2_21.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_21.Location = new System.Drawing.Point(230, 234);
            this.Label2_21.Name = "Label2_21";
            this.Label2_21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_21.Size = new System.Drawing.Size(66, 20);
            this.Label2_21.TabIndex = 205;
            this.Label2_21.Text = "Point 14:";
            // 
            // Label2_20
            // 
            this.Label2_20.BackColor = System.Drawing.Color.Transparent;
            this.Label2_20.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_20.Location = new System.Drawing.Point(230, 206);
            this.Label2_20.Name = "Label2_20";
            this.Label2_20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_20.Size = new System.Drawing.Size(66, 20);
            this.Label2_20.TabIndex = 204;
            this.Label2_20.Text = "Point 13:";
            // 
            // Label2_19
            // 
            this.Label2_19.BackColor = System.Drawing.Color.Transparent;
            this.Label2_19.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_19.Location = new System.Drawing.Point(230, 178);
            this.Label2_19.Name = "Label2_19";
            this.Label2_19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_19.Size = new System.Drawing.Size(66, 20);
            this.Label2_19.TabIndex = 203;
            this.Label2_19.Text = "Point 12:";
            // 
            // Label2_18
            // 
            this.Label2_18.BackColor = System.Drawing.Color.Transparent;
            this.Label2_18.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_18.Location = new System.Drawing.Point(230, 151);
            this.Label2_18.Name = "Label2_18";
            this.Label2_18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_18.Size = new System.Drawing.Size(66, 20);
            this.Label2_18.TabIndex = 202;
            this.Label2_18.Text = "Point 11:";
            // 
            // Label2_17
            // 
            this.Label2_17.BackColor = System.Drawing.Color.Transparent;
            this.Label2_17.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_17.Location = new System.Drawing.Point(230, 123);
            this.Label2_17.Name = "Label2_17";
            this.Label2_17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_17.Size = new System.Drawing.Size(66, 20);
            this.Label2_17.TabIndex = 201;
            this.Label2_17.Text = "Point 10:";
            // 
            // Label2_16
            // 
            this.Label2_16.BackColor = System.Drawing.Color.Transparent;
            this.Label2_16.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_16.Location = new System.Drawing.Point(230, 96);
            this.Label2_16.Name = "Label2_16";
            this.Label2_16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_16.Size = new System.Drawing.Size(66, 20);
            this.Label2_16.TabIndex = 200;
            this.Label2_16.Text = "Point 9:";
            // 
            // txtBellCount
            // 
            this.txtBellCount.AcceptsReturn = true;
            this.txtBellCount.BackColor = System.Drawing.SystemColors.Window;
            this.txtBellCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBellCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBellCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBellCount.Location = new System.Drawing.Point(330, 334);
            this.txtBellCount.MaxLength = 0;
            this.txtBellCount.Name = "txtBellCount";
            this.txtBellCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBellCount.Size = new System.Drawing.Size(39, 29);
            this.txtBellCount.TabIndex = 135;
            // 
            // txtHour7
            // 
            this.txtHour7.AcceptsReturn = true;
            this.txtHour7.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour7.Location = new System.Drawing.Point(106, 287);
            this.txtHour7.MaxLength = 0;
            this.txtHour7.Name = "txtHour7";
            this.txtHour7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour7.Size = new System.Drawing.Size(42, 28);
            this.txtHour7.TabIndex = 155;
            // 
            // txtMinute7
            // 
            this.txtMinute7.AcceptsReturn = true;
            this.txtMinute7.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute7.Location = new System.Drawing.Point(166, 287);
            this.txtMinute7.MaxLength = 0;
            this.txtMinute7.Name = "txtMinute7";
            this.txtMinute7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute7.Size = new System.Drawing.Size(42, 28);
            this.txtMinute7.TabIndex = 156;
            // 
            // txtMinute6
            // 
            this.txtMinute6.AcceptsReturn = true;
            this.txtMinute6.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute6.Location = new System.Drawing.Point(166, 259);
            this.txtMinute6.MaxLength = 0;
            this.txtMinute6.Name = "txtMinute6";
            this.txtMinute6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute6.Size = new System.Drawing.Size(42, 28);
            this.txtMinute6.TabIndex = 153;
            // 
            // txtHour6
            // 
            this.txtHour6.AcceptsReturn = true;
            this.txtHour6.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour6.Location = new System.Drawing.Point(106, 259);
            this.txtHour6.MaxLength = 0;
            this.txtHour6.Name = "txtHour6";
            this.txtHour6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour6.Size = new System.Drawing.Size(42, 28);
            this.txtHour6.TabIndex = 152;
            // 
            // txtHour5
            // 
            this.txtHour5.AcceptsReturn = true;
            this.txtHour5.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour5.Location = new System.Drawing.Point(106, 231);
            this.txtHour5.MaxLength = 0;
            this.txtHour5.Name = "txtHour5";
            this.txtHour5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour5.Size = new System.Drawing.Size(42, 28);
            this.txtHour5.TabIndex = 149;
            // 
            // txtMinute5
            // 
            this.txtMinute5.AcceptsReturn = true;
            this.txtMinute5.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute5.Location = new System.Drawing.Point(166, 231);
            this.txtMinute5.MaxLength = 0;
            this.txtMinute5.Name = "txtMinute5";
            this.txtMinute5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute5.Size = new System.Drawing.Size(42, 28);
            this.txtMinute5.TabIndex = 150;
            // 
            // txtMinute4
            // 
            this.txtMinute4.AcceptsReturn = true;
            this.txtMinute4.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute4.Location = new System.Drawing.Point(166, 203);
            this.txtMinute4.MaxLength = 0;
            this.txtMinute4.Name = "txtMinute4";
            this.txtMinute4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute4.Size = new System.Drawing.Size(42, 28);
            this.txtMinute4.TabIndex = 147;
            // 
            // txtHour4
            // 
            this.txtHour4.AcceptsReturn = true;
            this.txtHour4.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour4.Location = new System.Drawing.Point(106, 203);
            this.txtHour4.MaxLength = 0;
            this.txtHour4.Name = "txtHour4";
            this.txtHour4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour4.Size = new System.Drawing.Size(42, 28);
            this.txtHour4.TabIndex = 146;
            // 
            // txtHour3
            // 
            this.txtHour3.AcceptsReturn = true;
            this.txtHour3.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour3.Location = new System.Drawing.Point(106, 175);
            this.txtHour3.MaxLength = 0;
            this.txtHour3.Name = "txtHour3";
            this.txtHour3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour3.Size = new System.Drawing.Size(42, 28);
            this.txtHour3.TabIndex = 143;
            // 
            // txtMinute3
            // 
            this.txtMinute3.AcceptsReturn = true;
            this.txtMinute3.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute3.Location = new System.Drawing.Point(166, 175);
            this.txtMinute3.MaxLength = 0;
            this.txtMinute3.Name = "txtMinute3";
            this.txtMinute3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute3.Size = new System.Drawing.Size(42, 28);
            this.txtMinute3.TabIndex = 144;
            // 
            // txtMinute2
            // 
            this.txtMinute2.AcceptsReturn = true;
            this.txtMinute2.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute2.Location = new System.Drawing.Point(166, 148);
            this.txtMinute2.MaxLength = 0;
            this.txtMinute2.Name = "txtMinute2";
            this.txtMinute2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute2.Size = new System.Drawing.Size(42, 28);
            this.txtMinute2.TabIndex = 141;
            // 
            // txtHour2
            // 
            this.txtHour2.AcceptsReturn = true;
            this.txtHour2.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour2.Location = new System.Drawing.Point(106, 148);
            this.txtHour2.MaxLength = 0;
            this.txtHour2.Name = "txtHour2";
            this.txtHour2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour2.Size = new System.Drawing.Size(42, 28);
            this.txtHour2.TabIndex = 140;
            // 
            // txtHour1
            // 
            this.txtHour1.AcceptsReturn = true;
            this.txtHour1.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour1.Location = new System.Drawing.Point(106, 120);
            this.txtHour1.MaxLength = 0;
            this.txtHour1.Name = "txtHour1";
            this.txtHour1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour1.Size = new System.Drawing.Size(42, 28);
            this.txtHour1.TabIndex = 137;
            // 
            // txtMinute1
            // 
            this.txtMinute1.AcceptsReturn = true;
            this.txtMinute1.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute1.Location = new System.Drawing.Point(166, 120);
            this.txtMinute1.MaxLength = 0;
            this.txtMinute1.Name = "txtMinute1";
            this.txtMinute1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute1.Size = new System.Drawing.Size(42, 28);
            this.txtMinute1.TabIndex = 138;
            // 
            // txtMinute0
            // 
            this.txtMinute0.AcceptsReturn = true;
            this.txtMinute0.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute0.Location = new System.Drawing.Point(166, 92);
            this.txtMinute0.MaxLength = 0;
            this.txtMinute0.Name = "txtMinute0";
            this.txtMinute0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinute0.Size = new System.Drawing.Size(42, 28);
            this.txtMinute0.TabIndex = 134;
            // 
            // txtHour0
            // 
            this.txtHour0.AcceptsReturn = true;
            this.txtHour0.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHour0.Location = new System.Drawing.Point(106, 92);
            this.txtHour0.MaxLength = 0;
            this.txtHour0.Name = "txtHour0";
            this.txtHour0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHour0.Size = new System.Drawing.Size(42, 28);
            this.txtHour0.TabIndex = 132;
            // 
            // chkValid7
            // 
            this.chkValid7.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid7.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid7.Location = new System.Drawing.Point(80, 290);
            this.chkValid7.Name = "chkValid7";
            this.chkValid7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid7.Size = new System.Drawing.Size(14, 20);
            this.chkValid7.TabIndex = 154;
            this.chkValid7.Text = "";
            this.chkValid7.UseVisualStyleBackColor = false;
            // 
            // chkValid6
            // 
            this.chkValid6.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid6.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid6.Location = new System.Drawing.Point(80, 262);
            this.chkValid6.Name = "chkValid6";
            this.chkValid6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid6.Size = new System.Drawing.Size(14, 20);
            this.chkValid6.TabIndex = 151;
            this.chkValid6.Text = "";
            this.chkValid6.UseVisualStyleBackColor = false;
            // 
            // chkValid5
            // 
            this.chkValid5.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid5.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid5.Location = new System.Drawing.Point(80, 234);
            this.chkValid5.Name = "chkValid5";
            this.chkValid5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid5.Size = new System.Drawing.Size(14, 20);
            this.chkValid5.TabIndex = 148;
            this.chkValid5.Text = "";
            this.chkValid5.UseVisualStyleBackColor = false;
            // 
            // chkValid4
            // 
            this.chkValid4.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid4.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid4.Location = new System.Drawing.Point(80, 206);
            this.chkValid4.Name = "chkValid4";
            this.chkValid4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid4.Size = new System.Drawing.Size(14, 20);
            this.chkValid4.TabIndex = 145;
            this.chkValid4.Text = "";
            this.chkValid4.UseVisualStyleBackColor = false;
            // 
            // chkValid3
            // 
            this.chkValid3.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid3.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid3.Location = new System.Drawing.Point(80, 178);
            this.chkValid3.Name = "chkValid3";
            this.chkValid3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid3.Size = new System.Drawing.Size(14, 20);
            this.chkValid3.TabIndex = 142;
            this.chkValid3.Text = "";
            this.chkValid3.UseVisualStyleBackColor = false;
            // 
            // chkValid2
            // 
            this.chkValid2.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid2.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid2.Location = new System.Drawing.Point(80, 151);
            this.chkValid2.Name = "chkValid2";
            this.chkValid2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid2.Size = new System.Drawing.Size(14, 20);
            this.chkValid2.TabIndex = 139;
            this.chkValid2.Text = "";
            this.chkValid2.UseVisualStyleBackColor = false;
            // 
            // chkValid1
            // 
            this.chkValid1.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid1.Location = new System.Drawing.Point(80, 123);
            this.chkValid1.Name = "chkValid1";
            this.chkValid1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid1.Size = new System.Drawing.Size(14, 20);
            this.chkValid1.TabIndex = 136;
            this.chkValid1.Text = "";
            this.chkValid1.UseVisualStyleBackColor = false;
            // 
            // chkValid0
            // 
            this.chkValid0.BackColor = System.Drawing.SystemColors.Control;
            this.chkValid0.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkValid0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkValid0.Location = new System.Drawing.Point(80, 96);
            this.chkValid0.Name = "chkValid0";
            this.chkValid0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkValid0.Size = new System.Drawing.Size(14, 20);
            this.chkValid0.TabIndex = 130;
            this.chkValid0.Text = "";
            this.chkValid0.UseVisualStyleBackColor = false;
            // 
            // cmdWrite
            // 
            this.cmdWrite.BackColor = System.Drawing.SystemColors.Control;
            this.cmdWrite.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdWrite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWrite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdWrite.Location = new System.Drawing.Point(554, 334);
            this.cmdWrite.Name = "cmdWrite";
            this.cmdWrite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdWrite.Size = new System.Drawing.Size(99, 34);
            this.cmdWrite.TabIndex = 133;
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
            this.cmdRead.Location = new System.Drawing.Point(442, 334);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRead.Size = new System.Drawing.Size(99, 34);
            this.cmdRead.TabIndex = 131;
            this.cmdRead.Text = "Read";
            this.cmdRead.UseVisualStyleBackColor = false;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // Label2_8
            // 
            this.Label2_8.BackColor = System.Drawing.Color.Transparent;
            this.Label2_8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_8.Location = new System.Drawing.Point(156, 96);
            this.Label2_8.Name = "Label2_8";
            this.Label2_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_8.Size = new System.Drawing.Size(6, 20);
            this.Label2_8.TabIndex = 175;
            this.Label2_8.Text = ":";
            this.Label2_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_15
            // 
            this.Label2_15.BackColor = System.Drawing.Color.Transparent;
            this.Label2_15.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_15.Location = new System.Drawing.Point(156, 290);
            this.Label2_15.Name = "Label2_15";
            this.Label2_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_15.Size = new System.Drawing.Size(6, 20);
            this.Label2_15.TabIndex = 174;
            this.Label2_15.Text = ":";
            this.Label2_15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_14
            // 
            this.Label2_14.BackColor = System.Drawing.Color.Transparent;
            this.Label2_14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_14.Location = new System.Drawing.Point(156, 262);
            this.Label2_14.Name = "Label2_14";
            this.Label2_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_14.Size = new System.Drawing.Size(6, 20);
            this.Label2_14.TabIndex = 173;
            this.Label2_14.Text = ":";
            this.Label2_14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_13
            // 
            this.Label2_13.BackColor = System.Drawing.Color.Transparent;
            this.Label2_13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_13.Location = new System.Drawing.Point(156, 234);
            this.Label2_13.Name = "Label2_13";
            this.Label2_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_13.Size = new System.Drawing.Size(6, 20);
            this.Label2_13.TabIndex = 172;
            this.Label2_13.Text = ":";
            this.Label2_13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_12
            // 
            this.Label2_12.BackColor = System.Drawing.Color.Transparent;
            this.Label2_12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_12.Location = new System.Drawing.Point(156, 206);
            this.Label2_12.Name = "Label2_12";
            this.Label2_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_12.Size = new System.Drawing.Size(6, 20);
            this.Label2_12.TabIndex = 171;
            this.Label2_12.Text = ":";
            this.Label2_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_11
            // 
            this.Label2_11.BackColor = System.Drawing.Color.Transparent;
            this.Label2_11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_11.Location = new System.Drawing.Point(156, 178);
            this.Label2_11.Name = "Label2_11";
            this.Label2_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_11.Size = new System.Drawing.Size(6, 20);
            this.Label2_11.TabIndex = 170;
            this.Label2_11.Text = ":";
            this.Label2_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_10
            // 
            this.Label2_10.BackColor = System.Drawing.Color.Transparent;
            this.Label2_10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_10.Location = new System.Drawing.Point(156, 151);
            this.Label2_10.Name = "Label2_10";
            this.Label2_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_10.Size = new System.Drawing.Size(6, 20);
            this.Label2_10.TabIndex = 169;
            this.Label2_10.Text = ":";
            this.Label2_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2_9
            // 
            this.Label2_9.BackColor = System.Drawing.Color.Transparent;
            this.Label2_9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_9.Location = new System.Drawing.Point(156, 123);
            this.Label2_9.Name = "Label2_9";
            this.Label2_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_9.Size = new System.Drawing.Size(6, 20);
            this.Label2_9.TabIndex = 168;
            this.Label2_9.Text = ":";
            this.Label2_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaption0
            // 
            this.lblCaption0.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption0.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCaption0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCaption0.Location = new System.Drawing.Point(12, 66);
            this.lblCaption0.Name = "lblCaption0";
            this.lblCaption0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCaption0.Size = new System.Drawing.Size(202, 20);
            this.lblCaption0.TabIndex = 167;
            this.lblCaption0.Text = "Point   UseFlag   Start Time";
            // 
            // Label2_7
            // 
            this.Label2_7.BackColor = System.Drawing.Color.Transparent;
            this.Label2_7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_7.Location = new System.Drawing.Point(10, 290);
            this.Label2_7.Name = "Label2_7";
            this.Label2_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_7.Size = new System.Drawing.Size(66, 20);
            this.Label2_7.TabIndex = 166;
            this.Label2_7.Text = "Point 8:";
            // 
            // Label2_6
            // 
            this.Label2_6.BackColor = System.Drawing.Color.Transparent;
            this.Label2_6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_6.Location = new System.Drawing.Point(10, 262);
            this.Label2_6.Name = "Label2_6";
            this.Label2_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_6.Size = new System.Drawing.Size(66, 20);
            this.Label2_6.TabIndex = 165;
            this.Label2_6.Text = "Point 7:";
            // 
            // Label2_5
            // 
            this.Label2_5.BackColor = System.Drawing.Color.Transparent;
            this.Label2_5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_5.Location = new System.Drawing.Point(10, 234);
            this.Label2_5.Name = "Label2_5";
            this.Label2_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_5.Size = new System.Drawing.Size(66, 20);
            this.Label2_5.TabIndex = 164;
            this.Label2_5.Text = "Point 6:";
            // 
            // Label2_4
            // 
            this.Label2_4.BackColor = System.Drawing.Color.Transparent;
            this.Label2_4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_4.Location = new System.Drawing.Point(10, 206);
            this.Label2_4.Name = "Label2_4";
            this.Label2_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_4.Size = new System.Drawing.Size(66, 20);
            this.Label2_4.TabIndex = 163;
            this.Label2_4.Text = "Point 5:";
            // 
            // Label2_3
            // 
            this.Label2_3.BackColor = System.Drawing.Color.Transparent;
            this.Label2_3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_3.Location = new System.Drawing.Point(10, 178);
            this.Label2_3.Name = "Label2_3";
            this.Label2_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_3.Size = new System.Drawing.Size(66, 20);
            this.Label2_3.TabIndex = 162;
            this.Label2_3.Text = "Point 4:";
            // 
            // Label2_2
            // 
            this.Label2_2.BackColor = System.Drawing.Color.Transparent;
            this.Label2_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_2.Location = new System.Drawing.Point(10, 151);
            this.Label2_2.Name = "Label2_2";
            this.Label2_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_2.Size = new System.Drawing.Size(66, 20);
            this.Label2_2.TabIndex = 161;
            this.Label2_2.Text = "Point 3:";
            // 
            // Label2_1
            // 
            this.Label2_1.BackColor = System.Drawing.Color.Transparent;
            this.Label2_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_1.Location = new System.Drawing.Point(10, 123);
            this.Label2_1.Name = "Label2_1";
            this.Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_1.Size = new System.Drawing.Size(66, 20);
            this.Label2_1.TabIndex = 160;
            this.Label2_1.Text = "Point 2:";
            // 
            // Label2_0
            // 
            this.Label2_0.BackColor = System.Drawing.Color.Transparent;
            this.Label2_0.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2_0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2_0.Location = new System.Drawing.Point(10, 96);
            this.Label2_0.Name = "Label2_0";
            this.Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2_0.Size = new System.Drawing.Size(66, 20);
            this.Label2_0.TabIndex = 159;
            this.Label2_0.Text = "Point 1:";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(241, 340);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(91, 19);
            this.Label1.TabIndex = 158;
            this.Label1.Text = "Bell Count :";
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(15, 15);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(635, 28);
            this.lblMessage.TabIndex = 157;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmBellInfo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(664, 382);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtHour23);
            this.Controls.Add(this.txtMinute23);
            this.Controls.Add(this.txtMinute22);
            this.Controls.Add(this.txtHour22);
            this.Controls.Add(this.txtHour21);
            this.Controls.Add(this.txtMinute21);
            this.Controls.Add(this.txtMinute20);
            this.Controls.Add(this.txtHour20);
            this.Controls.Add(this.txtHour19);
            this.Controls.Add(this.txtMinute19);
            this.Controls.Add(this.txtMinute18);
            this.Controls.Add(this.txtHour18);
            this.Controls.Add(this.txtHour17);
            this.Controls.Add(this.txtMinute17);
            this.Controls.Add(this.txtMinute16);
            this.Controls.Add(this.txtHour16);
            this.Controls.Add(this.txtHour15);
            this.Controls.Add(this.txtMinute15);
            this.Controls.Add(this.txtMinute14);
            this.Controls.Add(this.txtHour14);
            this.Controls.Add(this.txtHour13);
            this.Controls.Add(this.txtMinute13);
            this.Controls.Add(this.txtMinute12);
            this.Controls.Add(this.txtHour12);
            this.Controls.Add(this.txtHour11);
            this.Controls.Add(this.txtMinute11);
            this.Controls.Add(this.txtMinute10);
            this.Controls.Add(this.txtHour10);
            this.Controls.Add(this.txtHour9);
            this.Controls.Add(this.txtMinute9);
            this.Controls.Add(this.txtMinute8);
            this.Controls.Add(this.txtHour8);
            this.Controls.Add(this.txtBellCount);
            this.Controls.Add(this.txtHour7);
            this.Controls.Add(this.txtMinute7);
            this.Controls.Add(this.txtMinute6);
            this.Controls.Add(this.txtHour6);
            this.Controls.Add(this.txtHour5);
            this.Controls.Add(this.txtMinute5);
            this.Controls.Add(this.txtMinute4);
            this.Controls.Add(this.txtHour4);
            this.Controls.Add(this.txtHour3);
            this.Controls.Add(this.txtMinute3);
            this.Controls.Add(this.txtMinute2);
            this.Controls.Add(this.txtHour2);
            this.Controls.Add(this.txtHour1);
            this.Controls.Add(this.txtMinute1);
            this.Controls.Add(this.txtMinute0);
            this.Controls.Add(this.txtHour0);
            this.Controls.Add(this.chkValid23);
            this.Controls.Add(this.chkValid22);
            this.Controls.Add(this.chkValid21);
            this.Controls.Add(this.chkValid20);
            this.Controls.Add(this.chkValid19);
            this.Controls.Add(this.chkValid18);
            this.Controls.Add(this.chkValid17);
            this.Controls.Add(this.chkValid16);
            this.Controls.Add(this.Label2_40);
            this.Controls.Add(this.Label2_47);
            this.Controls.Add(this.Label2_46);
            this.Controls.Add(this.Label2_45);
            this.Controls.Add(this.Label2_44);
            this.Controls.Add(this.Label2_43);
            this.Controls.Add(this.Label2_42);
            this.Controls.Add(this.Label2_41);
            this.Controls.Add(this.Label2_39);
            this.Controls.Add(this.Label2_38);
            this.Controls.Add(this.Label2_37);
            this.Controls.Add(this.Label2_36);
            this.Controls.Add(this.Label2_35);
            this.Controls.Add(this.Label2_34);
            this.Controls.Add(this.Label2_33);
            this.Controls.Add(this.Label2_32);
            this.Controls.Add(this.chkValid15);
            this.Controls.Add(this.chkValid14);
            this.Controls.Add(this.chkValid13);
            this.Controls.Add(this.chkValid12);
            this.Controls.Add(this.chkValid11);
            this.Controls.Add(this.chkValid10);
            this.Controls.Add(this.chkValid9);
            this.Controls.Add(this.chkValid8);
            this.Controls.Add(this.Label2_24);
            this.Controls.Add(this.Label2_31);
            this.Controls.Add(this.Label2_30);
            this.Controls.Add(this.Label2_29);
            this.Controls.Add(this.Label2_28);
            this.Controls.Add(this.Label2_27);
            this.Controls.Add(this.Label2_26);
            this.Controls.Add(this.Label2_25);
            this.Controls.Add(this.Label2_23);
            this.Controls.Add(this.Label2_22);
            this.Controls.Add(this.Label2_21);
            this.Controls.Add(this.Label2_20);
            this.Controls.Add(this.Label2_19);
            this.Controls.Add(this.Label2_18);
            this.Controls.Add(this.Label2_17);
            this.Controls.Add(this.Label2_16);
            this.Controls.Add(this.chkValid7);
            this.Controls.Add(this.chkValid6);
            this.Controls.Add(this.chkValid5);
            this.Controls.Add(this.chkValid4);
            this.Controls.Add(this.chkValid3);
            this.Controls.Add(this.chkValid2);
            this.Controls.Add(this.chkValid1);
            this.Controls.Add(this.chkValid0);
            this.Controls.Add(this.cmdWrite);
            this.Controls.Add(this.cmdRead);
            this.Controls.Add(this.Label2_8);
            this.Controls.Add(this.Label2_15);
            this.Controls.Add(this.Label2_14);
            this.Controls.Add(this.Label2_13);
            this.Controls.Add(this.Label2_12);
            this.Controls.Add(this.Label2_11);
            this.Controls.Add(this.Label2_10);
            this.Controls.Add(this.Label2_9);
            this.Controls.Add(this.lblCaption0);
            this.Controls.Add(this.Label2_7);
            this.Controls.Add(this.Label2_6);
            this.Controls.Add(this.Label2_5);
            this.Controls.Add(this.Label2_4);
            this.Controls.Add(this.Label2_3);
            this.Controls.Add(this.Label2_2);
            this.Controls.Add(this.Label2_1);
            this.Controls.Add(this.Label2_0);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(3, 29);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBellInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Bell Time";
            this.Load += new System.EventHandler(this.frmBellInfo_Load);
            this.ResumeLayout(false);

		}
		#endregion

        private int mnBellCount;
		private BELLINFO mBellInfo;

		private CheckBox[] fchkValid = new CheckBox[FKAttendDLL.MAX_BELLCOUNT_DAY];
		private TextBox[] ftxtHour = new TextBox[FKAttendDLL.MAX_BELLCOUNT_DAY];
		private TextBox[] ftxtMinute = new TextBox[FKAttendDLL.MAX_BELLCOUNT_DAY];

		private void cmdRead_Click(object sender, System.EventArgs e)
		{
            int vnResultCode;
            byte [] vbytBellInfo = new byte [1024];

            cmdRead.Enabled = false;
            lblMessage.Text = "Working...";
            Application.DoEvents();

            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdRead.Enabled = true;
                return;
            }

            vnResultCode = FKAttendDLL.FK_GetBellTime(FKAttendDLL.nCommHandleIndex, ref mnBellCount, vbytBellInfo);
            lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
            if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
            {
                object vobj = FKAttendDLL.ConvertByteArrayToStructure(vbytBellInfo, typeof(BELLINFO));
                if (vobj == null)
                    return;
                mBellInfo = (BELLINFO)vobj;
                ShowValue();
            }

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
            cmdRead.Enabled = true;		
		}

		private void cmdWrite_Click(object sender, System.EventArgs e)
		{
			int vnResultCode;
            byte [] bytBellInfo = new byte [1024];

			cmdWrite.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

			GetValue();

            FKAttendDLL.ConvertStructureToByteArray((object)mBellInfo, bytBellInfo);
            vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
			if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = FKAttendDLL.msErrorNoDevice;
				cmdWrite.Enabled = true;
				return;
			}

            vnResultCode = FKAttendDLL.FK_SetBellTime(FKAttendDLL.nCommHandleIndex, mnBellCount, bytBellInfo);
            lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

            FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
			cmdWrite.Enabled = true;
		}

		private void frmBellInfo_Load(object sender, System.EventArgs e)
		{
			int vnii;
			int vnLen;
			string vstrItem;
			string vstrName;

			mBellInfo.mValid = new byte[FKAttendDLL.MAX_BELLCOUNT_DAY];
			mBellInfo.mHour = new byte[FKAttendDLL.MAX_BELLCOUNT_DAY];
			mBellInfo.mMinute = new byte[FKAttendDLL.MAX_BELLCOUNT_DAY];
			foreach(object vtObject in Controls)
			{
				if(vtObject !=null)
				{
					vstrName = ((Control)vtObject).Name;

					vstrItem = "chkValid";
					vnLen = vstrItem.Length;
					if(vstrName.Length>vnLen)
					if (vstrName.Substring(0,vnLen) == vstrItem)
					{
						vnii = Convert.ToInt32(vstrName.Substring(vnLen, vstrName.Length - vnLen));
						fchkValid[vnii] = (CheckBox)vtObject;
						continue;
					}

					vstrItem = "txtHour";
					vnLen = vstrItem.Length;
					if(vstrName.Length>vnLen)
					if (vstrName.Substring(0,vnLen) == vstrItem)
					{
						vnii = Convert.ToInt32(vstrName.Substring(vnLen, vstrName.Length - vnLen));
						ftxtHour[vnii] = (TextBox)vtObject;
						continue;
					}

					vstrItem = "txtMinute";
					vnLen = vstrItem.Length;
					if(vstrName.Length>vnLen)
					if (vstrName.Substring(0,vnLen) == vstrItem)
					{
						vnii = Convert.ToInt32(vstrName.Substring(vnLen, vstrName.Length - vnLen));
						ftxtMinute[vnii] = (TextBox)vtObject;
						continue;
					}
				}
			}
			ShowValue();

		}

		private void ShowValue()
		{
			
			int vnii;

            for (vnii = 0; vnii < FKAttendDLL.MAX_BELLCOUNT_DAY; vnii++)
            {
                ftxtHour[vnii].Text = mBellInfo.mHour[vnii].ToString();
                ftxtMinute[vnii].Text = mBellInfo.mMinute[vnii].ToString();
                if (mBellInfo.mValid[vnii] > 1)
                    mBellInfo.mValid[vnii] = 0;
                fchkValid[vnii].CheckState = (mBellInfo.mValid[vnii] == 1) ? CheckState.Checked : CheckState.Unchecked;
            }
			txtBellCount.Text = Convert.ToString(mnBellCount);
		}

		private void GetValue()
		{
			
			int vnii;

			for(vnii = 0;vnii<FKAttendDLL.MAX_BELLCOUNT_DAY;vnii++)
			{
				mBellInfo.mHour[vnii] = Convert.ToByte(ftxtHour[vnii].Text);
				mBellInfo.mMinute[vnii] = Convert.ToByte(ftxtMinute[vnii].Text);
				mBellInfo.mValid[vnii] = Convert.ToByte(fchkValid[vnii].CheckState);
			}
			mnBellCount = Convert.ToInt32(txtBellCount.Text);
		}
	}
}
