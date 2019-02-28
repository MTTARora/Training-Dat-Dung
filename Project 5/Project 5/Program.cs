using System;

namespace Project_5
{
    class FindMax
    {
        public int MAX(int num1, int num2)
        {
            int f;
            if (num1 > num2)
            {
                f = num1;
            }
            else
            {
                f = num2;
            }
            return f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3000;
            int b = 9000;
            int m;
            FindMax f = new FindMax();
            m = f.MAX(a, b);
            Console.WriteLine("Max = {0}", m);
            Console.ReadKey();
        }
    }
}
