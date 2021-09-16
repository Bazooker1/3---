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
    public partial class delWork : Form
    {
        public delWork()
        {
            InitializeComponent();
        }

        public void GetKey(ref string fio, ref string rodd)
        {
            try
            {
                var ns = textBox1.Text;
                var spec = textBox2.Text;
                fio = ns;
                rodd = spec;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода!");
            }
        }
        public bool checkcorrect()
        {
            bool ch = true;
            try
            {
                var ns = textBox1.Text;
                var spec = textBox2.Text;
                if (ns.Length > 30)
                {
                    return false;
                }
                for (var i = 0; i < ns.Length; i++)
                {
                    if ((ns[i] < 'А'))
                    {
                        if ((ns[i] == '!') || (ns[i] == ',') || (ns[i] == '.') || (ns[i] == ' '))
                        {
                            return ch = true;
                        }
                        else return ch = false;
                    }
                }
                if (spec.Length > 30)
                {
                    return false;
                }
                for (var i = 0; i < spec.Length; i++)
                {
                    if ((spec[i] < 'А'))
                    {
                        if ((spec[i] == '!') || (spec[i] == ',') || (spec[i] == '.') || (spec[i] == ' '))
                        {
                            return ch = true;
                        }
                        else return ch = false;
                    }
                }
                return ch = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода!");
                return ch = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkcorrect() == true)
            {
                DialogResult = DialogResult.OK;
                Hide();
            }
            else
            {
                MessageBox.Show("Ошибка ввода!");
            }
        }
    }
}
