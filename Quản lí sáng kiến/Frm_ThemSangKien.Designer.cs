
namespace do_an_demo
{
    partial class Frm_ThemSangKien
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
            this.Txb_MaSK = new System.Windows.Forms.TextBox();
            this.Txb_TenSK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txb_Dotsangkien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Dtp_Thoidiemapdung = new System.Windows.Forms.DateTimePicker();
            this.Txb_Diadiemapdung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txb_MotaSK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_ThemSK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgv_SangKien = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SangKien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sáng kiến";
            // 
            // Txb_MaSK
            // 
            this.Txb_MaSK.Location = new System.Drawing.Point(22, 41);
            this.Txb_MaSK.Name = "Txb_MaSK";
            this.Txb_MaSK.Size = new System.Drawing.Size(146, 22);
            this.Txb_MaSK.TabIndex = 1;
            // 
            // Txb_TenSK
            // 
            this.Txb_TenSK.Location = new System.Drawing.Point(22, 122);
            this.Txb_TenSK.Name = "Txb_TenSK";
            this.Txb_TenSK.Size = new System.Drawing.Size(146, 22);
            this.Txb_TenSK.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sáng kiến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời điểm áp dụng";
            // 
            // Txb_Dotsangkien
            // 
            this.Txb_Dotsangkien.Location = new System.Drawing.Point(205, 41);
            this.Txb_Dotsangkien.Name = "Txb_Dotsangkien";
            this.Txb_Dotsangkien.Size = new System.Drawing.Size(146, 22);
            this.Txb_Dotsangkien.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đợt sáng kiến";
            // 
            // Dtp_Thoidiemapdung
            // 
            this.Dtp_Thoidiemapdung.Location = new System.Drawing.Point(205, 122);
            this.Dtp_Thoidiemapdung.Name = "Dtp_Thoidiemapdung";
            this.Dtp_Thoidiemapdung.Size = new System.Drawing.Size(200, 22);
            this.Dtp_Thoidiemapdung.TabIndex = 8;
            // 
            // Txb_Diadiemapdung
            // 
            this.Txb_Diadiemapdung.Location = new System.Drawing.Point(912, 41);
            this.Txb_Diadiemapdung.Multiline = true;
            this.Txb_Diadiemapdung.Name = "Txb_Diadiemapdung";
            this.Txb_Diadiemapdung.Size = new System.Drawing.Size(163, 103);
            this.Txb_Diadiemapdung.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(909, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa điểm áp dụng";
            // 
            // Txb_MotaSK
            // 
            this.Txb_MotaSK.Location = new System.Drawing.Point(422, 41);
            this.Txb_MotaSK.Multiline = true;
            this.Txb_MotaSK.Name = "Txb_MotaSK";
            this.Txb_MotaSK.Size = new System.Drawing.Size(467, 103);
            this.Txb_MotaSK.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mô tả sáng kiến";
            // 
            // Btn_ThemSK
            // 
            this.Btn_ThemSK.Location = new System.Drawing.Point(912, 150);
            this.Btn_ThemSK.Name = "Btn_ThemSK";
            this.Btn_ThemSK.Size = new System.Drawing.Size(163, 49);
            this.Btn_ThemSK.TabIndex = 48;
            this.Btn_ThemSK.Text = "Thêm sáng kiến";
            this.Btn_ThemSK.UseVisualStyleBackColor = true;
            this.Btn_ThemSK.Click += new System.EventHandler(this.Btn_ThemSK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgv_SangKien);
            this.groupBox1.Location = new System.Drawing.Point(12, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 453);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sáng kiến";
            // 
            // Dgv_SangKien
            // 
            this.Dgv_SangKien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_SangKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_SangKien.Location = new System.Drawing.Point(6, 30);
            this.Dgv_SangKien.Name = "Dgv_SangKien";
            this.Dgv_SangKien.RowHeadersWidth = 51;
            this.Dgv_SangKien.RowTemplate.Height = 24;
            this.Dgv_SangKien.Size = new System.Drawing.Size(1051, 417);
            this.Dgv_SangKien.TabIndex = 6;
            // 
            // Frm_ThemSangKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 682);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_ThemSK);
            this.Controls.Add(this.Txb_MotaSK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txb_Diadiemapdung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dtp_Thoidiemapdung);
            this.Controls.Add(this.Txb_Dotsangkien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txb_TenSK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_MaSK);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ThemSangKien";
            this.Text = "Frm_ThemSangKien";
            this.Load += new System.EventHandler(this.Frm_ThemSangKien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SangKien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_MaSK;
        private System.Windows.Forms.TextBox Txb_TenSK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txb_Dotsangkien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Dtp_Thoidiemapdung;
        private System.Windows.Forms.TextBox Txb_Diadiemapdung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txb_MotaSK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_ThemSK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgv_SangKien;
    }
}