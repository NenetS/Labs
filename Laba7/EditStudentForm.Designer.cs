namespace Laba7
{
    partial class EditStudentForm
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
            this.txtRecordBook = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecification = new System.Windows.Forms.ComboBox();
            this.dtpDateOfAdmission = new System.Windows.Forms.DateTimePicker();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRecordBook
            // 
            this.txtRecordBook.Location = new System.Drawing.Point(54, 39);
            this.txtRecordBook.Name = "txtRecordBook";
            this.txtRecordBook.Size = new System.Drawing.Size(229, 22);
            this.txtRecordBook.TabIndex = 3;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(54, 144);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(229, 22);
            this.txtFullName.TabIndex = 4;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Items.AddRange(new object[] {
            "Институт точных наук и информационных технологий",
            "Институт права",
            "Институт экономики"});
            this.comboBoxDepartment.Location = new System.Drawing.Point(54, 238);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(229, 24);
            this.comboBoxDepartment.TabIndex = 5;
            // 
            // comboBoxSpecification
            // 
            this.comboBoxSpecification.FormattingEnabled = true;
            this.comboBoxSpecification.Items.AddRange(new object[] {
            "Прикладная информатика",
            "Экономика",
            "Юриспруденция"});
            this.comboBoxSpecification.Location = new System.Drawing.Point(54, 349);
            this.comboBoxSpecification.Name = "comboBoxSpecification";
            this.comboBoxSpecification.Size = new System.Drawing.Size(229, 24);
            this.comboBoxSpecification.TabIndex = 7;
            // 
            // dtpDateOfAdmission
            // 
            this.dtpDateOfAdmission.Location = new System.Drawing.Point(431, 39);
            this.dtpDateOfAdmission.Name = "dtpDateOfAdmission";
            this.dtpDateOfAdmission.Size = new System.Drawing.Size(229, 22);
            this.dtpDateOfAdmission.TabIndex = 10;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(431, 144);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(229, 22);
            this.txtGroup.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(585, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.dtpDateOfAdmission);
            this.Controls.Add(this.comboBoxSpecification);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtRecordBook);
            this.Name = "EditStudentForm";
            this.Text = "EditStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecordBook;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxSpecification;
        private System.Windows.Forms.DateTimePicker dtpDateOfAdmission;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Button btnSave;
    }
}