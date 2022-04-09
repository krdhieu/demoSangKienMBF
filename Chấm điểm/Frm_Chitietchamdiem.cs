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
    public partial class Frm_Chitietchamdiem : Form
    {
        public Frm_Chitietchamdiem()
        {
            InitializeComponent();
        }

        private void Frm_Chitietchamdiem_Load(object sender, EventArgs e)
        {
            CRUD cRUD = new CRUD();
            string sqlQuery = "select * from Chitietchamdiem ";
            dataGridView1.DataSource = cRUD.getDataTable(sqlQuery);
        }
    }
}
