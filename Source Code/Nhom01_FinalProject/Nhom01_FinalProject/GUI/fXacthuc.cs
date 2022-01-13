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
    public partial class fXacthuc : Form
    {
        public fXacthuc()
        {
            InitializeComponent();
        }

        OracleConnection conn = new OracleConnection(CurrentUserLogin.Constring);
        private void btnLoad_Click(object sender, EventArgs e)
        {
            conn.Open();
            OracleDataAdapter oda = new OracleDataAdapter("SELECT * FROM PASSPORT.dsgiahanhochieu", conn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void fXacthuc_Load(object sender, EventArgs e)
        {

        }
    }
}
