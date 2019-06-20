using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Util
{
    public static class ConnectionFactory
    {
        private const string cadenaconexion = "";

        public static SqlConnection conexion()
        {
            try
            {
                return new SqlConnection(cadenaconexion);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
