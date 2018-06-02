namespace DAL.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        FacultyNumber = c.String(),
                        UCV = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.StudentSubjects",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        SubjectID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.StudentID, t.SubjectID })
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.SubjectID);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectID = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        LecturerName = c.String(),
                    })
                .PrimaryKey(t => t.SubjectID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentSubjects", "SubjectID", "dbo.Subjects");
            DropForeignKey("dbo.StudentSubjects", "StudentID", "dbo.Students");
            DropIndex("dbo.StudentSubjects", new[] { "SubjectID" });
            DropIndex("dbo.StudentSubjects", new[] { "StudentID" });
            DropTable("dbo.Subjects");
            DropTable("dbo.StudentSubjects");
            DropTable("dbo.Students");
        }
    }
}
