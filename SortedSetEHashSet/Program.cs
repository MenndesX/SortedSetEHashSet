using System;
using System.Collections.Generic;

namespace SortedSetEHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("teclado");
            set.Add("Mouse");
            set.Add("Monitor");

            Console.WriteLine(set.Contains("Monitor"));

            foreach (string item in set)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Sorted Set:");
            SortedSet<int> a = new SortedSet<int>() { 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 0, 1, 2, 4, 6, 7, 9, 10 };

            printCollection(a);
            printCollection(b);

            //Diferença
            Console.WriteLine("Diferença:");
            SortedSet<int> c = new SortedSet<int>(a);
            c.ExceptWith(b);
            printCollection(c);
           

            //União
            Console.WriteLine("União:");
            SortedSet<int> d = new SortedSet<int>(a);
            d.UnionWith(b);
            printCollection(d);
          

            //Interceção
            Console.WriteLine("Interceção:");
            SortedSet<int> e = new SortedSet<int>(a);
            e.IntersectWith(b);
            printCollection(e);

        }
        static void printCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}