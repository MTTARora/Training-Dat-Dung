using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Week_1.Model
{
    class Infomation 
    {
        public void infoMation(UserModel user)
        {
            dangnhap:
            Console.WriteLine("Chon thong tin ban muon hien thi\n1.Thong Tin Nguoi Dung\n2.Danh sach game");
            string chon = Console.ReadLine();
            switch(chon)
            {
                case "1":
                    Console.WriteLine("Ho Ten Nguoi Dung: {0}", user.userName);
                    Console.WriteLine("Email Nguoi Dung: {0}", user.userEmail);
                    Console.WriteLine("So Tien Da Thanh Toan: {0}", user.userPayment);
                    break;
                case "2":
                    game:
                    Console.WriteLine("Chon Game Ma Ban Muon Choi: \n1.PUBG\tThe Loai: Battle_Royale\tGia Thue: 10.000/h\n2.DoBa\tThe Loai: MoBa\tGia Thue: 5.000/h");
                    string select = Console.ReadLine();
                    switch(select)
                    {
                        case "1":
                            Console.WriteLine("Ten Game Ban Da Chon La:");
                            break;
                        case "2":
                            Console.WriteLine("Ten Game Ban Da Chon La:");
                            break;
                            defaul: { Console.WriteLine("Game Ban Chon Khong Co. Vui Long Chon Lai");goto game; }
                    }
                    break;
                default: { Console.Write("Chuc Nang Ban Chon Khong Dung. Vui Long Chon Lai"); goto dangnhap; }
            }
        }
    }
}
