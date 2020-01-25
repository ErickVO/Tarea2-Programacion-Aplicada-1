using System;
using System.Collections.Generic;
using System.Text;

namespace Registro.Entidades
{
    public class Persona
    {
        public int PersonaID { get; set; }
        public String Nombre { get; set; }
        public String Telefono { get; set; }
        public String Cedula { get; set; }
        public String Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona()
        {
            PersonaID = 0;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            FechaNacimiento = DateTime.Now;
        
        }


    }
    

       
}
