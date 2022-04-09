
namespace do_an_demo
{
    partial class Frm_ThemChiTietHoiDong
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txb_MaHD = new System.Windows.Forms.TextBox();
            this.Txb_Chucvu = new System.Windows.Forms.TextBox();
            this.Txb_MaGK = new System.Windows.Forms.TextBox();
            this.Txb_MachitietHD = new System.Windows.Forms.TextBox();
            this.Dgv_GKMaGK = new System.Windows.Forms.DataGridView();
            this.Dgv_HDMaHD = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_ThemChiTietHD = new System.Windows.Forms.Button();
            this.Dgv_Chitiethoidong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_GKMaGK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_HDMaHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Chitiethoidong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chi tiết hội đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hội đồng ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã giám khảo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chức vụ trong hội đồng";
            // 
            // Txb_MaHD
            // 
            this.Txb_MaHD.Location = new System.Drawing.Point(56, 150);
            this.Txb_MaHD.Name = "Txb_MaHD";
            this.Txb_MaHD.ReadOnly = true;
            this.Txb_MaHD.Size = new System.Drawing.Size(100, 22);
            this.Txb_MaHD.TabIndex = 4;
            // 
            // Txb_Chucvu
            // 
            this.Txb_Chucvu.Location = new System.Drawing.Point(566, 150);
            this.Txb_Chucvu.Name = "Txb_Chucvu";
            this.Txb_Chucvu.Size = new System.Drawing.Size(152, 22);
            this.Txb_Chucvu.TabIndex = 5;
            // 
            // Txb_MaGK
            // 
            this.Txb_MaGK.Location = new System.Drawing.Point(566, 67);
            this.Txb_MaGK.Name = "Txb_MaGK";
            this.Txb_MaGK.ReadOnly = true;
            this.Txb_MaGK.Size = new System.Drawing.Size(100, 22);
            this.Txb_MaGK.TabIndex = 6;
            // 
            // Txb_MachitietHD
            // 
            this.Txb_MachitietHD.Location = new System.Drawing.Point(56, 67);
            this.Txb_MachitietHD.Name = "Txb_MachitietHD";
            this.Txb_MachitietHD.Size = new System.Drawing.Size(137, 22);
            this.Txb_MachitietHD.TabIndex = 7;
            // 
            // Dgv_GKMaGK
            // 
            this.Dgv_GKMaGK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_GKMaGK.Location = new System.Drawing.Point(37, 262);
            this.Dgv_GKMaGK.Name = "Dgv_GKMaGK";
            this.Dgv_GKMaGK.RowHeadersWidth = 51;
            this.Dgv_GKMaGK.RowTemplate.Height = 24;
            this.Dgv_GKMaGK.Size = new System.Drawing.Size(356, 150);
            this.Dgv_GKMaGK.TabIndex = 8;
            this.Dgv_GKMaGK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_GKMaGK_CellContentClick);
            // 
            // Dgv_HDMaHD
            // 
            this.Dgv_HDMaHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_HDMaHD.Location = new System.Drawing.Point(37, 489);
            this.Dgv_HDMaHD.Name = "Dgv_HDMaHD";
            this.Dgv_HDMaHD.RowHeadersWidth = 51;
            this.Dgv_HDMaHD.RowTemplate.Height = 24;
            this.Dgv_HDMaHD.Size = new System.Drawing.Size(356, 150);
            this.Dgv_HDMaHD.TabIndex = 9;
            this.Dgv_HDMaHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_HDMaHD_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hội đồng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giám khảo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Chi tiết hội đồng ";
            // 
            // Btn_ThemChiTietHD
            // 
            this.Btn_ThemChiTietHD.Location = new System.Drawing.Point(824, 67);
            this.Btn_ThemChiTietHD.Name = "Btn_ThemChiTietHD";
            this.Btn_ThemChiTietHD.Size = new System.Drawing.Size(193, 78);
            this.Btn_ThemChiTietHD.TabIndex = 14;
            this.Btn_ThemChiTietHD.Text = "Thêm chi tiết hội đồng";
            this.Btn_ThemChiTietHD.UseVisualStyleBackColor = true;
            this.Btn_ThemChiTietHD.Click += new System.EventHandler(this.Btn_ThemChiTietHD_Click);
            // 
            // Dgv_Chitiethoidong
            // 
            this.Dgv_Chitiethoidong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Chitiethoidong.Location = new System.Drawing.Point(493, 262);
            this.Dgv_Chitiethoidong.Name = "Dgv_Chitiethoidong";
            this.Dgv_Chitiethoidong.RowHeadersWidth = 51;
            this.Dgv_Chitiethoidong.RowTemplate.Height = 24;
            this.Dgv_Chitiethoidong.Size = new System.Drawing.Size(546, 390);
            this.Dgv_Chitiethoidong.TabIndex = 15;
            this.Dgv_Chitiethoidong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Chitiethoidong_CellContentClick);
            // 
            // Frm_ThemChiTietHoiDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 682);
            this.Controls.Add(this.Dgv_Chitiethoidong);
            this.Controls.Add(this.Btn_ThemChiTietHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dgv_HDMaHD);
            this.Controls.Add(this.Dgv_GKMaGK);
            this.Controls.Add(this.Txb_MachitietHD);
            this.Controls.Add(this.Txb_MaGK);
            this.Controls.Add(this.Txb_Chucvu);
            this.Controls.Add(this.Txb_MaHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ThemChiTietHoiDong";
            this.Text = "Frm_ThemChiTietHoiDong";
            this.Load += new System.EventHandler(this.Frm_ThemChiTietHoiDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_GKMaGK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_HDMaHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Chitiethoidong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txb_MaHD;
        private System.Windows.Forms.TextBox Txb_Chucvu;
        private System.Windows.Forms.TextBox Txb_MaGK;
        private System.Windows.Forms.TextBox Txb_MachitietHD;
        private System.Windows.Forms.DataGridView Dgv_GKMaGK;
        private System.Windows.Forms.DataGridView Dgv_HDMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_ThemChiTietHD;
        private System.Windows.Forms.DataGridView Dgv_Chitiethoidong;
    }
}