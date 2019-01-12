using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectWeekly.Model
{
    class inforGame :UserModel
    {
        

        public void InforGame(UserModel user)
        {
            using (StreamReader sr = new StreamReader("F:\\New folder\\New folder\\GameList.txt")) 
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                
                
            }

        }

    }
}