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
    public partial class BooksDataDisplayUser : Form
    {
        CaracteristicsModel objectBook = new CaracteristicsModel();
        // MainForm mainContent = new MainForm();
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

        private void txt_SearchUser_TextChanged(object sender, EventArgs e)
        {
           
            objectBook.ShowBooksDataTableUsingAcces(txt_SearchUser.Text);
           
        }

        private void pictureIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
