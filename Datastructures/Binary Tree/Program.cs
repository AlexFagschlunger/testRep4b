using System;
using Binary_Tree.models;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1 = 20;
            int p2 = 15;
            int p3 = 30;
            int p4 = 25;
            int p5 = 35;
            int p6 = 22;
            int p7 = 28;
            int p8 = 32;
            int p9 = 38;
            int p10 = 31;
            int p11 = 33;

            BinaryTree bt = new BinaryTree();

            bt.Add(p1);
            bt.Add(p2);
            bt.Add(p3);
            bt.Add(p4);
            bt.Add(p5);
            bt.Add(p6);
            bt.Add(p7);
            bt.Add(p8);
            bt.Add(p9);
            bt.Add(p10);
            bt.Add(p11);

            bt.Remove(16);

            //Console.WriteLine(bt.counter);

            //BinaryTreeItem bt1 = new BinaryTreeItem();

            //bt1 = bt.FindRecursiv(23);
            //bt1 = bt.FindItemBeforeItemToFind(20);
            
            //bt1 = bt.FindMaxRecursiv(3);
            //bt1 = bt.FindMinRecursiv(3);

            

            Console.ReadKey();
        }
    }
}
