using ProjectWeekly.Helper;
using ProjectWeekly.Model;
using System;
using System.IO;

namespace ProjectWeekly
{
    class Program : UserModel
    {
        static void Main(string[] args)
        {
            UserModel user = new ProjectWeekly.Model.UserModel();
            Display display = new ProjectWeekly.Model.Display();
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
                        playListGame listGame = new ProjectWeekly.Model.playListGame();
                        //string[] game = System.IO.File.ReadAllLines("F:\\New folder\\New folder\\GameList.txt");
                        string[] game = new DBHelper().ReadAllLines(DBHelper.gameFilePath);
                        inforGame infor = new ProjectWeekly.Model.inforGame();
                        Console.WriteLine("Vui lòng chọn\n3. Thông Tin\n4. Danh Sach Game");
                        string choose = Console.ReadLine();
                        switch (choose)
                        {
                            case "3":
                                display.disPlayInformation(user);
                                break;
                            case "4":

                                listGame.gameList(user, infor);
                                break;
                        }

                    }
                    break;       

                default: { Console.WriteLine("Gia trị không hợp lệ"); break; }
            }
            Console.ReadKey();
        }
    
    }
   

}          
           
        