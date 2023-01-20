using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Datos.DbConect
{
    public static class Dbconect
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public static string GetCadena()
        {
            return cadena;
        }

    }
}
