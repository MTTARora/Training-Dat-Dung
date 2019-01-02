using System;
using System.IO;
using System.Linq;
using Project_Week_1.Model;

namespace Project_Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserModel u = new Model.UserModel();
            Model.Display d = new Model.Display();
            d.disPlaySign();
            u.Sign();
            

            Console.ReadKey();

        }
    }
}

