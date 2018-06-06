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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.ftsMenuItemAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
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
            this.ftsMenuItemAddStudent,
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
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToOrderColumns = true;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(26, 64);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowTemplate.Height = 33;
            this.dgvStudents.Size = new System.Drawing.Size(1870, 152);
            this.dgvStudents.TabIndex = 1;
            // 
            // ftsMenuItemAddStudent
            // 
            this.ftsMenuItemAddStudent.Name = "ftsMenuItemAddStudent";
            this.ftsMenuItemAddStudent.Size = new System.Drawing.Size(324, 38);
            this.ftsMenuItemAddStudent.Text = "Add Student";
            this.ftsMenuItemAddStudent.Click += new System.EventHandler(this.ftsMenuItemAddStudent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1952, 1044);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University app";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.ToolStripMenuItem ftsMenuItemAddStudent;
    }
}

