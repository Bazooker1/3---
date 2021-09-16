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
    public partial class searchWork : Form
    {
        public searchWork()
        {
            InitializeComponent();
        }

        public void GetKey1(ref string fio, ref string rodd)
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
                            return true;
                        }
                        else return false;
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
                            return true;
                        }
                        else return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода!");
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkcorrect())
            {
                try
                {
                    var ns = textBox1.Text;
                    var spec = textBox2.Text;
                    DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка ввода!");
                }
            }
            else MessageBox.Show("Ошибка ввода!");
        }
    }
}
