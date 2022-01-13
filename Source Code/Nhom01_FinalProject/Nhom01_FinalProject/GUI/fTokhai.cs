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
        string p_gender;
        Phieugiahan pgh = new Phieugiahan();
        PhieugiahanDAO pghDAO = new PhieugiahanDAO();
        public fTokhai()
        {
            InitializeComponent();
        }

        private void btnCacel(object sender, EventArgs e)
        {
            this.Close();
        }
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            pgh.Mapdk = GetConvertDatetime(DateTime.Now);
            pgh.Ngaydangky = DateTime.Now;
            string hoten = txtHoten.Text;
            pgh.Ngaysinh = dateTime_birthday.Value;
            pgh.Gioitinh = p_gender;
            pgh.Cmnd = txtCmnd.Text;
            pgh.Diachi = txtdiachi.Text;
            pgh.Phuong = txtPhuong.Text;
            pgh.Quanhuyen = combobox_quanhuyen.Text.Trim();
            pgh.Sdt = txtSDT.Text;
            pgh.Email = txtEmail.Text;
            pgh.Mahochieu = txtMahochieu.Text.Trim();



            // Connection String để kết nối trực tiếp tới Oracle.
            //string strconn = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
            //     + "localhost" + ")(PORT = " + "1521" + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
            //     + "ORCLPDB.LOCALDOMAIN" + ")));Password=" + "PASSPORT" + ";User ID=" + "PASSPORT";

            //OracleConnection conn = new OracleConnection(strconn);

            //conn.Open();
            //try
            //{
            //    string sql = "INSERT INTO PASSPORT.dsgiahanhochieu (mapdk, ngaydk, hoten, ngaysinh, gioitinh, cmnd, diachi, phuong, quanhuyen, sdt, email, mahochieu)" + "VALUES (:mapdk, :ngaydk, :hoten, :ngaysinh, :gioitinh, :cmnd, :diachi, :phuong, :quanhuyen, :sdt, :email, :mahochieu)";

            //    OracleCommand cmd = conn.CreateCommand();
            //    cmd.CommandText = sql;
            //    cmd.CommandType = CommandType.Text;

            //    //Tao mang tham so
            //    OracleParameter[] queryParams = new OracleParameter[12];
            //    queryParams[0] = new OracleParameter("mapdk", OracleDbType.Varchar2, pgh.Mapdk, ParameterDirection.Input);
            //    queryParams[1] = new OracleParameter("ngaydangky", OracleDbType.TimeStamp, pgh.Ngaydangky, ParameterDirection.Input);
            //    queryParams[2] = new OracleParameter("hoten", OracleDbType.NVarchar2, pgh.Hoten, ParameterDirection.Input);
            //    queryParams[3] = new OracleParameter("ngaysinh", OracleDbType.Date, pgh.Ngaysinh, ParameterDirection.Input);
            //    queryParams[4] = new OracleParameter("gioitinh", OracleDbType.NVarchar2, pgh.Gioitinh, ParameterDirection.Input);
            //    queryParams[5] = new OracleParameter("cmnd", OracleDbType.Varchar2, pgh.Cmnd, ParameterDirection.Input);
            //    queryParams[6] = new OracleParameter("diachi", OracleDbType.NVarchar2, pgh.Diachi, ParameterDirection.Input);
            //    queryParams[7] = new OracleParameter("phuong", OracleDbType.NVarchar2, pgh.Phuong, ParameterDirection.Input);
            //    queryParams[8] = new OracleParameter("quanhuyen", OracleDbType.NVarchar2, pgh.Quanhuyen, ParameterDirection.Input);
            //    queryParams[9] = new OracleParameter("sdt", OracleDbType.Varchar2, pgh.Sdt, ParameterDirection.Input);
            //    queryParams[10] = new OracleParameter("email", OracleDbType.Varchar2, pgh.Email, ParameterDirection.Input);
            //    queryParams[11] = new OracleParameter("mahochieu", OracleDbType.Varchar2, pgh.Mahochieu, ParameterDirection.Input);
            //    // Add mảng vào
            //    cmd.Parameters.AddRange(queryParams);

            //    // Thực thi Command (Dùng cho delete, insert, update).
            //    int rowCount = cmd.ExecuteNonQuery();

            //    if (rowCount > 0)
            //    {
            //        MessageBox.Show("Bạn đã đăng ký thông tin gia hạn hộ chiếu thành công với mã số " + pgh.Mapdk+". Vui lòng ghi nhớ mã số để thuận tiện tra cứu kết quả đăng ký sau này.!");
            //    }
            //}
            //catch (OracleException)
            //{
            //    MessageBox.Show("Lỗi con mẹ nó rồi!");
            //}
            try
            {
                int ThemPhieuGiaHan = pghDAO.ThemPhieuGiaHan(pgh.Mapdk, pgh.Ngaydangky, pgh.Hoten, pgh.Ngaysinh, pgh.Gioitinh, pgh.Cmnd, pgh.Diachi, pgh.Phuong, pgh.Quanhuyen, pgh.Sdt, pgh.Email, pgh.Mahochieu);
                if (ThemPhieuGiaHan > 0)
                {
                    MessageBox.Show("Bạn đã đăng ký thông tin gia hạn hộ chiếu thành công với mã số " + pgh.Mapdk + ". Vui lòng ghi nhớ mã số để thuận tiện tra cứu kết quả đăng ký sau này.!");
                }
            }
            catch (OracleException)
            {
                MessageBox.Show("Lỗi con mẹ nó rồi!");
            }
        }

        private void radioNam_CheckedChanged(object sender, EventArgs e)
        {
            p_gender = "Nam";
        }

        private void radioNu_CheckedChanged(object sender, EventArgs e)
        {
            p_gender = "Nữ";
        }

        private void fTokhai_Load(object sender, EventArgs e)
        {

        }
    }
}
