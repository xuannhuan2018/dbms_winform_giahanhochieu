using Nhom01_FinalProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nhom01_FinalProject.DTO;

namespace Nhom01_FinalProject.GUI
{
    public partial class fHsDangKy : Form
    {
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public fHsDangKy()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();

            if (txtTimKiem.Text == "")
            {
                dt = PhieugiahanDAO.LayThongTinTatCaPDK();
            }
            else
            {
                dt = PhieugiahanDAO.TimKiemThongTinTheoMa(txtTimKiem.Text);
            }

            dataGridView_ttdk.DataSource = dt;
        }
        private void fHsDangKy_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void btnXacThuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fUpdateXacThuc());
        }

        private void dataGridView_ttdk_events(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            Phieugiahan.Mapdk = dataGridView_ttdk.Rows[numrow].Cells[0].Value.ToString();
            Phieugiahan.Cmnd = dataGridView_ttdk.Rows[numrow].Cells[5].Value.ToString();
            Phieugiahan.Hoten = dataGridView_ttdk.Rows[numrow].Cells[2].Value.ToString();
            string tamp = dataGridView_ttdk.Rows[numrow].Cells[3].Value.ToString();
            Phieugiahan.Ngaysinh = (Convert.ToDateTime(tamp)).Date;
            Phieugiahan.Gioitinh = dataGridView_ttdk.Rows[numrow].Cells[4].Value.ToString();
            Phieugiahan.Phuong = dataGridView_ttdk.Rows[numrow].Cells[7].Value.ToString();
            Phieugiahan.Quanhuyen = dataGridView_ttdk.Rows[numrow].Cells[8].Value.ToString();
            Phieugiahan.Mahochieu = dataGridView_ttdk.Rows[numrow].Cells[11].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtTimKiem.ResetText();
            LoadData();
        }
    }
}
