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
    public partial class Frm_ThemSangKien : Form
    {
        public Frm_ThemSangKien()
        {
            InitializeComponent();
        }

        private void Frm_ThemSangKien_Load(object sender, EventArgs e)
        {
            loadSangKien();
        }

        public void themSangKien()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "EXEC Proc_ThemSangKien '" 
                + Txb_MaSK.Text.ToString().Trim() + "',N'" + Txb_TenSK.Text.ToString().ToString().Trim() + "','" 
                + Dtp_Thoidiemapdung.Value.ToString("yyyy/MM/dd")+ "',N'" + Txb_Diadiemapdung.Text.ToString().Trim() + "',N'"
                + Txb_MotaSK .Text.ToString().Trim() + "','" + Txb_Dotsangkien.Text.ToString().Trim() + "'";

            cRUD.execSqlQuery(sqlQuery);
        }

        public void loadSangKien()
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "Select * from Sangkien;";
            Dgv_SangKien.DataSource = cRUD.getDataTable(sqlQuery);

        }

        private void Btn_ThemSK_Click(object sender, EventArgs e)
        {
            themSangKien();
            loadSangKien();
        }
    }
}
