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
        RegistroDal usuario = new RegistroDal();
       
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
            usuario.RegistrarNuevoUsuario(txtNombre, txtApellido, txtCorreo, txtTelefono, txtNumeroDocumento, txbContraseña, cmbTipoDocumento);
            LimpiarCampos();
        }
    }
}
