using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace Consignacion
{
    public partial class fondoPanelVertical: Form
    {
        public fondoPanelVertical()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBoxNombreReceptor.Text == "Nombre de quien recibe")
            {
                textBoxNombreReceptor.Text = "";
                textBoxNombreReceptor.ForeColor = Color.LightGray;
            }   
        }

        private void textBoxNombreReceptor_Leave(object sender, EventArgs e)
        {
            if (textBoxNombreReceptor.Text == "")
            {
                textBoxNombreReceptor.Text = "Nombre de quien recibe";
                textBoxNombreReceptor.ForeColor = Color.DimGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBoxNumDocumento.Text == "Numero de documento")
            {
                textBoxNumDocumento.Text = "";
                textBoxNumDocumento.ForeColor = Color.LightGray;
            }
        }

        private void textBoxNumDocumento_Leave(object sender, EventArgs e)
        {
            if (textBoxNumDocumento.Text == "")
            {
                textBoxNumDocumento.Text = "Numero de documento";
                textBoxNumDocumento.ForeColor = Color.DimGray;
            }
        }

        private void textBoxValor_Enter(object sender, EventArgs e)
        {
            if (textBoxValor.Text == "Valor a transferir")
            {
                textBoxValor.Text = "";
                textBoxValor.ForeColor = Color.LightGray;
            }
        }

        private void textBoxValor_Leave(object sender, EventArgs e)
        {
            if (textBoxValor.Text == "")
            {
                textBoxValor.Text = "Valor a transferir";
                textBoxValor.ForeColor = Color.DimGray;
            }
        }

        private void buttonTransferirDinero_Click(object sender, EventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(textBoxNombreReceptor.Text) ||
                string.IsNullOrWhiteSpace(textBoxNumDocumento.Text) ||
                string.IsNullOrWhiteSpace(textBoxNumeroCuenta.Text) ||
                string.IsNullOrWhiteSpace(textBoxValor.Text) ||
                textBoxNombreReceptor.Text == "Nombre de quien recibe" ||
                textBoxNumDocumento.Text == "Numero de documento" ||
                textBoxNumeroCuenta.Text == "Numero de cuenta" ||
                textBoxValor.Text == "Valor a transferir") 
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el valor sea un número entero
            if (!int.TryParse(textBoxValor.Text, out int monto) || monto <= 0)
            {
                MessageBox.Show("El valor a transferir debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el número de documento sea un número entero
            if (!long.TryParse(textBoxNumDocumento.Text, out long documentoReceptor))
            {
                MessageBox.Show("El número de documento invalido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el número de cuenta sea un número entero
            if (!long.TryParse(textBoxNumeroCuenta.Text, out long numeroCueta))
            {
                MessageBox.Show("Numero de cuenta invalido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                string cadena_de_conexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CAJERO_AUTOMATICO;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(cadena_de_conexion))
                {
                    connection.Open();

                    //Iniciar transaccion
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // 1. Validar cuenta origen (emisor)
                        long documentoEmisor = ObtenerUsuarioActual();
                        decimal saldoActual = ObtenerSaldoCuenta(connection, transaction, documentoEmisor);


                        if (saldoActual == -1)
                        {
                            MessageBox.Show("No se encontro su ceunta bancaaria", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            transaction.Rollback();
                            return;
                        }

                        // 2. Validar fondos suficientes
                        if (saldoActual < monto)
                        {
                            MessageBox.Show("Fondos insuficientes para realizar la transferencia", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            transaction.Rollback();
                            return;
                        }
                        // 3. Validar cuenta destino (receptor)
                        var (cuentaValida, nombreReal) = ValidarCuentaDestino(
                            connection,
                            transaction,
                            documentoReceptor,
                            cuentaDestino,
                            textBoxNombreReceptor.Text
                        );

                        // 4. Confirmacion
                        var confirmacion = MessageBox.Show($"Confirmar transferencia de {monto:C} a {nombreReal}?",
                            "Confirmar Transaccion",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (confirmacion != DialogResult.Yes)
                        {
                            transaction.Rollback();
                            return;
                        }

                        // 5. Realizar transacción
                        ActualizarSaldo(connection, transaction, documentoEmisor, -monto);  // Débito
                        ActualizarSaldo(connection, transaction, documentoReceptor, monto); // Crédito

                        RegistrarTransaccion(connection, transaction, documentoEmisor, documentoReceptor, monto);

                        transaction.Commit();
                        MessageBox.Show("Transferencia realizada exitosamente!", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error durante la transacción: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }


        private void fondoContenerdor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBoxNombreReceptor_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxNumDocumento_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelConsignacion_Click(object sender, EventArgs e)
        {

        }
    }
}
