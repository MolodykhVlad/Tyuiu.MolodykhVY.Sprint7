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
using Tyuiu.MolodykhVY.Sprint7.Project.V4.Lib;


namespace Tyuiu.MolodykhVY.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;
        internal object dataGridViewMain_VMY;

        private void buttonSaveData_MVY_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogData_VMY.FileName = "OutPutFileBooks.csv";
            saveFileDialogData_VMY.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogData_VMY.ShowDialog();

            string path = saveFileDialogData_VMY.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewData_VMY.RowCount;
            int columns = dataGridViewData_VMY.ColumnCount;
            string header = "";
            for (int j = 0; j < columns; j++)
            {
                if (j != columns - 1)
                {
                    header += dataGridViewData_VMY.Columns[j].HeaderText + ";";
                }
                else
                {
                    header += dataGridViewData_VMY.Columns[j].HeaderText;
                }
            }
            File.AppendAllText(path, header + Environment.NewLine, Encoding.UTF8);


            for (int i = 0; i < rows; i++)
            {
                string str = "";
                for (int j = 0; j < columns; j++)
                {

                    if (j != columns - 1)
                    {
                        str += dataGridViewData_VMY.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewData_VMY.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);

            }
        }
            catch
            {
                MessageBox.Show("Ошибка при поиске книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}


        private void buttonOpenData_MVY_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogData_VMY.ShowDialog();
                openFilePath = openFileDialogData_VMY.FileName;
                dataGridViewData_VMY.Columns[0].HeaderText = "Артикул";
            dataGridViewData_VMY.Columns[1].HeaderText = "Название";
            dataGridViewData_VMY.Columns[2].HeaderText = "Автор";
            dataGridViewData_VMY.Columns[3].HeaderText = "Год издания";
            dataGridViewData_VMY.Columns[4].HeaderText = "Жанр";
            dataGridViewData_VMY.Columns[5].HeaderText = "Прочитано";


            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewData_VMY.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewData_VMY.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewData_VMY.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 5] == "True")
                    dataGridViewData_VMY.Rows[i].Cells[5].Value = true;
                else
                    dataGridViewData_VMY.Rows[i].Cells[5].Value = false;
            }
            

            }
            catch
            {
                MessageBox.Show("Ошибка при поиске книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddBook_VMY_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewData_VMY.Columns[0].HeaderText = "Артикул";
                dataGridViewData_VMY.Columns[1].HeaderText = "Название";
                dataGridViewData_VMY.Columns[2].HeaderText = "Автор";
                dataGridViewData_VMY.Columns[3].HeaderText = "Год издания";
                dataGridViewData_VMY.Columns[4].HeaderText = "Жанр";
                dataGridViewData_VMY.Columns[5].HeaderText = "Прочитано";
                dataGridViewData_VMY.Rows.Add();
            for (int i = 0; i < dataGridViewData_VMY.Rows.Count; i++)
            {
                dataGridViewData_VMY.Rows[i].Cells[0].Value = i;
            }
            }
            catch
            {
                MessageBox.Show("Ошибка при поиске книги", "Ой! Что-то пошло не так...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void ToolStripExit_VMY_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_VMY_Click(object sender, EventArgs e)
        {
            openFileDialogData_VMY.ShowDialog();
            openFilePath = openFileDialogData_VMY.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewData_VMY.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewData_VMY.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewData_VMY.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 4] == "True")
                    dataGridViewData_VMY.Rows[i].Cells[4].Value = true;
                else
                    dataGridViewData_VMY.Rows[i].Cells[4].Value = false;
            }

        }

        private void saveToolStripMenuItem_VMY_Click(object sender, EventArgs e)
        {
            Encoding encoding = Encoding.Default;//bfnanangnrnrwnrnybvcbnjnbvcfvbnmjhgfghjhghjk
            saveFileDialogData_VMY.FileName = "OutPutFileTask7.csv";
            saveFileDialogData_VMY.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogData_VMY.ShowDialog();

            string path = saveFileDialogData_VMY.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewData_VMY.RowCount;
            int columns = dataGridViewData_VMY.ColumnCount;
            string header = "";
            for (int j = 0; j < columns; j++)
            {
                if (j != columns - 1)
                {
                    header += dataGridViewData_VMY.Columns[j].HeaderText + ";";
                }
                else
                {
                    header += dataGridViewData_VMY.Columns[j].HeaderText;
                }
            }
            File.AppendAllText(path, header + Environment.NewLine);


            for (int i = 0; i < rows; i++)
            {
                string str = "";
                for (int j = 0; j < columns; j++)
                {

                    if (j != columns - 1)
                    {
                        str += dataGridViewData_VMY.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewData_VMY.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
            }

        }

        private void addToolStripMenuItem_VMY_Click(object sender, EventArgs e)
        {
            dataGridViewData_VMY.Rows.Add();
            for (int i = 0; i < dataGridViewData_VMY.Rows.Count; i++)
            {
                dataGridViewData_VMY.Rows[i].Cells[0].Value = i;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            for (int i = 0; i < dataGridViewData_VMY.RowCount; i++)
            {
                dataGridViewData_VMY.Rows[i].Selected = false;
                for (int j = comboBoxIsBookNew_VMY.SelectedIndex; j <= comboBoxIsBookNew_VMY.SelectedIndex; j++)
                    if (dataGridViewData_VMY.Rows[i].Cells[j].Value != null)
                        if (dataGridViewData_VMY.Rows[i].Cells[j].Value.ToString().Contains(textBoxBookSearch_VMY.Text))
                        {
                            dataGridViewData_VMY.Rows[i].Selected = true;
                            break;
                        }
            }
            }
            catch
            {
                MessageBox.Show("Ой! Что-то пошло не так...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridViewData_VMY.CurrentRow.Index >= 0)
            {
                int a = dataGridViewData_VMY.CurrentRow.Index;
                dataGridViewData_VMY.Rows.Remove(dataGridViewData_VMY.Rows[a]);
                if (dataGridViewData_VMY.Rows.Count == 1)
                {
                    dataGridViewData_VMY.Rows.Clear();
                }
            }
        
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialogData_VMY.ShowDialog();
            openFilePath = openFileDialogData_VMY.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewData_VMY.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewData_VMY.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewData_VMY.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 5] == "True")
                    dataGridViewData_VMY.Rows[i].Cells[5].Value = true;
                else
                    dataGridViewData_VMY.Rows[i].Cells[5].Value = false;
            }
        }

        private void buttonOpenDataReader_VMY_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogData_VMY.ShowDialog();
            openFilePath = openFileDialogData_VMY.FileName;
            dataGridViewData_VMY.Columns[0].HeaderText = "Номер билета";
            dataGridViewData_VMY.Columns[1].HeaderText = "Фамилия И. О.";
            dataGridViewData_VMY.Columns[2].HeaderText = "Номер";
            dataGridViewData_VMY.Columns[3].HeaderText = "Артикул книги";
            dataGridViewData_VMY.Columns[4].HeaderText = "Дата получения";
            dataGridViewData_VMY.Columns[5].HeaderText = "Вернул";



            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewData_VMY.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewData_VMY.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewData_VMY.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 5] == "True")
                    dataGridViewData_VMY.Rows[i].Cells[5].Value = true;
                else
                    dataGridViewData_VMY.Rows[i].Cells[5].Value = false;
            }
        }
            catch
            {
                MessageBox.Show("Ой! Что-то пошло не так...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void buttonSortedReader_VMY_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewData_VMY.RowCount; i++)
                {
                    dataGridViewData_VMY.Rows[i].Selected = false;
                    for (int j = comboBoxIsReaderNew_VMY.SelectedIndex; j <= comboBoxIsReaderNew_VMY.SelectedIndex; j++)
                        if (dataGridViewData_VMY.Rows[i].Cells[j].Value != null)
                            if (dataGridViewData_VMY.Rows[i].Cells[j].Value.ToString().Contains(textBoxReaderSearch_VMY.Text))
                            {
                                dataGridViewData_VMY.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при поиске книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddReader_VMY_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewData_VMY.Columns[0].HeaderText = "Номер билета";
                dataGridViewData_VMY.Columns[1].HeaderText = "Фамилия И. О.";
                dataGridViewData_VMY.Columns[2].HeaderText = "Номер";
                dataGridViewData_VMY.Columns[3].HeaderText = "Артикул книги";
                dataGridViewData_VMY.Columns[4].HeaderText = "Дата получения";
                dataGridViewData_VMY.Columns[5].HeaderText = "Вернул";
                dataGridViewData_VMY.Rows.Add();
                for (int i = 0; i < dataGridViewData_VMY.Rows.Count; i++)
                {
                    dataGridViewData_VMY.Rows[i].Cells[0].Value = i;
                }
            }
            catch
            {
                MessageBox.Show("Ой! Что-то пошло не так...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteReader_VMY_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewData_VMY.CurrentRow.Index >= 0)
            {
                int a = dataGridViewData_VMY.CurrentRow.Index;
                dataGridViewData_VMY.Rows.Remove(dataGridViewData_VMY.Rows[a]);
                if (dataGridViewData_VMY.Rows.Count == 1)
                {
                    dataGridViewData_VMY.Rows.Clear();
                }
            }
        }
            catch
            {
                MessageBox.Show("Ой! Что-то пошло не так...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void buttonEnableBookPanel_MVY_Click(object sender, EventArgs e)
        {
            groupBoxMoves_VMY.Enabled = true;
            groupBoxMovesReader_VMY.Enabled = false;
        }

        private void buttonEnableReaderPanel_MVY_Click(object sender, EventArgs e)
        {
            groupBoxMoves_VMY.Enabled = false;
            groupBoxMovesReader_VMY.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа предназначена для учета книг и читателей в небольшой библиотеки. Функции для библиотеки: учет взятых книг, учет читателе. Функции для читателя: учет прочитаных и взятых книг.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSaveDataReader_VMY_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogData_VMY.FileName = "OutPutFileReader.csv";
                saveFileDialogData_VMY.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogData_VMY.ShowDialog();

                string path = saveFileDialogData_VMY.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewData_VMY.RowCount;
                int columns = dataGridViewData_VMY.ColumnCount;
                string header = "";
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        header += dataGridViewData_VMY.Columns[j].HeaderText + ";";
                    }
                    else
                    {
                        header += dataGridViewData_VMY.Columns[j].HeaderText;
                    }
                }
                File.AppendAllText(path, header + Environment.NewLine, Encoding.UTF8);


                for (int i = 0; i < rows; i++)
                {
                    string str = "";
                    for (int j = 0; j < columns; j++)
                    {

                        if (j != columns - 1)
                        {
                            str += dataGridViewData_VMY.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str += dataGridViewData_VMY.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);

                }
            }
            catch
            {
                MessageBox.Show("Ой! Что-то пошло не так...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxIsReaderNew_VMY_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewData_VMY_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dataGridViewData_VMY.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewData_VMY.Rows[index].HeaderCell.Value = indexStr;
        }
    }
}
