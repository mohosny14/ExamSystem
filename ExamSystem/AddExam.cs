using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class AddExam : Form
    {
        Context db = new Context();
        public AddExam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam()
            {
                StartTime = dateTimePicker1.Value,
                EndTime = dateTimePicker2.Value,
                IsCorrective = checkBox1.Checked
            };
            db.Exams.Add(exam);
            db.SaveChanges();
            // to display Exam ID for Instructor 
            MessageBox.Show($"New Exam Added! & Exam Id  = {exam.ExamId}");
        }
    }
}
