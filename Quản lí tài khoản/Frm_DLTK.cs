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
    public partial class Frm_DLTK : Form
    {
        public Frm_DLTK()
        {
            InitializeComponent();
        }

        private void Frm_DLTK_Load(object sender, EventArgs e)
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "select * from taikhoan where TaiKhoan.Magiamkhao is not null";
            dataGridView1.DataSource = cRUD.getDataTable(sqlQuery);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Frm_QLTK f = new Frm_QLTK();
            f.ShowDialog();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
