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
        { /* /*
            первое - количество вершин
            второе - количество ребер
            остальные строки - это номера вершин ребра и его вес
            */
          //Kruskal k = new Kruskal(@"4 
          //                          6
          //                          1 2 1
          //                          2 3 6
          //                          3 4 2
          //                          4 1 5
          //                          1 3 4
          //                          2 4 3");
            Kruskal k = new Kruskal(@"5
                                      7
                                      1 2 3
                                      2 3 1
                                      2 4 5
                                      3 4 6
                                      3 5 5
                                      4 5 4
                                      5 1 1");

            k.BuildSpanningTree();
            Console.WriteLine("Cost: " + k.Cost);
            k.DisplayInfo();
            Console.WriteLine("Press any key...");
            

            Prim p = new Prim();
            List<Edge_Prim> MST = new List<Edge_Prim>();
            List<Edge_Prim> list = new List<Edge_Prim>();
            list.Add(new Edge_Prim(1, 2, 3));
            list.Add(new Edge_Prim(2, 3, 1));
            list.Add(new Edge_Prim(2, 4, 5));
            list.Add(new Edge_Prim(3, 4, 6));
            list.Add(new Edge_Prim(3, 5, 5));
            list.Add(new Edge_Prim(4, 5, 4));
            list.Add(new Edge_Prim(5, 1, 1));
            //list.Add(new Edge_Prim(1, 2, 5));
            //list.Add(new Edge_Prim(2, 3, 3));
            //list.Add(new Edge_Prim(3, 4, 4));
            //list.Add(new Edge_Prim(4, 5, 11));
            //list.Add(new Edge_Prim(5, 1, 2));
            //list.Add(new Edge_Prim(1, 3, 1));
            p.algorithmByPrim(5,list,MST);
            foreach (var item in MST)
            {
                Console.WriteLine( item.v1.ToString()+"-->"+ item.v2.ToString()+"  Вес :"+ item.weight.ToString());
            }
            
            Console.ReadKey();


        }


    }
}
