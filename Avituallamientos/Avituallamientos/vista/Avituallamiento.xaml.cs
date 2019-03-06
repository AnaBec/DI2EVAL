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
    /// Lógica de interacción para Avituallamiento.xaml
    /// </summary>
    public partial class Avituallamiento : Window
    {
        public LogicaNegocio logicaNegocio;
        public Producto producto;
        public AvituallamientoClase avituallamiento;
        public int posicion;
        public Boolean voyAmodificar;

        //constructor para añadir
        public Avituallamiento(LogicaNegocio logicaNegocio)
        {
            InitializeComponent();
            producto = new Producto();
            avituallamiento = new AvituallamientoClase();
            this.logicaNegocio = logicaNegocio;
            TablaProductosAvitu.DataContext = this.logicaNegocio;
            this.DataContext = this;
            this.DataContext = avituallamiento;
            voyAmodificar = false;
          
        }
        //cconstructor para modificar
        public Avituallamiento(LogicaNegocio logicaNegocio,AvituallamientoClase avituModif, int posicion)
        {
            InitializeComponent();
            this.avituallamiento = avituModif;
            this.logicaNegocio = logicaNegocio;
            this.posicion = posicion; //Borrar los datacontext???
            TablaProductosAvitu.DataContext = this.logicaNegocio;
            this.DataContext = this;
            this.DataContext = avituallamiento;
            voyAmodificar = true;

        }

        private void ButtonAnhadirProductos_Click(object sender, RoutedEventArgs e)
        {
            Productos productos = new Productos(logicaNegocio);
            productos.Show();
        }

        private void ButtonAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (voyAmodificar)
            {
                logicaNegocio.modificarAvituallamiento(avituallamiento, posicion);
            }
            else
            {
                logicaNegocio.anhadirAvituallamiento(avituallamiento);
                this.Close();
            }
        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
