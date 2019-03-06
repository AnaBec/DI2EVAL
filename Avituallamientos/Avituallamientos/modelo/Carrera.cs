using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avituallamientos.modelo
{
    public class Carrera
    {
        public String Nombre { get; set; }
        public ObservableCollection<AvituallamientoClase> ListaAvituallamientos { get; set; }

        public Carrera()
        {
            ListaAvituallamientos = new ObservableCollection<AvituallamientoClase>();
        }

        public Carrera(String nombre)
        {
            this.Nombre = nombre;
            ListaAvituallamientos = new ObservableCollection<AvituallamientoClase>();
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
