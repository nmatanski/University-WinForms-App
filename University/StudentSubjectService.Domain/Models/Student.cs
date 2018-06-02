using Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.Domain.Models
{
    public class Student
    {
        private CustomId _id;

        [Key]
        public string StudentID
        {
            get { return _id.ToString(); }
            private set { _id = new CustomId(new Guid(value)); }
        }

        public string Name { get; set; }

        public string FacultyNumber { get; set; }

        public string UCV { get; set; } // Unique citizenship number (ЕГН)

        public string Email { get; set; }

        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }

    }
}
