using Nhom01_FinalProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nhom01_FinalProject.GUI.GUI_GIAMSAT
{
    public partial class fHsGiamSat : Form
    {
        public fHsGiamSat()
        {
            InitializeComponent();
        }


        public void LoadData()
        {
            DataTable dt = new DataTable();
            if(txtTimKiem.Text == "")
            {
                dt = GiamsatDAO.LayThongTinGiamSat();
            }    
            else
            {
                dt = GiamsatDAO.TimKiemTheoMa(txtTimKiem.Text);
            }    
            dataGridView_hsgs_gs.DataSource = dt;
        } 
        
        
        private void fHsGiamSat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
