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

        /// <summary>
        /// Tạo một đối tượng Form có tên currentFormChild
        /// </summary>
        private Form currentFormChild;

        /// <summary>
        /// Mở form theo điều kiện đổ vào panel tương ứng
        /// </summary>
        /// <param name="childForm"></param>
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null) //Nếu có form con nào đang mở
            {
                currentFormChild.Close(); // Đóng form con đó đi
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_body.Controls.Add(childForm); //add form mới mở vào 
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();//Mở form
        }
        

        /// <summary>
        /// Xử lý sự kiện click button đăng nhập
        /// </summary> 
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            btnDangnhap.Visible = false;
            OpenChildForm(new fDangnhap()); //mở form fDangnhap trong khu vực panel
        }

        private void fTrangchu_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Xử lý sự kiện click logo
        /// </summary>
        private void pictureBox_Logo_Click(object sender, EventArgs e)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close(); //Đóng các form con đang mở
            }    
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            btnDangnhap.Visible = true;
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTokhai());
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fLienhe());
            btnDangnhap.Visible = true;
        }

        private void btnTracuu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTracuu());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fHuongdan());
        }
    }
}
