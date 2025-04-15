using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico.CONTROLADOR
{
    internal class Usuario
    {
       
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
       
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string TipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public int Contraseña { get; set; }


    }
}
