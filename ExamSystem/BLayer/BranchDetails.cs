using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class BranchDetails
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int Deptid { get; set; }
        public int Intakeid { get; set; }
        public int Branchid { get; set; }
        public int Trackid { get; set; }
        public int Crsid { get; set; }
        public int StdId { get; set; }

        public virtual ICollection<Department> Departments { get; set; }

        public virtual ICollection<Intake> Intakes { get; set; }

        public virtual ICollection<Branch> Branches { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }



        public virtual ICollection<Student> Students { get; set; }

        //public BranchDetails(int id, int Deptid, int Intakeid, int Branchid, int Trackid, int Crsid, int Stdid)
        //{
        //  this.id=id;
        //    this.Deptid=Deptid;
        //    this.Intakeid=Intakeid;
        //    this.Branchid=Branchid;
        //    this.Trackid=Trackid;
        //    this.Crsid=Crsid;
        //    this.Stdid=Stdid;
        // }

    }
}
