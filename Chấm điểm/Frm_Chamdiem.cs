using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_demo
{
    public partial class Frm_Chamdiem : Form
    {
        string magk = "";
        string sk = "";
        ConnectDB con = new ConnectDB();
        public Frm_Chamdiem()
        {
            InitializeComponent();
        }
        CRUD cRUD = new CRUD();
        public Frm_Chamdiem(string magk)
        {
            this.magk = magk;
            InitializeComponent();
            loadskvatg();
            loaddiem();
        }
        string msk;
        public void loadskvatg()
        {
            string sqlQuery = "select * from SKvaTG_view;";
            dgv_Sk.DataSource = cRUD.getDataTable(sqlQuery);
        }


        private void Frm_Chamdiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mahoidongDataSet3.Hoidongkhoahoc' table. You can move, or remove it, as needed.
            this.hoidongkhoahocTableAdapter1.Fill(this.mahoidongDataSet3.Hoidongkhoahoc);

        }
        public void loaddiem()
        {
            CRUD cRUD = new CRUD();
            Console.WriteLine(magk);
            string sqlQuery = "select * from diem_view where Magiamkhao = '"+ magk + "'; ";
            dgv_diem.DataSource = cRUD.getDataTable(sqlQuery);
        }
        private void dgv_Sk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Sk.Rows[e.RowIndex];
                txt_ten.Text = row.Cells[0].Value.ToString();
                txt_cv.Text = row.Cells[1].Value.ToString();
                txt_sk.Text = row.Cells[2].Value.ToString();
                msk = row.Cells[3].Value.ToString();
                
                CRUD cRUD = new CRUD();
                try
                {
                    string sk1 = txt_sk.Text.ToString();
                    con.openConnect();
                    SqlDataReader dulieu;
                    string sqlQuery = "select * from Chitietchamdiem,Sangkien where Chitietchamdiem.Masangkien = Sangkien.Masangkien and Chitietchamdiem.Magiamkhao = '"+magk+"' and Sangkien.Masangkien = '"+msk+"';";
                    SqlCommand cmd = new SqlCommand(sqlQuery,con.con);
                    dulieu = cmd.ExecuteReader();
                    if (dulieu.Read() == true)
                    {
                        MessageBox.Show("Bạn đã chấm điểm cho sáng kiến này!", "Thông báo");
                        txt_dmd.Text = dulieu.GetDouble(4).ToString();
                        txt_dnd.Text = dulieu.GetDouble(5).ToString();
                        txt_dtt.Text = dulieu.GetDouble(6).ToString();
                        txt_dpptb.Text = dulieu.GetDouble(7).ToString();
                        txt_dmd.Enabled = false;
                        txt_dtt.Enabled = false;
                        txt_dpptb.Enabled = false;
                        txt_dnd.Enabled = false;

                        con.closeConnect(); ;
                    }
                    else
                    {
                        txt_dmd.Enabled = true;
                        txt_dtt.Enabled = true;
                        txt_dpptb.Enabled = true;
                        txt_dnd.Enabled = true;
                        txt_dmd.ResetText();
                        txt_dnd.ResetText();
                        txt_dpptb.ResetText();
                        txt_dtt.ResetText();
                        con.closeConnect();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LỖi" + ex);
                }

            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(txt_dmd.Text == "")
            {
                MessageBox.Show("Bạn chưa chấm điểm mục đích");
                txt_dmd.Focus();
                if (txt_dnd.Text == "")
                {
                    MessageBox.Show("Bạn chưa chấm điểm nội dung");
                    txt_dnd.Focus();
                    if (txt_dtt.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chấm điểm ứng dụng");
                        txt_dtt.Focus();
                        if (txt_dpptb.Text == "")
                        {
                            MessageBox.Show("Bạn chưa chấm điểm phương pháp trình bày");
                            txt_dpptb.Focus();
                        }
                    }
                }
            }

            else
            {
                
                string sql = "insert into Chitietchamdiem(Machitietchamdiem,Mahoidong,Magiamkhao,Masangkien,Diemmucdich,Diemnoidung,Diemungdung,Diemtrinhbay) values ('"+txt_machamdiem.Text.ToString()+"','"+comboBox1.Text.ToString()+"','"+magk+"','"+msk+ "','" + txt_dmd.Text.ToString() + "','" + txt_dnd.Text.ToString() + "','" + txt_dtt.Text.ToString() + "','" + txt_dpptb.Text.ToString() + "');";
                cRUD.execSqlQuery(sql);
                MessageBox.Show("Chấm điểm thành công");
                loaddiem();
                loadskvatg();
            }
        }

        private void dgv_diem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_diem.Rows[e.RowIndex];
                txt_dmd.Text = row.Cells[3].Value.ToString();
                txt_dnd.Text = row.Cells[4].Value.ToString();
                txt_dtt.Text = row.Cells[5].Value.ToString();
                txt_dpptb.Text = row.Cells[6].Value.ToString();
            }
        }


    }
}
