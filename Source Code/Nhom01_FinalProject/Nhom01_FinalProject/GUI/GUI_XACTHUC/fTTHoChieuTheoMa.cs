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

namespace Nhom01_FinalProject.GUI
{
    public partial class fTTHoChieuTheoMa : Form
    {
        public fTTHoChieuTheoMa()
        {
            InitializeComponent();
        }

        private void fTTHoChieuTheoMa_Load(object sender, EventArgs e)
        {
            HochieuDAO.Laydulieutheoma(Phieugiahan.Mahochieu);

            label_socc.Text = Dancu.Cmnd;
            label_hoten.Text = Dancu.Hoten;
            label_birthday.Text = Dancu.Ngaysinh.ToString("dd-MM-yyyy");
            label_gioitinh.Text = Dancu.Gioitinh;
            label_diachi.Text = Dancu.Phuong + ", " + Dancu.Quanhuyen;

            if(Hochieu.Ngayhethan > DateTime.Now)
            {
                label_tinhtrang.Text = "Còn hạn sử dụng";
            }
            else
            {
                label_tinhtrang.Text = "Hết hạn sử dụng";
            }    
        }
    }
}
