using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Week_1.Model
{
    class Display : UserModel
    {        
        
        public void signUpScreen(UserModel user)
        {
            Console.Write("Ho Ten: ");
            user.userName = Convert.ToString(Console.ReadLine());
            Console.Write("Email: ");
            user.userEmail = Convert.ToString(Console.ReadLine());
            Console.Write("Mat Khau: ");
            user.userPassword = Convert.ToString(Console.ReadLine());
        }

        public void signInScreen(UserModel user)
        {
            Console.Write("Email: ");
            user.userEmail = Convert.ToString(Console.ReadLine());
            Console.Write("Mat Khau: ");
            user.userPassword = Convert.ToString(Console.ReadLine());
        }

       
    }
}
