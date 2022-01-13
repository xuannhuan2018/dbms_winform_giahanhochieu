using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nhom01_FinalProject.DTO;
using Nhom01_FinalProject.DAO;

namespace Nhom01_FinalProject.GUI
{
    public partial class fUpdateXacThuc : Form
    {
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

            panel_tthochieu.Controls.Add(childForm);
            panel_tthochieu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public fUpdateXacThuc()
        {
            InitializeComponent();
        }

        private void fUpdateXacThuc_Load(object sender, EventArgs e)
        {
            label_mpdk.Text = Phieugiahan.Mapdk;
            label_socc.Text = Phieugiahan.Cmnd;
            label_hoten.Text = Phieugiahan.Hoten;
            label_birthday.Text = Phieugiahan.Ngaysinh.ToString("dd-MM-yyyy");
            label_gioitinh.Text = Phieugiahan.Gioitinh;
            label_diachi.Text = Phieugiahan.Phuong + ", " + Phieugiahan.Quanhuyen;

            if(HochieuDAO.CheckMaHoChieu(Phieugiahan.Mahochieu))
            {
                OpenChildForm(new fTTHoChieuTheoMa());
            }    
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát khỏi trạng thái xác thực?",
                      "Thông báo", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnXacthuc_Click(object sender, EventArgs e)
        {
            Phieugiahan.Mapdk = label_mpdk.Text.Trim();
            Phieugiahan.Ttxacthuc = "Đã xác thực";
            Phieugiahan.Comments = combobox_comments.Text.Trim();

            int kq = PhieugiahanDAO.CapNhatTrangThaiXacThuc(Phieugiahan.Mapdk, Phieugiahan.Ttxacthuc, Phieugiahan.Comments);

            if(kq > 0)
            {
                MessageBox.Show("Đã cập nhật tình trạng xác thực cho phiếu đăng ký có mã là " + Phieugiahan.Mapdk);
                this.Close();
            }   
        }
    }
}
