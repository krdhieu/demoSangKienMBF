
namespace do_an_demo
{
    partial class Frm_SuaThongTinHD
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
            this.Btn_SuaThongTinHD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_Nhiemvu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dtp_Namthanhlap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_MaHD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgv_Hoidong = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Hoidong)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_SuaThongTinHD
            // 
            this.Btn_SuaThongTinHD.Location = new System.Drawing.Point(763, 586);
            this.Btn_SuaThongTinHD.Name = "Btn_SuaThongTinHD";
            this.Btn_SuaThongTinHD.Size = new System.Drawing.Size(117, 71);
            this.Btn_SuaThongTinHD.TabIndex = 18;
            this.Btn_SuaThongTinHD.Text = "Sửa thông tin hội đồng";
            this.Btn_SuaThongTinHD.UseVisualStyleBackColor = true;
            this.Btn_SuaThongTinHD.Click += new System.EventHandler(this.Btn_SuaThongTinHD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(763, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nhiệm vụ";
            // 
            // Txb_Nhiemvu
            // 
            this.Txb_Nhiemvu.Location = new System.Drawing.Point(763, 163);
            this.Txb_Nhiemvu.Multiline = true;
            this.Txb_Nhiemvu.Name = "Txb_Nhiemvu";
            this.Txb_Nhiemvu.Size = new System.Drawing.Size(303, 417);
            this.Txb_Nhiemvu.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(763, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Năm thành lập";
            // 
            // Dtp_Namthanhlap
            // 
            this.Dtp_Namthanhlap.Location = new System.Drawing.Point(763, 101);
            this.Dtp_Namthanhlap.Name = "Dtp_Namthanhlap";
            this.Dtp_Namthanhlap.Size = new System.Drawing.Size(200, 22);
            this.Dtp_Namthanhlap.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(763, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã hội đồng";
            // 
            // Txb_MaHD
            // 
            this.Txb_MaHD.Location = new System.Drawing.Point(763, 39);
            this.Txb_MaHD.Name = "Txb_MaHD";
            this.Txb_MaHD.ReadOnly = true;
            this.Txb_MaHD.Size = new System.Drawing.Size(200, 22);
            this.Txb_MaHD.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgv_Hoidong);
            this.groupBox1.Location = new System.Drawing.Point(20, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 639);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hội đồng khoa học";
            // 
            // Dgv_Hoidong
            // 
            this.Dgv_Hoidong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Hoidong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Hoidong.Location = new System.Drawing.Point(6, 21);
            this.Dgv_Hoidong.Name = "Dgv_Hoidong";
            this.Dgv_Hoidong.RowHeadersWidth = 51;
            this.Dgv_Hoidong.RowTemplate.Height = 24;
            this.Dgv_Hoidong.Size = new System.Drawing.Size(716, 612);
            this.Dgv_Hoidong.TabIndex = 0;
            this.Dgv_Hoidong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Hoidong_CellContentClick);
            // 
            // Frm_SuaThongTinHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 682);
            this.Controls.Add(this.Btn_SuaThongTinHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_Nhiemvu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dtp_Namthanhlap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_MaHD);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_SuaThongTinHD";
            this.Text = "Frm_SuaThongTinHD";
            this.Load += new System.EventHandler(this.Frm_SuaThongTinHD_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Hoidong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_SuaThongTinHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_Nhiemvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Dtp_Namthanhlap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_MaHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgv_Hoidong;
    }
}