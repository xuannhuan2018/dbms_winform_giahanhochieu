using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nhom01_FinalProject.DTO;
using Oracle.ManagedDataAccess.Client;

namespace Nhom01_FinalProject.DAO
{
    class DancuDAO
    {
        /// <summary>
        /// Lấy toàn bộ dữ liệu trong bảng ttcongdanhcm
        /// </summary>
        /// <returns>Một Datable chứa dữ liệu lấy được</returns>
        public static DataTable LayThongTinDanCuHCM()
        {
            //Câu truy vấn
            string sql = "SELECT * FROM RESIDENT.ttcongdanhcm";

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
        /// Lấy toàn bộ thông tin các hàng trong bảng ttcongdanhcm theo ma so cmnd
        /// </summary>
        /// <returns>trả về một Datatable</returns>
        public static DataTable TimKiemThongTinTheoCMND(string cmnd)
        {
            //Câu truy vấn
            string sql = "SELECT * FROM RESIDENT.ttcongdanhcm WHERE cmnd LIKE :v_cmnd";

            //Lấy OracleConnection làm tài nguyên
            OracleConnection connection = DynamicConnect.GetOracleConnection();

            // Mở chuỗi kết nối OracleConnection
            connection.Open();

            // Sử dụng OracleCommand
            OracleCommand cmd = DynamicConnect.GetOracleCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            //Tạo mảng chứa các biến
            OracleParameter[] queryParams = new OracleParameter[1];
            queryParams[0] = new OracleParameter("v_cmnd", OracleDbType.Varchar2, "%" + cmnd + "%", ParameterDirection.Input);

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
    }
}
