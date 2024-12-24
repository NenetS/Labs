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
    public partial class AddForm : Form
    {
        private Form1 Form1;
        private BindingSource BindingSource1;
        public AddForm(Form1 form, BindingSource bindingSource1)
        {
            InitializeComponent();
            Form1 = form;
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

            BindingSource1.Add(newData);
            Form1.OriginalDataUpdate((List<Data>)BindingSource1.DataSource);

            this.Close();
        }
    }
}
