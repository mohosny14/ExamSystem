using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Track
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trackid { get; set; }
        public string TrackName { get; set; }

        public virtual BranchDetails BranchDetails { get; set; }

    }

}
