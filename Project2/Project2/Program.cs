using System;
using System.Text;

namespace Project21
{
    class DienTichHinhChuNhatApplication
    {
        class Dientich
        {
            public double dai;
            public double rong ;

            public void Nhap()
            {
                Console.WriteLine("Moi nhap chieu dai: ");
                dai = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Moi nhap chieu rong: ");
                rong = Convert.ToDouble(Console.ReadLine());
            }
            public double Ketqua()
            {
                return dai * rong;
            }
            public void Print()
            {
                Console.WriteLine("Chieu dai da nhap la: {0}", dai);
                Console.WriteLine("Chieu rong da nhap la: {0}", rong);
                Console.WriteLine("Dien tich hinh chu nhat la: {0}", Ketqua());
            }
        }
        class HienthiraDisplay
        {
            static void Main(string[] args)
            {
                Dientich d = new Dientich();
                d.Nhap();
                d.Print();
                Console.ReadKey();
            }
        }
    }
}
