using CajeroAutomatico.CONTROLADOR;
using CajeroAutomatico.MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CajeroAutomatico.VISTA
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        ConsultaDal consultaDal = new ConsultaDal();
        private void btnConsultarSaldo_Click(object sender, EventArgs e)
        {
            
            string saldo = consultaDal.ConsultarSaldo(1104546039);
            LblSaldoDisponible.Text = saldo;
        }

        private void grpOpciones_Enter(object sender, EventArgs e)
        {

        }
    }
}
