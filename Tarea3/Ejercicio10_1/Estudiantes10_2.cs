using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio10_1
{
    class Estudiantes10_2
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int OrdenL { get; set; }
        public String Telefono { get; set; }
        public String Celular { get; set; }
        public String Direccion { get; set; }

        public Estudiantes10_2()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            OrdenL = 0;
            Telefono = string.Empty;
            Celular = string.Empty;
            Direccion = string.Empty;
        }

    }
}
