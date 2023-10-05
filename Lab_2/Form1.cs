using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Save()
        {

            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveDialog.FilterIndex = 1;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveDialog.FileName;
                    Encoding encoding = Encoding.Default;

                    if (radioButton1.Checked)
                    {
                        encoding = Encoding.UTF8;
                    }
                    else if (radioButton2.Checked) 
                    {
                        encoding = Encoding.GetEncoding(1251);
                    }
                    else if (radioButton3.Checked) 
                    {
                        encoding = Encoding.GetEncoding(866);
                    }

                    File.WriteAllText(filePath, textBox1.Text, encoding);

                    MessageBox.Show("Текст успешно сохранен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }


        private void CleanButton_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

    }
}
