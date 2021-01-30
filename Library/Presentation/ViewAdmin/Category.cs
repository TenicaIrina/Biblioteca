using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Domain;

namespace Presentation.ViewAdmin
{
    public partial class Category : Form
    {
        Helper con = new Helper();
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        SqlCommand cmd;

        public Category()
        {
            InitializeComponent();
        }
        private void pictureIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != "")
            {

                string query = "SELECT A.FIRSTNAME, A.LASTNAME "+
                               "FROM(((Author A INNER JOIN AUTHORBOOK AB  ON AB.AuthorIdFK = A.AuthorId) INNER JOIN CATEGORYBOOK BC   ON BC.ISBNFK = AB.ISBN)  INNER JOIN CATEGORYTABLE C  ON C.CATEGORYID = BC.CATEGORYIDFK)  WHERE (C.NAMECATEGORY = '" + txtCategory.Text + "')";
                cmd = new SqlCommand(query, con.OpenConnection());
                adpt = new SqlDataAdapter(cmd);
                dt = new System.Data.DataTable();
                adpt.Fill(dt);
                dataGridViewCategory.DataSource = dt;
            }
        }
    }
}
