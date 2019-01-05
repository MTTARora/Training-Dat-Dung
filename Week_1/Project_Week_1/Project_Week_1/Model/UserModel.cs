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

        //Kiem tra user da ton tai hay chua ?
        public bool checkUsers(string userEmail, string [] users)
        {
            var user = users.FirstOrDefault(x => x == userEmail);
            if (user != null)
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
                    //userEmail = Convert.ToString(Console.ReadLine()+ Environment.NewLine);
                    sw.WriteLine(userName);
                    sw.WriteLine(userEmail);
                    sw.WriteLine(userPassword);
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
            string[] users = System.IO.File.ReadAllLines("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\DB.txt");
            if (checkUsers(userEmail, users) == false)
            {
                Console.Write("Dang Nhap Thanh Cong\n");
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
