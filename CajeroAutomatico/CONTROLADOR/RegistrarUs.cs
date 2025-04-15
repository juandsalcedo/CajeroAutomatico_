﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.CONTROLADOR
{
     public class RegistrarUs
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int TipoUsuario { get; set; } = 1; // Asignación fija
    }
}
