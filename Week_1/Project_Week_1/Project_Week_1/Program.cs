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
            UserModel user = new Model.UserModel();
            Model.Display display = new Model.Display();
            Model.Infomation info = new Model.Infomation();
            string[] users = System.IO.File.ReadAllLines("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\DB.txt");
            /*display.signUpScreen(user);
            user.register();
            display.signInScreen(user);
            user.logIn();
            display.inFormation(user);*/
            lap:
            Console.Write("Chon chuc nang ban muon:\n1.Dang Ki\n2.Dang Nhap\nChuc Nang Ban Chon La: ");
            string chon = Console.ReadLine();
            switch(chon)
            {
                case "1":
                    Console.WriteLine("\nDang Ki: ");
                    display.signUpScreen(user);
                    if (user.register() == true)
                    {
                        goto lap;
                    }
                    break;
                case "2":
                    Console.WriteLine("\nDang Nhap:");
                    display.signInScreen(user);
                    if (user.logIn())
                    {
                        info.infoMation(user);
                    }
                    else
                    {
                        goto lap;
                    }

                    break;
                default: { Console.WriteLine("Ban da nhap sai vui long nhap lai\n"); goto lap; }
            }

            Console.ReadKey();

        }
    }
}

