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
        /// <summary>
        ///         /// Autentica el usuario contra el sistema utilizando credenciales utilizando usuario y contraseña
        /// </summary>
        /// <param name="userName"> Nombre de usuario</param>
        /// <param name="passWord"> Contraseña del usuario</param>
        /// <returns> Retorna Boolean True o False si fue logueado o no </returns>
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
