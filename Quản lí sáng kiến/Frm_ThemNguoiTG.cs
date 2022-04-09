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
    public partial class Frm_ThemNguoiTG : Form
    {
        public Frm_ThemNguoiTG()
        {
            InitializeComponent();
        }
        List<string> vaiTro = new List<string>() { "Người chủ trì", "Người hỗ trợ" };
        private void Frm_ThemNguoiTG_Load(object sender, EventArgs e)
        {
            loadNTG();
            loadTacGiaMaTG();
            loadSangKienMaSK();
            Cbx_Vaitro.DataSource = vaiTro;
        }

        public void loadNTG()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "Select * from Nguoithamgia;";
            Dgv_Nguoithamgia.DataSource = cRUD.getDataTable(sqlQuery);
        }

        public void loadTacGiaMaTG()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "Select * from View_TacGiaMaTG";
            Dgv_TacgiaMaTG.DataSource = cRUD.getDataTable(sqlQuery);
        }
        public void loadSangKienMaSK()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "Select * from View_SangKienMASK";
            Dgv_SKMaSK.DataSource = cRUD.getDataTable(sqlQuery);
        }
        public void themNTG()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "EXEC Proc_ThemNguoiTG '" + Txb_MaNTG.Text.ToString().Trim() + "','" + Txb_MaSK.Text.ToString().Trim() + "','"
                + Txb_MaTG.Text.ToString().Trim() + "',N'" + Cbx_Vaitro.Text.ToString() + "',N'" + Txb_Tiledonggop.Text.ToString().Trim() + "';";
            cRUD.execSqlQuery(sqlQuery);
        }

        private void Dgv_TacgiaMaTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_MaTG.Text = Dgv_TacgiaMaTG.CurrentRow.Cells[0].Value.ToString();
        }

        private void Dgv_SKMaSK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_MaSK.Text = Dgv_SKMaSK.CurrentRow.Cells[0].Value.ToString();
        }

        private void Btn_ThemNTG_Click(object sender, EventArgs e)
        {
            themNTG();
            loadNTG();
        }


    }
}
