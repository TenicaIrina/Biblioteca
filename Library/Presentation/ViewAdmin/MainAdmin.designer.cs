namespace Presentation
{
    partial class MainAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelTitlu = new System.Windows.Forms.Panel();
            this.pictureRestabilre = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureMarire = new System.Windows.Forms.PictureBox();
            this.pictureMinimizare = new System.Windows.Forms.PictureBox();
            this.pictureIesire = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btn8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelTitlu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestabilre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMarire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIesire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::Presentation.Properties.Resources.Admin_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 68);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // PanelTitlu
            // 
            this.PanelTitlu.BackColor = System.Drawing.Color.Lavender;
            this.PanelTitlu.Controls.Add(this.pictureRestabilre);
            this.PanelTitlu.Controls.Add(this.label1);
            this.PanelTitlu.Controls.Add(this.pictureMarire);
            this.PanelTitlu.Controls.Add(this.pictureMinimizare);
            this.PanelTitlu.Controls.Add(this.pictureIesire);
            this.PanelTitlu.Controls.Add(this.btnSlide);
            this.PanelTitlu.Location = new System.Drawing.Point(254, 0);
            this.PanelTitlu.Name = "PanelTitlu";
            this.PanelTitlu.Size = new System.Drawing.Size(1065, 60);
            this.PanelTitlu.TabIndex = 9;
            this.PanelTitlu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_PanelTop);
            // 
            // pictureRestabilre
            // 
            this.pictureRestabilre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureRestabilre.Image = global::Presentation.Properties.Resources.icon_maximaze;
            this.pictureRestabilre.Location = new System.Drawing.Point(1016, 0);
            this.pictureRestabilre.Name = "pictureRestabilre";
            this.pictureRestabilre.Size = new System.Drawing.Size(20, 20);
            this.pictureRestabilre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRestabilre.TabIndex = 4;
            this.pictureRestabilre.TabStop = false;
            this.pictureRestabilre.Visible = false;
            this.pictureRestabilre.Click += new System.EventHandler(this.Restabilire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Admin Dashboard";
            // 
            // pictureMarire
            // 
            this.pictureMarire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMarire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMarire.Image = global::Presentation.Properties.Resources.icon_maximaze;
            this.pictureMarire.Location = new System.Drawing.Point(1016, 0);
            this.pictureMarire.Name = "pictureMarire";
            this.pictureMarire.Size = new System.Drawing.Size(20, 20);
            this.pictureMarire.TabIndex = 3;
            this.pictureMarire.TabStop = false;
            this.pictureMarire.Click += new System.EventHandler(this.Marire_Click);
            // 
            // pictureMinimizare
            // 
            this.pictureMinimizare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimizare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimizare.Image = global::Presentation.Properties.Resources.icon_minimizare;
            this.pictureMinimizare.Location = new System.Drawing.Point(990, 0);
            this.pictureMinimizare.Name = "pictureMinimizare";
            this.pictureMinimizare.Size = new System.Drawing.Size(20, 20);
            this.pictureMinimizare.TabIndex = 2;
            this.pictureMinimizare.TabStop = false;
            this.pictureMinimizare.Click += new System.EventHandler(this.Minimizare_Click);
            // 
            // pictureIesire
            // 
            this.pictureIesire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureIesire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureIesire.Image = global::Presentation.Properties.Resources.iconexit1;
            this.pictureIesire.Location = new System.Drawing.Point(1042, 0);
            this.pictureIesire.Name = "pictureIesire";
            this.pictureIesire.Size = new System.Drawing.Size(20, 20);
            this.pictureIesire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureIesire.TabIndex = 1;
            this.pictureIesire.TabStop = false;
            this.pictureIesire.Click += new System.EventHandler(this.Iesire_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Image = global::Presentation.Properties.Resources.Mobile_Menu_Icon;
            this.btnSlide.Location = new System.Drawing.Point(6, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Lavender;
            this.panelContent.Location = new System.Drawing.Point(254, 66);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1065, 623);
            this.panelContent.TabIndex = 10;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(86, 14);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(51, 13);
            this.lblUserRole.TabIndex = 0;
            this.lblUserRole.Text = "UserRole";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(86, 31);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(35, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(86, 47);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lavender;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(4, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 94);
            this.button3.TabIndex = 3;
            this.button3.Text = "View books";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_ViewBooks_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lavender;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(4, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(244, 94);
            this.button5.TabIndex = 5;
            this.button5.Text = "Team \r\nManagement";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.TeamManagement_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(7, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 94);
            this.button2.TabIndex = 2;
            this.button2.Text = "Insert Books";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Project_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(7, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 94);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tasks reports";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ViewReports);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 792);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 85);
            this.button4.TabIndex = 15;
            this.button4.Text = "Log out";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lavender;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 403);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(244, 94);
            this.button6.TabIndex = 6;
            this.button6.Text = "Hours reports";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnReports);
            // 
            // MenuVertical
            // 
            this.MenuVertical.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MenuVertical.BackColor = System.Drawing.Color.SkyBlue;
            this.MenuVertical.Controls.Add(this.btn8);
            this.MenuVertical.Controls.Add(this.button6);
            this.MenuVertical.Controls.Add(this.button4);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.button5);
            this.MenuVertical.Controls.Add(this.button3);
            this.MenuVertical.Location = new System.Drawing.Point(-6, 66);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(254, 623);
            this.MenuVertical.TabIndex = 8;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Lavender;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn8.Location = new System.Drawing.Point(7, 503);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(241, 117);
            this.btn8.TabIndex = 16;
            this.btn8.Text = "Logout";
            this.btn8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_LogoutClick);
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1322, 695);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.PanelTitlu);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelTitlu.ResumeLayout(false);
            this.PanelTitlu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestabilre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMarire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIesire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelTitlu;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureMarire;
        private System.Windows.Forms.PictureBox pictureMinimizare;
        private System.Windows.Forms.PictureBox pictureIesire;
        private System.Windows.Forms.PictureBox pictureRestabilre;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button btn8;
    }
}