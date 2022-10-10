using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Intake
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Intakeid { get; set; }

        public string IntakeName { get; set; }

        public virtual BranchDetails BranchDetails { get; set; }

    }
}
