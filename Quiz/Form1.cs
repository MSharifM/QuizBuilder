using SelectPdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public List<Question> Questions { get; set; }
        public List<string> Students { get; set; }

        public Form1()
        {
            InitializeComponent();
            Questions = new List<Question>();
            Students = new List<string>();
        }

        private void btnQues_Click(object sender, EventArgs e)
        {
            #region Read questions from file

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string pathFileQuestions = openFileDialog1.FileName;
                using (var stream = new StreamReader(pathFileQuestions))
                {
                    while (!stream.EndOfStream)
                    {
                        var title = stream.ReadLine();
                        Dictionary<string, bool> options = new Dictionary<string, bool>();

                        for (int i = 0; i < 4; i++)
                        {
                            var optionText = stream.ReadLine();
                            options.Add(optionText, false);
                        }

                        int correctOption = int.Parse(stream.ReadLine()) - 1;
                        var correctKey = options.Keys.ElementAt(correctOption);
                        options[correctKey] = true;

                        Question question = new Question()
                        {
                            Title = title,
                            Options = options
                        };

                        Questions.Add(question);
                    }
                }
            }

            #endregion
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string pathFileQuestions = openFileDialog1.FileName;
                using (var stream = new StreamReader(pathFileQuestions))
                {
                    while (!stream.EndOfStream)
                    {
                        var name = stream.ReadLine();
                        Students.Add(name);
                    }
                }
            }
        }

        public List<Question> Randomize(List<Question> questions)
        {
            Random random = new Random();
            questions = questions.OrderBy(x => random.Next()).ToList();
            return questions;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string folderSavePath = folderBrowserDialog1.SelectedPath;

                if (Questions.Count == 0)
                {
                    MessageBox.Show("لطفا سوالات را وارد کنید");
                    return;
                }
                else if (Students.Count == 0)
                {
                    MessageBox.Show("لطفا نام دانش آموزان را وارد کنید");
                    return;
                }
                else
                {
                    #region Create html file and key file

                    for (int i = 0; i < Students.Count; i++)
                    {
                        string path = folderSavePath + Students[i] + ".html";

                        #region Create html and Key file

                        Questions = Randomize(Questions);
                        string pathKey = "C:\\Hassan\\Project\\New folder (2)\\New folder\\" + Students[i] + "key.txt";

                        using (var stream = new StreamWriter(path))
                        {
                            using (var streamKey = new StreamWriter(pathKey))
                            {
                                stream.WriteLine("<!DOCTYPE html>\r\n<html lang=\"fa\" dir=\"rtl\">\r\n<head>\r\n    <meta charset=\"UTF-8\"/>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n</head>\r\n    <body style=\"font-family: 'vazir';\">");
                                stream.WriteLine("<h1 style=\"color: red; text-align: center;\"><i>" + "سوالات " + Students[i] + "</i></h1>");
                                stream.WriteLine("<br>");
                                stream.WriteLine("<hr style=\"border: 1px solid red;\">");

                                int count = 1;
                                foreach (var question in Questions)
                                {
                                    stream.WriteLine("<h2><b>" + count + "- " + question.Title + "</b></h2>");

                                    Random random = new Random();
                                    question.Options = question.Options.OrderBy(x => random.Next()).ToDictionary(x => x.Key, x => x.Value);
                                    var randomOptionsKey = question.Options.Keys.ToList();
                                    var randomOptionsValue = question.Options.Values.ToList();

                                    int correctOption = 0;


                                    for (int j = 1; j < 5; j++)
                                    {
                                        stream.WriteLine($"<h4 style=\"color: blue;\">" + j + ") " + randomOptionsKey[j - 1] + "</h4>");

                                        if (randomOptionsValue[j - 1] == true)
                                        {
                                            correctOption = j;
                                        }
                                    }
                                    stream.WriteLine("<br>");
                                    stream.WriteLine("<hr>");

                                    streamKey.WriteLine(count + "- " + correctOption);
                                    count++;
                                }
                                stream.WriteLine("</body>\r\n</html>\r\n");
                            }
                        }

                        #endregion

                        HtmlToPdf converter = new HtmlToPdf();
                        PdfDocument doc = converter.ConvertUrl(path);

                        string pathPdf = "C:\\Hassan\\Project\\New folder (2)\\New folder\\" + Students[i] + ".pdf";
                        doc.Save(pathPdf);
                        File.Delete(path);

                        doc.Close();
                    }





                    #endregion
                }
            }
        }

        private void btnViewQuestions_Click(object sender, EventArgs e)
        {
            Form form = new FormListQuestions(Questions);
            form.ShowDialog();
        }
    }
}
