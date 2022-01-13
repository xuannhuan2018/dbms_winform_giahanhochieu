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

namespace Nhom01_FinalProject.GUI.GUI_LUUTRU
{
    public partial class fUpdateTimeHoChieu : Form
    {
        public fUpdateTimeHoChieu()
        {
            InitializeComponent();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát khỏi hủy hành động gia hạn hộ chiếu?",
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

        private void fUpdateTimeHoChieu_Load(object sender, EventArgs e)
        {
            HochieuDAO.LayThongTinHoChieuTheoMa(Phieugiahan.Mahochieu);
            label_mahochieu.Text = Phieugiahan.Mahochieu;
            label_ngaycap.Text = Hochieu.Ngaycap.ToString("dd-MM-yyyy");
            label_ngayhethan.Text = Hochieu.Ngayhethan.ToString("dd-MM-yyyy");

            if (Hochieu.Ngayhethan < DateTime.Now)
            {
                label_tinhtrang.Text = "HẾT HẠN SỬ DỤNG";
            }
            else
            {
                label_tinhtrang.Text = "CÒN HẠN SỬ DỤNG";
            }    
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            Hochieu.Tinhtrang = "Còn hạn sử dụng";
            Hochieu.Ngaycap = DateTime.Now;
            Hochieu.Ngaycap = DateTime.Parse(Hochieu.Ngaycap.ToString("MM-dd-yyyy"));
            Hochieu.Ngayhethan = dateTimePicker_hsd.Value;
            Hochieu.Ngayhethan = DateTime.Parse(Hochieu.Ngayhethan.ToString("MM-dd-yyyy"));

            int kq = HochieuDAO.UpdateTimeHoChieu(Phieugiahan.Mahochieu, Hochieu.Tinhtrang, Hochieu.Ngayhethan, Hochieu.Ngaycap);

            if (kq > 0)
            {
                MessageBox.Show("Đã cập nhật tình trạng xét duyệt cho phiếu đăng ký có mã là " + Phieugiahan.Mahochieu);
                fUpdateTimeHoChieu_Load(sender,e);
            }
            
        }
    }
}
