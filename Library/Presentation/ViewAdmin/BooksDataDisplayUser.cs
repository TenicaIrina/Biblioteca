using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Domain;

namespace Presentation.ViewAdmin
{
    public partial class BooksDataDisplayUser : Form
    {
        Helper con = new Helper();
        SqlDataAdapter dtadapter;
        System.Data.DataTable dt;
        SqlCommand cmd;
     


        public BooksDataDisplayUser()
        {
            InitializeComponent();
        }

        private void ProjectsDataDisplayUser_Load(object sender, EventArgs e)
        {
            ShowBooksfromModel();
        }
        private void ShowBooksfromModel()
        {
            CaracteristicsModel objectB = new CaracteristicsModel();
            dataGridView1User.DataSource = objectB.ShowBooksDataTableUsingAcces(txt_SearchUser.Text);
        }



        public void searchdata(string search)
        {
            string query = " select * from Book where Title like '%" + search + "%'";
            cmd = new SqlCommand(query, con.OpenConnection());
            dtadapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dtadapter.Fill(dt);
            dataGridView1User.DataSource = dt;
        }



        private void txt_SearchUser_TextChanged(object sender, EventArgs e)
        {
           
            searchdata(txt_SearchUser.Text);
           
        }

        private void pictureIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
