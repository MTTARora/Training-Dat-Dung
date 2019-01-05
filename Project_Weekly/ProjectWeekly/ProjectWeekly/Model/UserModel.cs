using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectWeekly.Model
{
    class UserModel
    {
        public string userName;
        public string userEmail;
        public string userPassWord;
        public int soTienThanhToan = 0;

        public bool checkUsers(string userEmail, string[] users)
        {   
            var user = users.FirstOrDefault(x => x.Split("-")[1] == userEmail);
            if (user != null)
                return false;
            else
                return true;

        }
        public bool checkPassWord(string userPassWord, string[]usersPassWord )
        {
            var userPass = usersPassWord.FirstOrDefault(x => x.Split("-")[0] == userEmail && x.Split("-")[1] ==  userPassWord);
            if (userPass != null)
                return false;
            else
                return true;
        }


        public bool RegisTration()
        {
            string[] user = System.IO.File.ReadAllLines("E:\\Data\\Projects\\Training\\Training-Dat-Dung\\New folder\\d.txt");
            if (checkUsers(userEmail, user) == true)
            {
                using (StreamWriter sw = new StreamWriter("E:\\Data\\Projects\\Training\\Training-Dat-Dung\\New folder\\d.txt", true, Encoding.UTF8))
                {
                    
                    sw.WriteLine(userEmail + "-" + userName);
                    sw.WriteLine(userEmail + "-" + userEmail);
                    sw.WriteLine(userEmail + "-" + userPassWord);
                    sw.WriteLine(userEmail + "- Số tiền đã thanh toán = " + soTienThanhToan);
                    Console.WriteLine("Tạo thành công");
                    return true;
                }   }

            else
            {
                Console.WriteLine("Tài khoản tồn tại ");
                return false;
            }
                Console.ReadLine();
            
        }

        private bool CheckUsers(string userEmail, string[] user)
        {
            throw new NotImplementedException();
        }

        public bool LogIn()
        {

            // Get data from DB
            string[] infos = System.IO.File.ReadAllLines("E:\\Data\\Projects\\Training\\Training-Dat-Dung\\New folder\\d.txt");

            // Kiểm tra đăng nhập thành công
            if (checkUsers(userEmail, infos) == false && checkPassWord(userPassWord, infos) == false)
            {
                Console.WriteLine("Dang nhap thanh cong");
                // Compare email to data from db
                int numData = 0; // Nhận biết vị trí data chứa email hiện tại
                foreach (string currentLine in infos)
                {
                    if (currentLine.Contains(userEmail))
                    {
                        
                        if (numData == 0)
                        {
                            userName = currentLine.Split("-")[1];
                        }
                        if (numData == 3)
                        {
                            soTienThanhToan = int.Parse(currentLine.Split("=")[1]);
                        }
                        numData++;
                    }
                }
                
                return true;
            }
            else
            {
                Console.WriteLine("Dang nhap that bai. Vui long kiem tra lai email va mat khau. Neu chua dang ki vui long dang ki");
                return false;
            }
        }

        private bool checkUsers(string userEmail, string user)
        {
            throw new NotImplementedException();
        }

        private void setName(string n)
        {
            userName = n;
        }
        private void setEmail(string e)
        {
            userEmail = e;
        }
        private void setPass(string p)
        {
            userPassWord = p;
        }




    }
}
