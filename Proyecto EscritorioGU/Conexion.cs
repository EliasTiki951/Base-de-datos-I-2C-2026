// PDF ConexionGU.pdf

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EscritorioGU
{
    public static class Conexion
    {
        private static string ConnectionString = @"Server=.\SQLEXPRESS;Initial Catalog=GestionUniversitaria;Integrated Security=True;";

        private static SqlConnection connection = new SqlConnection();

        public static SqlConnection abrirConn()
        {
            try
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void cerrarConn(SqlConnection conn)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
