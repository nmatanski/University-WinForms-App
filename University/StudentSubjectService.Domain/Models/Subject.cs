using Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.Domain.Models
{
    public class Subject
    {
        //private CustomId _id;

        [Key]
        public int SubjectID
        {
            //get { return _id.ToString(); }
            //private set { _id = new CustomId(new Guid(value)); }
            get;set;
        }

        public string Title { get; set; }

        public string LecturerName { get; set; }

        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }

    }
}
