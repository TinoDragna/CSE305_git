﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffsManagementSys_winform
{
    internal class AccountManager
    {
        private static String username = "admin";
        private static String password = "123";

        public static Boolean compareAccount(String usernameInput, String passwordInput)
        {
            if (password.Equals(passwordInput))
            {
                if (username.Equals(usernameInput))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
