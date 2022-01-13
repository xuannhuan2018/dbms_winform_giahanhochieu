using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nhom01_FinalProject.GUI;

namespace Nhom01_FinalProject
{
    public partial class fTrangchu : Form
    {
        public fTrangchu()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
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
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fDangnhap());
        }

        private void fTrangchu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Logo_Click(object sender, EventArgs e)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }    
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTokhai());
        }
    }
}
