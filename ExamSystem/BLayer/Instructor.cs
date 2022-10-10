using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Instructor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InsId { get; set; }

        public string InsName { get; set; }
        public string InsUserName { get; set; }
        public string InsPassword { get; set; }
        public int? SuperId { get; set; }


        [ForeignKey("SuperId")]
        public virtual Instructor Manager { get; set; }

        public Instructor( int Insid, string InsName, string InsUserName, string InsPassword, int Superid)
        {
            this.InsId=Insid;
            this.InsName=InsName;
            this.InsUserName=InsUserName;
            this.InsPassword=InsPassword;
            this.SuperId=Superid;
        }

    }
}
