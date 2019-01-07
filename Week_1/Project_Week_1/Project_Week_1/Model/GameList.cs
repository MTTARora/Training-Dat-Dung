using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Project_Week_1.Model
{
    class GameList : Infomation
    {
        public void gameList(UserModel user,gameInformation gameInfor)
        {
            string[] games = System.IO.File.ReadAllLines("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\GameList.txt");
            game:
            Console.WriteLine("Chon Game Ma Ban Muon Choi: ");
            gameInfor.inforGame(user);
            Console.Write("Game Ban Chon La: ");
            string select = Console.ReadLine();
            switch(select)
            {
                case "1":
                    string[] inforGame = System.IO.File.ReadAllLines("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\GameList.txt");
                    int numGame = 0;
                    string infor;
                    foreach (string currentSelect in inforGame)
                        if (numGame == 0)
                            //Console.WriteLine(select);
                            infor = currentSelect;

                    break;
                case "2":
                    string[] game = System.IO.File.ReadAllLines("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\GameList.txt");
                    int numGames = 0;
                    foreach (string currentSelect in game)
                        if (numGames == 1)
                            Console.WriteLine(currentSelect);
                    break;

                default: { Console.WriteLine("Game Ban Chon Hien Khong Co. Vui Long Chon Lai."); goto game; }

            }

        }
    }
}
