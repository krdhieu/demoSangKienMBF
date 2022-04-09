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
    public partial class Frm_QLGK : Form
    {
        public Frm_QLGK()
        {
            InitializeComponent();
        }

        private void QLGK_Load(object sender, EventArgs e)
        {
            if(dltk.phanquyen == 1 )
             {
              btn_sua.Hide();
              btn_them.Hide();
            }
            CRUD cRUD = new CRUD();
            string sqlQuery = "select * from Giamkhao ";
            dataGridView1.DataSource = cRUD.getDataTable(sqlQuery);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Frm_SuaThongTinGiamKhao f = new Frm_SuaThongTinGiamKhao();
            f.ShowDialog();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Frm_ThemGiamKhao f = new Frm_ThemGiamKhao();
            f.ShowDialog();
        }
    }
}
