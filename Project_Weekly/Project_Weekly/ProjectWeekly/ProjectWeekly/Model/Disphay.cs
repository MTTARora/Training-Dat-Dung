using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWeekly.Model
{
    class Display
    {
        private object playList;

        public void DisPlaySignUpSreen(UserModel user, Display display , playListGame game, inforGame infor)
        {
            Console.Write("Ho Ten: ");
            user.userName = Convert.ToString(Console.ReadLine());
            Console.Write("Email: ");
            user.userEmail = Convert.ToString(Console.ReadLine());
            Console.Write("Mat Khau: ");
            user.userPassWord = Convert.ToString(Console.ReadLine());
        }

        public void disPlayLogIn(UserModel user)
        {
                    
          Console.Write("Email: ");
          user.userEmail = Convert.ToString(Console.ReadLine());
             
          Console.Write("Mat Khau: ");
          user.userPassWord = Convert.ToString(Console.ReadLine());
                                
        }

        internal void DisPlaySignUpSreen(UserModel user)
        {
            throw new NotImplementedException();
        }

        public void disPlayInformation(UserModel user)
        {
            Console.WriteLine("ho Ten:{0}", user.userName);
            Console.WriteLine("Email: {0}", user.userEmail);
            Console.WriteLine("So tien da thanh toan:{0}",user.soTienThanhToan);
        }
        
        
    }
}
