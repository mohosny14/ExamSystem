using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class StudentExam
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int ExamId { get; set; }
        public int StdId { get; set; }
        public int result { get; set; }


        public virtual ICollection<Exam> Exams { get; set; }

        public virtual ICollection<Student> Students { get; set; }


    }
}
