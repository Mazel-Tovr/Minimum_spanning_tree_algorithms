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
        public int src;
        /// <summary>
        /// Информация о соединяемых вершинах
        /// </summary>
        public int dest;
        /// <summary>
        /// Их вес
        /// </summary>
        public double weight;

        public Edge_Boruvka(int src, int dest, double weight)
        {
            this.src = src;
            this.dest = dest;
            this.weight = weight;
        }


        /*
        /// <summary>
        /// Вспомогательный метод для получения всех доступных вершин из ребер
        /// </summary>
        /// <param name="lol">Лист с ребрами</param>
        /// <returns></returns>
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

        /// <summary>
        /// Метод для нахождения смежных ребер входяшей вершины
        /// </summary>
        /// <param name="vertice">Текушая вершина</param>
        /// <param name="edges">Лист ребер</param>
        /// <returns></returns>
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
        */
    }


    public class Boruvka
    {
        
        protected class Subset
        {
            public int parent;
            public int rank;
           public Subset(int parent, int rank)
            {
                this.parent = parent;
                this.parent = parent;
            }
        }
        public  List<Edge_Boruvka> MST = new List<Edge_Boruvka>();
        public double MSTweight { get; private set;}
        // V-> Number of vertices, E-> Number of edges 
        private static int v;
        private static int e;
        private List<Edge_Boruvka> edge;

        public Boruvka(List<Edge_Boruvka> List, int vershinbl, int rebra)
        {
            v = vershinbl;
            e = rebra;
            edge = List;
        }

        private int find(List<Subset> subsets, int i)
        {
            // find root and make root as parent of i 
            // (path compression) 
            if (subsets[i].parent != i)
                subsets[i].parent = find(subsets, subsets[i].parent);

            return subsets[i].parent;
        }
        private void Union(List<Subset> subsets, int x, int y)
        {
            int xroot = find(subsets, x);
            int yroot = find(subsets, y);

            // Attach smaller rank tree under root of high 
            // rank tree (Union by Rank) 
            if (subsets[xroot].rank < subsets[yroot].rank)
                subsets[xroot].parent = yroot;
            else if (subsets[xroot].rank > subsets[yroot].rank)
                subsets[yroot].parent = xroot;

            // If ranks are same, then make one as root and 
            // increment its rank by one 
            else
            {
                subsets[yroot].parent = xroot;
                subsets[xroot].rank++;
            }
        }

        public void boruvkaMST()
        {
            List<Subset> subsets = new List<Subset>();
            int[] cheapest = new int[v];

            for (int i = 0; i < v; i++)
            {
                subsets.Add(new Subset(i, 0));
                cheapest[i] = -1;
            }
            int numTrees = v;
            MSTweight = 0;

            while (numTrees > 1)
            {
                for (int z = 0; z < v; ++z)
                {
                    cheapest[z] = -1;
                }

                for (int i = 0; i < e; i++)
                {
                    // Find components (or sets) of two corners 
                    // of current edge 
                    int set1 = find(subsets, edge[i].src);
                    int set2 = find(subsets, edge[i].dest);

                    // If two corners of current edge belong to 
                    // same set, ignore current edge 
                    if (set1 == set2)
                        continue;

                    // Else check if current edge is closer to previous 
                    // cheapest edges of set1 and set2 
                    else
                    {
                        if (cheapest[set1] == -1 ||
                            edge[cheapest[set1]].weight > edge[i].weight)
                            cheapest[set1] = i;

                        if (cheapest[set2] == -1 ||
                            edge[cheapest[set2]].weight > edge[i].weight)
                            cheapest[set2] = i;
                    }
                }
                // Consider the above picked cheapest edges and add them 
                // to MST 
                for (int i = 0; i < v; i++)
                {
                    // Check if cheapest for current set exists 
                    if (cheapest[i] != -1)
                    {
                        int set1 = find(subsets, edge[cheapest[i]].src);
                        int set2 = find(subsets, edge[cheapest[i]].dest);

                        if (set1 == set2)
                            continue;
                        MSTweight += edge[cheapest[i]].weight;
                        MST.Add(new Edge_Boruvka(edge[cheapest[i]].src, edge[cheapest[i]].dest, edge[cheapest[i]].weight));
                        // Console.WriteLine(edge[cheapest[i]].src.ToString() + " --> "+ edge[cheapest[i]].dest.ToString());

                        // Do a union of set1 and set2 and decrease number 
                        // of trees 
                        Union(subsets, set1, set2);
                        numTrees--;
                    }


                }
               // Console.WriteLine("Weight of MST is " + MSTweight);

            }
        }
    }
  /*  public class Boruvka
    {
        // <summary>
        /// Константа 100
        /// </summary>
        private const int MAX = 100;

        /// <summary>
        /// Количество ребер
        /// </summary>
        private int edgesCount;

        /// <summary>
        /// Количество вершин
        /// </summary>
        private int verticesCount;

        /// <summary>
        /// Лист со всей инофрамацией о ребрах
        /// </summary>
        private List<Edge_Boruvka> edges;


        /// <summary>
        /// Массив номеров вершин, для определения зацикливания
        /// </summary>
        private int[] sets;

        /// <summary>
        /// Своистов для получение инфорации о ребрах
        /// </summary>
        public List<Edge_Boruvka> Edges { get { return edges; } }

        /// <summary>
        /// Свойство для получение инфы количество вершин
        /// </summary>
        public int VerticesCount { get { return verticesCount; } }

        /// <summary>
        /// Свойсто для стоимости
        /// </summary>
        public double Cost { get; private set; }

        /// <summary>
        /// Лист использованных ребер в ходе решения
        /// </summary>
        public List<Edge_Boruvka> MST = new List<Edge_Boruvka>();

        /// <summary>
        /// Конструктор для класса "rruvka"
        /// </summary>
        /// <param name="List">лист с ребрами</param>
        /// <param name="vershinbl">количестов вершин</param>
        /// <param name="rebra">количестов ребер</param>
        public Boruvka(List<Edge_Boruvka> List, int vershinbl, int rebra)
        {
            verticesCount = vershinbl;
            edgesCount = rebra;
            edges = List;
           // sets = Edge_Boruvka.GetAllVertices(_edges); //new int[MAX];
            //_edges.Insert(0, null);//Нулевой элемент пустой 

            // Заполняем массив от 1 до кол во вершин костыль так как если вершины не указаны не в нормальном порядке а например 8,9... то не работает (((( 
            //  for (int i = 1; i <= _verticesCount; i++) sets[i] = i;
        }
        
        /// <summary>
        /// Минимальное ребро из предложенных
        /// </summary>
        /// <param name="Adjacent_Vertices">Ребра</param>
        /// <param name="mass">массив </param>
        private void FindMinWeight(List<Edge_Boruvka> Adjacent_Vertices,List<int> mass)
        {

            //Временная переменная для веса
            double temp = 9999;

            //Минимальный вес из всех ребер и проверка на зацикливание
            for (int i = 0; i < Adjacent_Vertices.Count; i++)
            {

                if(true)


                if (Adjacent_Vertices[i].Weight < temp) temp = Adjacent_Vertices[i].Weight;
            }

            foreach (var item in Adjacent_Vertices)
            {
                if (item.Weight < temp) temp = item.Weight;

            }

            //Поиск нужного ребра
            foreach (var item in Adjacent_Vertices)
            {
                if (mass.Contains(item.U) && mass.Contains(item.V))
                {

                    if (temp == item.Weight)
                    {
                        MST.Add(item);
                        chek = true;
                        //Удаляем использованное ребро
                        foreach (var item1 in edges)
                        {
                            if (item.U == item1.U && item.V == item1.V)
                            {
                                edges.Remove(item1);
                                break;
                            }

                        }
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
            //MST.Add(null);
            int z = 0;
            while (edges.Count > 1 )
            {
                sets = Edge_Boruvka.GetAllVertices(edges);
                List<int> mass = sets.ToList();
                
                while (1 < mass.Count-1)
                {
                    
                    int verwina = mass[1];
                    List<Edge_Boruvka> Adjacent_Vertices = Edge_Boruvka.Get_Adjacent_Vertices(verwina, edges);
                    FindMinWeight(Adjacent_Vertices,mass);
                    if (chek)
                    {
                        mass.Remove(verwina);
                        //mass.Remove(MST[z].V);
                        z++;
                    }

                }
                timetostop--;
            }
        }
    }
    */
}
