using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Ho, Ten;
            Ho = "Pham Hoang";
            Ten = "Dung";
            string HoTen = Ho + " " + Ten; // gan chuoi bang toan tu
            Console.WriteLine("Ho va Ten: {0}", HoTen);

            DateTime ngaysinh = new DateTime(1999, 12, 11);
            string dob = string.Format("{0:D}:", ngaysinh);
            Console.WriteLine("Date Of Birth: {0} ", dob);

            char[] letter = {'N','a','m'};
            string gioitinh = new string(letter);
            Console.WriteLine("Gioi Tinh: {0}", gioitinh);
            Console.ReadKey();
        }
    }
}
