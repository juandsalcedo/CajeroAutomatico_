using CajeroAutomatico.CONTROLADOR;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.MODELO
{
    class ConsultaDal
    {
        Cuenta cuenta = new Cuenta();
        ConexionDB conexionDB = new ConexionDB();
        /*public void ConsultarSaldo()
        {
             cuenta.IdUsuario = 1104546039;

            using(SqlConnection conexion = conexionDB.AbrirConexion())
            {
                string Query = "SELECT Saldo FROM Cuentas WHERE IdUsuario = @idusuario";

                using(SqlCommand comando = new SqlCommand(Query,conexion))
                {
                    comando.Parameters.AddWithValue("idusuario",cuenta.IdUsuario);

                    object resultado = comando.ExecuteScalar(); // Trae solo un valor

                    if (resultado != null)
                    {
                        LblSaldo.Text = "$ " + resultado.ToString();
                    }
                    else
                    {
                        LblSaldo.Text = "Cuenta no encontrada";
                    }
                }
            }*/

        public string ConsultarSaldo(int idUsuario)
        {
            
            using (SqlConnection conexion = conexionDB.AbrirConexion())
            {
                string Query = "SELECT Saldo FROM Cuentas WHERE IdUsuario = @IdUsuario";
                using (SqlCommand comando = new SqlCommand(Query, conexion))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                        return "$ " + resultado.ToString();
                    else
                        return "Cuenta no encontrada";
                }
            }
        }


    }

}

