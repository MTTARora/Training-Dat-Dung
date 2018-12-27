using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10]; // a la mot mang co 10 phan tu;
            int i, j;
            for (i = 0; i < 10; i++)
                a[i] = i+0;
            for (j = 0; j < 10; j++)
                Console.WriteLine("Phan tu[{0}]: {1}", j, a[j]);
            Console.ReadKey();
        }
    }
}
