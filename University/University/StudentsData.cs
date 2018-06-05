using DAL.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class StudentsData : Form
    {
        private AppDbContext db;
        public StudentsData()
        {
            InitializeComponent();
            db = new AppDbContext();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void StudentsData_Load(object sender, EventArgs e)
        {
            var table = new DataTable();
            BindingSource source = new BindingSource();
            source.DataSource = db.Students.Local.ToBindingList();
            dataGridViewStudents.DataSource = source;
            dataGridViewStudents.Refresh();
        }
    }
}
