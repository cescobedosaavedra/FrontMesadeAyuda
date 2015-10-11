using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test
{
    public class Empleado
    {
        
        public int CodEmpleado { get; set; }        
        public string NombreEmpleado { get; set; }        
        public string ApellidoEmpleado { get; set; }        
        public string CorreoEmpleado { get; set; }        
        public string CargoEmpleado { get; set; }        
        public string TelefonoEmpleado { get; set; }        
        public string AreaEmpleado { get; set; }
        public string Password { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }
        public int LoginErrorCount { get; set; }
    }
}