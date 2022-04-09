using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace do_an_demo
{
    public partial class Frm_DangNhap : Form
    {
        ConnectDB con = new ConnectDB();
        public Frm_DangNhap()
        {
            InitializeComponent();
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {

            SqlDataReader dulieu;
            try
            {
                con.openConnect();
                
                string tk = txt_tk.Text;
                string mk = txt_mk.Text;
                if (tk.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản");
                }
                else if (mk.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                }
                else
                {
                    string sql = "select * from TaiKhoan Where Tentaikhoan = '" + tk + "' and Matkhau = '" + mk + "' ";
                    SqlCommand cmd = new SqlCommand(sql,con.con);
                    dulieu = cmd.ExecuteReader();
                    if (dulieu.Read() == true)
                    {
                  //      MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                        string username = dulieu.GetString(0);
                        string pass = dulieu.GetString(2);
                        int pq = dulieu.GetInt32(4);
                        dltk.phanquyen = pq;
                        string magk = "";
                        if (pq == 1)
                        {
                            magk = dulieu.GetString(1);
                        }
                        else
                        {
                            magk = "0";
                        }
                        
                        dltk.phanquyen = pq;
                            Frm_MainAD f = new Frm_MainAD(username, pass , dltk.phanquyen ,magk);
                            this.Hide();
                            f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                con.closeConnect();
            }
            catch (Exception loi)
            {
                MessageBox.Show("Lỗi kết nối!"+loi,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            } 
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }

   
}