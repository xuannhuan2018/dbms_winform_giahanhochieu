
namespace Nhom01_FinalProject.GUI
{
    partial class fAdminxt
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
            this.btnDSDK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHsHochieu = new System.Windows.Forms.Button();
            this.btnDanCu = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.label_user = new System.Windows.Forms.Label();
            this.label_hoten = new System.Windows.Forms.Label();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDSDK
            // 
            this.btnDSDK.Location = new System.Drawing.Point(0, 34);
            this.btnDSDK.Name = "btnDSDK";
            this.btnDSDK.Size = new System.Drawing.Size(260, 72);
            this.btnDSDK.TabIndex = 2;
            this.btnDSDK.Text = "Hồ Sơ Đăng Ký";
            this.btnDSDK.UseVisualStyleBackColor = true;
            this.btnDSDK.Click += new System.EventHandler(this.btnDSDK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnHsHochieu);
            this.panel1.Controls.Add(this.btnDanCu);
            this.panel1.Controls.Add(this.btnDSDK);
            this.panel1.Location = new System.Drawing.Point(30, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 520);
            this.panel1.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(0, 268);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(260, 72);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHsHochieu
            // 
            this.btnHsHochieu.Location = new System.Drawing.Point(0, 190);
            this.btnHsHochieu.Name = "btnHsHochieu";
            this.btnHsHochieu.Size = new System.Drawing.Size(260, 72);
            this.btnHsHochieu.TabIndex = 4;
            this.btnHsHochieu.Text = "Hồ Sơ Hộ Chiếu";
            this.btnHsHochieu.UseVisualStyleBackColor = true;
            this.btnHsHochieu.Click += new System.EventHandler(this.btnHsHochieu_Click);
            // 
            // btnDanCu
            // 
            this.btnDanCu.Location = new System.Drawing.Point(0, 112);
            this.btnDanCu.Name = "btnDanCu";
            this.btnDanCu.Size = new System.Drawing.Size(260, 72);
            this.btnDanCu.TabIndex = 3;
            this.btnDanCu.Text = "Hồ Sơ Công Dân";
            this.btnDanCu.UseVisualStyleBackColor = true;
            this.btnDanCu.Click += new System.EventHandler(this.btnDanCu_Click);
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.label_user);
            this.panel_body.Controls.Add(this.label_hoten);
            this.panel_body.Controls.Add(this.pictureBox_Logo);
            this.panel_body.Location = new System.Drawing.Point(309, 2);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1056, 520);
            this.panel_body.TabIndex = 4;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_user.Location = new System.Drawing.Point(607, 312);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(177, 44);
            this.label_user.TabIndex = 16;
            this.label_user.Text = "Tên user";
            // 
            // label_hoten
            // 
            this.label_hoten.AutoSize = true;
            this.label_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hoten.ForeColor = System.Drawing.Color.Black;
            this.label_hoten.Location = new System.Drawing.Point(347, 324);
            this.label_hoten.Name = "label_hoten";
            this.label_hoten.Size = new System.Drawing.Size(237, 32);
            this.label_hoten.TabIndex = 15;
            this.label_hoten.Text = "Chào mừng user";
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = global::Nhom01_FinalProject.Properties.Resources.logo_1;
            this.pictureBox_Logo.Location = new System.Drawing.Point(422, 25);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(290, 255);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 6;
            this.pictureBox_Logo.TabStop = false;
            // 
            // fAdminxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1365, 522);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel1);
            this.Name = "fAdminxt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Quản Lý Xác Thực";
            this.Load += new System.EventHandler(this.fAdminxt_Load);
            this.panel1.ResumeLayout(false);
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDSDK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHsHochieu;
        private System.Windows.Forms.Button btnDanCu;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_hoten;
    }
}