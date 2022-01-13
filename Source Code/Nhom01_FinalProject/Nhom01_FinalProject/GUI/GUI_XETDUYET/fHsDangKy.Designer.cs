
namespace Nhom01_FinalProject.GUI.GUI_XETDUYET
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Choxetduyet = new System.Windows.Forms.RadioButton();
            this.radioButton_Daxetduyet = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnXetduyet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_ttdk = new System.Windows.Forms.DataGridView();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.panel_body.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ttdk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.btnReLoad);
            this.panel_body.Controls.Add(this.groupBox2);
            this.panel_body.Controls.Add(this.groupBox1);
            this.panel_body.Controls.Add(this.btnXetduyet);
            this.panel_body.Controls.Add(this.label1);
            this.panel_body.Controls.Add(this.dataGridView_ttdk);
            this.panel_body.Location = new System.Drawing.Point(15, 12);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1038, 501);
            this.panel_body.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Choxetduyet);
            this.groupBox2.Controls.Add(this.radioButton_Daxetduyet);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(310, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 70);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tình trạng xét duyệt";
            // 
            // radioButton_Choxetduyet
            // 
            this.radioButton_Choxetduyet.AutoSize = true;
            this.radioButton_Choxetduyet.Location = new System.Drawing.Point(237, 35);
            this.radioButton_Choxetduyet.Name = "radioButton_Choxetduyet";
            this.radioButton_Choxetduyet.Size = new System.Drawing.Size(132, 24);
            this.radioButton_Choxetduyet.TabIndex = 1;
            this.radioButton_Choxetduyet.TabStop = true;
            this.radioButton_Choxetduyet.Text = "Chờ xét duyệt";
            this.radioButton_Choxetduyet.UseVisualStyleBackColor = true;
            this.radioButton_Choxetduyet.CheckedChanged += new System.EventHandler(this.radioButton_Choxetduyet_CheckedChanged);
            // 
            // radioButton_Daxetduyet
            // 
            this.radioButton_Daxetduyet.AutoSize = true;
            this.radioButton_Daxetduyet.Location = new System.Drawing.Point(35, 35);
            this.radioButton_Daxetduyet.Name = "radioButton_Daxetduyet";
            this.radioButton_Daxetduyet.Size = new System.Drawing.Size(123, 24);
            this.radioButton_Daxetduyet.TabIndex = 0;
            this.radioButton_Daxetduyet.TabStop = true;
            this.radioButton_Daxetduyet.Text = "Đã xét duyệt";
            this.radioButton_Daxetduyet.UseVisualStyleBackColor = true;
            this.radioButton_Daxetduyet.CheckedChanged += new System.EventHandler(this.radioButton_Daxetduyet_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Mã Phiếu Đăng Ký";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(15, 28);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(189, 31);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnXetduyet
            // 
            this.btnXetduyet.BackColor = System.Drawing.Color.DarkGreen;
            this.btnXetduyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXetduyet.ForeColor = System.Drawing.Color.White;
            this.btnXetduyet.Location = new System.Drawing.Point(894, 94);
            this.btnXetduyet.Name = "btnXetduyet";
            this.btnXetduyet.Size = new System.Drawing.Size(133, 58);
            this.btnXetduyet.TabIndex = 7;
            this.btnXetduyet.Text = "XÉT DUYỆT";
            this.btnXetduyet.UseVisualStyleBackColor = false;
            this.btnXetduyet.Click += new System.EventHandler(this.btnXetduyet_Click);
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
            // btnReLoad
            // 
            this.btnReLoad.BackColor = System.Drawing.Color.DarkGreen;
            this.btnReLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.ForeColor = System.Drawing.Color.White;
            this.btnReLoad.Location = new System.Drawing.Point(746, 94);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(133, 58);
            this.btnReLoad.TabIndex = 8;
            this.btnReLoad.Text = "LÀM MỚI";
            this.btnReLoad.UseVisualStyleBackColor = false;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ttdk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXetduyet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_ttdk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Choxetduyet;
        private System.Windows.Forms.RadioButton radioButton_Daxetduyet;
        private System.Windows.Forms.Button btnReLoad;
    }
}