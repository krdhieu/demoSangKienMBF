using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_demo
{
    public partial class Frm_SuaThongTinTacGia : Form
    {
        public Frm_SuaThongTinTacGia()
        {
            InitializeComponent();
        }
        List<string> gioiTinh = new List<string>() { "Nam", "Nữ" };
        private void Frm_SuaThongTinTacGia_Load(object sender, EventArgs e)
        {
            loadTacGia();
            Cbx_GioiTinh.DataSource = gioiTinh;
        }

        public void loadTacGia()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "Select * from TacGia;";
            Dgv_TacGia.DataSource = cRUD.getDataTable(sqlQuery);
        }

        public void suaThongTinTG()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "EXEC Proc_SuaTG '"+Txb_MaTacGia.Text.ToString().Trim()+"',N'" + Txb_TenTG.Text.ToString().Trim() + "',N'" + Cbx_GioiTinh.Text.ToString().Trim()
                + "','" + Dtp_NamSinh.Value.ToString("yyyy/MM/dd") + "',N'" + Txb_TrinhDo.Text.ToString().Trim()
                + "',N'" + Txb_ChucVu.Text.ToString().Trim() + "','" + Txb_SDT.Text.ToString().Trim()+"',N'" +Txb_DiaChi.Text.ToString().Trim() +"'";
            cRUD.execSqlQuery(sqlQuery);


        }

        private void Dgv_TacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_MaTacGia.Text = Dgv_TacGia.CurrentRow.Cells[0].Value.ToString();
            Txb_TenTG.Text = Dgv_TacGia.CurrentRow.Cells[1].Value.ToString();
            Dtp_NamSinh.Value = Convert.ToDateTime(Dgv_TacGia.CurrentRow.Cells[3].Value.ToString());
            Txb_TrinhDo.Text = Dgv_TacGia.CurrentRow.Cells[4].Value.ToString();
            Txb_ChucVu.Text = Dgv_TacGia.CurrentRow.Cells[5].Value.ToString();
            Txb_SDT.Text = Dgv_TacGia.CurrentRow.Cells[6].Value.ToString();
            Txb_DiaChi.Text = Dgv_TacGia.CurrentRow.Cells[7].Value.ToString();
        }

        private void Btn_ThemTG_Click(object sender, EventArgs e)
        {
            suaThongTinTG();
            loadTacGia();
        }
    }
}
