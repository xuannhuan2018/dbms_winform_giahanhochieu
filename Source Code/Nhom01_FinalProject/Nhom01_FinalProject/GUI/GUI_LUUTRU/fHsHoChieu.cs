using Nhom01_FinalProject.DAO;
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
    public partial class fHsHoChieu : Form
    {
        public fHsHoChieu()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = HochieuDAO.TimKiemThongTinTheoMa(txtTimKiem.Text);
            dataGridView_tthochieu_lt.DataSource = dt;
        }

        private void dataGridView_tthochieu_lt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fHsHoChieu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = HochieuDAO.LayThongTinHoChieu();
            dataGridView_tthochieu_lt.DataSource = dt;
        }
    }
}
