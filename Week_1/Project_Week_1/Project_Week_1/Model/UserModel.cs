using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Project_Week_1.Model
{
    class UserModel
    {
        public string userName;
        public string userEmail;
        public string userPassword;
        public int userPayment = 0;

        //Kiem tra user da ton tai hay chua ?
        public bool checkUsers(string userEmail, string [] users)
        {
            var user = users.FirstOrDefault(x => x.Split("-")[1] == userEmail);
            if (user != null)
                return false;
            else
                return true;
        }
        // Kiểm tra password
        public bool checkPass(string userPassword, string[] pass)
        {
            var password = pass.FirstOrDefault(x => x.Split("-")[1] == userPassword && x.Split("-")[0] == userEmail);
            if(password != null)
                return false;
            else
                return true;
            
        }
        //Check điều kiện và đăng kí 
        public bool register()
        {
            string[] users = System.IO.File.ReadAllLines("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\DB.txt");
            if (checkUsers(userEmail, users) == true)
            {
                using (StreamWriter sw = new StreamWriter("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\DB.txt", true)) // chưa hiểu
                {
                    sw.WriteLine(userEmail + "-" + userName);
                    sw.WriteLine(userEmail + "-"+  userEmail);
                    sw.WriteLine(userEmail + "-"+  userPassword);
                    sw.WriteLine(userEmail + "-" + "So Tien Da Thanh Toan =" + userPayment);
                    Console.Write("Tao Thanh Cong\n");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Tai khoan da ton tai");
                return false;
            }
        }
        public bool logIn()
        {
            string[] infor = System.IO.File.ReadAllLines("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\DB.txt");
            if (checkUsers(userEmail, infor) == false && checkPass(userPassword, infor) == false)
            {
                int numData = 0; // Cho biết vị trí của data hiện tại 
                Console.Write("Dang Nhap Thanh Cong\n");
                foreach (string currenLine in infor)
                {
                    if (currenLine.Contains(userEmail) )
                    {
                        //numData++;

                        if (numData == 0)
                        {
                            userName = currenLine.Split("-")[1];
                        }
                       
                        if (numData == 3)
                        {
                            userPayment = int.Parse(currenLine.Split("=")[1]);

                        }
                        numData++;
                    }
                }

                return true;
            }
            else
            {
                Console.Write("Dang Nhap Khong Thanh Cong. Vui Long Kiem Tra Lai Email Va Mat Khau Hoac Dang Ki Tai Khoan\n");
                return false;
            }
        }
        
        /*private void setName(string n)
        {
            userName = n;
        }
        private void setEmail(string e)
        {
            userEmail = e;
        }
        private void setPass(string p)
        {
            userPassword = p;
        }*/
    }
}
