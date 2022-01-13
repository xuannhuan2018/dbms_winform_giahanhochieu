using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Nhom01_FinalProject.DTO;
using Nhom01_FinalProject.DAO;

namespace Nhom01_FinalProject.GUI
{
    public partial class fTokhai : Form
    {
        //Gọi biến tạm đại diện cho kết quả giới tính
        string p_gender;

        public fTokhai()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm lấy mã số biên nhận theo thời gian thực
        /// </summary>
        static string GetConvertDatetime(DateTime a)
        {
            string p_year = Convert.ToString(a.Year);
            string p_month = Convert.ToString(a.Month);
            string p_day = Convert.ToString(a.Day);
            string p_hour = Convert.ToString(a.Hour);
            string p_minute = Convert.ToString(a.Minute);
            string p_second = Convert.ToString(a.Second);
            string mapdk = "PDK" + p_year + p_month + p_day + p_hour + p_minute + p_second;

            return mapdk;
        }

        /// <summary>
        /// Nếu checkbox Nam được check
        /// </summary>
        private void radioNam_CheckedChanged(object sender, EventArgs e)
        {
            p_gender = "Nam";
        }

        /// <summary>
        /// Nếu checkbox Nữ được check
        /// </summary>
        private void radioNu_CheckedChanged(object sender, EventArgs e)
        {
            p_gender = "Nữ";
        }

        /// <summary>
        /// Xử lý sự kiện nộp tờ khai gia hạn hộ chiếu
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Lấy thông tin các ô trên form gán tương ứng vào các thuộc tính của lớp Phieugiahan
            Phieugiahan.Mapdk = GetConvertDatetime(DateTime.Now);
            Phieugiahan.Ngaydangky = DateTime.Now;
            Phieugiahan.Hoten = txtHoten.Text;
            Phieugiahan.Ngaysinh = dateTime_birthday.Value.Date;
            Phieugiahan.Gioitinh = p_gender;
            Phieugiahan.Cmnd = txtCmnd.Text;
            Phieugiahan.Diachi = txtdiachi.Text;
            Phieugiahan.Phuong = txtPhuong.Text;
            Phieugiahan.Quanhuyen = combobox_quanhuyen.Text.Trim();
            Phieugiahan.Sdt = txtSDT.Text;
            Phieugiahan.Email = txtEmail.Text;
            Phieugiahan.Mahochieu = txtMahochieu.Text.Trim();

            if (Phieugiahan.Hoten == "" || Phieugiahan.Cmnd == "" || Phieugiahan.Diachi == "" || Phieugiahan.Phuong == "" || Phieugiahan.Quanhuyen == "" || Phieugiahan.Mahochieu == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            //else if (Math(DateTime.Now.Date - Phieugiahan.Ngaysinh) < 18)
            //{
                //MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
            //}
            else if (Phieugiahan.Sdt.Length !=10)
            {
                MessageBox.Show("Số điện thoại chưa đúng định dạng. Vui lòng kiểm tra lại!");
                txtSDT.Focus();
            }
            else if (Phieugiahan.Email.Contains("@") == false)
            {
                MessageBox.Show("Email chưa đúng định dạng vui lòng kiểm tra lại!");
                txtEmail.Focus();
            }
            else if (Phieugiahan.Cmnd.Length != 9 && Phieugiahan.Cmnd.Length != 12)
            {
                MessageBox.Show("Số chứng minh nhân dân không chính xác. Vui lòng kiểm tra lại");
            }    
            else
            {
                //Thực hiện hàm thêm truyền vào các biến tương ứng ở trên
                int ThemPhieuGiaHan = PhieugiahanDAO.ThemPhieuGiaHan(Phieugiahan.Mapdk, Phieugiahan.Ngaydangky, Phieugiahan.Hoten, Phieugiahan.Ngaysinh, Phieugiahan.Gioitinh, Phieugiahan.Cmnd, Phieugiahan.Diachi, Phieugiahan.Phuong, Phieugiahan.Quanhuyen, Phieugiahan.Sdt, Phieugiahan.Email, Phieugiahan.Mahochieu);

                //Nếu kết quả thêm lớn hơn 0 -> Thông báo kết quả thành công cho người dùng
                if (ThemPhieuGiaHan > 0)
                {
                    MessageBox.Show("Bạn đã đăng ký thông tin gia hạn hộ chiếu thành công với mã số " + Phieugiahan.Mapdk + ". Vui lòng ghi nhớ mã số để thuận tiện tra cứu kết quả đăng ký sau này.!");
                }
            }
        }

        /// <summary>
        /// Xử lý sự kiện reset lại các ô điền thông tin trong form
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtHoten.ResetText();
            txtCmnd.ResetText();
            txtdiachi.ResetText();
            txtEmail.ResetText();
            txtMahochieu.ResetText();
            txtPhuong.ResetText();
            txtSDT.ResetText();
            combobox_quanhuyen.ResetText();
            dateTime_birthday.ResetText();
        }

        /// <summary>
        /// Xử lý sự kiện đóng form đăng ký gia hạn hộ chiếu
        /// </summary>
        private void btnCacel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
