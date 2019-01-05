using ProjectWeekly.Model;
using System;

namespace ProjectWeekly
{
    class Program
    {
        static void Main(string[] args)
        {
            UserModel user = new ProjectWeekly.Model.UserModel();
            Disphay display = new ProjectWeekly.Model.Disphay();

         display.DisPlaySignUpSreen(user);
         user.RegisTration();

         display.disPlayLogIn(user);
         user.LogIn();

            Console.ReadKey();
        }
    }
}
