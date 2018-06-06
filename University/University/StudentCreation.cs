using DAL.Database;
using StudentService.Domain.Models;
using StudentSubjectService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class StudentCreation : Form
    {
        private StudentSubjectManager studentSubjectManager;

        private MainForm parent;

        public StudentCreation(MainForm parent)
        {
            InitializeComponent();

            this.parent = parent;

            studentSubjectManager = new StudentSubjectManager();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                Name = txtName.Text,
                FacultyNumber = txtFacultyNumber.Text,
                UCV = txtUCV.Text,
                Email = txtEmail.Text
            };

            studentSubjectManager.CreateNewStudent(student);

            parent.RefreshTable();
            Dispose();
        }
    }
}
