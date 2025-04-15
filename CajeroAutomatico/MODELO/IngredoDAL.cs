using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.MODELO
{
    class IngredoDAL
    {

        ConexionDB conexionDB = new ConexionDB();

        public void IngresoUsuario()
        {
            using(SqlConnection conexion = conexionDB.AbrirConexion())
            {

                string Query = "SELECT * FROM ";
            }
        }

    }
}
