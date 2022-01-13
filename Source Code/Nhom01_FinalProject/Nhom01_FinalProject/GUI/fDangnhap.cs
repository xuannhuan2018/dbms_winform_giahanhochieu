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

namespace Nhom01_FinalProject.GUI
{
    public partial class fDangnhap : Form
    {
        OracleConnection MainCon;

        public fDangnhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được trống!");
            }
            else
            {
                string host = "localhost";
                int port = 1521;
                string sid = "ORCLPDB.LOCALDOMAIN";

                // Connection String để kết nối trực tiếp tới Oracle.
                CurrentUserLogin.Constring = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                     + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                     + sid + ")));Password=" + txtUsername.Text.Trim() + ";User ID=" + txtPassword.Text.Trim();
                MainCon = new OracleConnection(CurrentUserLogin.Constring);

                try
                {
                    MainCon.Open();
                    MessageBox.Show("Đăng nhập thành công!");
                    new fXacthuc().ShowDialog();
                }

                catch
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác. Vui lòng kiểm tra lại!");
                }

                finally
                {
                    MainCon.Close();
                }
            }
        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void fDangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
