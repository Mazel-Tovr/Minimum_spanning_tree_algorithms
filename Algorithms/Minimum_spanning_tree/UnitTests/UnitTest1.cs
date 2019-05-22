using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms_Library;
using System.Collections.Generic;


namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPrim1()
        {
            
            Prim p = new Prim();
            List<Edge_Prim> MST = new List<Edge_Prim>();
            List<Edge_Prim> list = new List<Edge_Prim>();
            list.Add(new Edge_Prim(1, 2, 1));
            list.Add(new Edge_Prim(2, 3, 4));
            list.Add(new Edge_Prim(2, 4, 2));
            list.Add(new Edge_Prim(4, 3, 3));
            p.algorithmByPrim(4, list, MST);

            List<Edge_Prim> MST_Test = new List<Edge_Prim>();
            MST_Test.Add(new Edge_Prim(1, 2, 1));
            MST_Test.Add(new Edge_Prim(2, 4, 2));
            MST_Test.Add(new Edge_Prim(4, 3, 3));

            for (int i = 0; i < MST.Count; i++)
            {
                Assert.AreEqual(MST_Test[i].v1, MST[i].v1);
                Assert.AreEqual(MST_Test[i].v2, MST[i].v2);

            }
            
        }

        [TestMethod]
        public void TestMethodPrim2()
        {
            Prim p = new Prim();
            List<Edge_Prim> MST = new List<Edge_Prim>();
            List<Edge_Prim> list = new List<Edge_Prim>();
            list.Add(new Edge_Prim(1, 2, 1));
            list.Add(new Edge_Prim(2, 3, 2));
            list.Add(new Edge_Prim(2, 4, 4));
            list.Add(new Edge_Prim(3, 4, 3));
            p.algorithmByPrim(3, list, MST);

            List<Edge_Prim> MST_Test = new List<Edge_Prim>();
            MST_Test.Add(new Edge_Prim(1, 2, 1));
            MST_Test.Add(new Edge_Prim(2, 3, 2));
            MST_Test.Add(new Edge_Prim(3, 4, 3));

            for (int i = 0; i < MST.Count; i++)
            {
                Assert.AreEqual(MST_Test[i].v1, MST[i].v1);
                Assert.AreEqual(MST_Test[i].v2, MST[i].v2);

            }
        }
        [TestMethod]
        public void TestMethodPrim3()
        {
            Prim p = new Prim();
            List<Edge_Prim> MST = new List<Edge_Prim>();
            List<Edge_Prim> list = new List<Edge_Prim>();
            list.Add(new Edge_Prim(1, 2, 2));
            list.Add(new Edge_Prim(2, 3, 6));
            list.Add(new Edge_Prim(2, 4, 4));
            list.Add(new Edge_Prim(3, 4, 2));
            list.Add(new Edge_Prim(3, 5, 3));
            list.Add(new Edge_Prim(4, 5, 2));
            list.Add(new Edge_Prim(5, 1, 1));

            p.algorithmByPrim(5, list, MST);

            List<Edge_Prim> MST_Test = new List<Edge_Prim>();

            MST_Test.Add(new Edge_Prim(5, 1, 1));
            MST_Test.Add(new Edge_Prim(1, 2, 2));
            MST_Test.Add(new Edge_Prim(4, 5, 2));
            MST_Test.Add(new Edge_Prim(3, 4, 2));

            for (int i = 0; i < MST.Count; i++)
            {
                Assert.AreEqual(MST_Test[i].v1, MST[i].v1);
                Assert.AreEqual(MST_Test[i].v2, MST[i].v2);

            }

        }
        [TestMethod]
        public void TestMethodPrim4()
        {
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

            p.algorithmByPrim(5, list, MST);

            List<Edge_Prim> MST_Test = new List<Edge_Prim>();

            MST_Test.Add(new Edge_Prim(5, 1, 1));
            MST_Test.Add(new Edge_Prim(1, 2, 3));
            MST_Test.Add(new Edge_Prim(2, 3, 1));
            MST_Test.Add(new Edge_Prim(4, 5, 4));

            for (int i = 0; i < MST.Count; i++)
            {
                Assert.AreEqual(MST_Test[i].v1, MST[i].v1);
                Assert.AreEqual(MST_Test[i].v2, MST[i].v2);

            }
        }
       


        [TestMethod]
        public void TestMethodKruskal1()
        {
            Kruskal k = new Kruskal(@"4
                                      4
                                      1 2 1
                                      2 3 4
                                      2 4 2
                                      4 3 3");

            k.BuildSpanningTree();


            Assert.AreEqual(1,k.tree[1,1]);Assert.AreEqual(2, k.tree[1, 2]);
            Assert.AreEqual(2, k.tree[2, 1]); Assert.AreEqual(4, k.tree[2, 2]);
            Assert.AreEqual(4, k.tree[3, 1]); Assert.AreEqual(3, k.tree[3, 2]);



        }

        [TestMethod]
        public void TestMethodKruskal2()
        {
            Kruskal k = new Kruskal(@"4
                                      4
                                      1 2 1
                                      2 3 2
                                      2 4 4
                                      3 4 3");

            k.BuildSpanningTree();


            Assert.AreEqual(1, k.tree[1, 1]); Assert.AreEqual(2, k.tree[1, 2]);
            Assert.AreEqual(2, k.tree[2, 1]); Assert.AreEqual(3, k.tree[2, 2]);
            Assert.AreEqual(3, k.tree[3, 1]); Assert.AreEqual(4, k.tree[3, 2]);
        }
        [TestMethod]
        public void TestMethodKruskal3()
        {
            Kruskal k = new Kruskal(@"5
                                      7
                                      1 2 2
                                      2 3 6
                                      2 4 4
                                      3 4 2
                                      3 5 3
                                      4 5 2
                                      5 1 1");

            k.BuildSpanningTree();
            Assert.AreEqual(5, k.tree[1, 1]); Assert.AreEqual(1, k.tree[1, 2]);
            Assert.AreEqual(1, k.tree[2, 1]); Assert.AreEqual(2, k.tree[2, 2]);
            Assert.AreEqual(3, k.tree[3, 1]); Assert.AreEqual(4, k.tree[3, 2]);
            Assert.AreEqual(4, k.tree[4, 1]); Assert.AreEqual(5, k.tree[4, 2]);
        }
        [TestMethod]
        public void TestMethodKruskal4()
        {
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
            Assert.AreEqual(2, k.tree[1, 1]); Assert.AreEqual(3, k.tree[1, 2]);
            Assert.AreEqual(5, k.tree[2, 1]); Assert.AreEqual(1, k.tree[2, 2]);
            Assert.AreEqual(1, k.tree[3, 1]); Assert.AreEqual(2, k.tree[3, 2]);
            Assert.AreEqual(4, k.tree[4, 1]); Assert.AreEqual(5, k.tree[4, 2]);
        }
      

    }
}
