
using System.Windows.Forms;

namespace do_an_demo
{
    partial class Frm_MainAD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainAD));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_qlsk = new System.Windows.Forms.Button();
            this.btn_qltk = new System.Windows.Forms.Button();
            this.btn_hdkh = new System.Windows.Forms.Button();
            this.btn_qlgk = new System.Windows.Forms.Button();
            this.btn_ctcd = new System.Windows.Forms.Button();
            this.btn_qltg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_chucvu = new System.Windows.Forms.Label();
            this.lb_logout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1469700344_mbf-quychuanlogo-160219-03.png");
            this.imageList1.Images.SetKeyName(1, "1469700344_mbf-quychuanlogo-160219-03.png");
            this.imageList1.Images.SetKeyName(2, "1469700344_mbf-quychuanlogo-160219-03.png");
            // 
            // btn_qlsk
            // 
            this.btn_qlsk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_qlsk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_qlsk.ForeColor = System.Drawing.Color.Blue;
            this.btn_qlsk.Location = new System.Drawing.Point(432, 121);
            this.btn_qlsk.Name = "btn_qlsk";
            this.btn_qlsk.Size = new System.Drawing.Size(141, 110);
            this.btn_qlsk.TabIndex = 1;
            this.btn_qlsk.Text = "Quản lí sáng kiến";
            this.btn_qlsk.UseVisualStyleBackColor = false;
            this.btn_qlsk.Click += new System.EventHandler(this.btn_qlsk_Click);
            // 
            // btn_qltk
            // 
            this.btn_qltk.BackColor = System.Drawing.Color.White;
            this.btn_qltk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_qltk.ForeColor = System.Drawing.Color.Blue;
            this.btn_qltk.Location = new System.Drawing.Point(268, 121);
            this.btn_qltk.Name = "btn_qltk";
            this.btn_qltk.Size = new System.Drawing.Size(135, 110);
            this.btn_qltk.TabIndex = 0;
            this.btn_qltk.Text = "Quản lí tài khoản";
            this.btn_qltk.UseVisualStyleBackColor = false;
            this.btn_qltk.Click += new System.EventHandler(this.btn_qltk_Click);
            // 
            // btn_hdkh
            // 
            this.btn_hdkh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hdkh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_hdkh.ForeColor = System.Drawing.Color.Blue;
            this.btn_hdkh.Location = new System.Drawing.Point(268, 252);
            this.btn_hdkh.Name = "btn_hdkh";
            this.btn_hdkh.Size = new System.Drawing.Size(135, 105);
            this.btn_hdkh.TabIndex = 3;
            this.btn_hdkh.Text = "Quản lí hội đồng khoa học";
            this.btn_hdkh.UseVisualStyleBackColor = false;
            this.btn_hdkh.Click += new System.EventHandler(this.btn_hdkh_Click);
            // 
            // btn_qlgk
            // 
            this.btn_qlgk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_qlgk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_qlgk.ForeColor = System.Drawing.Color.Blue;
            this.btn_qlgk.Location = new System.Drawing.Point(597, 121);
            this.btn_qlgk.Name = "btn_qlgk";
            this.btn_qlgk.Size = new System.Drawing.Size(139, 110);
            this.btn_qlgk.TabIndex = 2;
            this.btn_qlgk.Text = "Quản lí giám khảo";
            this.btn_qlgk.UseVisualStyleBackColor = false;
            this.btn_qlgk.Click += new System.EventHandler(this.btn_qlgk_Click);
            // 
            // btn_ctcd
            // 
            this.btn_ctcd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ctcd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_ctcd.ForeColor = System.Drawing.Color.Blue;
            this.btn_ctcd.Location = new System.Drawing.Point(597, 252);
            this.btn_ctcd.Name = "btn_ctcd";
            this.btn_ctcd.Size = new System.Drawing.Size(139, 105);
            this.btn_ctcd.TabIndex = 5;
            this.btn_ctcd.Text = "Chi tiết chấm điểm";
            this.btn_ctcd.UseVisualStyleBackColor = false;
            this.btn_ctcd.Click += new System.EventHandler(this.btn_ctcd_Click);
            // 
            // btn_qltg
            // 
            this.btn_qltg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_qltg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_qltg.ForeColor = System.Drawing.Color.Blue;
            this.btn_qltg.Location = new System.Drawing.Point(432, 252);
            this.btn_qltg.Name = "btn_qltg";
            this.btn_qltg.Size = new System.Drawing.Size(141, 105);
            this.btn_qltg.TabIndex = 4;
            this.btn_qltg.Text = "Quản lí tác giả";
            this.btn_qltg.UseVisualStyleBackColor = false;
            this.btn_qltg.Click += new System.EventHandler(this.btn_qltg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 97);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic);
            this.lb_name.Location = new System.Drawing.Point(21, 140);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(58, 21);
            this.lb_name.TabIndex = 7;
            this.lb_name.Text = "label1";
            // 
            // lb_chucvu
            // 
            this.lb_chucvu.AutoSize = true;
            this.lb_chucvu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lb_chucvu.Location = new System.Drawing.Point(81, 200);
            this.lb_chucvu.Name = "lb_chucvu";
            this.lb_chucvu.Size = new System.Drawing.Size(59, 22);
            this.lb_chucvu.TabIndex = 8;
            this.lb_chucvu.Text = "label2";
            // 
            // lb_logout
            // 
            this.lb_logout.AutoSize = true;
            this.lb_logout.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_logout.Location = new System.Drawing.Point(21, 316);
            this.lb_logout.Name = "lb_logout";
            this.lb_logout.Size = new System.Drawing.Size(60, 22);
            this.lb_logout.TabIndex = 6;
            this.lb_logout.Text = "label3";
            this.lb_logout.Click += new System.EventHandler(this.lb_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chức vụ:";
            // 
            // Frm_MainAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(747, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_logout);
            this.Controls.Add(this.lb_chucvu);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_qltg);
            this.Controls.Add(this.btn_ctcd);
            this.Controls.Add(this.btn_qlgk);
            this.Controls.Add(this.btn_hdkh);
            this.Controls.Add(this.btn_qltk);
            this.Controls.Add(this.btn_qlsk);
            this.Name = "Frm_MainAD";
            this.Load += new System.EventHandler(this.Frm_MainAD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImageList imageList1;
        private Button btn_qlsk;
        private Button btn_qltk;
        private Button btn_hdkh;
        private Button btn_qlgk;
        private Button btn_ctcd;
        private Button btn_qltg;
        private PictureBox pictureBox1;
        private Label lb_name;
        private Label lb_chucvu;
        private Label lb_logout;
        private Label label1;
    }
}