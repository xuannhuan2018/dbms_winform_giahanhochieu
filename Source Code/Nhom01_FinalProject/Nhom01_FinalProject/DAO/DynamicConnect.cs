using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using Nhom01_FinalProject.DTO;

namespace Nhom01_FinalProject.DAO
{
    class DynamicConnect
    {
        public static OracleConnection GetOracleConnection()
        {
            OracleConnection conn = new OracleConnection(UserLogin.Constring);
            return conn;
        }

        public static OracleCommand GetOracleCommand(string query, OracleConnection conn)
        {
            OracleCommand cmd = new OracleCommand(query, conn);
            return cmd;
        }
    }
}
