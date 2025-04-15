using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.MODELO
{
    internal class RetirarDAL
    {

        ConexionDB conexionDB = new ConexionDB();
        public void Retirar(TextBox txbValorIngresado)
        {
            try
            {
                using (SqlConnection conexion = conexionDB.AbrirConexion())
                {
                    string QuerySelect = "select Saldo From CUENTAS where IdUsuario = @idusuario";

                    int IdUsuario = 1104546039;
                    int SaldoUsuario = 0;
                    int NuevoSaldo = 0;

                    using (SqlCommand ComandoSelect = new SqlCommand(QuerySelect, conexion))
                    {
                        ComandoSelect.Parameters.AddWithValue("@idusuario", IdUsuario);
                        object valor = ComandoSelect.ExecuteScalar();

                        if (valor != null)
                        {
                            SaldoUsuario = Convert.ToInt32(valor);
                        }
                    }

                    int ValorIngresado = Convert.ToInt32(txbValorIngresado.Text);

                    if (ValorIngresado < SaldoUsuario)
                    {
                        NuevoSaldo = SaldoUsuario - ValorIngresado;

                        string QueryUpdate = "UPDATE CUENTAS SET Saldo = @NuevoSaldo WHERE IdUsuario = @IdUsuario";

                        using (SqlCommand ComandoUpdate = new SqlCommand(QueryUpdate, conexion))
                        {
                            ComandoUpdate.Parameters.AddWithValue("@NuevoSaldo", NuevoSaldo);
                            ComandoUpdate.Parameters.AddWithValue("@IdUsuario", IdUsuario);

                            ComandoUpdate.ExecuteNonQuery();
                        }
                        MessageBox.Show("Retiro Exitoso" + "Exito" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Saldo Insuficiente" + "Error" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR DE FORMATO"+"Error"+ MessageBoxButtons.OK+MessageBoxIcon.Warning);
            }
            
        }
    }
}
