using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamSystem
{
    public class MCQuestion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int McqId { get; set; }
        public string McqContent { get; set; }
        public string McqCorrectChoise { get; set; }
        public int McqFullDegree { get; set; }
        public string Choise1 { get; set; }
        public string Choise2 { get; set; }
        public string Choise3 { get; set; }

        
        public int CrsId { get; set; }

        [ForeignKey("CrsId")]
        public Course Corseid { get; set; }

        public ExamQuestion ExamQuestion { get; set; }



    }
}
