using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Week_1.Model
{
    class GameList : Infomation
    {
        public void gameList(UserModel user)
        {
            chon:
            Console.WriteLine("Chon Game Ma Ban Muon Choi: \n1.PUBG\t The Loai: Battle_royale\tGia thue: 10.000/h\n2. Dota2\tTheLoai: Moba\tGia thue: 5.000/h");
            string select = Console.ReadLine();
            switch(select)
            {
                case "1":
                    
                    break;
                case "2":

                    break;
                default: { Console.Write("Game Ban Chon Khong Co. Vui Long Chon Lai"); goto chon; }
            }
        }
    }
}
