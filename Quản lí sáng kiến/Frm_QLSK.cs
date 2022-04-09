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
    public partial class Frm_QLSK : Form
    {
        public Frm_QLSK()
        {
            InitializeComponent();
        }

        private void Frm_QLSK_Load(object sender, EventArgs e)
        {
            if (dltk.phanquyen == 1)
            {
                btn_sua.Hide();
                btn_them.Hide();
                btn_suantg.Hide();
                btn_themng.Hide();
            }
            CRUD cRUD = new CRUD();
            string sqlQuery = "select * from Sangkien ";
            dataGridView1.DataSource = cRUD.getDataTable(sqlQuery);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Frm_SuaThongTinSangKien f = new Frm_SuaThongTinSangKien();
            f.ShowDialog();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Frm_ThemSangKien f = new Frm_ThemSangKien();
            f.ShowDialog();
        }

        private void btn_themng_Click(object sender, EventArgs e)
        {
            Frm_ThemNguoiTG f = new Frm_ThemNguoiTG();
            f.ShowDialog();
        }

        private void btn_suantg_Click(object sender, EventArgs e)
        {
            Frm_SuaNguoiThamGia f = new Frm_SuaNguoiThamGia();
            f.ShowDialog();
        }
    }
}
