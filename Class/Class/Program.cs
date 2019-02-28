using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Box
    {
        public double chieudai;
        public double chieurong;
        public double chieucao;
    }
    public class TheTich
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            double thetich = 0.0;

            Box1.chieucao = 5.25;
            Box1.chieudai = 3.5;
            Box1.chieurong = 7.80;

            Box2.chieucao = 9.0;
            Box2.chieudai = 180.0;
            Box2.chieurong = 120.0;

            thetich = Box1.chieucao * Box1.chieurong * Box1.chieudai;
            Console.WriteLine("The tich cua Box 1 la: {0}", thetich);

            thetich = Box2.chieucao * Box2.chieurong * Box2.chieudai;
            Console.WriteLine("The tich cua Box 2 la: {0}", thetich);

            Console.ReadKey();
        }
    }
}
