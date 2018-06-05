namespace University
{
    partial class StudentsData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentFacultyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentUCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToOrderColumns = true;
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridViewStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.StudentFacultyNumber,
            this.StudentUCV,
            this.StudentEmail});
            this.dataGridViewStudents.Location = new System.Drawing.Point(28, 39);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowTemplate.Height = 33;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1870, 152);
            this.dataGridViewStudents.TabIndex = 0;
            this.dataGridViewStudents.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridViewStudents.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridViewStudents.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StudentName.HeaderText = "Имена на студент";
            this.StudentName.MinimumWidth = 270;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 270;
            // 
            // StudentFacultyNumber
            // 
            this.StudentFacultyNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StudentFacultyNumber.HeaderText = "Факултетен номер";
            this.StudentFacultyNumber.MinimumWidth = 260;
            this.StudentFacultyNumber.Name = "StudentFacultyNumber";
            this.StudentFacultyNumber.Width = 260;
            // 
            // StudentUCV
            // 
            this.StudentUCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StudentUCV.HeaderText = "ЕГН";
            this.StudentUCV.MinimumWidth = 260;
            this.StudentUCV.Name = "StudentUCV";
            this.StudentUCV.Width = 260;
            // 
            // StudentEmail
            // 
            this.StudentEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StudentEmail.HeaderText = "E-mail";
            this.StudentEmail.MinimumWidth = 200;
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.Width = 200;
            // 
            // StudentsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2082, 1078);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "StudentsData";
            this.Text = "StudentsData";
            this.Load += new System.EventHandler(this.StudentsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentFacultyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentUCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentEmail;
    }
}