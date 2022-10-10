using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StdId { get; set; }
        public string StdName { get; set; }
        public string StdEmail { get; set; }
        public String StdUserName { get; set; }
        public String StdPassword { get; set; }

        public virtual BranchDetails BranchDetails { get; set; }

    }
}
