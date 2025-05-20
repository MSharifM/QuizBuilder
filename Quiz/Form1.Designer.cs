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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnViewQuestions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnQues
            // 
            this.btnQues.BackColor = System.Drawing.SystemColors.Info;
            this.btnQues.Location = new System.Drawing.Point(39, 159);
            this.btnQues.Name = "btnQues";
            this.btnQues.Size = new System.Drawing.Size(116, 46);
            this.btnQues.TabIndex = 0;
            this.btnQues.Text = "Questions";
            this.btnQues.UseVisualStyleBackColor = false;
            this.btnQues.Click += new System.EventHandler(this.btnQues_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.SystemColors.Info;
            this.btnStudents.Location = new System.Drawing.Point(54, 244);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(116, 46);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Student";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Lime;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCreate.Location = new System.Drawing.Point(206, 284);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(128, 49);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create Quiz";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnViewQuestions
            // 
            this.btnViewQuestions.BackColor = System.Drawing.SystemColors.Info;
            this.btnViewQuestions.Location = new System.Drawing.Point(46, 200);
            this.btnViewQuestions.Name = "btnViewQuestions";
            this.btnViewQuestions.Size = new System.Drawing.Size(116, 46);
            this.btnViewQuestions.TabIndex = 3;
            this.btnViewQuestions.Text = "View Questions";
            this.btnViewQuestions.UseVisualStyleBackColor = false;
            this.btnViewQuestions.Click += new System.EventHandler(this.btnViewQuestions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz.Properties.Resources.BCO1;
            this.ClientSize = new System.Drawing.Size(520, 345);
            this.Controls.Add(this.btnViewQuestions);
            this.Controls.Add(this.btnQues);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnCreate);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnQues;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnViewQuestions;
    }
}

