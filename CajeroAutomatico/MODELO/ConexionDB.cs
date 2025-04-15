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

        private string CadenaConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CajeroAutomatico;Integrated Security=True;";




        public SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();

            return conexion;
        }
    }
}
