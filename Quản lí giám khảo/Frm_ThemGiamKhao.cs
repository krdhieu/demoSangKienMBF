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
    public partial class Frm_ThemGiamKhao : Form
    {
        public Frm_ThemGiamKhao()
        {
            InitializeComponent();
        }

        public void loadGiamKhao()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "Select * from Giamkhao;";
            Dgv_GiamKhao.DataSource = cRUD.getDataTable(sqlQuery);
        }

        private void Frm_QuanLyGiamKhao_Load(object sender, EventArgs e)
        {
            loadGiamKhao();
        }

        public void themThongTinGK()
        {
            string sqlQuery = "EXEC Proc_ThemGK '" + Txb_MaGK.Text.ToString().Trim() + "', N'" + Txb_TenGK.Text.ToString().Trim() + "',N'" + Txb_Chucvu.Text.ToString().Trim() + "'";
            CRUD cRUD = new CRUD();
            cRUD.execSqlQuery(sqlQuery);
        }

        private void Btn_ThemGK_Click(object sender, EventArgs e)
        {
            themThongTinGK();
            loadGiamKhao();
        }
    }
}
