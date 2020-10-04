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

namespace ListBox_ComboBox_Lab
{
    public partial class MainForm : Form
    {
        private string _filePath = "";
        private string FilePath
        {
            get
            {
                return _filePath;
            }
            set
            {
                _filePath = value;
                FilePathLabel.Text = "Путь: " + value;
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddLine();
        }

        private void AddLine()
        {
            if (InputTextBox.Text != "" && !MainListBox.Items.Contains(InputTextBox.Text))
            {
                MainListBox.Items.Add(InputTextBox.Text);
                InputTextBox.Text = "";
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            InsertLine();
        }

        private void InsertLine()
        {
            if (InputTextBox.Text != "" && !MainListBox.Items.Contains(InputTextBox.Text))
            {
                int index = MainListBox.SelectedIndex;
                MainListBox.Items.Insert(index, InputTextBox.Text);
                InputTextBox.Text = "";
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ChangeLine();
        }

        private void ChangeLine()
        {
            if (InputTextBox.Text != "" && !MainListBox.Items.Contains(InputTextBox.Text) && MainListBox.SelectedIndex != -1)
            {
                int index = MainListBox.SelectedIndex;

                MainListBox.Items.Insert(index, InputTextBox.Text);
                MainListBox.Items.RemoveAt(MainListBox.SelectedIndex);
                InputTextBox.Text = "";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteFromList();
        }

        private void DeleteFromList()
        {
            try
            {
                MainListBox.Items.RemoveAt(MainListBox.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Строка для удаления не выбрана!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MainListBox.Items.Clear();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        
        private async void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    FilePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string result = await reader.ReadToEndAsync();
                        MainListBox.Items.AddRange(ToStringArray(result));
                    }
                }
            }
        }

        private string[] ToStringArray(string value)
        {
            char[] separators = new char[1] { '\n' };
            string[] result = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return result;
        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void SaveToFile()
        {
            if (FilePath != "")
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(FilePath))
                {
                    foreach (string item in MainListBox.Items)
                    {
                        file.WriteLine(item);
                    }
                    MessageBox.Show($"Файл сохранён по пути:\n{FilePath}", "Оповещение", MessageBoxButtons.OK);
                }
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void AddLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLine();
        }

        private void InsertLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertLine();
        }

        private void ChangeLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLine();
        }

        private void DeleteFromListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFromList();
        }

        private void ClearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainListBox.Items.Clear();
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текстовый редактор", "О программе", MessageBoxButtons.OK);
        }
    }
}
