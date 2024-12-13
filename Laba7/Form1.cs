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
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();

            // Заполнение ComboBox для Department
            comboBoxDepartment.Items.AddRange(new string[]
            {
            "Институт информационных технологий",
            "Институт экономики",
            "Институт права"
            });

            // Заполнение ComboBox для Specification
            comboBoxSpecification.Items.AddRange(new string[]
            {
            "Программная инженерия",
            "Экономика",
            "Юриспруденция"
            });

            dataGridViewStudents.DataSource = students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student(txtRecordBook.Text, txtFullName.Text,
                                       comboBoxDepartment.SelectedItem.ToString(),
                                       comboBoxSpecification.SelectedItem.ToString(),
                                       dtpDateOfAdmission.Value,
                                       txtGroup.Text);

            if (students.Any(s => s.RecordBook == student.RecordBook))
            {
                MessageBox.Show("Студент с таким номером зачетки уже существует.");
                return;
            }

            students.Add(student);
            UpdateDataGridView();
            ClearInputFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow != null)
            {
                var selectedStudent = (Student)dataGridViewStudents.CurrentRow.DataBoundItem;

                selectedStudent.FullName = txtFullName.Text;
                selectedStudent.Department = comboBoxDepartment.SelectedItem.ToString();
                selectedStudent.Specification = comboBoxSpecification.SelectedItem.ToString();
                selectedStudent.DateOfAdmission = dtpDateOfAdmission.Value;
                selectedStudent.Group = txtGroup.Text;

                UpdateDataGridView();
                ClearInputFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow != null)
            {
                var selectedStudent = (Student)dataGridViewStudents.CurrentRow.DataBoundItem;
                students.Remove(selectedStudent);
                UpdateDataGridView();
            }
        }

        private void UpdateDataGridView()
        {
            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = students;
        }

        private void ClearInputFields()
        {
            txtRecordBook.Clear();
            txtFullName.Clear();

            // Сброс значений ComboBox
            comboBoxDepartment.SelectedIndex = -1;
            comboBoxSpecification.SelectedIndex = -1;

            dtpDateOfAdmission.Value = DateTime.Now;
            txtGroup.Clear();
        }
    }
    }
}
