using DAL.Database;
using StudentService.Domain.Models;
using StudentSubjectService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSubjectService
{
    public class StudentSubjectManager : IStudentSubject
    {
        private readonly AppDbContext db;

        public StudentSubjectManager()
        {
            db = new AppDbContext();
        }

        public List<Subject> GetAllSubjectsByStudent(string facultyNumber)
        {
            return db.StudentSubjects.Where(ss => ss.Student.FacultyNumber == facultyNumber).Select(ss => ss.Subject).ToList();
        }

        public List<Student> GetAllStudentsBySubject(string subjectTitle)
        {
            return db.StudentSubjects.Where(ss => ss.Subject.Title == subjectTitle).Select(ss => ss.Student).ToList();
        }

        public void AddSubjectToStudent(string facultyNumber, string subjectTitle, string lecturerName = null)
        {
            var student = db.Students.Where(s => s.FacultyNumber == facultyNumber).SingleOrDefault();
            if (student == null)
                return;
            var subject = db.Subjects.Where(s => s.Title == subjectTitle).SingleOrDefault();
            if (subject == null)
                subject = new Subject { Title = subjectTitle, LecturerName = lecturerName };
            db.StudentSubjects.Add(new StudentSubject { Student = student, Subject = subject });
            db.SaveChanges();
        }

        public void LinkExistingStudentAndSubject(string facultyNumber, string subjectTitle)
        {
            var student = db.Students.Where(s => s.FacultyNumber == facultyNumber).SingleOrDefault();
            var subject = db.Subjects.Where(s => s.Title == subjectTitle).SingleOrDefault();
            if (student == null || subject == null)
                return;
            db.StudentSubjects.Add(new StudentSubject { Student = student, Subject = subject });
            db.SaveChanges();
        }

        public void DeleteLinkBetweenStudentAndSubject(string facultyNumber, string subjectTitle)
        {
            var studentSubject = db.StudentSubjects.Where(ss => ss.Student.FacultyNumber == facultyNumber && ss.Subject.Title == subjectTitle).SingleOrDefault();
            if (studentSubject == null)
                return;
            db.StudentSubjects.Remove(studentSubject);
            db.SaveChanges();
        }
    }
}
