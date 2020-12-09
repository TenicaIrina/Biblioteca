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
    public partial class BooksByDates : Form
    {
        Helper con = new Helper();
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        SqlCommand cmd;

        MainAdmin mainContent = new MainAdmin();

        public BooksByDates()
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

        private void label1User_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFromDate.Text != "" && txtToDate.Text != "")
            {
               
                string query = "select B.Title from Book B   where (B.DatePublishing between '" + txtFromDate.Text + "' AND  '" + txtToDate.Text  + "')";
                cmd = new SqlCommand(query, con.OpenConnection());
                adpt = new SqlDataAdapter(cmd);
                dt = new System.Data.DataTable();
                adpt.Fill(dt);
                dataGridView1Admin.DataSource = dt;
            }
        }
    }
}
