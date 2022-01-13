using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Nhom01_FinalProject.DAO
{
    public class GiamsatDAO
    {
        /// <summary>
        /// Lấy toàn bộ dữ liệu trong bảng được giám sát
        /// </summary>
        /// <returns>Một Datable chứa dữ liệu lấy được</returns>
        public static DataTable LayThongTinGiamSat()
        {
            //Câu truy vấn
            string sql = "SELECT TO_CHAR(extended_timestamp, 'DD-MM-YYYY HH24:MI:SS'), current_user, userhost, statement_type, sql_text, sql_bind FROM DBA_FGA_AUDIT_TRAIL ORDER BY extended_timestamp DESC";

            //Sử dụng nguồn dữ liệu OracleConnection
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            //Mở chuỗi kết nối
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = StaticConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Sử dụng ExecuteReader để đọc dữ liệu
            OracleDataReader oda = cmd.ExecuteReader();

            //Tạo mới một Datatable có tên dt 
            DataTable dt = new DataTable();

            //Load dữ liệu đã đọc được đổ vào dt
            dt.Load(oda);

            //Done
            return dt;
        }

        /// <summary>
        /// Tim kiem theo ma
        /// </summary>
        /// <returns>Một Datatable chữa các dòng dữ liệu</returns>
        public static DataTable TimKiemTheoMa(string mapdk)
        {
            //Câu truy vấn
            string sql = "SELECT TO_CHAR(extended_timestamp, 'DD-MM-YYYY HH24:MI:SS'), current_user, userhost, statement_type, sql_text, sql_bind FROM DBA_FGA_AUDIT_TRAIL WHERE sql_bind LIKE :v_mapdk ORDER BY extended_timestamp DESC";

            //Nguồn kết nối OracleConnection
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối
            connection.Open();

            // Sử dụng OracleConnection
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Tạo mảng chứa các biến
            OracleParameter[] queryParams = new OracleParameter[1];
            queryParams[0] = new OracleParameter("v_mapdk", OracleDbType.Varchar2, "%" + mapdk + "%", ParameterDirection.Input);

            // Thêm các biến vào OracleCommand
            cmd.Parameters.AddRange(queryParams);

            //Sử dụng ExecuteReader để đọc dữ liệu
            OracleDataReader oda = cmd.ExecuteReader();

            //Tạo một Datable có tên dt
            DataTable dt = new DataTable();

            //Load dữ liệu đọc được vào dt
            dt.Load(oda);

            //Trả về một dt chữa dữ liệu đọc được
            return dt;
        }
    }
}
