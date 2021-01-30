using System;
using System.Windows.Forms;
using Domain;

namespace Presentation.ViewAdmin
{
    public partial class ViewBooks : Form
    {
        BookModel objectBook = new BookModel();
        private bool Edit = false;

        public ViewBooks()
        {
            InitializeComponent();
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            ShowBooksfromModel();
        }

        private void ShowBooksfromModel()
        {
            BookModel objectB = new BookModel();
            dataGridViewBooks.DataSource = objectB.ShowBooks();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            //editare
            if (Edit)
            {
                try
                {
                    objectBook.EditBooks(txtISBN.Text, txtDate.Text, txtTitle.Text, txtBookPublishing.Text);
                    MessageBox.Show("The data was edited correctly");
                    ShowBooksfromModel();
                    ClearForm();
                    Edit = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data was not edited because" + ex);
                }
            }
            //inserare
            else
            {
                try
                {
                    objectBook.InsertBooks(txtISBN.Text, txtDate.Text, txtTitle.Text, txtBookPublishing.Text);
                    MessageBox.Show("The data was inserted correctly");
                    ShowBooksfromModel();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data was not inserted because" + ex);
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                Edit = true;
                txtISBN.Text = dataGridViewBooks.CurrentRow.Cells["ISBN"].Value.ToString();
                txtDate.Text = dataGridViewBooks.CurrentRow.Cells["DatePublishing"].Value.ToString();
                txtTitle.Text = dataGridViewBooks.CurrentRow.Cells["Title"].Value.ToString();
                txtBookPublishing.Text = dataGridViewBooks.CurrentRow.Cells["BookPublishing"].Value.ToString();
            }
            else
                MessageBox.Show("Select a line for editing ");
        }

        private void ClearForm()
        {
            txtISBN.Text = "";
            txtDate.Text = "";
            txtTitle.Text = "";
            txtBookPublishing.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                txtTitle.Text = dataGridViewBooks.CurrentRow.Cells["Title"].Value.ToString();
                objectBook.DeleteBooksfromtable(txtTitle.Text);
                MessageBox.Show("Data was deleted correctly");
                ShowBooksfromModel();
                txtTitle.Text = "";
            }
            else
                MessageBox.Show("Select a line for delete");
        }
    }
}
