namespace University
{
    partial class StudentCreation
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFacultyNumber = new System.Windows.Forms.TextBox();
            this.txtUCV = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(54, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 31);
            this.txtName.TabIndex = 0;
            // 
            // txtFacultyNumber
            // 
            this.txtFacultyNumber.AcceptsReturn = true;
            this.txtFacultyNumber.Location = new System.Drawing.Point(588, 65);
            this.txtFacultyNumber.Name = "txtFacultyNumber";
            this.txtFacultyNumber.Size = new System.Drawing.Size(400, 31);
            this.txtFacultyNumber.TabIndex = 1;
            // 
            // txtUCV
            // 
            this.txtUCV.Location = new System.Drawing.Point(54, 161);
            this.txtUCV.Name = "txtUCV";
            this.txtUCV.Size = new System.Drawing.Size(400, 31);
            this.txtUCV.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(588, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 31);
            this.txtEmail.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(444, 243);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 50);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // StudentCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 376);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUCV);
            this.Controls.Add(this.txtFacultyNumber);
            this.Controls.Add(this.txtName);
            this.Name = "StudentCreation";
            this.Text = "StudentCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFacultyNumber;
        private System.Windows.Forms.TextBox txtUCV;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCreate;
    }
}