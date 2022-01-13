using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Nhom01_FinalProject.DAO
{
    class StaticConnect
    {
        /// <summary>
        /// Hàm lấy thông tin kết nối
        /// </summary>
        /// <returns> nguồn kết nối</returns>
        public static OracleConnection GetOracleConnection()
        {
            //Một số biến mà chuỗi kết nối Oracle cần cung cấp
            string host = "192.168.214.1";
            int port = 1521;
            string sid = "ORCLPDB.LOCALDOMAIN";
            string v_password = "PASSPORT";
            string v_username = "PASSPORT";



            // Tạo chuỗi kết nốiđể kết nối trực tiếp tới Oracle.
            string strconn = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + v_password + ";User ID=" + v_username;

            OracleConnection conn = new OracleConnection(strconn);
            return conn;
        }

        /// <summary>
        /// GetSqlCommand
        /// </summary>
        /// <param name="query">Câu truy vấn</param>
        /// <param name="conn">nguồn kết nối</param>
        /// <returns>một OracleCommand</returns>
        public static OracleCommand GetOracleCommand(string query, OracleConnection conn)
        {
            OracleCommand cmd = new OracleCommand(query, conn);
            return cmd;
        }
    }
}
