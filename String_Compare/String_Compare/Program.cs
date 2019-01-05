using System;

namespace String_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Pham Hoang Dung"; //khai bao chuoi a;
            string b = "Day la so sanh chuoi"; //khai bao chuoi b;

            Console.WriteLine("Chuoi A da cho la: {0}", a); //in ra chuoi a da cho;
            Console.WriteLine("Chuoi B da cho la: {0}", b); //in ra chuoi b da cho;

            if (string.Compare(a,b)==0) // neu chuoi a va b bang nhau;
            {
                Console.WriteLine("A va B bang nhau"); //in ra man hinh;
            }
            else // neu a va b khong bang nhau;
            {
                Console.WriteLine("A va B khong bang nhau");
            }

            Console.ReadKey();
        }
    }
}
