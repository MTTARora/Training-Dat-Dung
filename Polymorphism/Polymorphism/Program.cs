using System;

namespace Polymorphism
{
    class Program
    {
        void print(int i)
        {
            Console.WriteLine("In so nguyen: {0}", i);
        }

        void print(double f)
        {
            Console.WriteLine("In so thuc: {0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("in chuoi: {0}", s);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.print(5);
            p.print(3.25);
            p.print("Hello World");

            Console.ReadKey();

        }
    }
}
