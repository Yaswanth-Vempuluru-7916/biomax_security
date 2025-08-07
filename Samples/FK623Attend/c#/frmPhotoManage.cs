using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FKAttendDllCSSample
{
    public partial class frmPhotoManage : Form
    {
        public frmPhotoManage()
        {
            InitializeComponent();
        }

        private int mnCommHandleIndex;
        private byte [] mbytPhotoImage;
        private void frmPhotoManage_Load(object sender, EventArgs e)
        {
            mnCommHandleIndex = FKAttendDLL.nCommHandleIndex;
        }

       

        private void cmdGetEnrollPhoto_Click(object sender, EventArgs e)
        {
            int nFKRetCode = 0;
            UInt32 nEnrollNumber = 0;
            int nPhotoLen = 0;
            string vStrEnrolllNumber;

            vStrEnrolllNumber = txtEnrollNumber.Text;
            nEnrollNumber = FKAttendDLL.GetInt(vStrEnrolllNumber);

            cmdGetEnrollPhoto.Enabled = false;
            lblMessage.Text = "Working...";
            System.Windows.Forms.Application.DoEvents();

            nFKRetCode = FKAttendDLL.FK_EnableDevice(mnCommHandleIndex, 0);
            if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdGetEnrollPhoto.Enabled = true;
                return;
            }

            mbytPhotoImage = new byte[0];
            nPhotoLen = 0;


            int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
            if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
                nFKRetCode = FKAttendDLL.FK_GetEnrollPhoto_StringID(mnCommHandleIndex, vStrEnrolllNumber, mbytPhotoImage, ref nPhotoLen);
            else
                nFKRetCode = FKAttendDLL.FK_GetEnrollPhoto(mnCommHandleIndex, nEnrollNumber, mbytPhotoImage, ref nPhotoLen);

            if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(nFKRetCode);

                FKAttendDLL.FK_EnableDevice(mnCommHandleIndex, 1);
                cmdGetEnrollPhoto.Enabled = true;
                return;
            }

            mbytPhotoImage = new byte[nPhotoLen];
            if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
                nFKRetCode = FKAttendDLL.FK_GetEnrollPhoto_StringID(mnCommHandleIndex, vStrEnrolllNumber, mbytPhotoImage, ref nPhotoLen);
            else
                nFKRetCode = FKAttendDLL.FK_GetEnrollPhoto(mnCommHandleIndex, nEnrollNumber, mbytPhotoImage, ref nPhotoLen);

            if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(nFKRetCode);
            }
            else
            {
                lblMessage.Text = "GetEnrollPhoto OK";
                SaveEnrollPhoto();
            }

            FKAttendDLL.FK_EnableDevice(mnCommHandleIndex, 1);
            cmdGetEnrollPhoto.Enabled = true;
        }

        private void SaveEnrollPhoto()
        {
            string strFilePath = "";

            if (mbytPhotoImage.Length < 1)
                return;

            strFilePath = System.IO.Directory.GetCurrentDirectory() + "\\EnrollPhoto.jpg";
            System.IO.File.WriteAllBytes(strFilePath, mbytPhotoImage);

            //object varImg = new System.Runtime.InteropServices.VariantWrapper(mbytPhotoImage);
            axAxImage1.Image = byteArrayToImage(mbytPhotoImage);
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void cmdSetEnrollPhoto_Click(object sender, EventArgs e)
        {
            int nFKRetCode = 0;
            UInt32 nEnrollNumber = 0;
            int nPhotoLen = 0;

            nPhotoLen = mbytPhotoImage.Length;
            if (nPhotoLen < 1)
            {
                return;
            }

            string vStrEnrolllNumber;

            vStrEnrolllNumber = txtEnrollNumber.Text;
            nEnrollNumber = FKAttendDLL.GetInt(vStrEnrolllNumber);

            cmdSetEnrollPhoto.Enabled = false;

            lblMessage.Text = "Writing Photo...";
            System.Windows.Forms.Application.DoEvents();

            nFKRetCode = FKAttendDLL.FK_EnableDevice(mnCommHandleIndex, 0);
            if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdSetEnrollPhoto.Enabled = true;
                return;
            }

            int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
            if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
                nFKRetCode = FKAttendDLL.FK_SetEnrollPhoto_StringID(mnCommHandleIndex, vStrEnrolllNumber, mbytPhotoImage, nPhotoLen);
            else
                nFKRetCode = FKAttendDLL.FK_SetEnrollPhoto(mnCommHandleIndex, nEnrollNumber, mbytPhotoImage, nPhotoLen);

            if (nFKRetCode == (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = "SetEnrollPhoto OK";
            }
            else
            {
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(nFKRetCode);
            }

            FKAttendDLL.FK_EnableDevice(mnCommHandleIndex, 1);
            cmdSetEnrollPhoto.Enabled = true;
        }

        private void cmdDeleteEnrollPhoto_Click(object sender, EventArgs e)
        {
            int nFKRetCode = 0;
            UInt32 nEnrollNumber = 0;

            string vStrEnrolllNumber;

            vStrEnrolllNumber = txtEnrollNumber.Text;
            nEnrollNumber = FKAttendDLL.GetInt(vStrEnrolllNumber);

            cmdDeleteEnrollPhoto.Enabled = false;
            lblMessage.Text = "Working...";
            System.Windows.Forms.Application.DoEvents();

            nFKRetCode = FKAttendDLL.FK_EnableDevice(mnCommHandleIndex, 0);
            if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.msErrorNoDevice;
                cmdDeleteEnrollPhoto.Enabled = true;
                return;
            }

            int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
            if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
                nFKRetCode = FKAttendDLL.FK_DeleteEnrollPhoto_StringID(mnCommHandleIndex, vStrEnrolllNumber);
            else
                nFKRetCode = FKAttendDLL.FK_DeleteEnrollPhoto(mnCommHandleIndex, nEnrollNumber);

            if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
            {
                lblMessage.Text = FKAttendDLL.ReturnResultPrint(nFKRetCode);
            }
            else
            {
                lblMessage.Text = "Delete Photo OK";
            }

            FKAttendDLL.FK_EnableDevice(mnCommHandleIndex, 1);
            cmdDeleteEnrollPhoto.Enabled = true;
        }
    }
}
