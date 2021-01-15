using System;

namespace Pool3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, x;
            Console.WriteLine("Introduceti numarul de elemente al tabloului: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] v_final = new int[n - 1];
            Console.WriteLine("Introduceti elementele tabloului : ");
            for (int i = 0; i < n; i++)
            {

                x = int.Parse(Console.ReadLine());
                v[i] = x;
            }
            Console.WriteLine("Introduceti pozitia de pe care trebuie stearsa valoarea corespunzatoare: ");
            k = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                if (i == k)
                    v_final[i] = v[i + 1]; 
                else
                {
                    if (i < k)
                        v_final[i] = v[i];
                    else
                        v_final[i] = v[i + 1];
                }


            }
            Console.WriteLine();
            for (int i = 0; i < n - 1; i++)
                Console.Write($"{v_final[i]} ");
            Console.ReadKey();

        }
    }
}
