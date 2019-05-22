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
using System.Diagnostics;

namespace GraphicInterface
{
    public partial class Main : Form
    {
        bool FormStatus = true;
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
            AddGraf a = new AddGraf(list, FormStatus);
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
            if (FormStatus == true)
            {
                listBox1.Items.Clear();

                foreach (var item in list)
                {

                    listBox1.Items.Add("Ребро: " + item.v1 + " ," + " " + item.v2 + " ," + " " + item.weight);
                }
            }
            else
            {
                listBox2.Items.Clear();

                foreach (var item in Edges)
                {

                    listBox2.Items.Add("Ребро: " + item.U + " ," + " " + item.V + " ," + " " + item.Weight);
                }
            }

        }

        /// <summary>
        /// Решение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int vershinbl))
            {
                listBox1.Items.Clear();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Prim p = new Prim();
                p.algorithmByPrim(vershinbl, list, MST);
                stopwatch.Stop();
                int weight = 0;
                foreach (var item in MST)
                {
                    weight += item.weight;
                    listBox1.Items.Add(item.v1 + "-->" + item.v2 + "  Вес :" + item.weight);
                }
                listBox1.Items.Add("Обший мин вес :" + weight);
                list.Clear();
               // time1.Text = GetPrimTime(1000,p);
            }
            else
            {
                MessageBox.Show("Введите кол во вершин");
            }
        }


        private List<Edge> Edges = new List<Edge>();

        /// <summary>
        /// Добавляем графф
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            FormStatus = false;
            AddGraf a = new AddGraf(Edges, FormStatus);
            a.Show();
            a.FormClosed += A_FormClosed;

        }

        /// <summary>
        /// Кнопка очистки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Edges.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int vershinbl))
            {
                listBox2.Items.Clear();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Kruskal k = new Kruskal(Edges, vershinbl, Edges.Count);
                k.BuildSpanningTree();
                stopwatch.Stop();
                for (int i = 1; i < Convert.ToInt32(textBox1.Text); i++)
                {
                    listBox2.Items.Add(k.tree[i, 1] + " --> " + k.tree[i, 2]);
                }
                listBox2.Items.Add("Обший мин вес :" + k.Cost);
                Edges.Clear();
               // time2.Text = GetKruskalTime(10000,k);
            } 
            else { MessageBox.Show("Введите кол во вершин"); }

        }

        /* private string GetKruskalTime(int Count, Kruskal k) {
             Stopwatch stopwatch = new Stopwatch();

             stopwatch.Start();

             for (int i = 0; i < Count; i++)
             {
                 k.BuildSpanningTree();
             }

             stopwatch.Stop();

             return stopwatch.ElapsedMilliseconds.ToString();
         }

         private string GetPrimTime(int Count, Prim p)
         {
             Stopwatch stopwatch = new Stopwatch();

             stopwatch.Start();

             for (int i = 0; i < Count; i++)
             {
                 p.algorithmByPrim(Convert.ToInt32(textBox2.Text), list, MST);

             }

             stopwatch.Stop();

             return stopwatch.ElapsedMilliseconds.ToString();
         }*/
    }
}
