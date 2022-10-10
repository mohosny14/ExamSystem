using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Context : DbContext
    {
        public Context() : base(@"Data Source=.;Initial Catalog=ExamSystemDB;Integrated Security=true;")
        { }

        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BranchDetails> BranchDetails { get; set; }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Exam> Exams { get; set; }


        public virtual DbSet<ExamQuestion> ExamQuestions { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }

        public virtual DbSet<Intake> Intakes { get; set; }

        public virtual DbSet<MCQuestion> MCQuestions { get; set; }
        public virtual DbSet<StdAnswers> StdAnswers { get; set; }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentExam> StudentExams { get; set; }
        public virtual DbSet<TFQuestion> TFQuestions { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<TxtQuestion> TxtQuestions { get; set; }


    }

}

