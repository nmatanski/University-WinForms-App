using DAL.Database;
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
    public partial class MainForm : Form
    {
        private AppDbContext db;
        private StudentSubjectManager studentSubjectManager;

        public StudentsData StudentsForm { get; set; } = new StudentsData();

        public StudentCreation StudentCreationForm { get; set; }

        public MainForm()
        {
            InitializeComponent();

            db = new AppDbContext();

            studentSubjectManager = new StudentSubjectManager();

            RefreshTable();
            //dgvStudents.Columns.Add(new DataGridViewColumn
            //{
            //    HeaderText = "Имена на студент",
            //    Width = 350,
            //});
            //dgvStudents.Columns.Add(new DataGridViewColumn
            //{
            //    HeaderText = "Факултетен номер",
            //    Width = 350,
            //});
            //dgvStudents.Columns.Add(new DataGridViewColumn
            //{
            //    HeaderText = "ЕГН",
            //    Width = 350,
            //});
            //dgvStudents.Columns.Add(new DataGridViewColumn
            //{
            //    HeaderText = "E-mail",
            //    Width = 350,
            //});
        }

        public void RefreshTable()
        {
            dgvStudents.DataSource = studentSubjectManager.GetAllStudents();
            dgvStudents.Refresh();
        }

        private void ftsMenuItemAddStudent_Click(object sender, EventArgs e)
        {
            StudentCreationForm = new StudentCreation(this);
            StudentCreationForm.Show();
        }

        private void ftsMenuItemShowStudents_Click(object sender, EventArgs e)
        {
            StudentsForm.Show();
        }
    }
}
