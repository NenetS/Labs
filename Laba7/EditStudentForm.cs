using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba7
{
    public partial class EditStudentForm : Form
    {
        public Student Student { get; private set; }
        public EditStudentForm(Student student)
        {
            InitializeComponent();
            Student = student;

            // Заполнение полей данными студента
            txtRecordBook.Text = student.RecordBook;
            txtFullName.Text = student.FullName;
            comboBoxDepartment.SelectedItem = student.Department;
            comboBoxSpecification.SelectedItem = student.Specification;
            dtpDateOfAdmission.Value = student.DateOfAdmission;
            txtGroup.Text = student.Group;
        }

        public EditStudentForm()
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Обновление данных студента
            Student.RecordBook = txtRecordBook.Text;
            Student.FullName = txtFullName.Text;
            Student.Department = comboBoxDepartment.SelectedItem.ToString();
            Student.Specification = comboBoxSpecification.SelectedItem.ToString();
            Student.DateOfAdmission = dtpDateOfAdmission.Value;
            Student.Group = txtGroup.Text;

            this.DialogResult = DialogResult.OK; // Успешное завершение
            this.Close(); // Закрытие формы
        }
    }
}