using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? num1 = null;
            double? num2 = 3.209876;
            double num3;
            num3 = num1 ?? 452433123123134;
            Console.WriteLine("Gia tri cua num 3: {0}",num3);
            num3 = num2 ?? 452433123123134;
            Console.WriteLine("Gia tri cua num3: {0}", num3);
            Console.ReadKey();
        }
    }
}
