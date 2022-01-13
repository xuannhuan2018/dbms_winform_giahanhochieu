using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nhom01_FinalProject.DAO;
using Nhom01_FinalProject.DTO;

namespace Nhom01_FinalProject.GUI
{
    public partial class fHsCongDan : Form
    {
        public fHsCongDan()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();

            if(txtTimKiem.Text == "")
            {
                dt = DancuDAO.LayThongTinDanCuHCM();
            }
            else
            {
                dt = DancuDAO.TimKiemThongTinTheoCMND(txtTimKiem.Text);
            }

            dataGridView_congdanhcm.DataSource = dt;
        }

        private void fHsCongDan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
