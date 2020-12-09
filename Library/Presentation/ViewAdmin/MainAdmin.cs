using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Common.cache;
using Presentation.ViewAdmin;

namespace Presentation
{
    public partial class MainAdmin : Form
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
     

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
           // Form1 obj = new Form1();
           // obj.Show();
        }

        private void Project_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new ViewBooks());
             //ViewBooks book = new ViewBooks();
             //book.Show();

        }

       


        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 254)
            {
                MenuVertical.Width = 96;
            }
            else
                MenuVertical.Width = 254;
        }



        private void Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizare_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Marire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //se alterneaza vizibilitatea celor 2 butoane
            pictureRestabilre.Visible = true;
            pictureMarire.Visible = false;
        }

        private void Restabilire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            //se alterneaza vizibilitatea celor 2 butoane
            pictureRestabilre.Visible = false;
            pictureMarire.Visible = true;
        }

        private void MouseDown_PanelTop(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void OpenFormInPanel(object FormnNew)
        {
            //daca exista vreun control il eliminam
            if (this.panelContent.Controls.Count > 0)
                this.panelContent.Controls.RemoveAt(0);

            //se creaza un formular
            Form fh = FormnNew as Form;

            //nu exista un formular de nivel superior
            fh.TopLevel = false;

            //sa  asigure acoperirea intregului panel
            fh.Dock = DockStyle.Fill;

            //atribuim panelul
            this.panelContent.Controls.Add(fh);

            //se stabileste instanta
            this.panelContent.Tag = fh;

            //se afiseaza
            fh.Show();
        }

        private void ViewReports(object sender, EventArgs e)
        {
          //  OpenFormInPanel(new ReportForm());
        }


        private void btnReports(object sender, EventArgs e)
        {
             OpenFormInPanel(new Category());
            //Category cat = new Category();
            //cat.Show();
        }

     

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblUserRole.Text = UserLoginCache.Position;
            lblFullName.Text = UserLoginCache.FullName;
            lblEmail.Text = UserLoginCache.Email;
        }

   
        private void btn_LogoutClick(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fm = new FrmLogin();
            fm.Show();
        }

        private void btn_ViewBooks_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new BooksDataDisplayUser());
            //BooksDataDisplayUser book = new BooksDataDisplayUser();
            //book.Show();
        }

        private void BooksByDates_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new BooksByDates());
            //BooksByDates data = new BooksByDates();
            //data.Show();
        }


        private void ViewPublishingHouse(object sender, EventArgs e)
        {
            OpenFormInPanel(new ReportsByPublishingHouse());
            //ReportsByPublishingHouse pu = new ReportsByPublishingHouse();
            //pu.Show();
        }
    }
}
