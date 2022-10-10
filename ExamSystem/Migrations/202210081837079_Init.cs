namespace ExamSystem.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("TFQuestionCourses", "TFQuestion_TfqId", "TFQuestions");
            DropForeignKey("TFQuestionCourses", "Course_CrsId", "Courses");
            DropIndex("TFQuestionCourses", new[] { "TFQuestion_TfqId" });
            DropIndex("TFQuestionCourses", new[] { "Course_CrsId" });
            AddForeignKey("Courses", "InsId", "Instructors", "InsId", cascadeDelete: true);
            AddForeignKey("TFQuestions", "CrsId", "Courses", "CrsId", cascadeDelete: true);
            CreateIndex("Courses", "InsId");
            CreateIndex("TFQuestions", "CrsId");
            DropTable("TFQuestionCourses");
        }
        
        public override void Down()
        {
            CreateTable(
                "TFQuestionCourses",
                c => new
                    {
                        TFQuestion_TfqId = c.Int(nullable: false),
                        Course_CrsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TFQuestion_TfqId, t.Course_CrsId });
            
            DropIndex("TFQuestions", new[] { "CrsId" });
            DropIndex("Courses", new[] { "InsId" });
            DropForeignKey("TFQuestions", "CrsId", "Courses");
            DropForeignKey("Courses", "InsId", "Instructors");
            CreateIndex("TFQuestionCourses", "Course_CrsId");
            CreateIndex("TFQuestionCourses", "TFQuestion_TfqId");
            AddForeignKey("TFQuestionCourses", "Course_CrsId", "Courses", "CrsId", cascadeDelete: true);
            AddForeignKey("TFQuestionCourses", "TFQuestion_TfqId", "TFQuestions", "TfqId", cascadeDelete: true);
        }
    }
}
