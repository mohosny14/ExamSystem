using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Deptid { get; set; }
        public string DeptName { get; set; }


        public virtual BranchDetails BranchDetails { get; set; }

    }
}
