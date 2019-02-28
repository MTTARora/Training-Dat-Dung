using System;

namespace Project4_1
{
    class ChuyenDoiDoNguoiDungNhap
    {
        public double d ;
        public void Nhap()
        {
            Console.WriteLine("Nhap So Ban Muon Chuyen Doi: ", d);
            d = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            int i = (int)d;
            Console.WriteLine("So Ban Muon Chuyen Doi La: {0}", d);
            Console.Write("So Da Chuyen Doi La: {0}", i);
        }
        static void Main(string[] args)
        {
            ChuyenDoiDoNguoiDungNhap c = new ChuyenDoiDoNguoiDungNhap();
            c.Nhap();
            c.Display();
            Console.ReadKey();
        }
    }
}
