using System;

namespace Project2
{
    class DienTichHinhChuNhatApplication
    {
        class Dientich
        {
            float dai;
            float rong;

            public void Nhap()
            {
                Console.WriteLine("Nhap chieu dai:  " + Console.ReadLine(),dai);
                Console.WriteLine("Nhap chieu rong:  " + Console.ReadLine(),rong);
            }
            public double Ketqua()
            {
                return dai * rong;
            }
            public void In()
            {
                Console.WriteLine("Dai: {0}", dai);
                Console.WriteLine("Rong: {0}", rong);
                Console.WriteLine("Dien tich hinh chu nhat: {0}", Ketqua());
            }
        }
        class HienthiraDisplay
        {
            static void Main(string[] args)
            {
                Dientich d = new Dientich();
                d.Nhap();
                d.Ketqua();
                d.In();
                Console.ReadKey();
            }
        }
    }
}
