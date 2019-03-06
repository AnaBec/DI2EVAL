using Avituallamientos.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Avituallamientos.vista
{
    /// <summary>
    /// Lógica de interacción para Productos.xaml
    /// </summary>
    public partial class Productos : Window
    {
        public Tipo[] TiposMaterial { get; set; }
        public LogicaNegocio logicaNegocio;
        public Producto producto { get; set; }
        public Boolean voyAModificar;
        public int posicion;
        public int errores;

        //Constructor para añadir
        public Productos(LogicaNegocio logicaNegocio)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            TiposMaterial = (Tipo[])Enum.GetValues(typeof(Tipo));
            producto = new Producto();

            TablaProductosTotales.DataContext = this.logicaNegocio;//binding tabla productos pordefecto
            voyAModificar = false;
            this.DataContext = this;//Binding para añadir a mano productos (nombre y precio)

        }


        //Constructor para modificar
        public Productos(LogicaNegocio logicaNegocio, Producto productoModificar, int posicion)
        {
            InitializeComponent();
            TiposMaterial = (Tipo[])Enum.GetValues(typeof(Tipo));
            this.producto = productoModificar;
            this.posicion = posicion;
            this.logicaNegocio = logicaNegocio;
            TablaProductosTotales.DataContext = this.logicaNegocio;//binding tabla productos pordefecto
            this.DataContext = this;//Binding para modificar el producto
            voyAModificar = true;


        }

        private void ButtonAnhadirNuevoProducto_Click(object sender, RoutedEventArgs e)
        {
            if (voyAModificar)
            { //modificamos el producto
                logicaNegocio.modificarProducto(producto, posicion);
                MessageBox.Show("Producto modificado");
            }
            else
            {
                //damos de alta el producto
                logicaNegocio.anhadirProducto(producto);
                MessageBox.Show("Producto añadido");
            }
        }

        private void ButtonCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (TablaProductosTotales.SelectedIndex != -1)
            {
                Producto producto = (Producto)TablaProductosTotales.SelectedItem;//tenemos el producto seleccionado
                logicaNegocio.eliminarProducto(producto);
                MessageBox.Show("Se ha borrado el producto correctamente");
            }
            else
            {
                MessageBox.Show("ERROR!! Debes seleccionar un producto");
            }
        }

        private void ButtonModificar_Click(object sender, RoutedEventArgs e)
        {
            //vamos a recoger el elemnto que seleccionamos en el datagrid(tabla):
            //comprobamos que haya algo seleccionado. 
            if (TablaProductosTotales.SelectedIndex != -1)
            {
                Producto producto = (Producto)TablaProductosTotales.SelectedItem;//tenemos el producto seleccionado
                Productos pantallaProductos = new Productos(logicaNegocio, (Producto)producto.Clone(), TablaProductosTotales.SelectedIndex);//le pasamos el producto CLONADO y la posicion
                pantallaProductos.ShowDialog();

            }
            else
            {
                MessageBox.Show("ERROR!! Debes seleccionar un producto");
            }
        }

        private void ButtonAnhadirAvitu_Click(object sender, RoutedEventArgs e)
        {
            if (TablaProductosTotales.SelectedIndex != -1)
            {
                Producto producto = (Producto)TablaProductosTotales.SelectedItem;//tenemos el producto seleccionado
                logicaNegocio.anhadirProductoAlAvituallamiento(producto);


                this.Close();
                Avituallamiento avitu = new Avituallamiento(logicaNegocio);
                avitu.Show();

            }
            else
            {
                MessageBox.Show("ERROR!! Debes seleccionar un producto");
            }
        }



    }
}
