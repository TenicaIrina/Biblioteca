namespace  Presentation.ViewAdmin

{
    partial class ReportsByPublishingHouse
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
            this.txtPublishing = new System.Windows.Forms.TextBox();
            this.dataGridViewPublishing = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishing)).BeginInit();
            this.SuspendLayout();
            // 
            // label1User
            // 
            this.label1User.AutoSize = true;
            this.label1User.BackColor = System.Drawing.Color.White;
            this.label1User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1User.Location = new System.Drawing.Point(28, 124);
            this.label1User.Name = "label1User";
            this.label1User.Size = new System.Drawing.Size(249, 24);
            this.label1User.TabIndex = 5;
            this.label1User.Text = "Search by Publishing House";
            // 
            // txtPublishing
            // 
            this.txtPublishing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublishing.Location = new System.Drawing.Point(306, 124);
            this.txtPublishing.Multiline = true;
            this.txtPublishing.Name = "txtPublishing";
            this.txtPublishing.Size = new System.Drawing.Size(301, 24);
            this.txtPublishing.TabIndex = 4;
            // 
            // dataGridViewPublishing
            // 
            this.dataGridViewPublishing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPublishing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPublishing.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPublishing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPublishing.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewPublishing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPublishing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPublishing.ColumnHeadersHeight = 30;
            this.dataGridViewPublishing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPublishing.EnableHeadersVisualStyles = false;
            this.dataGridViewPublishing.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPublishing.Location = new System.Drawing.Point(12, 199);
            this.dataGridViewPublishing.Name = "dataGridViewPublishing";
            this.dataGridViewPublishing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPublishing.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPublishing.Size = new System.Drawing.Size(980, 359);
            this.dataGridViewPublishing.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(672, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportsByPublishingHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1044, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1User);
            this.Controls.Add(this.txtPublishing);
            this.Controls.Add(this.dataGridViewPublishing);
            this.Name = "ReportsByPublishingHouse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1User;
        private System.Windows.Forms.TextBox txtPublishing;
        private System.Windows.Forms.DataGridView dataGridViewPublishing;
        private System.Windows.Forms.Button button1;
    }
}