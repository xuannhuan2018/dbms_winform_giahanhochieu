
namespace Nhom01_FinalProject.GUI.GUI_XETDUYET
{
    partial class fUpdateXetDuyet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_mpdk = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_no = new System.Windows.Forms.RadioButton();
            this.radioButton_yes = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_comments = new System.Windows.Forms.Label();
            this.label_trangthai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Index1 = new System.Windows.Forms.Label();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.btnXetDuyet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "XÉT DUYỆT THÔNG TIN GIA HẠN HỘ CHIẾU";
            // 
            // label_mpdk
            // 
            this.label_mpdk.AutoSize = true;
            this.label_mpdk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mpdk.ForeColor = System.Drawing.Color.Maroon;
            this.label_mpdk.Location = new System.Drawing.Point(389, 51);
            this.label_mpdk.Name = "label_mpdk";
            this.label_mpdk.Size = new System.Drawing.Size(175, 32);
            this.label_mpdk.TabIndex = 8;
            this.label_mpdk.Text = "[MÃ PHIẾU]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButton_no);
            this.groupBox1.Controls.Add(this.radioButton_yes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(111, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 134);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả xét duyệt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(114, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Không đồng ý gia hạn hộ chiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(114, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đồng ý gia hạn hộ chiếu";
            // 
            // radioButton_no
            // 
            this.radioButton_no.AutoSize = true;
            this.radioButton_no.Location = new System.Drawing.Point(53, 90);
            this.radioButton_no.Name = "radioButton_no";
            this.radioButton_no.Size = new System.Drawing.Size(17, 16);
            this.radioButton_no.TabIndex = 1;
            this.radioButton_no.TabStop = true;
            this.radioButton_no.UseVisualStyleBackColor = true;
            this.radioButton_no.CheckedChanged += new System.EventHandler(this.radioButton_no_CheckedChanged);
            // 
            // radioButton_yes
            // 
            this.radioButton_yes.AutoSize = true;
            this.radioButton_yes.Location = new System.Drawing.Point(53, 44);
            this.radioButton_yes.Name = "radioButton_yes";
            this.radioButton_yes.Size = new System.Drawing.Size(17, 16);
            this.radioButton_yes.TabIndex = 0;
            this.radioButton_yes.TabStop = true;
            this.radioButton_yes.UseVisualStyleBackColor = true;
            this.radioButton_yes.CheckedChanged += new System.EventHandler(this.radioButton_yes_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_comments);
            this.groupBox2.Controls.Add(this.label_trangthai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label_Index1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(111, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(850, 191);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tình trạng xác thực";
            // 
            // label_comments
            // 
            this.label_comments.AutoSize = true;
            this.label_comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_comments.ForeColor = System.Drawing.Color.Black;
            this.label_comments.Location = new System.Drawing.Point(238, 121);
            this.label_comments.Name = "label_comments";
            this.label_comments.Size = new System.Drawing.Size(413, 29);
            this.label_comments.TabIndex = 13;
            this.label_comments.Text = "Thông tin cá nhân không chính xác";
            // 
            // label_trangthai
            // 
            this.label_trangthai.AutoSize = true;
            this.label_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trangthai.ForeColor = System.Drawing.Color.Black;
            this.label_trangthai.Location = new System.Drawing.Point(238, 55);
            this.label_trangthai.Name = "label_trangthai";
            this.label_trangthai.Size = new System.Drawing.Size(146, 29);
            this.label_trangthai.TabIndex = 12;
            this.label_trangthai.Text = "Đã xác thực";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(79, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ghi chú:";
            // 
            // label_Index1
            // 
            this.label_Index1.AutoSize = true;
            this.label_Index1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Index1.ForeColor = System.Drawing.Color.Maroon;
            this.label_Index1.Location = new System.Drawing.Point(46, 55);
            this.label_Index1.Name = "label_Index1";
            this.label_Index1.Size = new System.Drawing.Size(162, 32);
            this.label_Index1.TabIndex = 10;
            this.label_Index1.Text = "Trạng thái:";
            // 
            // btnHuybo
            // 
            this.btnHuybo.BackColor = System.Drawing.Color.Maroon;
            this.btnHuybo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuybo.ForeColor = System.Drawing.Color.White;
            this.btnHuybo.Location = new System.Drawing.Point(802, 402);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(159, 47);
            this.btnHuybo.TabIndex = 15;
            this.btnHuybo.Text = "HỦY BỎ";
            this.btnHuybo.UseVisualStyleBackColor = false;
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // btnXetDuyet
            // 
            this.btnXetDuyet.BackColor = System.Drawing.Color.DarkGreen;
            this.btnXetDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXetDuyet.ForeColor = System.Drawing.Color.White;
            this.btnXetDuyet.Location = new System.Drawing.Point(637, 402);
            this.btnXetDuyet.Name = "btnXetDuyet";
            this.btnXetDuyet.Size = new System.Drawing.Size(159, 48);
            this.btnXetDuyet.TabIndex = 14;
            this.btnXetDuyet.Text = "XÉT DUYỆT";
            this.btnXetDuyet.UseVisualStyleBackColor = false;
            this.btnXetDuyet.Click += new System.EventHandler(this.btnXetDuyet_Click);
            // 
            // fUpdateXetDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 530);
            this.Controls.Add(this.btnHuybo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXetDuyet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_mpdk);
            this.Controls.Add(this.label1);
            this.Name = "fUpdateXetDuyet";
            this.Text = "fUpdateXetDuyet";
            this.Load += new System.EventHandler(this.fUpdateXetDuyet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_mpdk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_no;
        private System.Windows.Forms.RadioButton radioButton_yes;
        private System.Windows.Forms.Label label_comments;
        private System.Windows.Forms.Label label_trangthai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Index1;
        private System.Windows.Forms.Button btnHuybo;
        private System.Windows.Forms.Button btnXetDuyet;
    }
}