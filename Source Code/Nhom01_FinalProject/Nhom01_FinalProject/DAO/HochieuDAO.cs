using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nhom01_FinalProject.DTO;
using Oracle.ManagedDataAccess.Client;

namespace Nhom01_FinalProject.DAO
{
    public class HochieuDAO
    {
        /// <summary>
        /// Lấy toàn bộ dữ liệu trong bảng tthochieu
        /// </summary>
        /// <returns>Một Datatable chữa các dòng dữ liệu</returns>
        public static DataTable LayThongTinHoChieu()
        {
            //Câu truy vấn
            string sql = "SELECT * FROM RESIDENT.tthochieu";

            //Nguồn kết nối OracleConnection
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối
            connection.Open();

            // Sử dụng OracleConnection
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Sử dụng ExecuteReader để đọc dữ liệu
            OracleDataReader oda = cmd.ExecuteReader();

            //Tạo một Datable có tên dt
            DataTable dt = new DataTable();

            //Load dữ liệu đọc được vào dt
            dt.Load(oda);

            //Trả về một dt chữa dữ liệu đọc được
            return dt;
        }

        /// <summary>
        /// Lấy toàn bộ thông tin các hàng trong bảng tthochieutheo ma
        /// </summary>
        /// <returns>trả về một Datatable</returns>
        public static DataTable TimKiemThongTinTheoMa(string mahochieu)
        {
            //Câu truy vấn
            string sql = "SELECT * FROM RESIDENT.tthochieu WHERE mahochieu LIKE :v_mahochieu";

            //Lấy OracleConnection làm tài nguyên
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối OracleConnection
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Tạo mảng chứa các biến
            OracleParameter[] queryParams = new OracleParameter[1];
            queryParams[0] = new OracleParameter("v_mahochieu", OracleDbType.Varchar2, "%" + mahochieu + "%", ParameterDirection.Input);

            // Thêm các biến vào OracleCommand
            cmd.Parameters.AddRange(queryParams);

            //Đọc dữ liệu bằng ExecuteReader
            OracleDataReader oda = cmd.ExecuteReader();

            //Tạo mới DataTable có tên dt
            DataTable dt = new DataTable();

            //Load dữ liệu đọc được vào Datatable vừa tạo
            dt.Load(oda);

            //Trả về Datatable chứa dữ liệu theo câu truy vấn
            return dt;
        }

        /// <summary>
        /// Kiểm tra xem mã hộ chiếu có tồn tại hay không
        /// </summary>
        /// <param name="mahochieu"> Mã hộ chiếu</param>
        /// <returns>true/ flase</returns>
        public static bool CheckMaHoChieu(string mahochieu)
        {
            //Câu truy vấn
            string sql = "SELECT count(mahochieu) FROM RESIDENT.tthochieu WHERE mahochieu =:v_mahochieu";

            //Sử dụng nguồn OracleConnection
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            //Mở chuỗi kết nối
            connection.Open();

            //Sử dụng OracleCommand
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Tạo mảng chứa các biên
            OracleParameter[] queryParams = new OracleParameter[1];
            queryParams[0] = new OracleParameter("v_mahochieu", OracleDbType.Varchar2, mahochieu, ParameterDirection.Input);

            //Thêm các biến vào OracleCommand
            cmd.Parameters.AddRange(queryParams);

            //Trả về số dòng dữ liệu đếm được theo điều kiện và gán cho biến số nguyên number
            int number = Convert.ToInt32(cmd.ExecuteScalar());


            if (number > 0) //Nếu number lớn hơn không
            {
                return true; //Trả về true
            }
            else //Không có dòng nào thỏa
            {
                return false; //Trả về false
            }
        }

