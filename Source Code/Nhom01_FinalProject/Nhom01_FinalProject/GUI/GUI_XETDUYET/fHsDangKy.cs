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

namespace Nhom01_FinalProject.GUI.GUI_XETDUYET
{
    public partial class fHsDangKy : Form
    {
        public fHsDangKy()
        {
            InitializeComponent();
        }

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

        private void LoadDataGridView()
        {
            DataTable dt = new DataTable();
            dt = PhieugiahanDAO.LayThongTinTatCaPDK();
            dataGridView_ttdk.DataSource = dt;
        }
        private void fHsDangKy_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnXetduyet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fUpdateXetDuyet());

            if (currentFormChild == null)
            {
                LoadDataGridView();
            }    
        }

        private void dataGridView_ttdk_events(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            Phieugiahan.Mapdk = dataGridView_ttdk.Rows[numrow].Cells[0].Value.ToString();
            Phieugiahan.Ttxacthuc = dataGridView_ttdk.Rows[numrow].Cells[12].Value.ToString();
            Phieugiahan.Comments = dataGridView_ttdk.Rows[numrow].Cells[14].Value.ToString();
        }

        private void radioButton_Daxetduyet_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PhieugiahanDAO.LayDuLieuDaXetDuyet();
            dataGridView_ttdk.DataSource = dt;
        }

        private void radioButton_Choxetduyet_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PhieugiahanDAO.LayDuLieuChoXetDuyet();
            dataGridView_ttdk.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PhieugiahanDAO.TimKiemThongTinTheoMa(txtTimKiem.Text);
            dataGridView_ttdk.DataSource = dt;
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            txtTimKiem.ResetText();
            radioButton_Choxetduyet.Checked = false;
            radioButton_Daxetduyet.Checked = false;
            DataTable dt = new DataTable();
            dt = PhieugiahanDAO.LayThongTinTatCaPDK();
            dataGridView_ttdk.DataSource = dt;
        }
    }
}
