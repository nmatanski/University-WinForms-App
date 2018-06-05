using DAL.Database;
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
        public StudentsData StudentsForm { get; set; } = new StudentsData();

        public MainForm()
        {
            InitializeComponent();

            var db = new AppDbContext();
        }

        private void ftsMenuItemAddStudent_Click(object sender, EventArgs e)
        {

        }

        private void ftsMenuItemShowStudents_Click(object sender, EventArgs e)
        {
            StudentsForm.Show();
        }
    }
}
