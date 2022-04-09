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
    public partial class Frm_SuaThongTinHD : Form
    {
        public Frm_SuaThongTinHD()
        {
            InitializeComponent();
        }

        private void Frm_SuaThongTinHD_Load(object sender, EventArgs e)
        {
            loadHoiDong();
        }

        public void loadHoiDong()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "Select * from Hoidongkhoahoc;";
            Dgv_Hoidong.DataSource = cRUD.getDataTable(sqlQuery);
        }

        public void suaThongTinHD()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "EXEC Proc_SuaHD'" +Txb_MaHD.Text.ToString().Trim()+" ','" + Dtp_Namthanhlap.Value.ToString("yyyy/MM/dd") + "',N'" + Txb_Nhiemvu.Text.ToString().Trim() + "';";
            cRUD.execSqlQuery(sqlQuery);
        }

        private void Dgv_Hoidong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_MaHD.Text = Dgv_Hoidong.CurrentRow.Cells[0].Value.ToString();
            Dtp_Namthanhlap.Value = Convert.ToDateTime(Dgv_Hoidong.CurrentRow.Cells[1].Value.ToString());
            Txb_Nhiemvu.Text = Dgv_Hoidong.CurrentRow.Cells[2].Value.ToString();
        }

        private void Btn_SuaThongTinHD_Click(object sender, EventArgs e)
        {
            suaThongTinHD();
            loadHoiDong();
        }
    }
}
