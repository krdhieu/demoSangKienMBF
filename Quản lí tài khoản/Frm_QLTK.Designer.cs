namespace do_an_demo
{
    partial class Frm_QLTK
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tengk = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.cm_mtg = new System.Windows.Forms.ComboBox();
            this.giamKhaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sangKienMBFDataSet = new do_an_demo.SangKienMBFDataSet();
            this.txt_ttk = new System.Windows.Forms.TextBox();
            this.giamKhaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sangKienMBFDataSet1 = new do_an_demo.SangKienMBFDataSet1();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_gk = new System.Windows.Forms.DataGridView();
            this.dgv_tk = new System.Windows.Forms.DataGridView();
            this.giamKhaoTableAdapter = new do_an_demo.SangKienMBFDataSetTableAdapters.GiamKhaoTableAdapter();
            this.giamKhaoTableAdapter1 = new do_an_demo.SangKienMBFDataSet1TableAdapters.GiamKhaoTableAdapter();
            this.tacgiaDataSet3 = new do_an_demo.TacgiaDataSet3();
            this.tacgiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacgiaTableAdapter = new do_an_demo.TacgiaDataSet3TableAdapters.TacgiaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giamKhaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangKienMBFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamKhaoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangKienMBFDataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacgiaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacgiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_tengk);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmk);
            this.panel1.Controls.Add(this.cm_mtg);
            this.panel1.Controls.Add(this.txt_ttk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 186);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tên giám khảo";
            // 
            // txt_tengk
            // 
            this.txt_tengk.Enabled = false;
            this.txt_tengk.Location = new System.Drawing.Point(589, 96);
            this.txt_tengk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tengk.Name = "txt_tengk";
            this.txt_tengk.Size = new System.Drawing.Size(227, 22);
            this.txt_tengk.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(957, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã tác giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(189, 92);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(224, 22);
            this.txtmk.TabIndex = 8;
            // 
            // cm_mtg
            // 
            this.cm_mtg.DataSource = this.tacgiaBindingSource;
            this.cm_mtg.DisplayMember = "Matacgia";
            this.cm_mtg.FormattingEnabled = true;
            this.cm_mtg.Location = new System.Drawing.Point(589, 44);
            this.cm_mtg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cm_mtg.Name = "cm_mtg";
            this.cm_mtg.Size = new System.Drawing.Size(227, 24);
            this.cm_mtg.TabIndex = 7;
            this.cm_mtg.ValueMember = "Matacgia";
            // 
            // giamKhaoBindingSource
            // 
            this.giamKhaoBindingSource.DataMember = "GiamKhao";
            this.giamKhaoBindingSource.DataSource = this.sangKienMBFDataSet;
            // 
            // sangKienMBFDataSet
            // 
            this.sangKienMBFDataSet.DataSetName = "SangKienMBFDataSet";
            this.sangKienMBFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_ttk
            // 
            this.txt_ttk.Location = new System.Drawing.Point(189, 46);
            this.txt_ttk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ttk.Name = "txt_ttk";
            this.txt_ttk.Size = new System.Drawing.Size(224, 22);
            this.txt_ttk.TabIndex = 6;
            // 
            // giamKhaoBindingSource1
            // 
            this.giamKhaoBindingSource1.DataMember = "GiamKhao";
            this.giamKhaoBindingSource1.DataSource = this.sangKienMBFDataSet1;
            // 
            // sangKienMBFDataSet1
            // 
            this.sangKienMBFDataSet1.DataSetName = "SangKienMBFDataSet1";
            this.sangKienMBFDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_gk, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_tk, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 186);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1232, 572);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // dgv_gk
            // 
            this.dgv_gk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_gk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_gk.Location = new System.Drawing.Point(620, 4);
            this.dgv_gk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_gk.Name = "dgv_gk";
            this.dgv_gk.RowHeadersWidth = 51;
            this.dgv_gk.Size = new System.Drawing.Size(608, 564);
            this.dgv_gk.TabIndex = 1;
            // 
            // dgv_tk
            // 
            this.dgv_tk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tk.Location = new System.Drawing.Point(4, 4);
            this.dgv_tk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_tk.Name = "dgv_tk";
            this.dgv_tk.RowHeadersWidth = 51;
            this.dgv_tk.Size = new System.Drawing.Size(608, 564);
            this.dgv_tk.TabIndex = 0;
            this.dgv_tk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tk_CellContentClick);
            // 
            // giamKhaoTableAdapter
            // 
            this.giamKhaoTableAdapter.ClearBeforeFill = true;
            // 
            // giamKhaoTableAdapter1
            // 
            this.giamKhaoTableAdapter1.ClearBeforeFill = true;
            // 
            // tacgiaDataSet3
            // 
            this.tacgiaDataSet3.DataSetName = "TacgiaDataSet3";
            this.tacgiaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tacgiaBindingSource
            // 
            this.tacgiaBindingSource.DataMember = "Tacgia";
            this.tacgiaBindingSource.DataSource = this.tacgiaDataSet3;
            // 
            // tacgiaTableAdapter
            // 
            this.tacgiaTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_QLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 758);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_QLTK";
            this.Text = "Frm_QLTK";
            this.Load += new System.EventHandler(this.Frm_QLTK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giamKhaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangKienMBFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamKhaoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangKienMBFDataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacgiaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacgiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.ComboBox cm_mtg;
        private System.Windows.Forms.TextBox txt_ttk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_gk;
        private System.Windows.Forms.DataGridView dgv_tk;
        private SangKienMBFDataSet sangKienMBFDataSet;
        private System.Windows.Forms.BindingSource giamKhaoBindingSource;
        private SangKienMBFDataSetTableAdapters.GiamKhaoTableAdapter giamKhaoTableAdapter;
        private SangKienMBFDataSet1 sangKienMBFDataSet1;
        private System.Windows.Forms.BindingSource giamKhaoBindingSource1;
        private SangKienMBFDataSet1TableAdapters.GiamKhaoTableAdapter giamKhaoTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tengk;
        private TacgiaDataSet3 tacgiaDataSet3;
        private System.Windows.Forms.BindingSource tacgiaBindingSource;
        private TacgiaDataSet3TableAdapters.TacgiaTableAdapter tacgiaTableAdapter;
    }
}