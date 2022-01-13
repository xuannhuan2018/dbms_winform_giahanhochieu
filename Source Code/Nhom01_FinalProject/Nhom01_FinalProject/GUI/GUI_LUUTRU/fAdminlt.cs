using Nhom01_FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nhom01_FinalProject.GUI
{
    public partial class fAdminlt : Form
    {
     
        public fAdminlt()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void fAdminlt_Load(object sender, EventArgs e)
        {
            label_user.Text = UserLogin.Username;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đăng xuất khỏi hệ thống ?",
                     "Mood Test", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnDSDK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_LUUTRU.fHsDangKy());
        }

        private void btnHsHochieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_LUUTRU.fHsHoChieu());
        }
    }
}
