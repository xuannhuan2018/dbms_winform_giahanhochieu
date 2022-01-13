using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nhom01_FinalProject.DTO;
using Oracle.ManagedDataAccess.Client;

namespace Nhom01_FinalProject.DAO
{
    public class PhieugiahanDAO
    {
        /// <summary>
        /// Lấy toàn bộ thông tin các hàng trong bảng dsgiahanhochieu
        /// </summary>
        /// <returns>trả về một Datatable</returns>
        public static DataTable LayThongTinTatCaPDK()
        {
            string sql;

            if (UserLogin.Username == "BPLUUTRU")
            {
                sql = "SELECT mapdk, ngaydk, mahochieu, ttxetduyet FROM PASSPORT.dsgiahanhochieu";
            }
            else
            {
                sql = "SELECT * FROM PASSPORT.dsgiahanhochieu";
            }    

            //Lấy OracleConnection làm tài nguyên
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối OracleConnection
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

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
        /// Lấy toàn bộ thông tin các hàng trong bảng dsgiahanhochieu
        /// </summary>
        /// <returns>trả về một Datatable</returns>
        public static DataTable TimKiemThongTinTheoMa(string mapdk)
        {
            //Câu truy vấn
            string sql = "SELECT * FROM PASSPORT.dsgiahanhochieu WHERE mapdk LIKE :v_mapdk";

            //Lấy OracleConnection làm tài nguyên
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối OracleConnection
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Tạo mảng chứa các biến
            OracleParameter[] queryParams = new OracleParameter[1];
            queryParams[0] = new OracleParameter("v_mapdk", OracleDbType.Varchar2, "%" + mapdk + "%", ParameterDirection.Input);

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
        /// Lấy toàn bộ các hàng trong bảng dsgiahanhochieu có ttxetduyet = null
        /// </summary>
        /// <returns>trả về một Datatable</returns>
        public static DataTable LayDuLieuChoXetDuyet()
        {
            //Câu truy vấn
            string sql = "SELECT * FROM PASSPORT.dsgiahanhochieu WHERE ttxetduyet is null";

            //Lấy OracleConnection làm tài nguyên
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối OracleConnection
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

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
        /// Lấy toàn bộ các hàng trong bảng dsgiahanhochieu có ttxetduyet khác null
        /// </summary>
        /// <returns>trả về một Datatable</returns>
        public static DataTable LayDuLieuDaXetDuyet()
        {
            //Câu truy vấn
            string sql = "SELECT * FROM PASSPORT.dsgiahanhochieu WHERE ttxetduyet is not null";

            //Lấy OracleConnection làm tài nguyên
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối OracleConnection
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

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
        /// Lấy toàn bộ các hàng trong bảng dsgiahanhochieu có ttxetduyet là đồng ý
        /// </summary>
        /// <returns>trả về một Datatable</returns>
        public static DataTable LayDuLieuDongYXetDuyet()
        {
            //Câu truy vấn
            string sql = "SELECT * FROM PASSPORT.dsgiahanhochieu WHERE ttxetduyet = 'Đồng Ý'";

            //Lấy OracleConnection làm tài nguyên
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối OracleConnection
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

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
        /// Lấy toàn bộ các hàng trong bảng dsgiahanhochieu có ttxetduyet là không đồng ý
        /// </summary>
        /// <returns>trả về một Datatable</returns>
        public static DataTable LayDuLieuKhongDongYXetDuyet()
        {
            //Câu truy vấn
            string sql = "SELECT * FROM PASSPORT.dsgiahanhochieu WHERE ttxetduyet = 'Không Đồng Ý'";

            //Lấy OracleConnection làm tài nguyên
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối OracleConnection
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

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
        /// Hàm thêm dữ liệu vào bảng dsgiahanhochieu do người có nhu cầu gia hạn hộ chiếu khai
        /// </summary>
        /// <param name="mapdk">Mã phiếu đăng ký</param>
        /// <param name="ngaydk">Ngày đăng ký</param>
        /// <param name="hoten">Họ tên người dùng ghi theo CMND</param>
        /// <param name="ngaysinh">Ngày sinh ghi theo CMND</param>
        /// <param name="gioitinh">Giới tính ghi theo CMND</param>
        /// <param name="cmnd">Mã số CMND / Căn cước công dân</param>
        /// <param name="diachi">Địa chỉ (số nhà, đường)</param>
        /// <param name="phuong">Phường ghi theo CMND</param>
        /// <param name="quanhuyen">Quận/ huyện ghi theo CMND</param>
        /// <param name="sdt">Số điện thoại liên lạc</param>
        /// <param name="email">Email của người dùng (nếu có)</param>
        /// <param name="mahochieu">Mã hộ chiếu đã được cấp trước đó</param>
        /// <returns>Trả về số dòng đã được thay đổi trong bảng dsgiahanhochieu</returns>
        public static int ThemPhieuGiaHan(string mapdk, DateTime ngaydk, string hoten, DateTime ngaysinh, string gioitinh, string cmnd, string diachi, string phuong, string quanhuyen, string sdt, string email, string mahochieu)
        {
            //Câu truy vấn
            string sql = "INSERT INTO PASSPORT.dsgiahanhochieu (mapdk, ngaydk, hoten, ngaysinh, gioitinh, cmnd, diachi, phuong, quanhuyen, sdt, email, mahochieu)" + "VALUES (:mapdk, :ngaydk, :hoten, :ngaysinh, :gioitinh, :cmnd, :diachi, :phuong, :quanhuyen, :sdt, :email, :mahochieu)";

            // Lấy OracleConnection làm tài nguyên
            OracleConnection connection = StaticConnect.GetOracleConnection();

            // Mở chuỗi kết môi
            connection.Open();

            //Sử dụng OracleCommand
            OracleCommand cmd = StaticConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Tạo mảng chứa các biến
            OracleParameter[] queryParams = new OracleParameter[12];
            queryParams[0] = new OracleParameter("mapdk", OracleDbType.Varchar2, mapdk, ParameterDirection.Input);
            queryParams[1] = new OracleParameter("ngaydk", OracleDbType.Date, ngaydk, ParameterDirection.Input);
            queryParams[2] = new OracleParameter("hoten", OracleDbType.NVarchar2, hoten, ParameterDirection.Input);
            queryParams[3] = new OracleParameter("ngaysinh", OracleDbType.Date, ngaysinh, ParameterDirection.Input);
            queryParams[4] = new OracleParameter("gioitinh", OracleDbType.NVarchar2, gioitinh, ParameterDirection.Input);
            queryParams[5] = new OracleParameter("cmnd", OracleDbType.Varchar2, cmnd, ParameterDirection.Input);
            queryParams[6] = new OracleParameter("diachi", OracleDbType.NVarchar2, diachi, ParameterDirection.Input);
            queryParams[7] = new OracleParameter("phuong", OracleDbType.NVarchar2, phuong, ParameterDirection.Input);
            queryParams[8] = new OracleParameter("quanhuyen", OracleDbType.NVarchar2, quanhuyen, ParameterDirection.Input);
            queryParams[9] = new OracleParameter("sdt", OracleDbType.Varchar2, sdt, ParameterDirection.Input);
            queryParams[10] = new OracleParameter("email", OracleDbType.Varchar2, email, ParameterDirection.Input);
            queryParams[11] = new OracleParameter("mahochieu", OracleDbType.Varchar2, mahochieu, ParameterDirection.Input);

            // thêm các biến vừa tạo vào OracleCommand
            cmd.Parameters.AddRange(queryParams);

            //Sử dụng ExecuteNonQuery để thêm dữ liệu
            int row = cmd.ExecuteNonQuery();

            //Trả về số dòng dữ liệu đã được thêm
            return row;
        }

        /// <summary>
        /// Hàm kiểm tra tình trạng phiếu đăng ký
        /// </summary>
        /// <param name="sobiennhan">Mã phiếu đăng ký</param>
        /// <param name="hoten">Họ tên người đăng ký</param>
        /// <returns>Trả về chuỗi thông tin thể hiện tình trạng hiện tại của phiếu</returns>
        public static string TraCuuTrangThaiPhieuDK(string sobiennhan, string hoten)
        {
            //Câu truy vấn
            string sql = "SELECT ttxetduyet, comments FROM PASSPORT.dsgiahanhochieu WHERE mapdk =:v_mapdk and hoten =:v_hoten";

            //Biến tạm thể hiện chuỗi thông tin kết quả tra cứu
            string flag_results;

            // Sử dụng OracleConnection
            OracleConnection connection = StaticConnect.GetOracleConnection();

            // Mở chuỗi kết nối
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = StaticConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Tạo mảng chứa các biến
            OracleParameter[] queryParams = new OracleParameter[2];
            queryParams[0] = new OracleParameter("v_mapdk", OracleDbType.Varchar2, sobiennhan, ParameterDirection.Input);
            queryParams[1] = new OracleParameter("v_hoten", OracleDbType.NVarchar2, hoten, ParameterDirection.Input);

            // Thêm các biến vào OracleCommand
            cmd.Parameters.AddRange(queryParams);

            //Sử dụng ExecuteReader để đọc dữ liệu
            OracleDataReader reader = cmd.ExecuteReader();

            //Sử dụng kết quả đọc được
            using(reader)
            {
                if(reader.HasRows) //Nếu có hàng
                {
                    while (reader.Read()) //Đọc giá trị từng hàng
                    {
                        //Đọc chỉ số cột ttxetduyet
                        int xetduyetIndex = reader.GetOrdinal("ttxetduyet"); 

                        if(reader.IsDBNull(xetduyetIndex)) //Check xem giá trị của cột chỉ số có null hay không
                        {
                            Phieugiahan.Ttxetduyet = "";//null gán rỗng
                        }
                        else
                        {
                            Phieugiahan.Ttxetduyet = reader.GetString(xetduyetIndex);//không null thì đọc giá trị của cột chỉ số truyền vào
                        }

                        //Đọc chỉ số cột comments
                        int commentsIndex = reader.GetOrdinal("comments");

                        if (reader.IsDBNull(commentsIndex)) //Check xem giá trị của cột chỉ số có null hay không
                        {
                            Phieugiahan.Comments = "";//null gán rỗng
                        }
                        else
                        {
                            Phieugiahan.Comments = reader.GetString(commentsIndex); //không null thì đọc giá trị của cột chỉ số truyền vào
                        }
                        
                    }
                }    
            }

            if (Phieugiahan.Ttxetduyet == "") //giá trị của cột ttxetduyet đọc được là rỗng
            {
                flag_results = "Phiếu đăng ký đang trong quá trình xét duyệt"; 
            }
            else if (Phieugiahan.Ttxetduyet == "Đồng Ý")// giá trị của cột ttxetduyet đọc được là "Đồng Ý"
            {
                flag_results = "Phiếu đăng ký của bạn đã được phê duyệt. Vui lòng chuẩn bị hồ sơ và đến cơ quan có thẩm quyền gần nhất để hoàn tất thủ tục gia hạn hộ chiếu";
            }
            else // trường hợp còn lại
            {
                flag_results = "Tờ khai không hợp lệ. " + Phieugiahan.Comments + " .Vui lòng cung cấp thông tin chính xác hơn!";
            }

            //Trả về một chuỗi thông tin thể hiện tình trạng của phiếu đăng ký
            return flag_results;
        }

        /// <summary>
        /// Hàm kiểm tra thông tin có tồn tại phiếu đăng ký hay không
        /// </summary>
        /// <param name="mapdk">Mã phiếu đăng ký</param>
        /// <param name="hoten">Họ tên người đăng ký</param>
        /// <returns>Trả về một số thể hiện kết quả</returns>
        public static int CheckThongTinTraCuu(string mapdk, string hoten)
        {
            //Câu truy vấn
            string sql = "SELECT count(mapdk) FROM PASSPORT.dsgiahanhochieu WHERE mapdk =:v_mapdk and hoten =:v_hoten";

            //Sử dụng OracleConnection
            OracleConnection connection = StaticConnect.GetOracleConnection();

            // Mở chuỗi kết nối
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = StaticConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Tạo mảng chứa các biến
            OracleParameter[] queryParams = new OracleParameter[2];
            queryParams[0] = new OracleParameter("v_mapdk", OracleDbType.Varchar2, mapdk, ParameterDirection.Input);
            queryParams[1] = new OracleParameter("v_hoten", OracleDbType.NVarchar2, hoten, ParameterDirection.Input);

            // Thêm các biến vào OracleCommand
            cmd.Parameters.AddRange(queryParams);

            //Sử dụng ExecuteScalar để thực hiện kết quả câu truy vấn có chứa hàm tính toán
            int number = Convert.ToInt32(cmd.ExecuteScalar());

            //Trả về kết quả truy vấn
            return number;
        }

        /// <summary>
        /// Hàm cập nhật tình trạng xác thực
        /// </summary>
        /// <param name="mapdk">Mã phiếu đăng ký</param>
        /// <param name="xacthuc">Tình trạng xác thưc</param>
        /// <param name="comment">Ghi chú (nếu có)</param>
        /// <returns>Trả về 1 giá trị số nguyên thể hiện số dòng đã được cập nhật</returns>
        public static int CapNhatTrangThaiXacThuc(string mapdk, string xacthuc, string comment)
        {
            //Câu truy vấn
            string sql = "UPDATE PASSPORT.dsgiahanhochieu SET ttxacthuc =:v_ttxacthuc, comments =:v_comments WHERE mapdk =:v_mapdk";

            // Sử dụng nguồn OracleConnection
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Tạo mảng chứa các biến
            OracleParameter[] queryParams = new OracleParameter[3];
            queryParams[0] = new OracleParameter("v_ttxacthuc", OracleDbType.NVarchar2, xacthuc, ParameterDirection.Input);
            queryParams[1] = new OracleParameter("v_comments", OracleDbType.NVarchar2, comment, ParameterDirection.Input);
            queryParams[2] = new OracleParameter("v_mapdk", OracleDbType.Varchar2, mapdk, ParameterDirection.Input);

            // Thêm các biến vừa tạo vào OracleCommand
            cmd.Parameters.AddRange(queryParams);

            //Trả về số dòng dữ liệu đã được cập nhật và gán có biến số nguyên có tên là row
            int row = cmd.ExecuteNonQuery();

            //Trả về kết quả cho hàm
            return row;
        }

        /// <summary>
        /// Hàm cập nhật tình trạng xét duyệt
        /// </summary>
        /// <param name="xetduyet">Tình trạng xét duyệt</param>
        /// <param name="mapdk">Mã phiếu đăng ký</param>
        /// <returns></returns>
        public static int CapNhatTrangThaiXetDuyet(string xetduyet, string mapdk)
        {
            //Câu truy vấn
            string sql = "UPDATE PASSPORT.dsgiahanhochieu SET ttxetduyet =:v_ttxetduyet WHERE mapdk =:v_mapdk";

            // Sử dụng nguồn OracleConnection
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Tạo mảng chứa các biến
            OracleParameter[] queryParams = new OracleParameter[2];
            queryParams[0] = new OracleParameter("v_ttxetduyet", OracleDbType.NVarchar2, xetduyet, ParameterDirection.Input);
            queryParams[1] = new OracleParameter("v_mapdk", OracleDbType.Varchar2, mapdk, ParameterDirection.Input);

            // Thêm biến vào OracleCommand
            cmd.Parameters.AddRange(queryParams);

            //Trả về số dòng dữ liệu đã được cập nhật
            int row = cmd.ExecuteNonQuery();

            //Hoàn thành
            return row;
        }
    }
}

