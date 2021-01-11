using System;

namespace Pool3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
            int n, i, s = 0;
            Console.WriteLine("Introduceti lungimea vectorului:");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Elementele tabloului sunt:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
            for (i = 0; i < n; i++)
                s = s + a[i];
            Console.WriteLine($"Suma elementelor din tablou este:{s}.");
            Console.ReadKey();
        }
    }
}
