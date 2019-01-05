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
            lap:
            Console.WriteLine("Chon chuc nang ban muon: \n1.Dang Ki\n2.Dang Nhap");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    display.signUpScreen(user);
                    user.register();
                    if (user.checkUsers(user.userEmail, users) == false)
                        goto case "2";
                    break;
                case "2":
                    display.signInScreen(user);
                    user.logIn();
                    break;
                default:{ Console.Write("Ban da nhap sai vui long nhap lai \n"); goto lap; }
            }
           // Console.ReadLine();
            Console.ReadKey();

        }
    }
}

