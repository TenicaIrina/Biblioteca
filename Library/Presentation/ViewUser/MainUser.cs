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
    public partial class MainUser : Form
    {
        public MainUser()
        {
            InitializeComponent();
        }
        //folosit pentru deplasarea ferestrei
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void OpenFormInPanelUser(object FormnNew)
        {
            //daca exista vreun control il eliminam
            if (this.panelUser.Controls.Count > 0)
                this.panelUser.Controls.RemoveAt(0);

            //se creaza un formular
            Form fh = FormnNew as Form;

            //nu exista un formular de nivel superior
            fh.TopLevel = false;

            //sa  asigure acoperirea intregului panel
            fh.Dock = DockStyle.Fill;

            //atribuim panelul
            this.panelUser.Controls.Add(fh);

            //se stabileste instanta
            this.panelUser.Tag = fh;

            //se afiseaza
            fh.Show();
        }



        private void ViewReports_Click(object sender, EventArgs e)
        {
            OpenFormInPanelUser(new Category());
        }

    
      
        private void Minimizare_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


           

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMarire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //se alterneaza vizibilitatea celor 2 butoane
            pictureRestabilre.Visible = true;
            pictureMarire.Visible = false;

        }

        private void btnRestaurare(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Normal;

            //se alterneaza vizibilitatea celor 2 butoane
            pictureRestabilre.Visible = false;
            pictureMarire.Visible = true;
        }

        private void Micsorare_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BaraTiltlu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ManageProjectsUser_Click(object sender, EventArgs e)
        {
        //    ProjectsDataDisplayUser pr = new ProjectsDataDisplayUser();
        //    pr.Show();
        }

        private void ManageTasks_UserClick(object sender, EventArgs e)
        {
          //  OpenFormInPanelUser(new TaskForm());
        }

        private void TeamManage_Click(object sender, EventArgs e)
        {
          //  OpenFormInPanelUser(new TeamManagement());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
        //    this.Close();
        //    Form1 fm = new Form1();
        //    fm.Show();
        }

        private void ReportsByHours(object sender, EventArgs e)
        {
           // OpenFormInPanelUser(new ReportsProject());
        }

        private void TimeTrakingReports(object sender, EventArgs e)
        {
           //FormTest formTest = new FormTest();
           // formTest.Show();
        }

        private void MenuClick(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 256)
            {
                MenuVertical.Width = 95;
            }
            else
                MenuVertical.Width = 256;
        }

        //private void btnLogoutUser_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    FrmLogin fm = new FrmLogin();
        //    fm.Show();
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblNameUser.Text = UserLoginCache.Position;
            lblUserRole.Text = UserLoginCache.FullName;
            lblmailUser.Text = UserLoginCache.Email;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmLogin fm = new FrmLogin();
            fm.Show();
        }

        private void ManageBooksUser_Click(object sender, EventArgs e)
        {
            OpenFormInPanelUser(new BooksByDates());
        }

        private void ReportsManage_Click(object sender, EventArgs e)
        {
            OpenFormInPanelUser(new ReportsByPublishingHouse());
        }
    }
}
