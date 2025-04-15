using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.CONTROLADOR
{
    class Cuenta
    {

        public int IdCuenta { get; set; }
        public int IdUsuario { get; set; }
        public string TipoCuenta { get;set; }
        public float Saldo { get; set; }
    }
}
