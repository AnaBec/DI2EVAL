using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avituallamientos.modelo
{
    public class LogicaNegocio
    {
        public ObservableCollection<Carrera> ListaCarreras { get; set; }
        public ObservableCollection<Producto> ListaProductos { get; set; }
        public ObservableCollection<Producto> ListaProductosDisponibles { get; set; }
        public ObservableCollection<AvituallamientoClase> ListaAvituallamientos { get; set; }
        public AvituallamientoClase avituallamiento { get; set; }

        public LogicaNegocio()
        {
            ListaAvituallamientos = new ObservableCollection<AvituallamientoClase>();
            ListaProductosDisponibles = new ObservableCollection<Producto>();
            creacionProductosAuto();
            creacionCarrerasAuto();
         
        }

        //Añadir un producto manualmente
        public void anhadirProducto(Producto producto)
        {
            ListaProductos.Add(producto);
        }

        //Eliminar un producto
        public void eliminarProducto(Producto producto)
        {
            ListaProductos.Remove(producto);
        }

        //Modificar producto
        public void modificarProducto(Producto producto, int posicion)
        {
            ListaProductos[posicion] = producto;//reemplazamos de la lista, en la posicion que diga el metodo
            //y le estamos metiendo un nuevo producto. el viejo se pierde
        }

        //añadir avituallamiento
        public void anhadirAvituallamiento(AvituallamientoClase avituallamiento)
        {
            ListaAvituallamientos.Add(avituallamiento);
        }

        //modificar avituallamiento
        public void modificarAvituallamiento(AvituallamientoClase avituallamiento, int posicion)
        {
            ListaAvituallamientos[posicion] = avituallamiento;
        }

        public void anhadirProductoAlAvituallamiento(Producto producto)
        {
            
            ListaProductosDisponibles.Add(producto);            
        }

        //Añadir carrera a lista carreras
        public void anhadirCarrera(Carrera carrera)
        {
            ListaCarreras.Add(carrera);
        }
        
        //Carreras que ya salen por defecto en la tabla
        public void creacionCarrerasAuto()
        {
            //Carrera 1
            ListaCarreras = new ObservableCollection<Carrera>();
            Carrera carrera1 = new Carrera("Desafío Astur");
            AvituallamientoClase avituallamiento1 = new AvituallamientoClase("Desafío Astur", 20, new Persona("Ana", 608011735));
            carrera1.ListaAvituallamientos.Add(avituallamiento1);
            ListaCarreras.Add(carrera1);

            //Carrera2
            Carrera carrera2 = new Carrera("Last");
            AvituallamientoClase avituallamiento2 = new AvituallamientoClase("Last", 35, new Persona("Jordy", 657657345));
            carrera2.ListaAvituallamientos.Add(avituallamiento2);

            ListaCarreras.Add(carrera2);
        }
        //Productos que ya salen por defecto en la tabla
        public void creacionProductosAuto()
        {

            if (ListaProductos == null)
            {
                ListaProductos = new ObservableCollection<Producto>();
            }
           
            //Producto1
            Producto producto1 = new Producto("Tiritas", Tipo.MaterialSanitario, 1.30);
            //Producto2
            Producto producto2 = new Producto("Aquarius", Tipo.Bebida, 1.80);
            //Producto3
            Producto producto3 = new Producto("Barrita energética fresa", Tipo.Comida, 2.00);

            ListaProductos.Add(producto1);
            ListaProductos.Add(producto2);
            ListaProductos.Add(producto3);
        }
    }
}
