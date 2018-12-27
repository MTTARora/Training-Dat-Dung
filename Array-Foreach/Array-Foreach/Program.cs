using System;

namespace Array_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];
            for (int i = 0; i < 20; i++) 
                a[i] = i + 20;
            foreach(int j in a)
            {
                int i = j - 20;
                Console.WriteLine("Phan tu [{0}]= {1}", i, j);
                i++;
            }
            Console.ReadKey();
        }
    }
}
