using System;

namespace Pool3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.
            int n, i;
            Console.Write("Introduceti lungimea vectorului: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elementele tabloului sunt:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
            int c = 0;
            int min = a[0];
            for (i = 0; i < n; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            int max = a[0];
            int b = 0;
            for (i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            for (i = 0; i < n; i++)
            { 
                if (a[i] == min)
                {
                    c++;
                }
            }
            for (i = 0; i < n; i++)
            { 
                if (a[i] == max)
                {
                    b++;
                } 
            }
            Console.WriteLine($"Cea mai mare valoare este {max} si apare de {b} ori.");
            Console.WriteLine($"Cea mai mica valoare este {min} si apare de {c} ori.");
            Console.ReadKey();
        }
    }
}
