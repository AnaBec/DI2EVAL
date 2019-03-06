using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avituallamientos.modelo
{
    public class Persona
    {
        public String Nombre { get; set; }
        public int NumTelefono { get; set; }

        public Persona()
        {
        }

        public Persona(String nombre, int numTelefono)
        {
            this.Nombre = nombre;
            this.NumTelefono = numTelefono;
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + "\nTeléfono: " + NumTelefono;
        }
    }
}
