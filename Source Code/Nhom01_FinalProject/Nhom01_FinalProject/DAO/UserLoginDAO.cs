using Nhom01_FinalProject.DTO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Nhom01_FinalProject.DAO
{
    class UserLoginDAO
    {
        /// <summary>
        /// Hàm kiếm tra thông tin đăng nhập
        /// </summary>
        /// <param name="username">Tên tài khoản đăng nhập</param>
        /// <param name="password">Mật khẩu đăng nhập</param>
        /// <returns>Trả về kết quả đăng nhập dưới dạng bool</returns>
        public static bool CheckCurrentUserLogin(string username, string password)
        {
            //Chuỗi đăng nhập truyền vào 2 biến usernamme, password
            UserLogin.Constring = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                     + "192.168.214.1" + ")(PORT = " + "1521" + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                     + "ORCLPDB.LOCALDOMAIN" + "))); Password=" + username + ";User ID=" + password;

            //Tạo mới OracleConnection với chuỗi vừa tạo ở trên
            OracleConnection MainCon = new OracleConnection(UserLogin.Constring);

            try //Thử mở kết nối
            {
                MainCon.Open();
            }
            catch (OracleException)
            {
                //Nếu xảy ra lỗi (không mở được) thì đóng kết nối
                MainCon.Close();
            }

            if (MainCon.State == ConnectionState.Open)// Kiểm tra việc mở trên được hay không thông qua trạng thái chuỗi sau khi mở: nếu trạng thái đang open là mở đc
            {
                return true; //trả về true
            }
            else //Trạng thái đang đóng
            {
                return false;// trả về false
            }
        }
    }
}
