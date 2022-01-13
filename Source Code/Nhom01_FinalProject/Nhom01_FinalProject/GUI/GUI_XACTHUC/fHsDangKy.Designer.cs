
namespace Nhom01_FinalProject.GUI
{
    partial class fHsDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oracleDataAdapter1 = new Oracle.ManagedDataAccess.Client.OracleDataAdapter();
            this.oracleDataAdapter2 = new Oracle.ManagedDataAccess.Client.OracleDataAdapter();
            this.dataGridView_ttdk = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnXacThuc = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ttdk)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_ttdk
            // 
            this.dataGridView_ttdk.AllowUserToOrderColumns = true;
            this.dataGridView_ttdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ttdk.Location = new System.Drawing.Point(16, 173);
            this.dataGridView_ttdk.Name = "dataGridView_ttdk";
            this.dataGridView_ttdk.RowHeadersWidth = 51;
            this.dataGridView_ttdk.RowTemplate.Height = 24;
            this.dataGridView_ttdk.Size = new System.Drawing.Size(1011, 319);
            this.dataGridView_ttdk.TabIndex = 2;
            this.dataGridView_ttdk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ttdk_events);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(116, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(778, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SÁCH THÔNG TIN ĐĂNG KÝ GIA HẠN HỘ CHIẾU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Mã Phiếu Đăng Ký";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(52, 29);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(214, 31);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnXacThuc
            // 
            this.btnXacThuc.BackColor = System.Drawing.Color.DarkGreen;
            this.btnXacThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacThuc.ForeColor = System.Drawing.Color.White;
            this.btnXacThuc.Location = new System.Drawing.Point(894, 93);
            this.btnXacThuc.Name = "btnXacThuc";
            this.btnXacThuc.Size = new System.Drawing.Size(133, 58);
            this.btnXacThuc.TabIndex = 7;
            this.btnXacThuc.Text = "XÁC THỰC";
            this.btnXacThuc.UseVisualStyleBackColor = false;
            this.btnXacThuc.Click += new System.EventHandler(this.btnXacThuc_Click);
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.btnReload);
            this.panel_body.Controls.Add(this.groupBox1);
            this.panel_body.Controls.Add(this.btnXacThuc);
            this.panel_body.Controls.Add(this.label1);
            this.panel_body.Controls.Add(this.dataGridView_ttdk);
            this.panel_body.Location = new System.Drawing.Point(-1, -2);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1038, 501);
            this.panel_body.TabIndex = 8;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.DarkGreen;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(724, 94);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(133, 58);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "LÀM MỚI";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // fHsDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1038, 500);
            this.Controls.Add(this.panel_body);
            this.Name = "fHsDangKy";
            this.Text = "fHsDangKy";
            this.Load += new System.EventHandler(this.fHsDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ttdk)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Oracle.ManagedDataAccess.Client.OracleDataAdapter oracleDataAdapter1;
        private Oracle.ManagedDataAccess.Client.OracleDataAdapter oracleDataAdapter2;
        private System.Windows.Forms.DataGridView dataGridView_ttdk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXacThuc;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btnReload;
    }
}