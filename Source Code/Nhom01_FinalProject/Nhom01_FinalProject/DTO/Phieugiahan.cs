using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhom01_FinalProject.DTO
{
    /// <summary>
    /// Class: Phieugiahan
    /// </summary>
    public class Phieugiahan
    {
        //Attributes
        static string mapdk;
        static DateTime ngaydangky;
        static string hoten;
        static DateTime ngaysinh;
        static string gioitinh;
        static string cmnd;
        static string diachi;
        static string phuong;
        static string quanhuyen;
        static string sdt;
        static string email;
        static string mahochieu;
        static string ttxacthuc;
        static string ttxetduyet;
        static string comments;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Phieugiahan()
        {

        }

        /// <summary>
        /// Properties
        /// </summary>
        public static string Mapdk
        {
            get { return mapdk; }
            set { mapdk = value; }
        }

        public static DateTime Ngaydangky
        {
            get { return ngaydangky; }
            set { ngaydangky = value; }
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

        public static string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
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

        public static string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public static string Email
        {
            get { return email; }
            set { email = value; }
        }

        public static string Mahochieu
        {
            get { return mahochieu; }
            set { mahochieu = value; }
        }
        
        public static string Ttxacthuc
        {
            get { return ttxacthuc; }
            set { ttxacthuc = value; }
        }

        public static string Ttxetduyet
        {
            get { return ttxetduyet; }
            set { ttxetduyet = value; }
        }

        public static string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
    }
}
