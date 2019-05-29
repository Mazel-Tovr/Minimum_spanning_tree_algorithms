using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_Library;

namespace Minimum_spanning_tree
{
    class Program
    {
        static void Main(string[] args)
        { /* 
            первое - количество вершин
            второе - количество ребер
            остальные строки - это номера вершин ребра и его вес
            
            Kruskal k = new Kruskal(@"12 
                                    19
                                    0 1 1
                                    0 10 8
                                    0 9 8
                                    0 8 3
                                    1 2 4
                                    1 10 4
                                    2 3 5
                                    2 10 2
                                    3 11 1
                                    3 4 10
                                    4 11 9
                                    4 5 5
                                    5 6 6
                                    6 11 11
                                    6 7 6
                                    7 10 5
                                    7 8 5
                                    8 10 4
                                    8 9 7");
           */

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

            Kruskal k = new Kruskal(list, 12, list.Count);
            k.BuildSpanningTree();

            for (int i = 1; i < 12; i++)
            {
                Console.WriteLine(k.tree[i, 1] + " --> " + k.tree[i, 2]);
            }
            Console.WriteLine("Cost: " + k.Cost);
            Console.WriteLine("Press any key...");
           
            
           /* 
           Prim p = new Prim();
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
           //list.Add(new Edge_Prim(1, 2, 3));
           //list.Add(new Edge_Prim(2, 3, 1));
           //list.Add(new Edge_Prim(2, 4, 5));
           //list.Add(new Edge_Prim(3, 4, 6));
           //list.Add(new Edge_Prim(3, 5, 5));
           //list.Add(new Edge_Prim(4, 5, 4));
           //list.Add(new Edge_Prim(5, 1, 1));
           //list.Add(new Edge_Prim(1, 2, 5));
           //list.Add(new Edge_Prim(2, 3, 3));
           //list.Add(new Edge_Prim(3, 4, 4));
           //list.Add(new Edge_Prim(4, 5, 11));
           //list.Add(new Edge_Prim(5, 1, 2));
           //list.Add(new Edge_Prim(1, 3, 1));
           p.algorithmByPrim(12,list,MST);
           int weight = 0;
           foreach (var item in MST)
           {
               Console.WriteLine( item.v1.ToString()+"-->"+ item.v2.ToString()+"  Вес :"+ item.weight.ToString());
               weight += item.weight;
           }
           Console.WriteLine("Минимальный вес "+ weight);
           Console.ReadKey();

           */
           //List<Edge_Boruvka> list = new List<Edge_Boruvka>();
           //list.Add(new Edge_Boruvka(0, 1, 1));
           //list.Add(new Edge_Boruvka(0, 10, 8));
           //list.Add(new Edge_Boruvka(0, 9, 8));
           //list.Add(new Edge_Boruvka(0, 8, 3));
           //list.Add(new Edge_Boruvka(1, 2, 4));
           //list.Add(new Edge_Boruvka(1, 10, 4));
           //list.Add(new Edge_Boruvka(2, 3, 5));
           //list.Add(new Edge_Boruvka(2, 10, 2));
           //list.Add(new Edge_Boruvka(3, 11, 1));
           //list.Add(new Edge_Boruvka(3, 4, 10));
           //list.Add(new Edge_Boruvka(4, 11, 9));
           //list.Add(new Edge_Boruvka(4, 5, 5));
           //list.Add(new Edge_Boruvka(5, 6, 6));
           //list.Add(new Edge_Boruvka(6, 11, 11));
           //list.Add(new Edge_Boruvka(6, 7, 6));
           //list.Add(new Edge_Boruvka(7, 10, 5));
           //list.Add(new Edge_Boruvka(7, 8, 5));
           //list.Add(new Edge_Boruvka(8, 10, 4));
           //list.Add(new Edge_Boruvka(8, 9, 7));
           //Boruvka br = new Boruvka(list, 12, list.Count);
           //br.boruvkaMST();
           //foreach (var item in br.MST)
           //{
           //    Console.WriteLine(item.src.ToString() + "-->" + item.dest.ToString() + "  Вес :" + item.weight.ToString());
           //}
           Console.ReadKey();

        }


    }
}
