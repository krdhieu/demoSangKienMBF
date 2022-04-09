namespace do_an_demo
{
    partial class Frm_Chamdiem
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hoidongkhoahocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sangKienMBFDataSet2 = new do_an_demo.SangKienMBFDataSet2();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_machamdiem = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.txt_dpptb = new System.Windows.Forms.NumericUpDown();
            this.txt_dtt = new System.Windows.Forms.NumericUpDown();
            this.txt_dnd = new System.Windows.Forms.NumericUpDown();
            this.txt_dmd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_sk = new System.Windows.Forms.TextBox();
            this.txt_cv = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_diem = new System.Windows.Forms.DataGridView();
            this.dgv_Sk = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.hoidongkhoahocTableAdapter = new do_an_demo.SangKienMBFDataSet2TableAdapters.HoidongkhoahocTableAdapter();
            this.mahoidongDataSet3 = new do_an_demo.MahoidongDataSet3();
            this.hoidongkhoahocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hoidongkhoahocTableAdapter1 = new do_an_demo.MahoidongDataSet3TableAdapters.HoidongkhoahocTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoidongkhoahocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangKienMBFDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dpptb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dmd)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahoidongDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoidongkhoahocBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1504, 246);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(852, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(652, 246);
            this.panel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_machamdiem);
            this.groupBox2.Controls.Add(this.btn_luu);
            this.groupBox2.Controls.Add(this.txt_dpptb);
            this.groupBox2.Controls.Add(this.txt_dtt);
            this.groupBox2.Controls.Add(this.txt_dnd);
            this.groupBox2.Controls.Add(this.txt_dmd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(652, 246);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điểm cho sáng kiến";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mã hội đồng";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.hoidongkhoahocBindingSource1;
            this.comboBox1.DisplayMember = "Mahoidong";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(515, 78);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "Mahoidong";
            // 
            // hoidongkhoahocBindingSource
            // 
            this.hoidongkhoahocBindingSource.DataMember = "Hoidongkhoahoc";
            this.hoidongkhoahocBindingSource.DataSource = this.sangKienMBFDataSet2;
            // 
            // sangKienMBFDataSet2
            // 
            this.sangKienMBFDataSet2.DataSetName = "SangKienMBFDataSet2";
            this.sangKienMBFDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mã phiếu điểm";
            // 
            // txt_machamdiem
            // 
            this.txt_machamdiem.Location = new System.Drawing.Point(515, 33);
            this.txt_machamdiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_machamdiem.Name = "txt_machamdiem";
            this.txt_machamdiem.Size = new System.Drawing.Size(132, 22);
            this.txt_machamdiem.TabIndex = 12;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(443, 160);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(201, 44);
            this.btn_luu.TabIndex = 11;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_dpptb
            // 
            this.txt_dpptb.Location = new System.Drawing.Point(228, 177);
            this.txt_dpptb.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dpptb.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_dpptb.Name = "txt_dpptb";
            this.txt_dpptb.Size = new System.Drawing.Size(160, 22);
            this.txt_dpptb.TabIndex = 10;
            // 
            // txt_dtt
            // 
            this.txt_dtt.Location = new System.Drawing.Point(228, 124);
            this.txt_dtt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dtt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_dtt.Name = "txt_dtt";
            this.txt_dtt.Size = new System.Drawing.Size(160, 22);
            this.txt_dtt.TabIndex = 9;
            // 
            // txt_dnd
            // 
            this.txt_dnd.Location = new System.Drawing.Point(228, 80);
            this.txt_dnd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dnd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_dnd.Name = "txt_dnd";
            this.txt_dnd.Size = new System.Drawing.Size(160, 22);
            this.txt_dnd.TabIndex = 8;
            // 
            // txt_dmd
            // 
            this.txt_dmd.Location = new System.Drawing.Point(228, 34);
            this.txt_dmd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dmd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_dmd.Name = "txt_dmd";
            this.txt_dmd.Size = new System.Drawing.Size(160, 22);
            this.txt_dmd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm mục đích";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm nội dung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ứng dụng thực tiễn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phương pháp trình bày";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 246);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_sk);
            this.groupBox1.Controls.Add(this.txt_cv);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(840, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sáng kiến";
            // 
            // txt_sk
            // 
            this.txt_sk.Location = new System.Drawing.Point(131, 171);
            this.txt_sk.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sk.Name = "txt_sk";
            this.txt_sk.Size = new System.Drawing.Size(480, 22);
            this.txt_sk.TabIndex = 5;
            // 
            // txt_cv
            // 
            this.txt_cv.Location = new System.Drawing.Point(131, 108);
            this.txt_cv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cv.Name = "txt_cv";
            this.txt_cv.Size = new System.Drawing.Size(480, 22);
            this.txt_cv.TabIndex = 4;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(131, 41);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(480, 22);
            this.txt_ten.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sáng kiến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.4069F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.5931F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_diem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Sk, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 246);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1504, 443);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgv_diem
            // 
            this.dgv_diem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_diem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_diem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_diem.Location = new System.Drawing.Point(656, 4);
            this.dgv_diem.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_diem.Name = "dgv_diem";
            this.dgv_diem.RowHeadersWidth = 51;
            this.dgv_diem.Size = new System.Drawing.Size(844, 435);
            this.dgv_diem.TabIndex = 0;
            this.dgv_diem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_diem_CellClick);
            // 
            // dgv_Sk
            // 
            this.dgv_Sk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Sk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Sk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Sk.Location = new System.Drawing.Point(4, 4);
            this.dgv_Sk.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Sk.Name = "dgv_Sk";
            this.dgv_Sk.RowHeadersWidth = 51;
            this.dgv_Sk.Size = new System.Drawing.Size(644, 435);
            this.dgv_Sk.TabIndex = 1;
            this.dgv_Sk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sk_CellClick);
            // 
            // hoidongkhoahocTableAdapter
            // 
            this.hoidongkhoahocTableAdapter.ClearBeforeFill = true;
            // 
            // mahoidongDataSet3
            // 
            this.mahoidongDataSet3.DataSetName = "MahoidongDataSet3";
            this.mahoidongDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoidongkhoahocBindingSource1
            // 
            this.hoidongkhoahocBindingSource1.DataMember = "Hoidongkhoahoc";
            this.hoidongkhoahocBindingSource1.DataSource = this.mahoidongDataSet3;
            // 
            // hoidongkhoahocTableAdapter1
            // 
            this.hoidongkhoahocTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_Chamdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 689);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Chamdiem";
            this.Text = "Frm_Chamdiem";
            this.Load += new System.EventHandler(this.Frm_Chamdiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoidongkhoahocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangKienMBFDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dpptb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dmd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahoidongDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoidongkhoahocBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.NumericUpDown txt_dpptb;
        private System.Windows.Forms.NumericUpDown txt_dtt;
        private System.Windows.Forms.NumericUpDown txt_dnd;
        private System.Windows.Forms.NumericUpDown txt_dmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_sk;
        private System.Windows.Forms.TextBox txt_cv;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_diem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgv_Sk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_machamdiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private SangKienMBFDataSet2 sangKienMBFDataSet2;
        private System.Windows.Forms.BindingSource hoidongkhoahocBindingSource;
        private SangKienMBFDataSet2TableAdapters.HoidongkhoahocTableAdapter hoidongkhoahocTableAdapter;
        private MahoidongDataSet3 mahoidongDataSet3;
        private System.Windows.Forms.BindingSource hoidongkhoahocBindingSource1;
        private MahoidongDataSet3TableAdapters.HoidongkhoahocTableAdapter hoidongkhoahocTableAdapter1;
    }
}