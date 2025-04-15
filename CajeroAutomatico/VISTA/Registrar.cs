using CajeroAutomatico.CONTROLADOR;
using CajeroAutomatico.MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.VISTA
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUs nuevoUsuario = new RegistrarUs
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                TipoDocumento = cmbTipoDocumento.SelectedItem.ToString(),
                NumeroDocumento = txtNumeroDocumento.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text
            };

            UsuarioControl controller = new UsuarioControl();

            try
            {
                if (controller.RegistrarNuevoUsuario(nuevoUsuario))
                {
                    MessageBox.Show("Usuario registrado exitosamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cmbTipoDocumento.SelectedIndex = -1;
            txtNumeroDocumento.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
