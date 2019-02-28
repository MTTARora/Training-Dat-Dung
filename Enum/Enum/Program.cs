using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum // Enum: Liệt kê;
{
    class Program
    {
        enum Stuff{Sun,Mon,Tue, Wed,Thur,Fri,Sat};
        static void Main(string[] args)
        {
            int dautuan = (int)Stuff.Mon;
            int cuoituan = (int)Stuff.Sat;
            Console.WriteLine("Dau tuan: {0}", dautuan);
            Console.WriteLine("Cuoi tuan: {0}", cuoituan);

            Console.ReadKey();
        }
    }
}
