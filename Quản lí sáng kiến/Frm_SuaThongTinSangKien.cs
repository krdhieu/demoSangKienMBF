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
    public partial class Frm_SuaThongTinSangKien : Form
    {
        public Frm_SuaThongTinSangKien()
        {
            InitializeComponent();
        }

        private void Frm_SuaThongTinSangKien_Load(object sender, EventArgs e)
        {
            loadSangKien();
        }

        public void loadSangKien()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "Select * from Sangkien;";
            Dgv_SangKien.DataSource = cRUD.getDataTable(sqlQuery);

        }

        public void suaSangKien()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "EXEC Proc_SuaSK '"
                + Txb_MaSK.Text.ToString() + "',N'" + Txb_TenSK.Text.ToString().Trim() + "','"
                + Dtp_Thoidiemapdung.Value.ToString("yyyy/MM/dd") + "',N'" + Txb_Diadiemapdung.Text.ToString().Trim() + "',N'"
                + Txb_MotaSK.Text.ToString().Trim() + "',N'" + Txb_Dotsangkien.Text.ToString().Trim()+"'";
            cRUD.execSqlQuery(sqlQuery);
        }
        private void Dgv_SangKien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_MaSK.Text = Dgv_SangKien.CurrentRow.Cells[0].Value.ToString();
            Txb_TenSK.Text = Dgv_SangKien.CurrentRow.Cells[1].Value.ToString();
            Dtp_Thoidiemapdung.Value = Convert.ToDateTime(Dgv_SangKien.CurrentRow.Cells[2].Value.ToString());
            Txb_Diadiemapdung.Text = Dgv_SangKien.CurrentRow.Cells[3].Value.ToString();
            Txb_MotaSK.Text = Dgv_SangKien.CurrentRow.Cells[4].Value.ToString();
            Txb_Dotsangkien.Text = Dgv_SangKien.CurrentRow.Cells[5].Value.ToString();
        }

        private void Btn_SuaSK_Click(object sender, EventArgs e)
        {
            suaSangKien();
            loadSangKien();
        }
    }
}
