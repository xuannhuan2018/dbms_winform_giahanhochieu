using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhom01_FinalProject.DTO
{
    /// <summary>
    /// Class: Dan cu
    /// </summary>
    class Dancu
    {
        // Attributes
        static string cmnd;
        static string hoten;
        static DateTime ngaysinh;
        static string gioitinh;
        static string quoctich;
        static string diachi;
        static string phuong;
        static string quanhuyen;
        static string tinhthanhpho;
        static DateTime ngaycap;

        /// <summary>
        /// Default Contructor
        /// </summary>
        public Dancu()
        {

        }

        /// <summary>
        /// Properties
        /// </summary>
        public static string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public static string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }

        public static DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        public static string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public static string Quoctich
        {
            get { return quoctich; }
            set { quoctich = value; }
        }

        public static string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public static string Phuong
        {
            get { return phuong; }
            set { phuong = value; }
        }

        public static string Quanhuyen
        {
            get { return quanhuyen; }
            set { quanhuyen = value; }
        }

        public string Tinhthanhpho
        {
            get { return tinhthanhpho; }
            set { tinhthanhpho = value; }
        }

        public static DateTime Ngaycap
        {
            get { return ngaycap; }
            set { ngaycap = value; }
        }
    }
}
