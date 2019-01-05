using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Project_Week_1.Helpers
{
    class DBHelper : Model.UserModel
    {

        
        public void DB()
        {
            FileStream f = new FileStream("D:\\Data\\SourceTree\\Train\\Week_1\\Project_Week_1\\Project_Week_1\\DB\\DB.txt", FileMode.Append, FileAccess.ReadWrite);
        }
       //Ghi data
       public void insertData(Model.UserModel user)
        {

        }

        public Model.UserModel user()
        {
            return null;
        }


    }
}
