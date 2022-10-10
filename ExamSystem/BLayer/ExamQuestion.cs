using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class ExamQuestion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        //fk for Exam
        public int ExamId { get; set; }
        public int CrsId { get; set; }
        public int McqId { get; set; }
        public int TfqId { get; set; }
        public int TxtId { get; set; }
        public int QstDegree { get; set; }
        public string QstType { get; set; }

        public ICollection<Exam> Exams { get; set; }

        public ICollection<TFQuestion> TfQuestions { get; set; }

        public ICollection<MCQuestion> MCQuestions { get; set; }

        public ICollection<TxtQuestion> TxtQuestions { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
