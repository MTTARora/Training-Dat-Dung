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
        public void DB()
        {
            FileStream f = new FileStream("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\DB.txt", FileMode.Append,FileAccess.ReadWrite);
        }
        //Check điều kiện và đăng kí 
        public void Sign()
        {
            string[] user = System.IO.File.ReadAllLines("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\DB.txt");
            if (checkUsers(userEmail, user) == true)
            {
                Console.WriteLine("Tao thanh cong");
                //StreamWriter sw = new StreamWriter("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\DB.txt", true,Encoding.UTF8);
                //sw.WriteLine();
                //sw.Close();
                using (StreamWriter sw = new StreamWriter("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\DB.txt", true, Encoding.UTF8))
                {
                    userName = Convert.ToString(Console.ReadLine());
                    sw.Write(userName);
                }
            }
         
            else
            {
                Console.WriteLine("Tai khoan da ton tai");
                Console.ReadLine();
            }
        }
        /*public void logIn()
        {
            string user = null;
            if (checkUsers(userEmail, user) == false)
            {
                Console.Write("Email: {0}", userEmail);
                userEmail = Convert.ToString(Console.ReadLine());
                Console.Write("Mat Khau: {0}", userPassword);
                userPassword = Convert.ToString(Console.ReadLine());
            }
        }*/

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
            userPassword = p;
        }

        

    }
}
