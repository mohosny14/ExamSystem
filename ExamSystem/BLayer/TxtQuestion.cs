using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class TxtQuestion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TxtId { get; set; }
        public string TxtContent { get; set; }
        public string TxtBestAnswer { get; set; }

        public int FullDegree { get; set; }
        public int crsid { get; set; }

        [ForeignKey("crsid")]
        public virtual Course Course { get; set; }
        public ExamQuestion ExamQuestion { get; set; }

        public TxtQuestion ( int Txtid, string TxtContent, string TxtBestAnswer, int FullDegree, int crsid)
        {
            this.crsid = crsid;
            this.FullDegree = FullDegree;
            this.TxtBestAnswer = TxtBestAnswer;
            this.TxtContent = TxtContent;
            this.TxtId = Txtid;
        }



    }
}
