using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Library
{

    public class Edge_Boruvka
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

        public Edge_Boruvka(int U, int V, double Weight)
        {
            this.U = U;
            this.V = V;
            this.Weight = Weight;
        }

        public static int[] GetAllVertices(List<Edge_Boruvka> lol)
        {
            int[] mass = new int[100];
            int i = 1;
            foreach (var item in lol)
            {
                mass[i] = item.U;
                mass[i + 1] = item.V;
                i++;
            }

            var hashset = new HashSet<int>(); //Создаём объект типа множество.

            foreach (var x in mass) // Проходимся по массиву и добавляем только те элементы, которых во множестве ещё нет
                if (!hashset.Contains(x))
                    hashset.Add(x);

            Array.Resize(ref mass, hashset.Count); // Изменяем размерность массива на необходимую
            mass = hashset.ToArray();

            return mass;
        }

        public static List<Edge_Boruvka> Get_Adjacent_Vertices(int vertice, List<Edge_Boruvka> edges)
        {
            List<Edge_Boruvka> Adjacent_Vertices = new List<Edge_Boruvka>();
            foreach (var item in edges)
            {
                if (item != null)
                    if ((item.U == vertice) || (item.V == vertice))
                    {
                        Adjacent_Vertices.Add(item);
                    }
            }
             return Adjacent_Vertices;
           
        }

    }

    public class Boruvka
    {
        // <summary>
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
        private List<Edge_Boruvka> _edges;

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
        public List<Edge_Boruvka> Edges { get { return _edges; } }

        /// <summary>
        /// Свойство для получение инфы количество вершин
        /// </summary>
        public int VerticesCount { get { return _verticesCount; } }

        /// <summary>
        /// Свойсто для стоимости
        /// </summary>
        public double Cost { get; private set; }


        public List<Edge_Boruvka> MST = new List<Edge_Boruvka>();
        /// <summary>
        /// Конструктор для класса "rruvka"
        /// </summary>
        /// <param name="List">лист с ребрами</param>
        /// <param name="vershinbl">количестов вершин</param>
        /// <param name="rebra">количестов ребер</param>
        public Boruvka(List<Edge_Boruvka> List, int vershinbl, int rebra)
        {
            tree = new int[MAX, 2];//Инфа о вершинах от куда -> куда 
            _verticesCount = vershinbl;
            _edgesCount = rebra;
            _edges = List;
            sets = Edge_Boruvka.GetAllVertices(_edges); //new int[MAX];
            _edges.Insert(0, null);//Нулевой элемент пустой 

            // Заполняем массив от 1 до кол во вершин костыль так как если вершины не указаны не в нормальном порядке а например 8,9... то не работает (((( 
            //  for (int i = 1; i <= _verticesCount; i++) sets[i] = i;
        }
        
        private void FindMinWeight(List<Edge_Boruvka> Adjacent_Vertices,List<int> mass)
        {
            double temp = 9999;
            foreach (var item in Adjacent_Vertices)
            {
                if (item.Weight < temp) temp = item.Weight;

            }

            foreach (var item in Adjacent_Vertices)
            {
                if (mass.Contains(item.U) && mass.Contains(item.V))
                {
                    if (temp == item.Weight)
                    {
                        MST.Add(item);
                        chek = true;
                        break;
                    }
                }
                chek = false;
            }
        }
        private bool chek;
        public void BuildSpanningTree()
        {
            int timetostop = Edges.Count;
            MST.Add(null);
            while (sets.Length < timetostop )
            {
                List<int> mass = sets.ToList();
                for (int i=1,z = 1; i < mass.Count-1;z++)
                {
                    
                    int verwina = mass[i];
                    List<Edge_Boruvka> Adjacent_Vertices = Edge_Boruvka.Get_Adjacent_Vertices(verwina, _edges);
                    FindMinWeight(Adjacent_Vertices,mass);
                    if (chek)
                    {
                        mass.Remove(MST[z].U);
                        mass.Remove(MST[z].V);
                    }

                }
                timetostop--;
            }
        }
    }
}
