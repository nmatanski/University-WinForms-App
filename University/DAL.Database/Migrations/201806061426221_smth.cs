namespace DAL.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class smth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentSubjects", "StudentID", "dbo.Students");
            DropForeignKey("dbo.StudentSubjects", "SubjectID", "dbo.Subjects");
            DropIndex("dbo.StudentSubjects", new[] { "StudentID" });
            DropIndex("dbo.StudentSubjects", new[] { "SubjectID" });
            DropPrimaryKey("dbo.Students");
            DropPrimaryKey("dbo.Subjects");
            AddColumn("dbo.StudentSubjects", "Student_StudentID", c => c.Int());
            AddColumn("dbo.StudentSubjects", "Subject_SubjectID", c => c.Int());
            AlterColumn("dbo.Students", "StudentID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Subjects", "SubjectID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Students", "StudentID");
            AddPrimaryKey("dbo.Subjects", "SubjectID");
            CreateIndex("dbo.StudentSubjects", "Student_StudentID");
            CreateIndex("dbo.StudentSubjects", "Subject_SubjectID");
            AddForeignKey("dbo.StudentSubjects", "Student_StudentID", "dbo.Students", "StudentID");
            AddForeignKey("dbo.StudentSubjects", "Subject_SubjectID", "dbo.Subjects", "SubjectID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentSubjects", "Subject_SubjectID", "dbo.Subjects");
            DropForeignKey("dbo.StudentSubjects", "Student_StudentID", "dbo.Students");
            DropIndex("dbo.StudentSubjects", new[] { "Subject_SubjectID" });
            DropIndex("dbo.StudentSubjects", new[] { "Student_StudentID" });
            DropPrimaryKey("dbo.Subjects");
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Subjects", "SubjectID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Students", "StudentID", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.StudentSubjects", "Subject_SubjectID");
            DropColumn("dbo.StudentSubjects", "Student_StudentID");
            AddPrimaryKey("dbo.Subjects", "SubjectID");
            AddPrimaryKey("dbo.Students", "StudentID");
            CreateIndex("dbo.StudentSubjects", "SubjectID");
            CreateIndex("dbo.StudentSubjects", "StudentID");
            AddForeignKey("dbo.StudentSubjects", "SubjectID", "dbo.Subjects", "SubjectID", cascadeDelete: true);
            AddForeignKey("dbo.StudentSubjects", "StudentID", "dbo.Students", "StudentID", cascadeDelete: true);
        }
    }
}
