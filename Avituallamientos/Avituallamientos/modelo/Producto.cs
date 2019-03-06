using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avituallamientos.modelo
{
    //Ala hora de modificar un producto de la tabla, según lo estamos modificando cambia
    //de nombre automaticamente sin darle a aceptar. y si damos a cancelar, se va a quedar
    //modificado. Para solucinarlo, tenemos que hacer que el producto sea clonable. Implementamos
    //sus metodos (mas abajo gestionado "Metodo clone")

    public enum Tipo { Bebida, Comida, MaterialSanitario }

    public class Producto : ICloneable, IDataErrorInfo, INotifyPropertyChanged
    {
        public String Nombre { get; set; }
        public Tipo Tipo { get; set; }
        public double Precio { get; set; }

        public Producto()
        {
        }

        public Producto(String nombre, Tipo tipo, double precio)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Precio = precio;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\nTipo material: " + Tipo + "\nPrecio: " + Precio;
        }

        //devolvemos una copia del objeto. Va a ser una copia de un objeto pero serán
        //2 objetos diferentes. 
        //En el botón "modificar", tenemos que decirle que el libro que pasamos es una copia
        //Ir al código del botón "modificar" en "MainWindow".

        public object Clone()
        {
            return this.MemberwiseClone(); //Va a clonar el objeto y todos sus atributos
        }

        public string Error
        {
            get { return ""; }
        }

             public string this[string columnName]
        {
            get
            {
                string resultado = "";
                if (columnName == "Nombre")
                {
                    if (string.IsNullOrEmpty(Nombre))
                    {
                        resultado = "El campo no puede estar vacío";
                       
                    }
                }
                else if (columnName == "Precio")
                {
                    
                    if (double.IsNaN(Precio))
                    {
                        resultado = "Introduce un valor numérico";
                    }
                }
                return resultado;
            }
        }


        

        public event PropertyChangedEventHandler PropertyChanged;
    }
}