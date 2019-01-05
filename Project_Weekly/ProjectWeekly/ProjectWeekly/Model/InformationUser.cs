using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProjectWeekly.Model
{
    class InformationUser :Model.UserModel
    {
        public void Information()
        {
            string[] users = System.IO.File.ReadAllLines("E:\\Data\\Projects\\Training\\Training-Dat-Dung\\New folder\\d.txt");
            Console.WriteLine("Chon \n1. Thong tin tai  \n2.  danh sach game");
            string chon = Console.ReadLine();

            switch(chon)
            {
                case "1":
                    Console.WriteLine("Ho ten",userName);
                    Console.WriteLine("Email:", userEmail);
                        break;
                case "2":

                    break;
            }
        }

    }
}
