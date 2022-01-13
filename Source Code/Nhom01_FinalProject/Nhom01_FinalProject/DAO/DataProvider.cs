using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Nhom01_FinalProject.DTO;
using Oracle.ManagedDataAccess.Client;

namespace Nhom01_FinalProject.DAO
{
    /// <summary>
    /// Class DataProvider
    /// </summary>
    class DataProvider
    {
        //Khởi tạo các biến và gán cho biến khởi tạo giá trị ban đầu là null
        OracleConnection conn = null;
        OracleCommand cmm = null;
        OracleDataAdapter da = null;
        /// <summary>
        /// Phương thức DataProvider
        /// </summary>
        public DataProvider()
        {
            conn = new OracleConnection(CurrentUserLogin.Constring);
            cmm = conn.CreateCommand();
        }
    }
}