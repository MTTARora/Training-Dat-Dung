using ProjectWeekly.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectWeekly.Helper
{
    class DBHelper : Model.UserModel
    {
        public void DB()
        {
            FileStream f = new FileStream("E:\\Data\\Projects\\Training\\Training-Dat-Dung\\New folder\\d.txt", FileMode.Append, FileAccess.ReadWrite);
        }
        public void insertUser(UserModel user)
        {

        }
        public UserModel getUser()
        {
            return null;
        }


    }
}