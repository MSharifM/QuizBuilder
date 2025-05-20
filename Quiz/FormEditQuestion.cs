using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class FormEditQuestion: Form
    {
        Question Question { get; set; }
        public FormEditQuestion(Question question)
        {
            InitializeComponent();
            Question = question;
        }

        private void FormEditQuestion_Load(object sender, EventArgs e)
        {

        }
    }
}
