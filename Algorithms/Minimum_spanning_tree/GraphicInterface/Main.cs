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
        /// Лист курскала
        /// </summary>
        private List<Edge> Edges = new List<Edge>();


        private List<Edge_Boruvka> Boruvka = new List<Edge_Boruvka>();

        /// <summary>
        /// Очищаем все
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            list.Clear();
            Edges.Clear();
            Boruvka.Clear();
        }

        /// <summary>
        /// Добавляем ребро
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AddGraf a = new AddGraf(list, Edges, Boruvka);
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

                listBox1.Items.Add("Ребро: " + item.v1 + " ," + " " + item.v2 + " ," + " " + item.weight);
            }

            listBox2.Items.Clear();

            foreach (var item in Edges)
            {

                listBox2.Items.Add("Ребро: " + item.U + " ," + " " + item.V + " ," + " " + item.Weight);
            }
            listBox3.Items.Clear();
            foreach (var item in Boruvka)
            {
                listBox3.Items.Add("Ребро: " + item.src + " ," + " " + item.dest + " ," + " " + item.weight);
            }

        }

        /// <summary>
        /// Решение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(verticalcount.Text, out int vershinbl))
            {
                listBox1.Items.Clear();
                Prim p = new Prim();
                p.algorithmByPrim(vershinbl, list, MST);
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



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            if (int.TryParse(verticalcount.Text, out int vershinbl))
            {
                listBox2.Items.Clear();

                Kruskal k = new Kruskal(Edges, vershinbl, Edges.Count);
                k.BuildSpanningTree();

                for (int i = 1; i < vershinbl; i++)
                {
                    listBox2.Items.Add(k.tree[i, 1] + " --> " + k.tree[i, 2]);
                }
                listBox2.Items.Add("Обший мин вес :" + k.Cost);
                Edges.Clear();
                // time2.Text = GetKruskalTime(10000,k);
            }
            else { MessageBox.Show("Введите кол во вершин"); }

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(verticalcount.Text, out int vershinbl))
            {
                listBox3.Items.Clear();
                Boruvka br = new Boruvka(Boruvka, vershinbl, Boruvka.Count);
                if (Boruvka.Count > 0)
                {
                    br.boruvkaMST();
                }
                foreach (var item in br.MST)
                {
                    listBox3.Items.Add(item.src + "-->" + item.dest + "  Вес :" + item.weight);
                }
                listBox3.Items.Add("Общий мин вес " + br.MSTweight);
                Boruvka.Clear();
            }
            else { MessageBox.Show("Введите кол во вершин"); }
        }

        private class Time
        {
            public string GetBoruvkaTime(int Count)
            {
                List<Edge_Boruvka> list = new List<Edge_Boruvka>();
                list.Add(new Edge_Boruvka(0, 1, 1));
                list.Add(new Edge_Boruvka(0, 10, 8));
                list.Add(new Edge_Boruvka(0, 9, 8));
                list.Add(new Edge_Boruvka(0, 8, 3));
                list.Add(new Edge_Boruvka(1, 2, 4));
                list.Add(new Edge_Boruvka(1, 10, 4));
                list.Add(new Edge_Boruvka(2, 3, 5));
                list.Add(new Edge_Boruvka(2, 10, 2));
                list.Add(new Edge_Boruvka(3, 11, 1));
                list.Add(new Edge_Boruvka(3, 4, 10));
                list.Add(new Edge_Boruvka(4, 11, 9));
                list.Add(new Edge_Boruvka(4, 5, 5));
                list.Add(new Edge_Boruvka(5, 6, 6));
                list.Add(new Edge_Boruvka(6, 11, 11));
                list.Add(new Edge_Boruvka(6, 7, 6));
                list.Add(new Edge_Boruvka(7, 10, 5));
                list.Add(new Edge_Boruvka(7, 8, 5));
                list.Add(new Edge_Boruvka(8, 10, 4));
                list.Add(new Edge_Boruvka(8, 9, 7));
                
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                Boruvka br = new Boruvka(list, 12, list.Count);
                for (int i = 0; i < Count; i++)
                {
                    br.boruvkaMST();
                }
                stopwatch.Stop();
                return stopwatch.ElapsedMilliseconds.ToString();
            }
            public string GetPrimTime(int Count)
            {
                List<Edge_Prim> MST = new List<Edge_Prim>();
                List<Edge_Prim> list = new List<Edge_Prim>();
                list.Add(new Edge_Prim(0, 1, 1));
                list.Add(new Edge_Prim(0, 10, 8));
                list.Add(new Edge_Prim(0, 9, 8));
                list.Add(new Edge_Prim(0, 8, 3));
                list.Add(new Edge_Prim(1, 2, 4));
                list.Add(new Edge_Prim(1, 10, 4));
                list.Add(new Edge_Prim(2, 3, 5));
                list.Add(new Edge_Prim(2, 10, 2));
                list.Add(new Edge_Prim(3, 11, 1));
                list.Add(new Edge_Prim(3, 4, 10));
                list.Add(new Edge_Prim(4, 11, 9));
                list.Add(new Edge_Prim(4, 5, 5));
                list.Add(new Edge_Prim(5, 6, 6));
                list.Add(new Edge_Prim(6, 11, 11));
                list.Add(new Edge_Prim(6, 7, 6));
                list.Add(new Edge_Prim(7, 10, 5));
                list.Add(new Edge_Prim(7, 8, 5));
                list.Add(new Edge_Prim(8, 10, 4));
                list.Add(new Edge_Prim(8, 9, 7));

                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                Prim p = new Prim();
                for (int i = 0; i < Count; i++)
                {
                    p.algorithmByPrim(12, list, MST);
                }
                stopwatch.Stop();
                return stopwatch.ElapsedMilliseconds.ToString();
            }
            public string GetKruskalTime(int Count)
            {
                List<Edge> list = new List<Edge>();
                list.Add(new Edge(0, 1, 1));
                list.Add(new Edge(0, 10, 8));
                list.Add(new Edge(0, 9, 8));
                list.Add(new Edge(0, 8, 3));
                list.Add(new Edge(1, 2, 4));
                list.Add(new Edge(1, 10, 4));
                list.Add(new Edge(2, 3, 5));
                list.Add(new Edge(2, 10, 2));
                list.Add(new Edge(3, 11, 1));
                list.Add(new Edge(3, 4, 10));
                list.Add(new Edge(4, 11, 9));
                list.Add(new Edge(4, 5, 5));
                list.Add(new Edge(5, 6, 6));
                list.Add(new Edge(6, 11, 11));
                list.Add(new Edge(6, 7, 6));
                list.Add(new Edge(7, 10, 5));
                list.Add(new Edge(7, 8, 5));
                list.Add(new Edge(8, 10, 4));
                list.Add(new Edge(8, 9, 7));

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Kruskal k = new Kruskal(list, 12, list.Count);
                for (int i = 0; i < Count; i++)
                {
                    k.BuildSpanningTree();
                }
                stopwatch.Stop();
                return stopwatch.ElapsedMilliseconds.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Time time = new Time();
            labelTimeKruskal1.Text = time.GetKruskalTime(10000);
            labelTimeKruskal2.Text = time.GetKruskalTime(20000);
            labelTimeKruskal3.Text = time.GetKruskalTime(40000);
            labelTimeKruskal4.Text = time.GetKruskalTime(80000);
            labelTimeKruskal5.Text = time.GetKruskalTime(160000);
            labelTimePrim1.Text = time.GetPrimTime(10000);
            labelTimePrim2.Text = time.GetPrimTime(20000);
            labelTimePrim3.Text = time.GetPrimTime(40000);
            labelTimePrim4.Text = time.GetPrimTime(80000);
            labelTimePrim5.Text = time.GetPrimTime(160000);
            labelTimeBoruvka1.Text = time.GetBoruvkaTime(10000);
            labelTimeBoruvka2.Text = time.GetBoruvkaTime(20000);
            labelTimeBoruvka3.Text = time.GetBoruvkaTime(40000);
            labelTimeBoruvka4.Text = time.GetBoruvkaTime(80000);
            labelTimeBoruvka5.Text = time.GetBoruvkaTime(160000);
        }
    }
}
