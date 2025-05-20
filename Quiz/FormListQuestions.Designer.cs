namespace Quiz
{
    partial class FormListQuestions
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
            this.dgvListQuestions = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListQuestions
            // 
            this.dgvListQuestions.AllowUserToAddRows = false;
            this.dgvListQuestions.AllowUserToDeleteRows = false;
            this.dgvListQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dgvListQuestions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Title,
            this.Delete,
            this.Edit});
            this.dgvListQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListQuestions.Location = new System.Drawing.Point(0, 0);
            this.dgvListQuestions.Name = "dgvListQuestions";
            this.dgvListQuestions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvListQuestions.Size = new System.Drawing.Size(741, 450);
            this.dgvListQuestions.TabIndex = 0;
            this.dgvListQuestions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListQuestions_CellContentClick);
            // 
            // Number
            // 
            this.Number.FillWeight = 40F;
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // Title
            // 
            this.Title.FillWeight = 83.94196F;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Delete
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.NullValue = "Delete";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.FillWeight = 60F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // Edit
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.NullValue = "Edit";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle2;
            this.Edit.FillWeight = 60F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormListQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.dgvListQuestions);
            this.Name = "FormListQuestions";
            this.Text = "FormListQuestions";
            this.Load += new System.EventHandler(this.FormListQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
    }
}