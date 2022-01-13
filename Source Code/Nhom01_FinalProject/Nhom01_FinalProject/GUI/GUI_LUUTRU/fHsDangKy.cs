using Nhom01_FinalProject.DAO;
using Nhom01_FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nhom01_FinalProject.GUI.GUI_LUUTRU
{
    public partial class fHsDangKy : Form
    {
        public fHsDangKy()
        {
            InitializeComponent();
            btnGiaHanHoChieu.Enabled = true;
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

            panel_body.Controls.Add(childForm); //add form mới mở vào 
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();//Mở form
        }


        private void dataGridView_hsdk_lt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            Phieugiahan.Mapdk = dataGridView_hsdk_lt.Rows[numrow].Cells[0].Value.ToString();
            Phieugiahan.Ttxetduyet = dataGridView_hsdk_lt.Rows[numrow].Cells[3].Value.ToString();
            Phieugiahan.Mahochieu = dataGridView_hsdk_lt.Rows[numrow].Cells[2].Value.ToString();
        }

        private void LoadDataGridView()
        {
            DataTable dt = new DataTable();
            if (radioButton_DongY.Checked)
            {
                btnGiaHanHoChieu.Enabled = true;
                dt = PhieugiahanDAO.LayDuLieuDongYXetDuyet();
                dataGridView_hsdk_lt.DataSource = dt;
            }
            else if(radioButton_KhongDongY.Checked)
            {
                btnGiaHanHoChieu.Enabled = false;
                dt = PhieugiahanDAO.LayDuLieuKhongDongYXetDuyet();
                dataGridView_hsdk_lt.DataSource = dt;
            }
            else
            {
                btnGiaHanHoChieu.Enabled = false;
                dt = PhieugiahanDAO.LayThongTinTatCaPDK();
                dataGridView_hsdk_lt.DataSource = dt;
            }
        }

        private void fHsDangKy_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            radioButton_DongY.Checked = false;
            radioButton_KhongDongY.Checked = false;
            btnGiaHanHoChieu.Enabled = false;
            LoadDataGridView();
        }

        private void radioButton_DongY_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void radioButton_KhongDongY_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnGiaHanHoChieu_Click(object sender, EventArgs e)
        {
            if(Phieugiahan.Ttxetduyet == "Không Đồng Ý")
            {
                MessageBox.Show("Không thể cập nhật thời gian gia hạn hộ chiếu!");
            }
            else
            {
                OpenChildForm(new fUpdateTimeHoChieu());
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            btnGiaHanHoChieu.Enabled = false;
            dt = PhieugiahanDAO.TimKiemThongTinTheoMa(txtTimKiem.Text);
            dataGridView_hsdk_lt.DataSource = dt;
        }
    }
}
