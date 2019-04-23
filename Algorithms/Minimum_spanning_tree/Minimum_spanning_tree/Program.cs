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
        {  /*
            первое - количество вершин
            второе - количество ребер
            остальные строки - это номера вершин ребра и его вес
            */
            Kruskal k = new Kruskal(@"4 
                                      6
                                      1 2 1
                                      2 3 3
                                      3 4 2
                                      4 1 5
                                      1 3 4
                                      2 4 6");
           
            k.BuildSpanningTree();
            Console.WriteLine("Cost: " + k.Cost);
            k.DisplayInfo();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
