using StudentService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSubjectService.Domain
{
    public interface IStudentSubject
    {
        List<Student> GetAllStudents();
        List<Subject> GetAllSubjects();
        Student GetStudentByFacultyNumber(string facultyNumber);
        Subject GetSubjectByTitle(string subjectTitle);
        List<Subject> GetAllSubjectsByStudent(string facultyNumber);
        List<Student> GetAllStudentsBySubject(string subjectTitle);
        void AddSubjectToStudent(string facultyNumber, string subjectTitle, string lecturerName = null);
        void LinkExistingStudentAndSubject(string facultyNumber, string subjectTitle);
        void DeleteLinkBetweenStudentAndSubject(string facultyNumber, string subjectTitle);
    }
}
