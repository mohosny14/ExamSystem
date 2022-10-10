using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CrsId { get; set; }
        public string CrsTitle { get; set; }
        public string CrsDesc { get; set; }
        public int CrsMinDegree { get; set; }
        public int CrsMaxDegree { get; set; }
        public int InsId { get; set; }

        [ForeignKey("InsId")]
        public virtual Instructor Instructor { get; set; }

        public virtual ICollection<TFQuestion> TFQuestions { get; set; }
        public virtual ICollection<TxtQuestion> TxtQuestions { get; set; }
        public virtual ICollection<MCQuestion> MCQuestions { get; set; }

    }
}
