using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.MODELO
{
    internal class ConexionDB
    {

        private string cadena_de_conexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CAJERO_AUTOMATICO;Integrated Security=True";

        public SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(cadena_de_conexion);
            conexion.Open();
            return conexion;
        }
    }
}
