using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Week_1.Model
{
    class Display : UserModel
    {        
        
        public void disPlaySign()
        {
            Console.Write("Ho Ten: {0}",userName);
            userName = Convert.ToString(Console.ReadLine());
            Console.Write("Email: {0}", userEmail);
            userEmail = Convert.ToString(Console.ReadLine());
            Console.Write("Mat Khau: {0}", userPassword);
            userPassword = Convert.ToString(Console.ReadLine());
        }

        public void disPlayLog()
        {
            Console.Write("Email: {0}", userEmail);
            userEmail = Convert.ToString(Console.ReadLine());
            Console.Write("Mat Khau: {0}", userPassword);
            userPassword = Convert.ToString(Console.ReadLine());
        }
    }
}
