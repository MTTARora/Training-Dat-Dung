using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Project_Week_1.Model
{
    class gameInformation
    {
        public void inforGame(UserModel user)
        {
            using (StreamReader sr = new StreamReader("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\GameList.txt"))
            {
                string chon;
                while ((chon = sr.ReadLine()) != null)
                        Console.WriteLine(chon);

            }


        }
    }
}
