using CajeroAutomatico.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            IngresoForm ingreso = new IngresoForm();
            ingreso.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            IngresoForm ingreso = new IngresoForm();
            ingreso.Show();
        }
    }
}
