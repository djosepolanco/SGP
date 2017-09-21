using SGP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Repository
{
    public class UsersRepository
    {

        public Boolean Login(string userName, string passWord)
        {
            bool isAuthenticated = false;

            using (var DB = new DBContext())
            {
                isAuthenticated = DB.Users.Where(
                u => u.UserName.Equals(userName) &&
                u.PassWord.Equals(passWord)).Count() > 0;
            }

            return isAuthenticated;
        }
    }
}
