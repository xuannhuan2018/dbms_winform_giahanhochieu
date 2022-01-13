using Nhom01_FinalProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nhom01_FinalProject.GUI
{
    public partial class fHsHoChieu : Form
    {
        public fHsHoChieu()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();

            if (txtTimKiem.Text == "")
            {
                dt = HochieuDAO.LayThongTinHoChieu();
            }
            else
            {
                dt = HochieuDAO.TimKiemThongTinTheoMa(txtTimKiem.Text);
            }

            dataGridView_tthochieu.DataSource = dt;
        }


        private void fHsHoChieu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
