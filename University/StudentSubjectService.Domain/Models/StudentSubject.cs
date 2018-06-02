using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.Domain.Models
{
    public class StudentSubject
    {
        [Key, Column(Order = 0)]
        public string StudentID { get; private set; }

        [Key, Column(Order = 1)]
        public string SubjectID { get; private set; }

        public virtual Student Student { get; set; }

        public virtual Subject Subject { get; set; }


    }
}
