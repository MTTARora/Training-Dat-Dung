using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Week_1.Model
{
    class Infomation 
    {
        public void infoMation(UserModel user, Display display, GameList Game,gameInformation gameInfor)
        {
            dangnhap:
            Console.Write("Chon thong tin ban muon hien thi\n1.Thong Tin Nguoi Dung\n2.Danh sach game\nChuc Nang Ban Chon La: ");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    display.inforUser(user);
                    break;
                case "2":
                    string[] games = System.IO.File.ReadAllLines("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\GameList.txt");
                    Game.gameList(user,gameInfor);
            
                    break;
                default: { Console.Write("Chuc Nang Ban Chon Khong Dung. Vui Long Chon Lai"); goto dangnhap; }
            }
        }
    }
}
