using CarLogin.CarRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLogin.DataBase
{
  internal static  class DbExtensions
    {
        public static bool HasUserByEmail(this Table<Users> table, string email)
        {
            bool isFound = false;
            foreach (Users user in table.GetAllData())
            {
                if(user != null)
                {
                    if(user.Email == email)
                    {
                        isFound = true;
                    }
                }
            }
            return isFound;
        }

        public static bool HasUserByPassword(this Table<Users> table,string password)
        {
            bool isFound = false;
            foreach (Users user in table.GetAllData())
            {
                if (user != null)
                {
                    if (user.Password == password)
                    {
                        isFound = true;
                    }
                }
            }
            return isFound;
        }

        public static int UserId(this DbContext dbContext,Users users,string email)
        {
            int Userid = 0;
            dbContext.GetAllData(users.GetType());
            Table<Users> data = dbContext.userData;
            foreach (Users user in data)
            {
                if (user.Email == email)
                {
                    Userid = user.Id;
                }
            }
            return Userid;
        }


    }
}
