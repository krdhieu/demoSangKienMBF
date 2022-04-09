
namespace do_an_demo
{
    partial class Frm_ThemNguoiTG
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
            this.Dgv_TacgiaMaTG = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noname = new System.Windows.Forms.GroupBox();
            this.Dgv_SKMaSK = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Dgv_Nguoithamgia = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Cbx_Vaitro = new System.Windows.Forms.ComboBox();
            this.Btn_ThemNTG = new System.Windows.Forms.Button();
            this.Txb_Tiledonggop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txb_MaSK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txb_MaTG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_MaNTG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TacgiaMaTG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.noname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SKMaSK)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Nguoithamgia)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_TacgiaMaTG
            // 
            this.Dgv_TacgiaMaTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_TacgiaMaTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TacgiaMaTG.Location = new System.Drawing.Point(6, 21);
            this.Dgv_TacgiaMaTG.Name = "Dgv_TacgiaMaTG";
            this.Dgv_TacgiaMaTG.RowHeadersWidth = 51;
            this.Dgv_TacgiaMaTG.RowTemplate.Height = 24;
            this.Dgv_TacgiaMaTG.Size = new System.Drawing.Size(374, 180);
            this.Dgv_TacgiaMaTG.TabIndex = 0;
            this.Dgv_TacgiaMaTG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_TacgiaMaTG_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgv_TacgiaMaTG);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác giả";
            // 
            // noname
            // 
            this.noname.Controls.Add(this.Dgv_SKMaSK);
            this.noname.Location = new System.Drawing.Point(18, 424);
            this.noname.Name = "noname";
            this.noname.Size = new System.Drawing.Size(387, 252);
            this.noname.TabIndex = 2;
            this.noname.TabStop = false;
            this.noname.Text = "Sáng kiến";
            // 
            // Dgv_SKMaSK
            // 
            this.Dgv_SKMaSK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_SKMaSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_SKMaSK.Location = new System.Drawing.Point(6, 35);
            this.Dgv_SKMaSK.Name = "Dgv_SKMaSK";
            this.Dgv_SKMaSK.RowHeadersWidth = 51;
            this.Dgv_SKMaSK.RowTemplate.Height = 24;
            this.Dgv_SKMaSK.Size = new System.Drawing.Size(368, 199);
            this.Dgv_SKMaSK.TabIndex = 1;
            this.Dgv_SKMaSK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_SKMaSK_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Dgv_Nguoithamgia);
            this.groupBox3.Location = new System.Drawing.Point(414, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 469);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Người tham gia";
            // 
            // Dgv_Nguoithamgia
            // 
            this.Dgv_Nguoithamgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Nguoithamgia.Location = new System.Drawing.Point(6, 21);
            this.Dgv_Nguoithamgia.Name = "Dgv_Nguoithamgia";
            this.Dgv_Nguoithamgia.RowHeadersWidth = 51;
            this.Dgv_Nguoithamgia.RowTemplate.Height = 24;
            this.Dgv_Nguoithamgia.Size = new System.Drawing.Size(649, 442);
            this.Dgv_Nguoithamgia.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Cbx_Vaitro);
            this.groupBox4.Controls.Add(this.Txb_Tiledonggop);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Txb_MaSK);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Txb_MaTG);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.Txb_MaNTG);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(18, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(591, 188);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // Cbx_Vaitro
            // 
            this.Cbx_Vaitro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Vaitro.FormattingEnabled = true;
            this.Cbx_Vaitro.Location = new System.Drawing.Point(201, 120);
            this.Cbx_Vaitro.Name = "Cbx_Vaitro";
            this.Cbx_Vaitro.Size = new System.Drawing.Size(173, 24);
            this.Cbx_Vaitro.TabIndex = 11;
            // 
            // Btn_ThemNTG
            // 
            this.Btn_ThemNTG.Location = new System.Drawing.Point(629, 148);
            this.Btn_ThemNTG.Name = "Btn_ThemNTG";
            this.Btn_ThemNTG.Size = new System.Drawing.Size(173, 53);
            this.Btn_ThemNTG.TabIndex = 10;
            this.Btn_ThemNTG.Text = "Thêm người tham gia";
            this.Btn_ThemNTG.UseVisualStyleBackColor = true;
            this.Btn_ThemNTG.Click += new System.EventHandler(this.Btn_ThemNTG_Click);
            // 
            // Txb_Tiledonggop
            // 
            this.Txb_Tiledonggop.Location = new System.Drawing.Point(396, 55);
            this.Txb_Tiledonggop.Name = "Txb_Tiledonggop";
            this.Txb_Tiledonggop.Size = new System.Drawing.Size(173, 22);
            this.Txb_Tiledonggop.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tỉ lệ đóng góp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vai trò";
            // 
            // Txb_MaSK
            // 
            this.Txb_MaSK.Location = new System.Drawing.Point(201, 55);
            this.Txb_MaSK.Name = "Txb_MaSK";
            this.Txb_MaSK.ReadOnly = true;
            this.Txb_MaSK.Size = new System.Drawing.Size(173, 22);
            this.Txb_MaSK.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã sáng kiến";
            // 
            // Txb_MaTG
            // 
            this.Txb_MaTG.Location = new System.Drawing.Point(9, 120);
            this.Txb_MaTG.Multiline = true;
            this.Txb_MaTG.Name = "Txb_MaTG";
            this.Txb_MaTG.ReadOnly = true;
            this.Txb_MaTG.Size = new System.Drawing.Size(173, 24);
            this.Txb_MaTG.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã tác giả";
            // 
            // Txb_MaNTG
            // 
            this.Txb_MaNTG.Location = new System.Drawing.Point(6, 55);
            this.Txb_MaNTG.Name = "Txb_MaNTG";
            this.Txb_MaNTG.Size = new System.Drawing.Size(173, 22);
            this.Txb_MaNTG.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã người tham gia";
            // 
            // Frm_ThemNguoiTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 682);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Btn_ThemNTG);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.noname);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ThemNguoiTG";
            this.Text = "Frm_ThemNguoiTG";
            this.Load += new System.EventHandler(this.Frm_ThemNguoiTG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TacgiaMaTG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.noname.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SKMaSK)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Nguoithamgia)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_TacgiaMaTG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox noname;
        private System.Windows.Forms.DataGridView Dgv_SKMaSK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Dgv_Nguoithamgia;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_ThemNTG;
        private System.Windows.Forms.TextBox Txb_Tiledonggop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txb_MaSK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txb_MaTG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_MaNTG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbx_Vaitro;
    }
}