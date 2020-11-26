namespace Presentation.ViewAdmin
{
    partial class BooksDataDisplayUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1User = new System.Windows.Forms.Label();
            this.txt_SearchUser = new System.Windows.Forms.TextBox();
            this.dataGridView1User = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1User)).BeginInit();
            this.SuspendLayout();
            // 
            // label1User
            // 
            this.label1User.AutoSize = true;
            this.label1User.BackColor = System.Drawing.Color.White;
            this.label1User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1User.Location = new System.Drawing.Point(28, 124);
            this.label1User.Name = "label1User";
            this.label1User.Size = new System.Drawing.Size(135, 24);
            this.label1User.TabIndex = 5;
            this.label1User.Text = "Search by Title";
            // 
            // txt_SearchUser
            // 
            this.txt_SearchUser.Location = new System.Drawing.Point(200, 124);
            this.txt_SearchUser.Multiline = true;
            this.txt_SearchUser.Name = "txt_SearchUser";
            this.txt_SearchUser.Size = new System.Drawing.Size(464, 24);
            this.txt_SearchUser.TabIndex = 4;
            this.txt_SearchUser.TextChanged += new System.EventHandler(this.txt_SearchUser_TextChanged);
            // 
            // dataGridView1User
            // 
            this.dataGridView1User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1User.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1User.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1User.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1User.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1User.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1User.ColumnHeadersHeight = 30;
            this.dataGridView1User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1User.EnableHeadersVisualStyles = false;
            this.dataGridView1User.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1User.Location = new System.Drawing.Point(21, 209);
            this.dataGridView1User.Name = "dataGridView1User";
            this.dataGridView1User.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1User.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1User.Size = new System.Drawing.Size(980, 359);
            this.dataGridView1User.TabIndex = 3;
            // 
            // ProjectsDataDisplayUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 636);
            this.Controls.Add(this.label1User);
            this.Controls.Add(this.txt_SearchUser);
            this.Controls.Add(this.dataGridView1User);
            this.Name = "ProjectsDataDisplayUser";
            this.Load += new System.EventHandler(this.ProjectsDataDisplayUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1User;
        private System.Windows.Forms.TextBox txt_SearchUser;
        private System.Windows.Forms.DataGridView dataGridView1User;
    }
}