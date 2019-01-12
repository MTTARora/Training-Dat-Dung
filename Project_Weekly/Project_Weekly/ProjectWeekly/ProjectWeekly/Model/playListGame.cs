using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectWeekly.Model
{
    class playListGame : inforGame 
    {
        public void gameList(UserModel user, inforGame game)
        {
            string[] games = System.IO.File.ReadAllLines("F:\\New folder\\New folder\\GameList.txt");
            game:
            Console.WriteLine("Chon game ma ban muốn Choi");
            game.InforGame(user);
            string select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    using (StreamReader sr = new StreamReader("F:\\New folder\\New folder\\GameList.txt")) ;
                    int numGame = 0;
                    foreach (string currenSelect in games)
                        if (numGame == 0)
                            Console.WriteLine(currenSelect + "\nSo gio muon thue:");
                    break;
                //case "2":
                  //  using (StreamReader sr = new StreamReader("F:\\New folder\\New folder\\GameList.txt")) ;
                    //int numGame1 = 0;
                    //foreach (string currenSelect in games)
                      //  if (numGame1 == 0)
                        //    Console.WriteLine(currenSelect);
                   // break;
                default: { Console.WriteLine("game khong co" ); goto game; }
            }
        }

        internal void gameList(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
