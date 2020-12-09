using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation.ViewAdmin
{
    public partial class ReportsByPublishingHouse : Form
    {
        Helper con = new Helper();
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        SqlCommand cmd;

        MainAdmin mainContent = new MainAdmin();

        public ReportsByPublishingHouse()
        {
            InitializeComponent();
        }

        private void ProjectsDataDisplayUser_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPublishing.Text != "")
            {

                string query = "select B.Title from Book B   where B.BookPublishing='" + txtPublishing.Text + "'";
                cmd = new SqlCommand(query, con.OpenConnection());
                adpt = new SqlDataAdapter(cmd);
                dt = new System.Data.DataTable();
                adpt.Fill(dt);
                dataGridViewPublishing.DataSource = dt;
            }
        }
    }
}
