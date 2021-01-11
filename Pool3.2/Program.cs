using System;

namespace Pool3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da un vector cu n elemente si o valoare k. 
            //Se cere sa se determine prima pozitie din vector pe care apare k. 
            //Daca k nu apare in vector rezultatul va fi -1.
            int n, i, k, z = 0, u = 0;
            Console.WriteLine("Introduceti lungimea vectorului:");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea cautata:");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Elementele tabloului sunt:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
           for (i = 0; i < n; i++)
            {
                if (a[i] == k)
                    z = 1;
                u = i;
            }
            if (z == 1)
                Console.WriteLine($"Valoarea {k} se afla pe pozitia {u}.");
            else
                Console.WriteLine("-1");
            Console.ReadKey();
        }
    }
}
