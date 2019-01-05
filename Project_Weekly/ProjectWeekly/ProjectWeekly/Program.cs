using ProjectWeekly.Model;
using System;

namespace ProjectWeekly
{
    class Program : UserModel
    {
        static void Main(string[] args)
        {
            UserModel user = new ProjectWeekly.Model.UserModel();
            Display display = new ProjectWeekly.Model.Display();
            string[] users = System.IO.File.ReadAllLines("E:\\Data\\Projects\\Training\\Training-Dat-Dung\\New folder\\d.txt");
            Console.WriteLine("Vui lòng chọn\n1. Dang Ki\n2. Dang Nhap");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    display.DisPlaySignUpSreen(user);

                    user.RegisTration();
                    goto case "2";

                    
                // Sign in
                case "2":

                    display.disPlayLogIn(user);
                   
                    if (user.LogIn())
                    {
                        display.disPlayInformation(user);
                           
                    }
                    
                    break;
                    default:    
                    Console.WriteLine("Gia trị không hợp lệ");
                   break;
             }
            
           

            Console.ReadKey();
        }
    }
}
