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
    public partial class FormListQuestions : Form
    {
        List<Question> Questions { get; set; }
        public FormListQuestions(List<Question> questions)
        {
            InitializeComponent();
            Questions = questions;
        }

        private void FormListQuestions_Load(object sender, EventArgs e)
        {
            ShowListQuestions(Questions, dgvListQuestions);
        }

        private void dgvListQuestions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvListQuestions.Columns[e.ColumnIndex].Name == "Edit")
            {
                var id = dgvListQuestions.Rows[e.RowIndex].Cells["Number"].Value; 
                Form frm = new FormEditQuestion(Questions[int.Parse(id.ToString()) - 1]);
                frm.ShowDialog();
            }
            else if (dgvListQuestions.Columns[e.ColumnIndex].Name == "Delete")
            {
                var id = int.Parse(dgvListQuestions.Rows[e.RowIndex].Cells["Number"].Value.ToString()) -1 ;
                if(MessageBox.Show($"ایا از حذف {Questions[id].Title} مطمئنید؟","هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Questions.RemoveAt(int.Parse(id.ToString()));
                    ShowListQuestions(Questions, dgvListQuestions);
                }
            }
        }

        static void ShowListQuestions(List<Question> Questions , DataGridView dataGridView)
        {
            int row = 1;
            dataGridView.Rows.Clear();
            foreach (var question in Questions)
            {
                dataGridView.Rows.Add(row, question.Title);
                row++;
            }
        }
    }
}