        /// <summary>
        /// Lấy dữ liệu theo mã hộ chiếu truyền vào
        /// </summary>
        /// <param name="mahochieu">Mã hộ chiếu</param>
        public static void Laydulieutheoma(string mahochieu)
        {
            //Câu truy vấn JOIN giữa 2 bảng tthochieu và ttcongdanhcm
            string sql = "select hc.ngaycap, hc.ngayhethan, cd.cmnd, cd.hoten, cd.ngaysinh, cd.gioitinh, cd.phuong, cd.quanhuyen from RESIDENT.tthochieu hc JOIN RESIDENT.ttcongdanhcm cd ON hc.cmnd = cd.cmnd WHERE hc.mahochieu =:v_mahochieu";
            
            // Sử dụng nguồn OracleConnection
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Tạo bảng chứa các biến
            OracleParameter[] queryParams = new OracleParameter[1];
            queryParams[0] = new OracleParameter("v_mahochieu", OracleDbType.Varchar2, mahochieu, ParameterDirection.Input);

            // Thêm biến vào OracleCommand
            cmd.Parameters.AddRange(queryParams);

            //Sử dụng ExecuteReader để đọc dữ liệu
            OracleDataReader reader = cmd.ExecuteReader();

            using (reader) //Sử dụng dữ liệu đã đọc
            {
                if (reader.HasRows) //Nếu có dòng
                {
                    while (reader.Read()) //Đọc theo từng dòng
                    {
                        //Đọc chỉ số dòng của các cột có tên tương ứng
                        int ngaycapIndex = reader.GetOrdinal("ngaycap"); 
                        int ngayhethanIndex = reader.GetOrdinal("ngayhethan");
                        int cmndIndex = reader.GetOrdinal("cmnd");
                        int hotenIndex = reader.GetOrdinal("hoten");
                        int ngaysinhIndex = reader.GetOrdinal("ngaysinh");
                        int gioitinhIndex = reader.GetOrdinal("gioitinh");
                        int phuongIndex = reader.GetOrdinal("phuong");
                        int quanhuyenIndex = reader.GetOrdinal("quanhuyen");

                        //Lấy giá trị của cột có chỉ số đã đọc tương ứng
                        Hochieu.Ngaycap = reader.GetDateTime(ngaycapIndex);
                        Hochieu.Ngayhethan = reader.GetDateTime(ngayhethanIndex);
                        Dancu.Cmnd = reader.GetString(cmndIndex);
                        Dancu.Hoten = reader.GetString(hotenIndex);
                        Dancu.Ngaysinh = reader.GetDateTime(ngaysinhIndex);
                        Dancu.Gioitinh = reader.GetString(gioitinhIndex);
                        Dancu.Phuong = reader.GetString(phuongIndex);
                        Dancu.Quanhuyen = reader.GetString(quanhuyenIndex);
                    }
                }
            }
        }

        /// <summary>
        /// Lấy các cột thông tin về thời gian theo mã hộ chiếu
        /// </summary>
        /// <param name="mahochieu">Mã hộ chiếu</param>
        public static void LayThongTinHoChieuTheoMa(string mahochieu)
        {
            //Câu truy vấn JOIN giữa 2 bảng tthochieu và ttcongdanhcm
            string sql = "SELECT * FROM RESIDENT.tthochieu WHERE mahochieu =:v_mahochieu";

            // Sử dụng nguồn OracleConnection
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Tạo bảng chứa các biến
            OracleParameter[] queryParams = new OracleParameter[1];
            queryParams[0] = new OracleParameter("v_mahochieu", OracleDbType.Varchar2, mahochieu, ParameterDirection.Input);

            // Thêm biến vào OracleCommand
            cmd.Parameters.AddRange(queryParams);

            //Sử dụng ExecuteReader để đọc dữ liệu
            OracleDataReader reader = cmd.ExecuteReader();

            using (reader) //Sử dụng dữ liệu đã đọc
            {
                if (reader.HasRows) //Nếu có dòng
                {
                    while (reader.Read()) //Đọc theo từng dòng
                    {
                        //Đọc chỉ số dòng của các cột có tên tương ứng
                        int ngaycapIndex = reader.GetOrdinal("ngaycap");
                        int ngayhethanIndex = reader.GetOrdinal("ngayhethan");

                        //Lấy giá trị của cột có chỉ số đã đọc tương ứng
                        Hochieu.Ngaycap = reader.GetDateTime(ngaycapIndex);
                        Hochieu.Ngayhethan = reader.GetDateTime(ngayhethanIndex);
                    }
                }
            }
        }

        public static int UpdateTimeHoChieu(string mahochieu, string tinhtrang, DateTime ngayhethan, DateTime ngaycap)
        {
            //Câu truy vấn
            string sql = "update resident.tthochieu set resident.tthochieu.ngayhethan = TO_DATE(:v_ngayhethan, 'dd-mm-yyyy'), resident.tthochieu.ngaycap = TO_DATE(:v_ngaycap, 'dd-mm-yyyy'), resident.tthochieu.tinhtrang =:v_tinhtrang where mahochieu =:v_mahochieu";

            // Sử dụng nguồn OracleConnection
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Tạo mảng chứa các biến
            OracleParameter[] queryParams = new OracleParameter[4];
            queryParams[0] = new OracleParameter("v_ngayhethan", OracleDbType.Varchar2, ngayhethan.ToString("dd-MM-yyyy"), ParameterDirection.Input);
            queryParams[1] = new OracleParameter("v_ngaycap", OracleDbType.Varchar2, ngaycap.ToString("dd-MM-yyyy"), ParameterDirection.Input);
            queryParams[2] = new OracleParameter("v_tinhtrang", OracleDbType.NVarchar2, tinhtrang, ParameterDirection.Input);
            queryParams[3] = new OracleParameter("v_mahochieu", OracleDbType.Varchar2, mahochieu, ParameterDirection.Input);


            // Thêm biến vào OracleCommand
            cmd.Parameters.AddRange(queryParams);

            //Trả về số dòng dữ liệu đã được cập nhật
            int row = cmd.ExecuteNonQuery();

            //Hoàn thành
            return row;
        }
    }
}
