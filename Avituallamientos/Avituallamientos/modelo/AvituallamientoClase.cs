using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avituallamientos.modelo
{
    public class AvituallamientoClase : ICloneable, INotifyPropertyChanged
    {
        public String NombreCarrera { get; set; }
        public int PuntoKilometrico { get; set; }
        public Persona PersonaContacto { get; set; }
        public ObservableCollection<Producto> ListaProductosDisponibles { get; set; }

        public AvituallamientoClase()
        {
        }

        public AvituallamientoClase(String nombreCarrera, int puntoKilometrico, Persona personaContacto)
        {
            this.NombreCarrera = nombreCarrera;
            this.PuntoKilometrico = puntoKilometrico;
            this.PersonaContacto = personaContacto;
            this.ListaProductosDisponibles = new ObservableCollection<Producto>();
        }
        public override string ToString()
        {
            return "Nombre Carrera: " + NombreCarrera + "\nPunto kilométrico: " + PuntoKilometrico + "\nPersona de contacto: " + PersonaContacto;
        }


        public object Clone()
        {
           return this.MemberwiseClone();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
