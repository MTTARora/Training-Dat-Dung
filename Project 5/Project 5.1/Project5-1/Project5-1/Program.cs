using System;

namespace Project5_1
{
    class SLN
    {
        int num1;
        int num2;
        public void Nhap()
        {
            Console.WriteLine("Nhap so thu 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

        }
        public int Max(int num1,int num2)
        {
            int r;
            if (num1 > num2)
                r = num1;
            else
                r = num2;
            return r;
        }
        public void Display()
        {
            Console.WriteLine("So thu 1 la: {0}", num1);
            Console.WriteLine("So thu 2 la: {0}", num2);
            Console.WriteLine("So lon nhat la:{0}", Max(num1,num2));
        }
    }
        
       
    class Chinh
    {
        static void Main(string[] args)
        {
            SLN f = new SLN();
            int c;
            int a ;
            int b ;
            c = f.Max();

        }
    }
}
