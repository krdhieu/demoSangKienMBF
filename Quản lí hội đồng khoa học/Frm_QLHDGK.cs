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
    public partial class Frm_QLHDGK : Form
    {
        public Frm_QLHDGK()
        {
            InitializeComponent();
        }

        private void Frm_QLHDGK_Load(object sender, EventArgs e)
        {
            if (dltk.phanquyen == 1)
            {
                btn_sua.Hide();
                btn_them.Hide();
                btn_suatt.Hide();
                btn_themgk.Hide();
            }
            CRUD cRUD = new CRUD();
            string sqlQuery = "select * from Hoidongkhoahoc ";
            dataGridView1.DataSource = cRUD.getDataTable(sqlQuery);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Frm_SuaThongTinHD f = new Frm_SuaThongTinHD();
            f.ShowDialog();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Frm_ThemHoiDong f = new Frm_ThemHoiDong();
            f.ShowDialog();
        }

        private void btn_suatt_Click(object sender, EventArgs e)
        {
            Frm_SuaChiTietHoiDong f = new Frm_SuaChiTietHoiDong();
            f.ShowDialog();
        }

        private void btn_themgk_Click(object sender, EventArgs e)
        {
            Frm_ThemChiTietHoiDong f = new Frm_ThemChiTietHoiDong();
            f.ShowDialog();
        }
    }
}
