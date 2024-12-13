using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba7.Laba7;

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
                "Институт точных наук и информационных технологий",
                "Институт экономики",
                "Институт права"
            });

            // Заполнение ComboBox для Specification
            comboBoxSpecification.Items.AddRange(new string[]
            {
                "Прикладная информатика",
                "Экономика",
                "Юриспруденция"
            });

            // Инициализация DataGridView
            dataGridViewStudents.AutoGenerateColumns = true; // Автоматическое создание столбцов
            UpdateDataGridView(); // Обновление отображения данных
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRecordBook.Text) ||
                string.IsNullOrEmpty(txtFullName.Text) ||
                comboBoxDepartment.SelectedIndex == -1 ||
                comboBoxSpecification.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtGroup.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

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
            dataGridViewStudents.DataSource = null; // Сброс источника данных
            dataGridViewStudents.DataSource = students; // Установка нового источника данных
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