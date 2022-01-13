
namespace Nhom01_FinalProject.GUI.GUI_LUUTRU
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
            this.panel_body = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_KhongDongY = new System.Windows.Forms.RadioButton();
            this.radioButton_DongY = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnGiaHanHoChieu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_hsdk_lt = new System.Windows.Forms.DataGridView();
            this.panel_body.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hsdk_lt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.btnReload);
            this.panel_body.Controls.Add(this.groupBox2);
            this.panel_body.Controls.Add(this.groupBox1);
            this.panel_body.Controls.Add(this.btnGiaHanHoChieu);
            this.panel_body.Controls.Add(this.label1);
            this.panel_body.Controls.Add(this.dataGridView_hsdk_lt);
            this.panel_body.Location = new System.Drawing.Point(13, 15);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1038, 501);
            this.panel_body.TabIndex = 10;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.DarkGreen;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(743, 94);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(133, 58);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "LÀM MỚI";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_KhongDongY);
            this.groupBox2.Controls.Add(this.radioButton_DongY);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(290, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 70);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tình trạng xét duyệt";
            // 
            // radioButton_KhongDongY
            // 
            this.radioButton_KhongDongY.AutoSize = true;
            this.radioButton_KhongDongY.Location = new System.Drawing.Point(230, 35);
            this.radioButton_KhongDongY.Name = "radioButton_KhongDongY";
            this.radioButton_KhongDongY.Size = new System.Drawing.Size(136, 24);
            this.radioButton_KhongDongY.TabIndex = 1;
            this.radioButton_KhongDongY.TabStop = true;
            this.radioButton_KhongDongY.Text = "Không Đồng Ý";
            this.radioButton_KhongDongY.UseVisualStyleBackColor = true;
            this.radioButton_KhongDongY.CheckedChanged += new System.EventHandler(this.radioButton_KhongDongY_CheckedChanged);
            // 
            // radioButton_DongY
            // 
            this.radioButton_DongY.AutoSize = true;
            this.radioButton_DongY.Location = new System.Drawing.Point(81, 35);
            this.radioButton_DongY.Name = "radioButton_DongY";
            this.radioButton_DongY.Size = new System.Drawing.Size(84, 24);
            this.radioButton_DongY.TabIndex = 0;
            this.radioButton_DongY.TabStop = true;
            this.radioButton_DongY.Text = "Đồng Ý";
            this.radioButton_DongY.UseVisualStyleBackColor = true;
            this.radioButton_DongY.CheckedChanged += new System.EventHandler(this.radioButton_DongY_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Mã Phiếu Đăng Ký";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(6, 28);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(214, 31);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnGiaHanHoChieu
            // 
            this.btnGiaHanHoChieu.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGiaHanHoChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaHanHoChieu.ForeColor = System.Drawing.Color.White;
            this.btnGiaHanHoChieu.Location = new System.Drawing.Point(894, 94);
            this.btnGiaHanHoChieu.Name = "btnGiaHanHoChieu";
            this.btnGiaHanHoChieu.Size = new System.Drawing.Size(133, 58);
            this.btnGiaHanHoChieu.TabIndex = 7;
            this.btnGiaHanHoChieu.Text = "CẬP NHẬT";
            this.btnGiaHanHoChieu.UseVisualStyleBackColor = false;
            this.btnGiaHanHoChieu.Click += new System.EventHandler(this.btnGiaHanHoChieu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(55, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(920, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SÁCH THÔNG TIN GIA HẠN HỘ CHIẾU TẠI THÀNH PHỐ HỒ CHÍ MINH";
            // 
            // dataGridView_hsdk_lt
            // 
            this.dataGridView_hsdk_lt.AllowUserToOrderColumns = true;
            this.dataGridView_hsdk_lt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hsdk_lt.Location = new System.Drawing.Point(223, 179);
            this.dataGridView_hsdk_lt.Name = "dataGridView_hsdk_lt";
            this.dataGridView_hsdk_lt.RowHeadersWidth = 51;
            this.dataGridView_hsdk_lt.RowTemplate.Height = 24;
            this.dataGridView_hsdk_lt.Size = new System.Drawing.Size(622, 319);
            this.dataGridView_hsdk_lt.TabIndex = 2;
            this.dataGridView_hsdk_lt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hsdk_lt_CellContentClick);
            // 
            // fHsDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 530);
            this.Controls.Add(this.panel_body);
            this.Name = "fHsDangKy";
            this.Text = "fHsDangKy";
            this.Load += new System.EventHandler(this.fHsDangKy_Load);
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hsdk_lt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_KhongDongY;
        private System.Windows.Forms.RadioButton radioButton_DongY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnGiaHanHoChieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_hsdk_lt;
        private System.Windows.Forms.Button btnReload;
    }
}