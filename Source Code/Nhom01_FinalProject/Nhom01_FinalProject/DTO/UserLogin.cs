using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhom01_FinalProject.DTO
{
    /// <summary>
    /// Class: CurrentUserLogin
    /// </summary>
    public class UserLogin
    {
        // Attribute
        static string constring;

        static string username;

        static string password;

        /// <summary>
        /// Get and set attribute Constring
        /// </summary>
        public static string Constring
        {
            get { return constring; }
            set { constring = value; }
        }

        /// <summary>
        /// Get and set attribute Username
        /// </summary>
        public static string Username
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        /// Get and set attribute Password
        /// </summary>
        public static string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
