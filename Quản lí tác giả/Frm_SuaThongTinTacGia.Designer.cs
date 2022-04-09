
namespace do_an_demo
{
    partial class Frm_SuaThongTinTacGia
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
            this.Btn_ThemTG = new System.Windows.Forms.Button();
            this.Cbx_GioiTinh = new System.Windows.Forms.ComboBox();
            this.Dtp_NamSinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Txb_SDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txb_ChucVu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txb_TrinhDo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txb_DiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txb_TenTG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_MaTacGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgv_TacGia = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_ThemTG
            // 
            this.Btn_ThemTG.Location = new System.Drawing.Point(814, 198);
            this.Btn_ThemTG.Name = "Btn_ThemTG";
            this.Btn_ThemTG.Size = new System.Drawing.Size(255, 48);
            this.Btn_ThemTG.TabIndex = 47;
            this.Btn_ThemTG.Text = "Sửa thông tin tác giả";
            this.Btn_ThemTG.UseVisualStyleBackColor = true;
            this.Btn_ThemTG.Click += new System.EventHandler(this.Btn_ThemTG_Click);
            // 
            // Cbx_GioiTinh
            // 
            this.Cbx_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_GioiTinh.FormattingEnabled = true;
            this.Cbx_GioiTinh.Location = new System.Drawing.Point(246, 40);
            this.Cbx_GioiTinh.Name = "Cbx_GioiTinh";
            this.Cbx_GioiTinh.Size = new System.Drawing.Size(121, 24);
            this.Cbx_GioiTinh.TabIndex = 46;
            // 
            // Dtp_NamSinh
            // 
            this.Dtp_NamSinh.Location = new System.Drawing.Point(246, 107);
            this.Dtp_NamSinh.Name = "Dtp_NamSinh";
            this.Dtp_NamSinh.Size = new System.Drawing.Size(200, 22);
            this.Dtp_NamSinh.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(751, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Địa chỉ";
            // 
            // Txb_SDT
            // 
            this.Txb_SDT.Location = new System.Drawing.Point(754, 44);
            this.Txb_SDT.MaxLength = 10;
            this.Txb_SDT.Name = "Txb_SDT";
            this.Txb_SDT.Size = new System.Drawing.Size(161, 22);
            this.Txb_SDT.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(751, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Số điện thoại";
            // 
            // Txb_ChucVu
            // 
            this.Txb_ChucVu.Location = new System.Drawing.Point(523, 107);
            this.Txb_ChucVu.Multiline = true;
            this.Txb_ChucVu.Name = "Txb_ChucVu";
            this.Txb_ChucVu.Size = new System.Drawing.Size(196, 22);
            this.Txb_ChucVu.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Chức vụ";
            // 
            // Txb_TrinhDo
            // 
            this.Txb_TrinhDo.Location = new System.Drawing.Point(523, 44);
            this.Txb_TrinhDo.Name = "Txb_TrinhDo";
            this.Txb_TrinhDo.Size = new System.Drawing.Size(161, 22);
            this.Txb_TrinhDo.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Trình độ chuyên môn";
            // 
            // Txb_DiaChi
            // 
            this.Txb_DiaChi.Location = new System.Drawing.Point(754, 107);
            this.Txb_DiaChi.Multiline = true;
            this.Txb_DiaChi.Name = "Txb_DiaChi";
            this.Txb_DiaChi.Size = new System.Drawing.Size(315, 68);
            this.Txb_DiaChi.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Năm sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Giới tính";
            // 
            // Txb_TenTG
            // 
            this.Txb_TenTG.Location = new System.Drawing.Point(18, 107);
            this.Txb_TenTG.Name = "Txb_TenTG";
            this.Txb_TenTG.Size = new System.Drawing.Size(161, 22);
            this.Txb_TenTG.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Họ và tên";
            // 
            // Txb_MaTacGia
            // 
            this.Txb_MaTacGia.Location = new System.Drawing.Point(18, 44);
            this.Txb_MaTacGia.Name = "Txb_MaTacGia";
            this.Txb_MaTacGia.ReadOnly = true;
            this.Txb_MaTacGia.Size = new System.Drawing.Size(161, 22);
            this.Txb_MaTacGia.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã tác giả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgv_TacGia);
            this.groupBox1.Location = new System.Drawing.Point(12, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 421);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tác giả";
            // 
            // Dgv_TacGia
            // 
            this.Dgv_TacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_TacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TacGia.Location = new System.Drawing.Point(6, 30);
            this.Dgv_TacGia.Name = "Dgv_TacGia";
            this.Dgv_TacGia.RowHeadersWidth = 51;
            this.Dgv_TacGia.RowTemplate.Height = 24;
            this.Dgv_TacGia.Size = new System.Drawing.Size(1051, 385);
            this.Dgv_TacGia.TabIndex = 6;
            this.Dgv_TacGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_TacGia_CellContentClick);
            // 
            // Frm_SuaThongTinTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 682);
            this.Controls.Add(this.Btn_ThemTG);
            this.Controls.Add(this.Cbx_GioiTinh);
            this.Controls.Add(this.Dtp_NamSinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txb_SDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txb_ChucVu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txb_TrinhDo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txb_DiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txb_TenTG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_MaTacGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SuaThongTinTacGia";
            this.Text = "Frm_SuaThongTinTacGia";
            this.Load += new System.EventHandler(this.Frm_SuaThongTinTacGia_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ThemTG;
        private System.Windows.Forms.ComboBox Cbx_GioiTinh;
        private System.Windows.Forms.DateTimePicker Dtp_NamSinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txb_SDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txb_ChucVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txb_TrinhDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txb_DiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txb_TenTG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_MaTacGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgv_TacGia;
    }
}