using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWeekly.Model
{
    class Disphay : UserModel
    {
       
        public void DisPlaySignUpSreen(UserModel user)
        {
            Console.Write("Ho Ten: {0}");
            user.userName = Convert.ToString(Console.ReadLine());
            Console.Write("Email: {0}");
            user.userEmail = Convert.ToString(Console.ReadLine());
            Console.Write("Mat Khau: {0}");
            user.userPassWord = Convert.ToString(Console.ReadLine());
        }

        public void disPlayLogIn(UserModel user)
        {
            Console.Write("Email: {0}"); 
            user.userEmail = Convert.ToString(Console.ReadLine());
            Console.Write("Mat Khau: {0}"); 
            user.userPassWord = Convert.ToString(Console.ReadLine());
        }
    }
}
