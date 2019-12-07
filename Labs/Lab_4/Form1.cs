using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> list = new List<string>();
        private void ReadFile_Click(object sender, EventArgs e)
        {
            string test;
            var currentOpenFileDialog = new OpenFileDialog();
            currentOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            currentOpenFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            currentOpenFileDialog.ShowDialog();
            //currentOpenFileDialog.FileName = DialogResult();
            Stopwatch mystopwatch = new Stopwatch();
            mystopwatch.Start();
            test = File.ReadAllText(currentOpenFileDialog.FileName);
            char []a = { '\n', ' ' };
            foreach(string list2 in test.Split())
            {
                if(!list.Contains(list2))
                list.Add(list2);
            }
            mystopwatch.Stop();
            label1.Text = mystopwatch.Elapsed.TotalMilliseconds.ToString();
            //listBox1.BeginUpdate();
            //foreach (string list3 in list)
            //{
            //    listBox1.Items.Add(list3);
            //}
            //listBox1.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            Stopwatch watch = new Stopwatch();
            if (list.Count <= 0)
            {
                MessageBox.Show("Ошибка!!! Не выбран файл для поиска");
                MessageBoxButtons message=new MessageBoxButtons();
                message = MessageBoxButtons.OK;
            }
            else
            {
                listBox1.BeginUpdate();
                watch.Start();
                    if (list.Contains(a))
                    { 
                        listBox1.Items.Add(a);
                    }
                    else
                    {
                        listBox1.Items.Add("Данного слова нет в выбранном файле");
                    }
                watch.Stop();
                listBox1.EndUpdate();
                label4.Text = watch.Elapsed.TotalMilliseconds.ToString();
            }

        }
    }
}
