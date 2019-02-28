using System;

namespace TinhGiaiThua
{

    class Project_6
    {
        public int TinhGiaiThua(int num)
        {
            int a;
            if (num == 1) /* neu so nhap vao bang 1 thi dung man hinh*/
                return 1;
            else
                a = TinhGiaiThua (num-1)*num; /* nếu số nhập vào khác 1 thì tính giai thừa*/
                return a;               /* trả về giá trị đã tính*/
        }

        static void Main(string[] args)
        {
            Project_6 p = new Project_6();
            Console.WriteLine("Giai thua cua 6 la: {0}", p.TinhGiaiThua(6));
            Console.WriteLine("Gia thua cua 8 la: {0}", p.TinhGiaiThua(8));
            Console.WriteLine("Gia thua cua 10 la {0}", p.TinhGiaiThua(10));
            Console.ReadKey();
        }
    }
}
