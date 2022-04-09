using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_demo
{
    public partial class Frm_ThemTacGia : Form
    {
        public Frm_ThemTacGia()
        {
            InitializeComponent();
        }
        List<string> gioiTinh = new List<string>() {"Nam","Nữ" };
        private void Frm_ThemTacGia_Load(object sender, EventArgs e)
        {
            Cbx_GioiTinh.DataSource = gioiTinh;
            loadTacGia();
        }

        public void loadTacGia()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "Select * from TacGia;";
            Dgv_TacGia.DataSource= cRUD.getDataTable(sqlQuery);
        }

        public void themTG()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "exec Proc_ThemTG '" + Txb_MaTacGia.Text.ToString() + "',N'" + Txb_TenTG.Text.ToString() 
                + "',N'"+ Cbx_GioiTinh.Text.ToString() + "','" + Dtp_NamSinh.Value.ToString("yyyy/MM/dd") 
                +"',N'"+Txb_TrinhDo.Text.ToString()+"',N'"+Txb_ChucVu.Text.ToString()+"','"+Txb_SDT.Text.ToString()+"',N'"+Txb_DiaChi.Text.ToString()+"';";
            cRUD.execSqlQuery(sqlQuery);
            loadTacGia();
        }

        private void Txb_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)&& (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
                
        }

        private void Btn_ThemTG_Click(object sender, EventArgs e)
        {
            themTG();
        }
    }
}
