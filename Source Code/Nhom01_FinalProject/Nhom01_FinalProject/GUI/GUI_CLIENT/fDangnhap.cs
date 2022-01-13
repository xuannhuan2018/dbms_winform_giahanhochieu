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
    public partial class fDangnhap : Form
    {
        public fDangnhap()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Tạo một đối tượng Form có tên currentFormChild
        /// </summary>
        private Form currentFormChild;

        /// <summary>
        /// Mở form theo điều kiện đổ vào panel tương ứng
        /// </summary>
        /// <param name="childForm"></param>
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null) //Nếu có form con nào đang mở
            {
                currentFormChild.Close(); // Đóng form con đó đi
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_bodyDN.Controls.Add(childForm); //add form mới mở vào 
            panel_bodyDN.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();//Mở form
        }

        /// <summary>
        /// Kiểm tra thông tin trống khi đăng nhập
        /// </summary>
        /// <param name="username">Tên đăng nhập</param>
        /// <param name="password">Mật khẩu đăng nhập</param>
        /// <returns>Trả về true/ false</returns>
        static bool CheckInforNull(string username, string password)
        {
            if (username == "" || password == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Reset trạng thái ban đầu của các textbox và checkbox
        /// </summary>
        private void ResetTextBox()
        {
            txtPassword.ResetText();
            txtUsername.ResetText();
            checkPassword.Checked = false;
        }

        /// <summary>
        /// Phân quyền đăng nhập vào các form tương ứng với từng username
        /// </summary>
        /// <param name="username">Thông báo kết quả đăng nhập & Mở form tương ứng</param>
        public void CheckRoleLogin(string username)
        {
            if(username == "PASSPORT" || username == "RESIDENT") //Nhóm user chứa dữ liệu
            {
                MessageBox.Show("Tên đăng nhập hoặc tài khoản đăng nhập không chính xác. Vui lòng kiểm tra lại!"); //Không được đăng nhập trên giao diện
            }
            else if(username == "BPXETDUYET") //Nhóm user xét duyệt
            {
                MessageBox.Show("Đăng nhập thành công");
                OpenChildForm(new fAdminxd());
            }
            else if(username == "BPLUUTRU") //Nhóm user lưu trữ
            {
                MessageBox.Show("Đăng nhập thành công");
                OpenChildForm(new fAdminlt());
            }
            else if (username == "BPGIAMSAT")// Nhóm user giám sát
            {
                MessageBox.Show("Đăng nhập thành công");
                OpenChildForm(new fAdmings());
            }
            else //Nhóm user còn lại (user xác thực)
            {
                MessageBox.Show("Đăng nhập thành công");
                OpenChildForm(new fAdminxt());
            }
        }

        /// <summary>
        /// Sự kiện button đăng nhập
        /// </summary>
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            UserLogin.Username = txtUsername.Text; //gán cho thuộc tính Username thuộc lớp CurrentLogin có giá trị ô txtUsername
            UserLogin.Password = txtPassword.Text;//gán cho thuộc tính Password thuộc lớp CurrentLogin có giá trị ô txtPassword

            if (CheckInforNull(UserLogin.Username, UserLogin.Password) == false) //Kiểm tra thông tin NULL
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được trống!");
            }
            else
            {      
               if(UserLoginDAO.CheckCurrentUserLogin(UserLogin.Username, UserLogin.Password) == true) //Kiểm tra thông tin đăng nhập là đúng
                {
                    CheckRoleLogin(UserLogin.Username); //Phân quyền đăng nhập
                    ResetTextBox(); //Reset trạng thái các ô
                }
                else //Thông tin đăng nhập sai
                {
                    MessageBox.Show("Tên đăng nhập hoặc tài khoản đăng nhập không chính xác. Vui lòng kiểm tra lại!");
                }                  
            }
        }

        /// <summary>
        /// Xử lý sự kiện click checkbox Password
        /// </summary>
        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkPassword.Checked) //Nếu được check
            {
                txtPassword.UseSystemPasswordChar = true;//Xuất hiện trạng thái mặc định của mặc khẩu
            }
            else//Nếu không được check 
            {
                txtPassword.UseSystemPasswordChar = false; //Che giấu mật khẩu dưới dạng ***
            }    
        }

        private void fDangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
