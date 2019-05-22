using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Library
{
   public class Edge_Prim
    {
        /// <summary>
        /// Вершины от --> куда 
        /// </summary>
        public int v1, v2;

        /// <summary>
        /// Вес
        /// </summary>
        public int weight;

        /// <summary>
        /// Коструктор
        /// </summary>
        /// <param name="v1">Вершина от</param>
        /// <param name="v2">Вершина куда</param>
        /// <param name="weight">Вес,стоимость</param>
        public Edge_Prim(int v1, int v2, int weight)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.weight = weight;
        }
    }

    /// <summary>
    /// Алгоритм прима
    /// </summary>
   public class Prim
    {
        
        /// <summary>
        /// Алгоритм прима
        /// </summary>
        /// <param name="numberV">Количество вершин</param>
        /// <param name="E">Входные данные</param>
        /// <param name="MST">Лист ответа</param>
        public void algorithmByPrim(int numberV, List<Edge_Prim> E, List<Edge_Prim> MST)
        {
            //неиспользованные ребра
            List<Edge_Prim> notUsedE = new List<Edge_Prim>(E);
            //использованные вершины
            List<int> usedV = new List<int>();
            //неиспользованные вершины
            List<int> notUsedV = new List<int>();
            for (int i = 0; i <= numberV; i++)
                notUsedV.Add(i);
            //выбираем случайную начальную вершину
            // Random rand = new Random();
            // usedV.Add(rand.Next(0, numberV));
            //Не выбираем,хаха
            usedV.Add(1);
            notUsedV.RemoveAt(usedV[0]);

            while (notUsedV.Count > 0)
            {
                int minE = -1; //номер наименьшего ребра
                               //поиск наименьшего ребра
                for (int i = 0; i < notUsedE.Count; i++)
                {
                    var a = usedV.IndexOf(notUsedE[i].v1);
                   //Проверяем находится ли текушая вершина в использованых и наобарот  
                    if ((usedV.IndexOf(notUsedE[i].v1) != -1) && (notUsedV.IndexOf(notUsedE[i].v2) != -1) ||
                        (usedV.IndexOf(notUsedE[i].v2) != -1) && (notUsedV.IndexOf(notUsedE[i].v1) != -1))
                    {
                        //Если не первый обход
                        if (minE != -1)
                        {
                            //Сравниваем вес текуший вершины с "предыдушей"
                            if (notUsedE[i].weight < notUsedE[minE].weight)
                                minE = i;
                        }

                        else
                            minE = i;
                    }
                    
                        
                }
                if (minE == -1)
                    break;
                //заносим новую вершину в список использованных и удаляем ее из списка неиспользованных
                if (usedV.IndexOf(notUsedE[minE].v1) != -1)
                {
                    usedV.Add(notUsedE[minE].v2);
                    notUsedV.Remove(notUsedE[minE].v2);
                }
                else
                {
                    usedV.Add(notUsedE[minE].v1);
                    notUsedV.Remove(notUsedE[minE].v1);
                }
                //заносим новое ребро в дерево и удаляем его из списка неиспользованных
                MST.Add(notUsedE[minE]);
                notUsedE.RemoveAt(minE);
            }
        }

   }
}
