 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Library
{
    /// <summary>
    /// Класс ребра
    /// </summary>
    public class Edge
    {
        /// <summary>
        /// Информация о соединяемых вершинах
        /// </summary>
        public int U;
        /// <summary>
        /// Информация о соединяемых вершинах
        /// </summary>
        public int V;
        /// <summary>
        /// Их вес
        /// </summary>
        public double Weight;

        public Edge(int U, int V, double Weight)
        {
            this.U = U;
            this.V = V;
            this.Weight = Weight;
        }
    }

    public class Kruskal
    {
        /// <summary>
        /// Константа 100
        /// </summary>
        private const int MAX = 100;

        /// <summary>
        /// Количество ребер
        /// </summary>
        private int _edgesCount;

        /// <summary>
        /// Количество вершин
        /// </summary>
        private int _verticesCount;

        /// <summary>
        /// Лист со всей инофрамацией о ребрах
        /// </summary>
        private List<Edge> _edges;

        /// <summary>
        /// дерево в двумерном массиве (1-макс кол-во ре)
        /// </summary>
        public int[,] tree;

        /// <summary>
        /// Массив номеров вершин, для определения зацикливания
        /// </summary>
        private int[] sets;

        /// <summary>
        /// Своистов для получение инфорации о ребрах
        /// </summary>
        public List<Edge> Edges { get { return _edges; } }

        /// <summary>
        /// Свойство для получение инфы количество вершин
        /// </summary>
        public int VerticesCount { get { return _verticesCount; } }

        /// <summary>
        /// Свойсто для стоимости
        /// </summary>
        public double Cost { get; private set; }


        /// <summary>
        /// Заносим данные о графе из входных данныйх , версия для консольки
        /// </summary>
        /// <param name="input">Строка данных</param>
        public Kruskal(string input)
        {
            tree = new int[MAX, 3];//Инфа о вершинах от куда -> куда 
            sets = new int[MAX];

            string[] lines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);//разбиваем входные данные на массив из строк
            _verticesCount = int.Parse(lines[0]);
            _edgesCount = int.Parse(lines[1]);
            _edges = new List<Edge>();

            _edges.Add(null);

            for (int i = 2; i < lines.Count(); i++)
            {
                string[] line = lines[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);//Заносив в новый массив данные о графе из входных данных

                  _edges.Add(new Edge(Convert.ToInt32(line[0]), Convert.ToInt32(line[1]), Convert.ToDouble(line[2])));
               //добавляем данные в лист 
            }

            for (int i = 1; i <= _verticesCount; i++) sets[i] = i;
        }

        /// <summary>
        /// Версия для Windows Forms бояр
        /// </summary>
        /// <param name="List"></param>
        /// <param name="vershinbl"></param>
        /// <param name="rebra"></param>  
        public Kruskal(List<Edge> List,int vershinbl ,int rebra)
        {
            tree = new int[MAX, 3];//Инфа о вершинах от куда -> куда 
            sets = new int[MAX];
            _verticesCount = vershinbl;
            _edgesCount = rebra;
            _edges = List;
            _edges.Insert(0, null);

            for (int i = 1; i <= _verticesCount; i++) sets[i] = i;
        }


        /// <summary>
        /// Сортируем ребра по весу (Пузырьком)
        /// </summary>
        /// <param name="k">Количество ребер</param>
        private void ArrangeEdges(int k)
        {
            Edge temp;
            for (int i = 1; i < k; i++)
            {
                for (int j = 1; j <= k - i; j++)
                {
                    if (_edges[j].Weight > _edges[j + 1].Weight)
                    {
                        temp = _edges[j];
                        _edges[j] = _edges[j + 1];
                        _edges[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Метод поиска вершин
        /// </summary>
        /// <param name="vertex">вершина</param>
        /// <returns></returns>
        public int Find(int vertex)
        {
            if (sets[vertex] == vertex) return vertex;
            return sets[vertex] = Find(sets[vertex]);
        }

        //private int Find(int vertex)
        //{
        //    return (sets[vertex]);
        //}

        /// <summary>
        /// Метод для соединение 2х вершин 
        /// </summary>
        /// <param name="v1">первая вершина</param>
        /// <param name="v2">вторая вершина</param>
        private void Join(int v1, int v2)
        {
            if (v1 < v2)
                sets[v2] = v1;
            else
                sets[v1] = v2;
        }

        /// <summary>
        /// Построение нового дерева
        /// </summary>
        public void BuildSpanningTree()
        {
            int k = _edgesCount;
            int i, t = 1;
            this.ArrangeEdges(k);
            this.Cost = 0;
            for (i = 1; i <= k; i++)
            {
                for (i = 1; i < k; i++)
                    if (this.Find(_edges[i].U) != this.Find(_edges[i].V))
                    {
                        tree[t, 1] = _edges[i].U;
                        tree[t, 2] = _edges[i].V;
                        this.Cost += _edges[i].Weight;
                        this.Join(Find(_edges[i].U), Find(_edges[i].V));

                        t++;
                    }
            }
        }

        /// <summary>
        /// Вывод инфы 
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine("The Edges of the Minimum Spanning Tree are:");
            for (int i = 1; i < _verticesCount; i++)
                Console.WriteLine(tree[i, 1] + " --> " + tree[i, 2]);
        }
    }
}

