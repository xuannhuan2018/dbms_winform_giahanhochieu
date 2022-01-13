using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhom01_FinalProject.DTO
{
    /// <summary>
    /// class: Ho chieu
    /// </summary>
    public class Hochieu
    {
        // Attributes
        static string mahochieu;
        static DateTime ngaycap;
        static DateTime ngayhethan;
        static string tinhtrang;
        static string cmnd;

       /// <summary>
       /// Default Contructor
       /// </summary>
        public Hochieu()
        {

        }

        /// <summary>
        /// Properties
        /// </summary>
        public static string Mahochieu
        {
            get { return mahochieu; }
            set { mahochieu = value; }
        }

        public static DateTime Ngaycap
        {
            get { return ngaycap; }
            set { ngaycap = value; }
        }

        public static DateTime Ngayhethan
        {
            get { return ngayhethan; }
            set { ngayhethan = value; }
        }

        public static string Tinhtrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
        
        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
    }
}
