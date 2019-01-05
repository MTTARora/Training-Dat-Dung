using System;

namespace Inheritance
{
    class Hinhchunhat
    {
        public double chieudai;
        public double chieurong;
        public void setchieudai(double l)
        {
            chieudai = l;
        }
        public void setchieurong(double w)
        {
            chieurong = w;
        }
    }
    class Dientich : Hinhchunhat
    {
        public double dientich()
        {
            return (chieudai * chieurong);
        }
    }


     class HamChinh
    {
       static void Main(string[] args)
       {
            Dientich d = new Dientich();
            Hinhchunhat h = new Hinhchunhat();
            d.setchieudai(5);
            d.setchieurong(6);
            Console.WriteLine("Dien tich hinh chu nhat la: {0}", d.dientich());
            Console.ReadKey();
       }
    }
}
