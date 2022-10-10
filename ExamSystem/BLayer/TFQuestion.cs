using System.ComponentModel.DataAnnotations;

namespace ExamSystem
{
    public class TFQuestion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TfqId { get; set; }
        public string TfqContent { get; set; }
        [Required]
        public string TfqCorrectAnswer { get; set; }
        public int TfqFullDegree { get; set; }

        public int CrsId { get; set; }

        public ExamQuestion ExamQuestion { get; set; }

        [ForeignKey("CrsId")]
        public Course Course { get; set; }
    }
}
