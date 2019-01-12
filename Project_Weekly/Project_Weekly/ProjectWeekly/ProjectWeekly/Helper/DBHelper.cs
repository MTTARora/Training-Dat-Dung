using ProjectWeekly.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectWeekly.Helper
{
    class DBHelper : Model.UserModel
    {
        public static DBHelper instance = null; 

        public static string userFilePath = "D:\\Projects\\New folder\\user.txt";
        public static string gameFilePath = "D:\\Projects\\New folder\\game.txt";

       public static DBHelper getInstance()
        {
            if(instance == null)
            {
                instance = new DBHelper();
            }

            return instance;

        }

        // CONTRUCTORS 

        public FileStream DB()
        {
            FileStream f = new FileStream(userFilePath, FileMode.Append, FileAccess.ReadWrite);
            return f;
        }

        public FileStream  GameDB()
        {
            FileStream f = new FileStream(gameFilePath, FileMode.Append, FileAccess.ReadWrite);
            return f;

        }

        // METHODS

        public string[] ReadFileUser()
        {
            string[] users = System.IO.File.ReadAllLines(DBHelper.userFilePath);
            return users;
        }

        public string[] ReadAllLines(string filePath)
        {

            string[] lines = System.IO.File.ReadAllLines(filePath);
            return lines;

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