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
    public partial class Frm_ThemChiTietHoiDong : Form
    {
        public Frm_ThemChiTietHoiDong()
        {
            InitializeComponent();
        }

        private void Frm_ThemChiTietHoiDong_Load(object sender, EventArgs e)
        {
            loadChiTietHD();
            loadGK();
            loadHD();
        }
        public void loadChiTietHD()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "Select * from Chitiethoidong";
            Dgv_Chitiethoidong.DataSource = cRUD.getDataTable(sqlQuery);
        }
        public void loadGK()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "Select * from View_GiamKhaoMaGK";
            Dgv_GKMaGK.DataSource = cRUD.getDataTable(sqlQuery);
        }
        public void loadHD()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "select * from View_HoiDongMaHD;";
            Dgv_HDMaHD.DataSource = cRUD.getDataTable(sqlQuery);
        }
        public void themChitietHD()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "exec Proc_ThemchitietHD '" + Txb_MachitietHD.Text.ToString().Trim() + "','" + Txb_MaHD.Text.ToString().Trim() 
                + "','" + Txb_MaGK.Text.ToString().Trim() + "',N'" + Txb_Chucvu.Text.ToString().Trim() + "';";
            cRUD.execSqlQuery(sqlQuery);
        }

        

        private void Dgv_GKMaGK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_MaGK.Text = Dgv_GKMaGK.CurrentRow.Cells[0].Value.ToString();
        }

        private void Dgv_HDMaHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_MaHD.Text = Dgv_HDMaHD.CurrentRow.Cells[0].Value.ToString();
        }


        private void Btn_ThemChiTietHD_Click(object sender, EventArgs e)
        {
            themChitietHD();
            loadChiTietHD();
        }

        private void Dgv_Chitiethoidong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
