using System;
using System.ComponentModel.DataAnnotations;

namespace ExamSystem
{
    public class StdAnswers
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 10)]
        public int QstId { get; set; }

        [Key]
        [Column(Order = 20)]
        public string QstType { get; set; }
        public string StdAnswer { get; set; }
        [Key]
        [Column(Order = 30)]
        public int StdID { get; set; }
        public int ExamId { get; set; }
        public int StdDegree { get; set; }
        public DateTime Time { get; set; }

        public Student student { get; set; }
    }
}
