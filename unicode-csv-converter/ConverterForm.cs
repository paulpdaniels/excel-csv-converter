using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unicode_csv_converter
{
    public partial class ConverterForm : Form
    {
        private ExcelConverter converter;

        public ConverterForm()
        {
            InitializeComponent();

            this.converter = new ExcelConverter();

            this.encodingSelection.Items.Add(new EncodingItem("UTF-8", Encoding.UTF8));
            this.encodingSelection.Items.Add(new EncodingItem("Unicode", Encoding.Unicode));

            this.encodingSelection.SelectedIndex = 0;
            this.encodingSelection.ValueMember = "Name";
        }

        private async void doConvertButton_Click(object sender, EventArgs e)
        {
            string delimiter = FixDelimiter(this.delimiterTextBox.Text);

            Encoding encoding = ((EncodingItem)this.encodingSelection.SelectedItem).Encoding;

            this.progressLabel.Text = "Converting...";

            await this.converter.Convert(new List<string> { this.inputTextBox.Text }, new List<string> { this.outputTextBox.Text }, delimiter, encoding);

            this.progressLabel.Text = "Conversion Success!";
        }

        private string FixDelimiter(string p)
        {
            p = p.Trim();

            //We are dealing with a control character
            if (p.StartsWith("\\"))
            {
                if (p.StartsWith("\\t")) return '\t'.ToString();
            }

            return p;
        }

        private void browseFilesButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                var result = dialog.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    SetFileNames(dialog.FileName);
                }
            }
        }

        private void SetFileNames(string fileName)
        {
            this.inputTextBox.Text = fileName;
            this.outputTextBox.Text = Path.ChangeExtension(fileName, "csv");
        }

        private void ConverterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Delimiter = this.delimiterTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void inputTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string [] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            SetFileNames(files[0]);
        }

        private void inputTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
