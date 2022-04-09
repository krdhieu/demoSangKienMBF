
namespace do_an_demo
{
    partial class Frm_SuaThongTinGiamKhao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgv_GiamKhao = new System.Windows.Forms.DataGridView();
            this.Txb_Chucvu = new System.Windows.Forms.TextBox();
            this.Txb_TenGK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_MaGK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_SuaGK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_GiamKhao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgv_GiamKhao);
            this.groupBox1.Location = new System.Drawing.Point(12, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 449);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giám khảo";
            // 
            // Dgv_GiamKhao
            // 
            this.Dgv_GiamKhao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_GiamKhao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_GiamKhao.Location = new System.Drawing.Point(6, 40);
            this.Dgv_GiamKhao.Name = "Dgv_GiamKhao";
            this.Dgv_GiamKhao.RowHeadersWidth = 51;
            this.Dgv_GiamKhao.RowTemplate.Height = 24;
            this.Dgv_GiamKhao.Size = new System.Drawing.Size(1051, 403);
            this.Dgv_GiamKhao.TabIndex = 6;
            this.Dgv_GiamKhao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_GiamKhao_CellContentClick);
            // 
            // Txb_Chucvu
            // 
            this.Txb_Chucvu.Location = new System.Drawing.Point(18, 124);
            this.Txb_Chucvu.Multiline = true;
            this.Txb_Chucvu.Name = "Txb_Chucvu";
            this.Txb_Chucvu.Size = new System.Drawing.Size(759, 61);
            this.Txb_Chucvu.TabIndex = 18;
            // 
            // Txb_TenGK
            // 
            this.Txb_TenGK.Location = new System.Drawing.Point(417, 33);
            this.Txb_TenGK.Multiline = true;
            this.Txb_TenGK.Name = "Txb_TenGK";
            this.Txb_TenGK.Size = new System.Drawing.Size(360, 61);
            this.Txb_TenGK.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Chức vụ trong công ty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên giám khảo";
            // 
            // Txb_MaGK
            // 
            this.Txb_MaGK.Location = new System.Drawing.Point(18, 33);
            this.Txb_MaGK.Multiline = true;
            this.Txb_MaGK.Name = "Txb_MaGK";
            this.Txb_MaGK.ReadOnly = true;
            this.Txb_MaGK.Size = new System.Drawing.Size(360, 61);
            this.Txb_MaGK.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã giám khảo";
            // 
            // Btn_SuaGK
            // 
            this.Btn_SuaGK.Location = new System.Drawing.Point(814, 137);
            this.Btn_SuaGK.Name = "Btn_SuaGK";
            this.Btn_SuaGK.Size = new System.Drawing.Size(255, 48);
            this.Btn_SuaGK.TabIndex = 19;
            this.Btn_SuaGK.Text = "Sửa thông tin giám khảo";
            this.Btn_SuaGK.UseVisualStyleBackColor = true;
            this.Btn_SuaGK.Click += new System.EventHandler(this.Btn_SuaGK_Click);
            // 
            // Frm_SuaThongTinGiaKhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 682);
            this.Controls.Add(this.Btn_SuaGK);
            this.Controls.Add(this.Txb_Chucvu);
            this.Controls.Add(this.Txb_TenGK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_MaGK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_SuaThongTinGiaKhao";
            this.Text = "Frm_SuaThongTinGiaKhao";
            this.Load += new System.EventHandler(this.Frm_SuaThongTinGiaKhao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_GiamKhao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgv_GiamKhao;
        private System.Windows.Forms.TextBox Txb_Chucvu;
        private System.Windows.Forms.TextBox Txb_TenGK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_MaGK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_SuaGK;
    }
}