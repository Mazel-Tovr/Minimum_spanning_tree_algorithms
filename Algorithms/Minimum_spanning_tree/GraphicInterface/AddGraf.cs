using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms_Library;

namespace GraphicInterface
{
    public partial class AddGraf : Form
    {
        List<Edge_Prim> list;
        List<Edge> list1;
        public int res;
        public int res2;
        public int res3;
        public double res33;
        private bool algoritm = true;
        public AddGraf(List<Edge_Prim> list , bool algoritm)
        {
            this.algoritm = algoritm;
            this.list = list;
            InitializeComponent();
        }
        public AddGraf(List<Edge> list1, bool algoritm)
        {
            this.algoritm = algoritm;
            this.list1 = list1;
            InitializeComponent();
        }

        /// <summary>
        /// Добавляем ребро
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (algoritm == true)
            {
                //Проверка ввода
                if (int.TryParse(textBox1.Text, out res) && int.TryParse(textBox2.Text, out res2) && int.TryParse(textBox3.Text, out res3))
                {
                    list.Add(new Edge_Prim(res, res2, res3));
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Ошибка при вводе данных");
                }
            }
            else
            {
                if (int.TryParse(textBox1.Text, out res) && int.TryParse(textBox2.Text, out res2) && double.TryParse(textBox3.Text, out res33))
                {
                    list1.Add(new Edge (res, res2, res33));
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Ошибка при вводе данных");
                }
            }
        }

        /// <summary>
        /// Ничего не происходит
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGraf_Load(object sender, EventArgs e)
        {

        }
    }
}
