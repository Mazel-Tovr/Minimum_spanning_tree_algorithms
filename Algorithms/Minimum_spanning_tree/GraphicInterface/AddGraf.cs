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
        List<Edge_Boruvka> Boruvka;
        public int res;
        public int res2;
        public int res3;
        public double res33;
        public AddGraf(List<Edge_Prim> list, List<Edge> list1, List<Edge_Boruvka> Boruvka)
        {
            this.list = list;
            this.list1 = list1;
            this.Boruvka = Boruvka;
            InitializeComponent();
        }
       

        /// <summary>
        /// Добавляем ребро
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
                //Проверка ввода
                if (int.TryParse(textBox1.Text, out res) && int.TryParse(textBox2.Text, out res2) && int.TryParse(textBox3.Text, out res3)&& double.TryParse(textBox3.Text, out res33))
                {

                if (list != null) list.Add(new Edge_Prim(res, res2, res3));
                if (list1 != null) list1.Add(new Edge (res, res2, res33));
                if (Boruvka != null) Boruvka.Add(new Edge_Boruvka(res, res2, res3));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка при вводе данных");
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
