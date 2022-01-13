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
    public partial class fTracuu : Form
    {
        public fTracuu()
        {
            InitializeComponent();
        }

        private bool CheckInforNull(string mapdk, string hoten)
        {
            if(mapdk == "" || hoten =="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(CheckInforNull(txtMaPDK.Text.Trim(), txtHoten.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (PhieugiahanDAO.CheckThongTinTraCuu(txtMaPDK.Text.Trim(), txtHoten.Text.Trim()) > 0)
                {
                    MessageBox.Show(PhieugiahanDAO.TraCuuTrangThaiPhieuDK(txtMaPDK.Text.Trim(), txtHoten.Text.Trim()));
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã số biên nhận hoặc họ tên. Vui lòng kiểm tra lại!");
                }
            }
        }
    }
}
