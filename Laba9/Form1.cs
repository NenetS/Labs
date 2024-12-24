using System;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Xml.Serialization;
using System.Xml;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Laba9
{
    public partial class Form1 : Form
    {
        private List<Data> originalData;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = new List<Data>();
        }

        public void OriginalDataUpdate(List<Data> BS)
        {
            originalData = BS;
            bindingSource1.DataSource = BS;
        }

        private void SaveToCSV(string filePath)
        {
            var configBS1 = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true
            };

            try
            {
                using (var sw = new StreamWriter(filePath))
                using (CsvWriter cw = new CsvWriter(sw, configBS1))
                {
                    cw.WriteRecords((IEnumerable)dataGridView1.DataSource);
                }
                MessageBox.Show("CVS файл сохранен.", "Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно сохранить CSV файл: " + ex.Message, "Ошибка");
            }
        }

        private void LoadFromCSV(string filePath)
        {
            var configBS2 = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true
            };

            try
            {
                using (var sr = new StreamReader(filePath))
                using (CsvReader cr = new CsvReader(sr, configBS2))
                {
                    OriginalDataUpdate(cr.GetRecords<Data>().ToList());
                }
                MessageBox.Show("CSV файл загружен.", "Успешно");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно загрузить CSV файл: " + ex.Message, "Ошибка");
            }
        }

        private void SaveToXML(string filePath)
        {
            try
            {
                List<Data> bindingSourceList = new List<Data>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Data teacher = new Data
                    {
                        fio = row.Cells[0].Value?.ToString(),
                        number = row.Cells[1].Value?.ToString(),
                        study = row.Cells[2].Value?.ToString(),
                    };
                    bindingSourceList.Add(teacher);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<Data>));
                using (TextWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, bindingSourceList);
                }

                MessageBox.Show("XML файл сохранен.", "Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно сохранить XML файл: " + ex.Message, "Ошибка");
            }
        }

        private void LoadFromXML(string filePath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                using (XmlReader reader = XmlReader.Create(fileStream))
                {
                    OriginalDataUpdate((List<Data>)new XmlSerializer(typeof(List<Data>)).Deserialize(reader));
                }

                MessageBox.Show("XML файл загружен.", "Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке XML файла: " + ex.Message, "Ошибка");
            }
        }

        private void SaveToJson(string filePath)
        {
            try
            {
                string json;
                using (StringWriter sw = new StringWriter())
                {
                    using (JsonWriter jw = new JsonTextWriter(sw))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(jw, dataGridView1.DataSource);
                    }
                    json = sw.ToString();
                }

                File.WriteAllText(filePath, json);

                MessageBox.Show("JSON файл сохранен.", "Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно сохранить JSON файл: " + ex.Message, "Ошибка");
            }
        }

        private void LoadFromJson(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                List<Data> data = JsonConvert.DeserializeObject<List<Data>>(json);
                OriginalDataUpdate(data);

                MessageBox.Show("JSON файл загружен.", "Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке JSON файла: " + ex.Message, "Ошибка");
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml|JSON files (*.json)|*.json" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                if (bindingSource1 == null)
                    throw new ArgumentNullException(nameof(bindingSource1));

                if (string.IsNullOrWhiteSpace(filePath))
                    throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));

                if (filePath.EndsWith(".csv"))
                    SaveToCSV(filePath);
                else if (filePath.EndsWith(".xml"))
                    SaveToXML(filePath);
                else if (filePath.EndsWith(".json"))
                    SaveToJson(filePath);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml|JSON files (*.json)|*.json" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                if (bindingSource1 == null)
                    throw new ArgumentNullException(nameof(bindingSource1));

                if (string.IsNullOrWhiteSpace(filePath))
                    throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));

                if (filePath.EndsWith(".csv"))
                    LoadFromCSV(filePath);
                else if (filePath.EndsWith(".xml"))
                    LoadFromXML(filePath);
                else if (filePath.EndsWith(".json"))
                    LoadFromJson(filePath);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this, bindingSource1);
            addForm.ShowDialog();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                DataSending(selectedRow);
            }
            else if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                DataSending(selectedRow);
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();

                foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                {
                    rowsToDelete.Add(selectedRow);
                }

                // Удаляем строки
                foreach (DataGridViewRow row in rowsToDelete)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент для удаления.");
            }
        }

        public void DataSending(DataGridViewRow selectedRow)
        {
            Change changeForm = new Change(this, selectedRow, bindingSource1);
            changeForm.fioTextBox.Text = selectedRow.Cells[0].Value?.ToString();
            changeForm.NumberTextBox.Text = selectedRow.Cells[1].Value?.ToString();
            changeForm.StudyTextBox.Text = selectedRow.Cells[2].Value?.ToString();
            changeForm.ShowDialog();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text.ToLower();

            List<Data> filteredStudentList = originalData.Where(student =>
                student.fio.ToLower().Contains(searchText) ||
                student.number.ToLower().Contains(searchText) ||
                student.study.ToLower().Contains(searchText)
            ).ToList();

            bindingSource1.DataSource = filteredStudentList;
        }

    }
}
