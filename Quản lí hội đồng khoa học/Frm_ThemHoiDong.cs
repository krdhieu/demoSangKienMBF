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
    public partial class Frm_ThemHoiDong : Form
    {
        public Frm_ThemHoiDong()
        {
            InitializeComponent();
        }

        private void Frm_ThemHoiDong_Load(object sender, EventArgs e)
        {
            loadHoiDong();
        }

        public void loadHoiDong()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "Select * from Hoidongkhoahoc;";
            Dgv_Hoidong.DataSource = cRUD.getDataTable(sqlQuery);
        }

        public void themHD()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "EXEC Proc_ThemHD '" + Txb_MaHD.Text.ToString().Trim() + "','" + Dtp_Namthanhlap.Value.ToString("yyyy/MM/dd") + "',N'" + Txb_Nhiemvu.Text.ToString().Trim() + "';";
            cRUD.execSqlQuery(sqlQuery);
        }
        private void Dgv_Hoidong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            themHD();
            loadHoiDong();
        }
    }
}
