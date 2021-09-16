using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class addWork : Form
    {
        public addWork()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckCorrect() == true)
            {
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Ошибка ввода!");
        }
        public Worker newWorker()
        {
            Worker vova = new Worker(textBox1.Text, textBox2.Text);
            return vova;
        }
        private bool CheckCorrect()
        {
            bool ch = true;
            var fio = textBox1.Text;
            var rodd = textBox2.Text;
            for (var i = 0; i < fio.Length; i++)
            {
                if ((fio[i] < 'А'))
                {
                    if ((fio[i] == '!') || (fio[i] == ',') || (fio[i] == '.') || (fio[i] == ' '))
                    {
                        ch = true;
                    }
                    else return ch == false;
                }
            }
            for (var i = 0; i < rodd.Length; i++)
            {
                if ((rodd[i] < 'А'))
                {
                    if ((rodd[i] == '!') || (rodd[i] == ',') || (rodd[i] == '.') || (rodd[i] == ' '))
                    {
                        ch = true;
                    }
                    else return ch == false;
                }
            }
            return ch;
        }
    }
}
