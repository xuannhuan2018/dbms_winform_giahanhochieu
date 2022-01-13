using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nhom01_FinalProject.DAO;
using Nhom01_FinalProject.DTO;

namespace Nhom01_FinalProject.GUI.GUI_XETDUYET
{
    public partial class fUpdateXetDuyet : Form
    {
        public fUpdateXetDuyet()
        {
            InitializeComponent();
        }


        private void radioButton_yes_CheckedChanged(object sender, EventArgs e)
        {
            Phieugiahan.Ttxetduyet = "Đồng Ý";
        }

        private void radioButton_no_CheckedChanged(object sender, EventArgs e)
        {
            Phieugiahan.Ttxetduyet = "Không Đồng Ý";
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát khỏi trạng thái xét duyệt?",
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

        private void fUpdateXetDuyet_Load(object sender, EventArgs e)
        {
            label_mpdk.Text = Phieugiahan.Mapdk;
            label_trangthai.Text= Phieugiahan.Ttxacthuc;
            label_comments.Text = Phieugiahan.Comments;

        }

        private void btnXetDuyet_Click(object sender, EventArgs e)
        {
            int kq = PhieugiahanDAO.CapNhatTrangThaiXetDuyet(Phieugiahan.Ttxetduyet, Phieugiahan.Mapdk);

            if (kq > 0)
            {
                MessageBox.Show("Đã cập nhật tình trạng xét duyệt cho phiếu đăng ký có mã là " + Phieugiahan.Mapdk);
                this.Close();
            }
        }
    }
}
