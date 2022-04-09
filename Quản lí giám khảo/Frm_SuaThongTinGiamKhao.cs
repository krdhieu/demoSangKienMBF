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
    public partial class Frm_SuaThongTinGiamKhao : Form
    {
        public Frm_SuaThongTinGiamKhao()
        {
            InitializeComponent();
        }

        private void Frm_SuaThongTinGiaKhao_Load(object sender, EventArgs e)
        {
            loadGiamKhao();
        }
        public void loadGiamKhao()
        {
            CRUD cRUD = new CRUD();
            String sqlQuery = "Select * from Giamkhao;";
            Dgv_GiamKhao.DataSource = cRUD.getDataTable(sqlQuery);
        }

        private void Dgv_GiamKhao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_MaGK.Text = Dgv_GiamKhao.CurrentRow.Cells[0].Value.ToString();
            Txb_TenGK.Text = Dgv_GiamKhao.CurrentRow.Cells[1].Value.ToString();
            Txb_Chucvu.Text = Dgv_GiamKhao.CurrentRow.Cells[2].Value.ToString();
        }

        public void suaThongTinGK()
        {
            string sqlQuery = "EXEC Proc_SuaGK	'" + Txb_MaGK.Text.ToString().Trim() + "',N'" + Txb_TenGK.Text.ToString().Trim() + "',N'" + Txb_Chucvu.Text.ToString().Trim() + "';";
            CRUD cRUD = new CRUD();
            cRUD.execSqlQuery(sqlQuery);
        }

        private void Btn_SuaGK_Click(object sender, EventArgs e)
        {
            suaThongTinGK();
            loadGiamKhao();
        }
    }
}
