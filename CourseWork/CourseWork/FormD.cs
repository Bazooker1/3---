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

namespace CourseWork
{
    public partial class FormD : Form
    {
        int index = 0;
        MyAVL tree = new MyAVL();
        List<ProcessedReq> ProcList = new List<ProcessedReq>();
        HashTable tab = new HashTable();
        List<Worker> list = new List<Worker>();
        public FormD()
        {
            InitializeComponent();
            Form MainForm = new MainForm();
            MainForm.Hide();
            tab.Clear();
            string path = @"C:\Users\WhiteZetsu\source\repos\CourseWork\Workers.txt";
            var flag = true;
            try
            {
                StreamReader input = new StreamReader(path);
                var ch = true;
                dataGridView1.Rows.Clear();
                while (!input.EndOfStream)
                {
                    string s = input.ReadLine();
                    string[] subs = s.Split(' ');
                    Worker vova = new Worker(subs[0].Replace("_", " "), subs[1].Replace("_", " "));
                    list.Add(vova);
                    tab.Add(vova);
                    dataGridView1.Rows.Add(tab.Hash(vova.fio), vova.fio, vova.rodd);
                }
                MessageBox.Show("Файл успешно считан!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входных данных!");
            }
            string path1 = @"C:\Users\WhiteZetsu\source\repos\CourseWork\ProcRequests.txt";
            StreamReader input1 = new StreamReader(path1);
            try
            {
                var ch1 = true;
                dataGridView2.Rows.Clear();
                while (!input1.EndOfStream)
                {
                    string s1 = input1.ReadLine();
                    string[] subs1 = s1.Split(' ');
                    string[] dates1 = subs1[0].Split('.');
                    if (!subs1[0].Contains('.'))
                    {
                        ch1 = false;
                    }
                    if (subs1[subs1.Length - 1].ToCharArray()[0] != '8' || subs1[subs1.Length - 1].ToCharArray().Length != 11)
                    {
                        ch1 = false;
                    }
                    var problem1 = subs1[1].ToCharArray();
                    var worker = subs1[3].ToCharArray();
                    var customer = subs1[2].ToCharArray();
                    if (problem1.Length > 30)
                    {
                        ch1 = false;
                    }
                    for (var i = 0; i < problem1.Length; i++)
                    {
                        if ((problem1[i] < 'А'))
                        {
                            if ((problem1[i] != '!') && (problem1[i] != ',') && (problem1[i] != '.') && (problem1[i] == ' ') && (problem1[i] != '_'))
                            {
                                ch1 = false;
                            }
                        }
                    }
                    if (dates1.Length != 3)
                        ch1 = false;
                    if (int.Parse(dates1[0]) < 1 || int.Parse(dates1[0]) > 31 || int.Parse(dates1[1]) < 0 || int.Parse(dates1[1]) > 12 || int.Parse(dates1[2]) < 2007 || int.Parse(dates1[2]) > 2030)
                    {
                        ch1 = false;
                    }
                    for (var i = 0; i < worker.Length; i++)
                    {
                        if ((worker[i] < 'А'))
                        {
                            if ((worker[i] != '!') && (worker[i] != ',') && (worker[i] != '.') && (worker[i] == ' ') && (worker[i] != '_'))
                            {
                                ch1 = false;
                            }
                        }
                    }
                    for (var i = 0; i < customer.Length; i++)
                    {
                        if ((customer[i] < 'А'))
                        {
                            if ((customer[i] != '!') && (customer[i] != ',') && (customer[i] != '.') && (customer[i] == ' ') && (customer[i] != '_'))
                            {
                                ch1 = false;
                            }
                        }
                    }
                    if (ch1 != false)
                    {
                        ProcessedReq r = new ProcessedReq(new DateKey(int.Parse(dates1[0]), int.Parse(dates1[1]), int.Parse(dates1[2])), subs1[subs1.Length - 1], subs1[3].Replace('_', ' '), subs1[2].Replace('_', ' '), subs1[1].Replace('_', ' '));
                        ProcList.Add(r);
                        tree.Add(r.worker, index);
                        index++;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag != false)
                    MessageBox.Show("Файл успешно считан!");

                else
                {
                    MessageBox.Show("Ошибка входных данных!");
                    Application.Exit();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входных данных!");
                Application.Exit();
            }
            finally
            {
                input1.Close();
            }

            foreach (var it in ProcList)
            {
                dataGridView2.Rows.Add(it.Key.dd.ToString() + "." + it.Key.mm.ToString() + "." + it.Key.yy.ToString(), it.problem, it.customer, it.worker, it.num);
            }
        }
        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var it in list)
            {
                dataGridView1.Rows.Add(tab.Hash(it.fio), it.fio, it.rodd);
            }
        }
        private void RefreshDataGrid1()
        {
            dataGridView2.Rows.Clear();
            foreach (var it in ProcList)
            {
                dataGridView2.Rows.Add(it.Key.dd.ToString() + "." + it.Key.mm.ToString() + "." + it.Key.yy.ToString(), it.problem, it.customer, it.worker, it.num);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addWork addForm = new addWork();
            DialogResult dr = addForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Worker vova = addForm.newWorker();
                if (tab.Find(vova.fio) == null)
                {
                    tab.Add(vova);
                    list.Add(vova);
                    RefreshDataGrid();
                    MessageBox.Show("Работник успешно добавлен!");
                }
                else MessageBox.Show("Такой работник уже есть.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delWork addForm = new delWork();
            DialogResult dr = addForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fio = "";
                string rodd = "";
                addForm.GetKey(ref fio, ref rodd);
                try
                {
                    if (tab.Find(fio) != null)
                    {
                        var vova = new Worker(fio, rodd);
                        tab.Del(vova);
                        list.Remove(vova);
                        RefreshDataGrid();
                        MessageBox.Show("Работник успешно удален!");
                    }
                    else
                    {
                        MessageBox.Show("Такого работника не существует!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка ввода!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchWork addForm = new searchWork();
            DialogResult dr = addForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fio = "";
                string rodd = "";
                addForm.GetKey1(ref fio, ref rodd);
                try
                {
                    var srch = tab.Find(fio);
                    if (srch != null)
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Rows.Add(tab.Hash(fio), fio, rodd);
                    }
                    else MessageBox.Show("Такого работника не существует!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Такого работника не существует!");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 addForm = new Form6();
            DialogResult dialogResult = addForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ProcessedReq N = addForm.NewProcRequest();
                bool foundin = false;
                if (tab.Find(N.worker) != null)
                {
                    if (tree.Find(N.worker, tree.root) == null)
                    {
                        tree.Add
                    }

                    else
                    {
                        MessageBox.Show("Заявка уже обработана!");
                    }

                }
                else MessageBox.Show("Невозможно обработать несуществующую заявку!");
            }
        }
    }
}
