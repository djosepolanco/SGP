﻿using SGP.Helpers;
using SGP.Repository;
using System;
using System.Windows.Forms;

namespace SGP.Forms
{
    public partial class Login : Form
    {
        #region global Declariations 
        private UsersRepository User;
        #endregion

        public Login()
        {
            User = new UsersRepository();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text.Trim();
            string passWord = txtPassword.Text.Trim();

           if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                Helper.Message("Debe completar los campos.");
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                bool isAuthenticated = User.Login(userName, passWord);
                Cursor = Cursors.Arrow;
                if (isAuthenticated)
                {
                    this.Close();
                    return;
                }

                Helper.Message("Usuario y/o contraseña incorrectos");
            }
            catch (Exception)
            {
                Helper.Message("Ha ocurrido un error al intentar logear al usuario, favor intente mas tarde");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Exit()
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Exit();
        }
    }
}
