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
    public partial class DrawGraphForm : Form
    {
        DrawGraph G;
        /// <summary>
        /// Лист с кооринатмаи вершин
        /// </summary>
        List<Vertex> V;
        /// <summary>
        /// Лист ребер
        /// </summary>
        List<Edgee> E;

        int selected1; //выбранные вершины, для соединения линиями
        int selected2;

        public DrawGraphForm()
        {
            InitializeComponent();
            V = new List<Vertex>();
            G = new DrawGraph(sheet.Width, sheet.Height);
            E = new List<Edgee>();
            sheet.Image = G.GetBitmap();
        }

        //кнопка - выбрать вершину
        private void selectButton_Click(object sender, EventArgs e)
        {
            selectButton.Enabled = false;
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            deleteButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
        }

        //кнопка - рисовать вершину
        private void drawVertexButton_Click(object sender, EventArgs e)
        {
            drawVertexButton.Enabled = false;
            selectButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            deleteButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
        }

        //кнопка - рисовать ребро
        private void drawEdgeButton_Click(object sender, EventArgs e)
        {
            drawEdgeButton.Enabled = false;
            selectButton.Enabled = true;
            drawVertexButton.Enabled = true;
            deleteButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
            selected2 = -1;
        }

        //кнопка - удалить элемент
        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteButton.Enabled = false;
            selectButton.Enabled = true;
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
        }

        //кнопка - удалить граф
        private void deleteALLButton_Click(object sender, EventArgs e)
        {
            selectButton.Enabled = true;
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            deleteButton.Enabled = true;
            const string message = "Вы действительно хотите полностью удалить граф?";
            const string caption = "Удаление";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
                V.Clear();
                E.Clear();
                G.clearSheet();
                sheet.Image = G.GetBitmap();
            }
        }

        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            //нажата кнопка "выбрать вершину", ищем степень вершины
            if (selectButton.Enabled == false)
            {
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        if (selected1 != -1)
                        {
                            selected1 = -1;
                            G.clearSheet();
                            G.drawALLGraph(V, E);
                            sheet.Image = G.GetBitmap();
                        }
                        if (selected1 == -1)
                        {
                            G.drawSelectedVertex(V[i].x, V[i].y);
                            selected1 = i;
                            sheet.Image = G.GetBitmap();
                           
                            break;
                        }
                    }
                }
            }
            //нажата кнопка "рисовать вершину"
            if (drawVertexButton.Enabled == false)
            {
                V.Add(new Vertex(e.X, e.Y));
                G.drawVertex(e.X, e.Y, (V.Count - 1).ToString());
                sheet.Image = G.GetBitmap();
            }
            //нажата кнопка "рисовать ребро"
            if (drawEdgeButton.Enabled == false)
            {
                try
                {

                    if (e.Button == MouseButtons.Left)
                    {
                        for (int i = 0; i < V.Count; i++)
                        {
                            if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                            {
                                if (selected1 == -1)
                                {
                                    G.drawSelectedVertex(V[i].x, V[i].y);
                                    selected1 = i;
                                    sheet.Image = G.GetBitmap();
                                    break;
                                }
                                if (selected2 == -1)
                                {
                                    G.drawSelectedVertex(V[i].x, V[i].y);
                                    selected2 = i;
                                    int weigth = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Введите вес графа"));
                                    E.Add(new Edgee(selected1, selected2, weigth));
                                    G.drawEdge(V[selected1], V[selected2], E[E.Count - 1], E.Count - 1);
                                    selected1 = -1;
                                    selected2 = -1;
                                    sheet.Image = G.GetBitmap();
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    
                }
                if (e.Button == MouseButtons.Right)
                {
                    if ((selected1 != -1) &&
                        (Math.Pow((V[selected1].x - e.X), 2) + Math.Pow((V[selected1].y - e.Y), 2) <= G.R * G.R))
                    {
                        G.drawVertex(V[selected1].x, V[selected1].y, (selected1).ToString());
                        selected1 = -1;
                        sheet.Image = G.GetBitmap();
                    }
                }
            }
            //нажата кнопка "удалить элемент"
            if (deleteButton.Enabled == false)
            {
                bool flag = false; //удалили ли что-нибудь по ЭТОМУ клику
                //ищем, возможно была нажата вершина
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        for (int j = 0; j < E.Count; j++)
                        {
                            if ((E[j].v1 == i) || (E[j].v2 == i))
                            {
                                E.RemoveAt(j);
                                j--;
                            }
                            else
                            {
                                if (E[j].v1 > i) E[j].v1--;
                                if (E[j].v2 > i) E[j].v2--;
                            }
                        }
                        V.RemoveAt(i);
                        flag = true;
                        break;
                    }
                }
                //ищем, возможно было нажато ребро
                if (!flag)
                {
                    for (int i = 0; i < E.Count; i++)
                    {
                        if (E[i].v1 == E[i].v2) //если это петля
                        {
                            if ((Math.Pow((V[E[i].v1].x - G.R - e.X), 2) + Math.Pow((V[E[i].v1].y - G.R - e.Y), 2) <= ((G.R + 2) * (G.R + 2))) &&
                                (Math.Pow((V[E[i].v1].x - G.R - e.X), 2) + Math.Pow((V[E[i].v1].y - G.R - e.Y), 2) >= ((G.R - 2) * (G.R - 2))))
                            {
                                E.RemoveAt(i);
                                flag = true;
                                break;
                            }
                        }
                        else //не петля
                        {
                            if (((e.X - V[E[i].v1].x) * (V[E[i].v2].y - V[E[i].v1].y) / (V[E[i].v2].x - V[E[i].v1].x) + V[E[i].v1].y) <= (e.Y + 4) &&
                                ((e.X - V[E[i].v1].x) * (V[E[i].v2].y - V[E[i].v1].y) / (V[E[i].v2].x - V[E[i].v1].x) + V[E[i].v1].y) >= (e.Y - 4))
                            {
                                if ((V[E[i].v1].x <= V[E[i].v2].x && V[E[i].v1].x <= e.X && e.X <= V[E[i].v2].x) ||
                                    (V[E[i].v1].x >= V[E[i].v2].x && V[E[i].v1].x >= e.X && e.X >= V[E[i].v2].x))
                                {
                                    E.RemoveAt(i);
                                    flag = true;
                                    break;
                                }
                            }
                        }
                    }
                }

                //если что-то было удалено, то обновляем граф на экране
                if (flag)
                {
                    G.clearSheet();
                    G.drawALLGraph(V, E);
                    sheet.Image = G.GetBitmap();
                }
            }
        }

        private void buttonPrim_Click(object sender, EventArgs e)
        {
            List<Edge_Prim> ListPrim = new List<Edge_Prim>();
            foreach (var item in E)
            {
                ListPrim.Add(new Edge_Prim(item.v1, item.v2, item.weight));
            }
            List<Edge_Prim> MST = new List<Edge_Prim>();
            Prim p = new Prim();
            p.algorithmByPrim(V.Count, ListPrim, MST);

            List<Edgee> ListAnswer = new List<Edgee>();
            foreach (var item in MST)
            {
                ListAnswer.Add(new Edgee(item.v1, item.v2, item.weight));
            }
            
            G.drawALLGraphAnswer(V, ListAnswer);
            sheet.Image = G.GetBitmap();

        }

        private void buttonKruskal_Click(object sender, EventArgs e)
        {
            List<Edge> ListKruskal = new List<Edge>();
            foreach (var item in E)
            {
                ListKruskal.Add(new Edge(item.v1, item.v2, item.weight));
            }
            Kruskal k = new Kruskal(ListKruskal, V.Count, ListKruskal.Count);
            k.BuildSpanningTree();

            List<Edgee> ListAnswer = new List<Edgee>();
            for (int i = 1; i < E.Count; i++)
            {
                ListAnswer.Add(new Edgee(k.tree[i, 1], k.tree[i, 2], k.tree[i, 3]));
            }

            G.drawALLGraphAnswer(V, ListAnswer);
            sheet.Image = G.GetBitmap();

        }

        private void buttonBoruvka_Click(object sender, EventArgs e)
        {
            List<Edge_Boruvka> ListBoruvka = new List<Edge_Boruvka>();
            foreach (var item in E)
            {
                ListBoruvka.Add(new Edge_Boruvka(item.v1, item.v2, item.weight));
            }
            Boruvka br = new Boruvka(ListBoruvka, V.Count, ListBoruvka.Count);
            br.boruvkaMST();

            List<Edgee> ListAnswer = new List<Edgee>();
            foreach (var item in br.MST)
            {
                ListAnswer.Add(new Edgee(item.src, item.dest, (int)item.weight));
            }

            G.drawALLGraphAnswer(V, ListAnswer);
            sheet.Image = G.GetBitmap();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
