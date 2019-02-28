using System;

namespace Nullable1
{
    class Program
    {

        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 145;
            double? num3 = new double?();
            double? num4 = 3.25;
            bool? Bool = new bool?();
            Console.WriteLine("Gia tri Nullable kieu int: {0} , {1}, {2}, {3} ", num1, num2, num3, num4);
            Console.WriteLine("Gia tri Nullable kieu bool: {0}", Bool);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
