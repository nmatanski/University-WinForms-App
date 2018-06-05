namespace University
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsDropDownBtnStudent = new System.Windows.Forms.ToolStripDropDownButton();
            this.ftsMenuItemShowStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDropDownButtonSubject = new System.Windows.Forms.ToolStripDropDownButton();
            this.ftsMenuItemAddStudentsToSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.ftsMenuItemShowSubjects = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDropDownBtnStudent,
            this.tsDropDownButtonSubject});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1952, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsDropDownBtnStudent
            // 
            this.tsDropDownBtnStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDropDownBtnStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ftsMenuItemShowStudents});
            this.tsDropDownBtnStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsDropDownBtnStudent.Image")));
            this.tsDropDownBtnStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDropDownBtnStudent.Name = "tsDropDownBtnStudent";
            this.tsDropDownBtnStudent.Size = new System.Drawing.Size(120, 36);
            this.tsDropDownBtnStudent.Text = "Student";
            // 
            // ftsMenuItemShowStudents
            // 
            this.ftsMenuItemShowStudents.Name = "ftsMenuItemShowStudents";
            this.ftsMenuItemShowStudents.Size = new System.Drawing.Size(324, 38);
            this.ftsMenuItemShowStudents.Text = "Edit Students";
            this.ftsMenuItemShowStudents.Click += new System.EventHandler(this.ftsMenuItemShowStudents_Click);
            // 
            // tsDropDownButtonSubject
            // 
            this.tsDropDownButtonSubject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDropDownButtonSubject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ftsMenuItemAddStudentsToSubject,
            this.ftsMenuItemShowSubjects});
            this.tsDropDownButtonSubject.Image = ((System.Drawing.Image)(resources.GetObject("tsDropDownButtonSubject.Image")));
            this.tsDropDownButtonSubject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDropDownButtonSubject.Name = "tsDropDownButtonSubject";
            this.tsDropDownButtonSubject.Size = new System.Drawing.Size(116, 36);
            this.tsDropDownButtonSubject.Text = "Subject";
            // 
            // ftsMenuItemAddStudentsToSubject
            // 
            this.ftsMenuItemAddStudentsToSubject.Name = "ftsMenuItemAddStudentsToSubject";
            this.ftsMenuItemAddStudentsToSubject.Size = new System.Drawing.Size(372, 38);
            this.ftsMenuItemAddStudentsToSubject.Text = "Add Students to Subject";
            // 
            // ftsMenuItemShowSubjects
            // 
            this.ftsMenuItemShowSubjects.Name = "ftsMenuItemShowSubjects";
            this.ftsMenuItemShowSubjects.Size = new System.Drawing.Size(372, 38);
            this.ftsMenuItemShowSubjects.Text = "Edit Subjects";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.FacultyNumber,
            this.UCV,
            this.Email});
            this.dataGridView1.Location = new System.Drawing.Point(26, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1870, 152);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Имена на студент";
            this.Column1.MinimumWidth = 270;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 270;
            // 
            // FacultyNumber
            // 
            this.FacultyNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FacultyNumber.HeaderText = "Факултетен номер";
            this.FacultyNumber.MinimumWidth = 260;
            this.FacultyNumber.Name = "FacultyNumber";
            this.FacultyNumber.ReadOnly = true;
            this.FacultyNumber.Width = 260;
            // 
            // UCV
            // 
            this.UCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UCV.HeaderText = "ЕГН";
            this.UCV.MinimumWidth = 260;
            this.UCV.Name = "UCV";
            this.UCV.ReadOnly = true;
            this.UCV.Width = 260;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Email.HeaderText = "E-mail";
            this.Email.MinimumWidth = 200;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1952, 1044);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University app";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsDropDownBtnStudent;
        private System.Windows.Forms.ToolStripMenuItem ftsMenuItemShowStudents;
        private System.Windows.Forms.ToolStripDropDownButton tsDropDownButtonSubject;
        private System.Windows.Forms.ToolStripMenuItem ftsMenuItemAddStudentsToSubject;
        private System.Windows.Forms.ToolStripMenuItem ftsMenuItemShowSubjects;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn UCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

