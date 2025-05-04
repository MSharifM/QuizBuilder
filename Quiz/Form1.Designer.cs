namespace Quiz
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnQues = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnQues
            // 
            this.btnQues.Location = new System.Drawing.Point(12, 12);
            this.btnQues.Name = "btnQues";
            this.btnQues.Size = new System.Drawing.Size(75, 23);
            this.btnQues.TabIndex = 0;
            this.btnQues.Text = "Questions";
            this.btnQues.UseVisualStyleBackColor = true;
            this.btnQues.Click += new System.EventHandler(this.btnQues_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(362, 12);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(75, 23);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Student";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(191, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 270);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnQues);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnQues;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnCreate;
    }
}

