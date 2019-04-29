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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Лист ребер
        /// </summary>
        private List<Edge_Prim> list = new List<Edge_Prim>();
        /// <summary>
        /// Лист ответ
        /// </summary>
        private List<Edge_Prim> MST = new List<Edge_Prim>();

        /// <summary>
        /// Очищаем все
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            list.Clear();
        }

        /// <summary>
        /// Добавляем ребро
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AddGraf a = new AddGraf(list);
            a.Show();
            a.FormClosed += A_FormClosed;
        }

        /// <summary>
        /// При закрытии формы добавляем ребра в лист бокс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBox1.Items.Clear();
            
            foreach (var item in list)
            {
                
                listBox1.Items.Add("Ребро: " +item.v1+" ,"+" "+item.v2+" ,"+" "+item.weight);
            }
            
        }

        /// <summary>
        /// Решение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Prim p = new Prim();
            p.algorithmByPrim(5, list, MST);
            int weight = 0;
            foreach (var item in MST)
            {
                weight += item.weight;
                listBox1.Items.Add(item.v1 + "-->" + item.v2 + "  Вес :" + item.weight);
            }
            listBox1.Items.Add("Обший мин вес :" + weight);
            list.Clear();
        }
    }
}
