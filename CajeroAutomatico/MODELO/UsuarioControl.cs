using CajeroAutomatico.CONTROLADOR;
using CajeroAutomatico.VISTA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.MODELO
{
    public class UsuarioControl
    {
        private string connectionString = "Data Source=MSSQLLocalDB;Initial Catalog=CAJERO_AUTOMATICO;Integrated Security=True";

        public bool RegistrarNuevoUsuario(RegistrarUs registrarUs)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuarios (Nombre, Apellido, TipoDocumento, NumeroDocumento, Correo, Telefono, TipoUsuario) " +
                               "VALUES (@Nombre, @Apellido, @TipoDocumento, @NumeroDocumento, @Correo, @Telefono, @TipoUsuario)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", registrarUs.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", registrarUs.Apellido);
                    cmd.Parameters.AddWithValue("@TipoDocumento", registrarUs.TipoDocumento);
                    cmd.Parameters.AddWithValue("@NumeroDocumento", registrarUs.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@Correo", registrarUs.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", registrarUs.Telefono);
                    cmd.Parameters.AddWithValue("@TipoUsuario", registrarUs.TipoUsuario);

                    connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }
}
