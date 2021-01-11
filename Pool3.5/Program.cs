using System;

namespace Pool3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
            //Se cere sa se insereze valoarea e in vector pe pozitia k.
            //Primul element al vectorului se considera pe pozitia zero.
            int n, e, k, x;
            Console.WriteLine("Introduceti lungimea vectorului: ");
            n = int.Parse(Console.ReadLine());
          
            int[] v = new int[n];
            int[] a = new int[n + 1];
            Console.WriteLine("Introduceti elementele vectorului: ");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;
            }
            Console.Write("Elementele tabloului sunt:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($" {v[i]}  ");
            }
            Console.WriteLine();
            Console.WriteLine("Introduceti valoarea care trebuie inserata: ");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti pozitia pe care trebuie inserata valoarea: ");
            k = int.Parse(Console.ReadLine());
            for (int i = 0; i < n + 1; i++)
            {
                if (i < k)
                    a[i] = v[i];
                else
                {
                    if (i == k)
                        a[i] = e;
                    else
                        a[i] = v[i - 1];
                }
            }
            Console.WriteLine("Vecdtorul rezultat este:");
            for (int i = 0; i < n + 1; i++)
            Console.Write($"{a[i]} ");
            Console.ReadKey();
        }
    }
}
