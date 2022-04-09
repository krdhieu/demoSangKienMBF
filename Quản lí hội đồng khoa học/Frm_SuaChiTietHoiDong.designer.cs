
namespace do_an_demo
{
    partial class Frm_SuaChiTietHoiDong
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
            this.Dgv_Chitiethoidong = new System.Windows.Forms.DataGridView();
            this.Btn_SuaChiTietHD = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dgv_HDMaHD = new System.Windows.Forms.DataGridView();
            this.Dgv_GKMaGK = new System.Windows.Forms.DataGridView();
            this.Txb_MachitietHD = new System.Windows.Forms.TextBox();
            this.Txb_MaGK = new System.Windows.Forms.TextBox();
            this.Txb_Chucvu = new System.Windows.Forms.TextBox();
            this.Txb_MaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Chitiethoidong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_HDMaHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_GKMaGK)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Chitiethoidong
            // 
            this.Dgv_Chitiethoidong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Chitiethoidong.Location = new System.Drawing.Point(500, 254);
            this.Dgv_Chitiethoidong.Name = "Dgv_Chitiethoidong";
            this.Dgv_Chitiethoidong.RowHeadersWidth = 51;
            this.Dgv_Chitiethoidong.RowTemplate.Height = 24;
            this.Dgv_Chitiethoidong.Size = new System.Drawing.Size(546, 390);
            this.Dgv_Chitiethoidong.TabIndex = 30;
            this.Dgv_Chitiethoidong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Chitiethoidong_CellContentClick);
            // 
            // Btn_SuaChiTietHD
            // 
            this.Btn_SuaChiTietHD.Location = new System.Drawing.Point(882, 110);
            this.Btn_SuaChiTietHD.Name = "Btn_SuaChiTietHD";
            this.Btn_SuaChiTietHD.Size = new System.Drawing.Size(164, 59);
            this.Btn_SuaChiTietHD.TabIndex = 29;
            this.Btn_SuaChiTietHD.Text = "Sửa chi tiết hội đồng";
            this.Btn_SuaChiTietHD.UseVisualStyleBackColor = true;
            this.Btn_SuaChiTietHD.Click += new System.EventHandler(this.Btn_SuaChiTietHD_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Chi tiết hội đồng ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Giám khảo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Hội đồng";
            // 
            // Dgv_HDMaHD
            // 
            this.Dgv_HDMaHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_HDMaHD.Location = new System.Drawing.Point(44, 481);
            this.Dgv_HDMaHD.Name = "Dgv_HDMaHD";
            this.Dgv_HDMaHD.RowHeadersWidth = 51;
            this.Dgv_HDMaHD.RowTemplate.Height = 24;
            this.Dgv_HDMaHD.Size = new System.Drawing.Size(356, 150);
            this.Dgv_HDMaHD.TabIndex = 25;
            this.Dgv_HDMaHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_HDMaHD_CellContentClick);
            // 
            // Dgv_GKMaGK
            // 
            this.Dgv_GKMaGK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_GKMaGK.Location = new System.Drawing.Point(44, 254);
            this.Dgv_GKMaGK.Name = "Dgv_GKMaGK";
            this.Dgv_GKMaGK.RowHeadersWidth = 51;
            this.Dgv_GKMaGK.RowTemplate.Height = 24;
            this.Dgv_GKMaGK.Size = new System.Drawing.Size(356, 150);
            this.Dgv_GKMaGK.TabIndex = 24;
            this.Dgv_GKMaGK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_GKMaGK_CellContentClick);
            // 
            // Txb_MachitietHD
            // 
            this.Txb_MachitietHD.Location = new System.Drawing.Point(63, 59);
            this.Txb_MachitietHD.Name = "Txb_MachitietHD";
            this.Txb_MachitietHD.Size = new System.Drawing.Size(137, 22);
            this.Txb_MachitietHD.TabIndex = 23;
            // 
            // Txb_MaGK
            // 
            this.Txb_MaGK.Location = new System.Drawing.Point(252, 59);
            this.Txb_MaGK.Name = "Txb_MaGK";
            this.Txb_MaGK.ReadOnly = true;
            this.Txb_MaGK.Size = new System.Drawing.Size(152, 22);
            this.Txb_MaGK.TabIndex = 22;
            // 
            // Txb_Chucvu
            // 
            this.Txb_Chucvu.Location = new System.Drawing.Point(252, 142);
            this.Txb_Chucvu.Name = "Txb_Chucvu";
            this.Txb_Chucvu.Size = new System.Drawing.Size(152, 22);
            this.Txb_Chucvu.TabIndex = 21;
            // 
            // Txb_MaHD
            // 
            this.Txb_MaHD.Location = new System.Drawing.Point(63, 142);
            this.Txb_MaHD.Name = "Txb_MaHD";
            this.Txb_MaHD.ReadOnly = true;
            this.Txb_MaHD.Size = new System.Drawing.Size(137, 22);
            this.Txb_MaHD.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Chức vụ trong hội đồng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã giám khảo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã hội đồng ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã chi tiết hội đồng";
            // 
            // Frm_SuaChiTietHoiDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 682);
            this.Controls.Add(this.Dgv_Chitiethoidong);
            this.Controls.Add(this.Btn_SuaChiTietHD);
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
            this.Name = "Frm_SuaChiTietHoiDong";
            this.Text = "Frm_SuaChiTietHoiDong";
            this.Load += new System.EventHandler(this.Frm_SuaChiTietHoiDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Chitiethoidong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_HDMaHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_GKMaGK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Chitiethoidong;
        private System.Windows.Forms.Button Btn_SuaChiTietHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Dgv_HDMaHD;
        private System.Windows.Forms.DataGridView Dgv_GKMaGK;
        private System.Windows.Forms.TextBox Txb_MachitietHD;
        private System.Windows.Forms.TextBox Txb_MaGK;
        private System.Windows.Forms.TextBox Txb_Chucvu;
        private System.Windows.Forms.TextBox Txb_MaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}