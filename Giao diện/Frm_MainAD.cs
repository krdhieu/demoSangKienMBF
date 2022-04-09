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
    public partial class Frm_MainAD : Form
    {
        public Frm_MainAD()
        {
            InitializeComponent();
        }
        string username = "", pass = "",magk = "";
        int phanquyen;
        private void lb_logout_Click(object sender, EventArgs e)
        {
            
            Frm_DangNhap f = new Frm_DangNhap();
            dltk.phanquyen = -1 ;
            dltk.magk = ""; 
            this.Hide();
            f.ShowDialog();
        }



        private void btn_qlsk_Click(object sender, EventArgs e)
        {
            Frm_QLSK f2 = new Frm_QLSK();
            f2.ShowDialog();
        }



        private void btn_qlgk_Click(object sender, EventArgs e)
        {
            Frm_QLGK f3 = new Frm_QLGK();
            f3.ShowDialog();
        }

        private void btn_hdkh_Click(object sender, EventArgs e)
        {
            Frm_QLHDGK f = new Frm_QLHDGK();
            f.ShowDialog();
        }

        private void btn_qltg_Click(object sender, EventArgs e)
        {
            Frm_QLTG f2 = new Frm_QLTG();
            f2.ShowDialog();
        }

        private void Frm_MainAD_Load(object sender, EventArgs e)
        {

        }

        private void btn_ctcd_Click(object sender, EventArgs e)
        {
            Frm_Chitietchamdiem f = new Frm_Chitietchamdiem();
            f.ShowDialog();
        }

        private void btn_qltk_Click(object sender, EventArgs e)
        {
            if(phanquyen == 1)
            {
                Frm_Chamdiem f4 = new Frm_Chamdiem(magk);
                f4.ShowDialog();
            }
            else
            {
                Frm_DLTK f4 = new Frm_DLTK();
                f4.ShowDialog();
            }
        }

        public Frm_MainAD(string username, string pass,int phanquyen,string magk)
        {
            InitializeComponent();
            this.username = username;
            this.pass = pass;
            this.phanquyen = phanquyen;
            this.magk = magk;
            dltk.magk = magk;
            if(phanquyen == 1)
            {
                btn_qltk.Text = "Chấm điểm";
                lb_chucvu.Text = "Giám khảo";
            }
            else
            {
                lb_chucvu.Text = "Quản trị viên";
            }

            lb_logout.Text = "Logout";
            lb_name.Text = "Xin chào " + username;
        }
    }
}
