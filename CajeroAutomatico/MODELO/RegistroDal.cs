using CajeroAutomatico.CONTROLADOR;
using CajeroAutomatico.VISTA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.MODELO
{
    public class RegistroDal
    {
        ConexionDB conexionDB = new ConexionDB();
        Usuario usuario = new Usuario();
        public void RegistrarNuevoUsuario(TextBox txbNombre, TextBox txbApellido, TextBox txbCorreo, TextBox txbTelefono, TextBox txbNumeroDocumento, TextBox txbContraseña, ComboBox cmbTipoDocumento)
        {
      
            using (SqlConnection conexion = conexionDB.AbrirConexion())
            {
                usuario.Nombre = txbNombre.Text;
                usuario.Apellido = txbApellido.Text;
                usuario.Correo = txbCorreo.Text;
                usuario.Telefono = txbTelefono.Text;
                usuario.NumeroDocumento = Convert.ToInt32(txbNumeroDocumento.Text);
                usuario.TipoDocumento = cmbTipoDocumento.Text;
                usuario.Contraseña = Convert.ToInt32(txbContraseña.Text);

                string query = "INSERT INTO Usuario (Nombre, Apellido, Correo, Telefono, TipoDocumento,NumeroDocumento,Contraseña) " +
                               "VALUES (@Nombre, @Apellido,@Correo,@Telefono,@TipoDocumento,@NumeroDocumento,@Contraseña)";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@TipoDocumento", usuario.TipoDocumento);
                    cmd.Parameters.AddWithValue("@NumeroDocumento",usuario.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Registro Exitoso" + "Exito" + MessageBoxButtons.OK + MessageBoxIcon.Information);
            }
        }
    }
}
