using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Branch
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Branchid { get; set; }
        public string BranchName { get; set; }

        public virtual BranchDetails BranchDetails { get; set; }

    }
}
