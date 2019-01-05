using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double r;
            Console.WriteLine("Nhap ban kinh r: ");
            r = Convert.ToDouble(Console.ReadLine());
            double dientich = pi * r * r;
            Console.WriteLine("Ban kinh ban da nhap la: {0} \nDien tich hinh tron la: {1}", r, dientich);
            Console.ReadKey();
        }
    }
}
