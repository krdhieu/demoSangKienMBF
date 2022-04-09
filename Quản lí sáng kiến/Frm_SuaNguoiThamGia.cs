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
    public partial class Frm_SuaNguoiThamGia : Form
    {
        public Frm_SuaNguoiThamGia()
        {
            InitializeComponent();
        }
        List<string> vaitro =new  List<string>(){"Nguời chủ trì","Người hỗ trợ"};



        private void Frm_SuaNguoiThamGia_Load(object sender, EventArgs e)
        {
            loadNTG();
            Cbx_Vaitro.DataSource = vaitro;
            loadTacGiaMaTG();
            loadSangKienMaSK();
        }

        public void suaNTG()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "EXEC Proc_SuaNTG '" + Txb_MaNTG.Text.ToString().Trim() + "','" + Txb_MaSK.Text.ToString().Trim() + "','"
                + Txb_MaTG.Text.ToString().Trim() + "',N'" + Cbx_Vaitro.Text.ToString().Trim() + "',N'" + Txb_Tiledonggop.Text.ToString().Trim()+"'";
            cRUD.execSqlQuery(sqlQuery);
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

        private void Dgv_TacgiaMaTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_MaTG.Text = Dgv_TacgiaMaTG.CurrentRow.Cells[0].Value.ToString();
        }

        private void Dgv_SKMaSK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_MaSK.Text = Dgv_SKMaSK.CurrentRow.Cells[0].Value.ToString();
        }

        private void Dgv_Nguoithamgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_MaNTG.Text = Dgv_Nguoithamgia.CurrentRow.Cells[0].Value.ToString();
            Txb_Tiledonggop.Text = Dgv_Nguoithamgia.CurrentRow.Cells[4].Value.ToString();
            Txb_MaSK.Text = Dgv_Nguoithamgia.CurrentRow.Cells[1].Value.ToString();
            Txb_MaTG.Text = Dgv_Nguoithamgia.CurrentRow.Cells[2].Value.ToString();
        }

        private void Btn_SuaNTG_Click(object sender, EventArgs e)
        {
            suaNTG();
            loadNTG();
        }
    }
}
