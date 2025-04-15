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
    public partial class FormOpciones : Form
    {
        public FormOpciones()
        {
            InitializeComponent();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();

            funcionalidades.Retirar(txbDineroRetirar);
            txbDineroRetirar.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
