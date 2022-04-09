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
    public partial class Frm_QLTK : Form
    {
        ConnectDB con = new ConnectDB();
        SqlDataReader dulieu;
        CRUD cRUD = new CRUD();
        public Frm_QLTK()
        {
            InitializeComponent();
            loadTacGia();
            loadTaiKhoan();
        }

        private void Frm_QLTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tacgiaDataSet3.Tacgia' table. You can move, or remove it, as needed.
            this.tacgiaTableAdapter.Fill(this.tacgiaDataSet3.Tacgia);


        }
        public void loadTacGia()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "Select * from Giamkhao;";
            dgv_gk.DataSource = cRUD.getDataTable(sqlQuery);
        }
        public void loadTaiKhoan()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "select * from taikhoan where TaiKhoan.Magiamkhao is not null";
            dgv_tk.DataSource = cRUD.getDataTable(sqlQuery);
        }

        public void themTK()
        {
            DateTime now = DateTime.UtcNow;
            string qh = "1";
            CRUD cRUD = new CRUD();
            string tk = txt_ttk.Text;
            string mk = txtmk.Text;
            con.openConnect();
            string magiamkhao = cm_mtg.Text;
            string sql = "select * from TaiKhoan Where Magiamkhao = '" + magiamkhao + "' ";
            SqlCommand cmd = new SqlCommand(sql,con.con);
            dulieu = cmd.ExecuteReader();
            if (tk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                txt_ttk.Focus();
            }
            else if (mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                txtmk.Focus();
            }
            else if(dulieu.Read() == true)
            {
                MessageBox.Show("Tài khoản của giám khảo này đã tồn tại");
            }
            else
            {
                try
                {
                    string sqlQuery = "INSERT INTO TaiKhoan (Tentaikhoan,Magiamkhao,Matkhau,Ngaylap,Quyenhan) VALUES ('" + txt_ttk.Text.ToString() + "','" + cm_mtg.Text.ToString()
                    + "','" + txtmk.Text.ToString() + "','" + now.ToString("yyyy/MM/dd") + "'," + qh.ToString() + ")";
                    cRUD.execSqlQuery(sqlQuery);
                    loadTaiKhoan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            con.closeConnect();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            themTK();
        }

        private void dgv_tk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_tk.Rows[e.RowIndex];
                txt_ttk.Text = row.Cells[0].Value.ToString();
                txtmk.Text = row.Cells[2].Value.ToString();
                cm_mtg.Text = row.Cells[1].Value.ToString();
            }
            SqlDataReader dt;
            string sql = "select Tengiamkhao from GiamKhao where Magiamkhao = '" + cm_mtg.Text.ToString() + "' ";
            dt = cRUD.ReadData(sql);
            if(dt.Read() == true)
            {
                txt_tengk.Text = dt.GetString(0);
            }

        }
    }
}
