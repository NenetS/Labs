using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba9
{
    public partial class Change : Form
    {
        private Form1 Form1;
        private DataGridView SelectedRow;
        private DataGridViewRow selectedRow;
        private BindingSource BindingSource1;
        public Change(Form1 form, DataGridView selectedRow, BindingSource bindingSource1)
        {
            InitializeComponent();
            Form1 = form;
            SelectedRow = selectedRow;
            BindingSource1 = bindingSource1;
        }

        public Change(Form1 form1, DataGridViewRow selectedRow, BindingSource bindingSource1)
        {
            InitializeComponent();
            Form1 = form1;
            this.selectedRow = selectedRow;
            BindingSource1 = bindingSource1;
        }

        private void Ok_Click_1(object sender, EventArgs e)
        {
            Data newData = new Data
            {
                fio = fioTextBox.Text,
                number = NumberTextBox.Text,
                study = StudyTextBox.Text,
            };

            BindingSource1[selectedRow.Index] = newData;
            Form1.OriginalDataUpdate((List<Data>)BindingSource1.DataSource);

            this.Close();
        }
    }
}
