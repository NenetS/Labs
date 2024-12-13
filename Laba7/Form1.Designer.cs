namespace Laba7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecordBook = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSpecification = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateOfAdmission = new System.Windows.Forms.DateTimePicker();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1265, 316);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Info";
            // 
            // txtRecordBook
            // 
            this.txtRecordBook.Location = new System.Drawing.Point(34, 364);
            this.txtRecordBook.Multiline = true;
            this.txtRecordBook.Name = "txtRecordBook";
            this.txtRecordBook.Size = new System.Drawing.Size(229, 56);
            this.txtRecordBook.TabIndex = 2;
            this.txtRecordBook.Text = "Record book #\r\n\r\nСюда вводи:\r\n";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(34, 442);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(229, 57);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.Text = "Full Name\r\n\r\nВот здесь:";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(316, 396);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(229, 24);
            this.comboBoxDepartment.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Department";
            // 
            // comboBoxSpecification
            // 
            this.comboBoxSpecification.FormattingEnabled = true;
            this.comboBoxSpecification.Location = new System.Drawing.Point(316, 474);
            this.comboBoxSpecification.Name = "comboBoxSpecification";
            this.comboBoxSpecification.Size = new System.Drawing.Size(229, 24);
            this.comboBoxSpecification.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Specification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date of admission";
            // 
            // dtpDateOfAdmission
            // 
            this.dtpDateOfAdmission.Location = new System.Drawing.Point(691, 398);
            this.dtpDateOfAdmission.Name = "dtpDateOfAdmission";
            this.dtpDateOfAdmission.Size = new System.Drawing.Size(200, 22);
            this.dtpDateOfAdmission.TabIndex = 9;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(691, 442);
            this.txtGroup.Multiline = true;
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(229, 57);
            this.txtGroup.TabIndex = 10;
            this.txtGroup.Text = "Group #\r\n\r\nСюда:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1088, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1088, 419);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1088, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 564);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.dtpDateOfAdmission);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSpecification);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtRecordBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "Form1";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecordBook;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSpecification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateOfAdmission;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

