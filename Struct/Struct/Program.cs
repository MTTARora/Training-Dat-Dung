using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Book
    {
        public string tensach;
        public string tacgia;
        public string theloai;
        public int masach;
    };
    class Program
    {
        static void Main(string[] args)
        {
            Book Book1;
            Book Book2;
            //thong tin cuon sach thu 1: 
            Book1.tensach = " Lap trinh C#";
            Book1.tacgia = "Anders Hejlsberg";
            Book1.theloai = "IT";
            Book1.masach = 12;

            //thong tin cuon sach thu 2:
            Book2.tensach = "Lam sao de hoc tot C#";
            Book2.tacgia = "Google";
            Book2.theloai = "IT";
            Book2.masach = 11;

            //in thong tin cuon sach thu 1: 
            Console.WriteLine("Thong tin cuon sach thu 1: ");
            Console.WriteLine("Ten cuon sach: {0}", Book1.tensach);
            Console.WriteLine("Tac gia: {0}", Book1.tacgia);
            Console.WriteLine("The loai: {0}", Book1.theloai);
            Console.WriteLine("Ma cuon sach: {0}", Book1.masach);

            //in thong tin cuon sach thu 2: 
            Console.WriteLine("\nThong tin cuon sach thu 2: ");
            Console.WriteLine("Ten cuon sach: {0}", Book2.tensach);
            Console.WriteLine("Tac gia: {0}", Book2.tacgia);
            Console.WriteLine("The loai: {0}", Book2.theloai);
            Console.WriteLine("Ma cuon sach: {0}", Book2.masach);

            Console.ReadKey();
        }
    }
}
