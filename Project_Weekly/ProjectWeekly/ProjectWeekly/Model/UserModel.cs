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
       

        public bool checkUsers(string userEmail, string [] users)
        {
            var user = users.FirstOrDefault(x => x == userEmail);
            if (user != null)
                return false;
            else
                return true;
        }


        public void RegisTration()
        {
            string[] user = System.IO.File.ReadAllLines("F:\\New folder\\New folder\\d.txt");
            if (checkUsers(userEmail, user) == true)
            {
                using (StreamWriter sw = new StreamWriter("F:\\New folder\\New folder\\d.txt", true, Encoding.UTF8))
                {
                    
                    sw.WriteLine(userName);
                    sw.WriteLine(userEmail);
                    sw.WriteLine(userPassWord);
                    Console.WriteLine("Tạo thành công");
                }   }

            else
            {
                Console.WriteLine("Tài khoản tồn tại ");
            }
                Console.ReadLine();
            
        }

        private bool CheckUsers(string userEmail, string[] user)
        {
            throw new NotImplementedException();
        }

        public void LogIn()
        {
            string[] user = System.IO.File.ReadAllLines("F:\\New folder\\New folder\\d.txt");
            if (checkUsers(userEmail, user) == false) ;
            {
                Console.Write("Email: {0}", userEmail);
                userEmail = Convert.ToString(Console.ReadLine());
                Console.Write("Mat Khau: {0}", userPassWord);
                userPassWord = Convert.ToString(Console.ReadLine());
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
