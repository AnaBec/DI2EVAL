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
    /// Lógica de interacción para GestionAvituallamientos.xaml
    /// </summary>
    public partial class GestionAvituallamientos : Window
    {
        public LogicaNegocio logicaNegocio;
        public int indiceCarrera { get; set; }//binding combo carreras
        public int indiceAvituallamiento { get; set; }//binding datagrid avituallamientos

        public GestionAvituallamientos(LogicaNegocio logicaNegocio)
        {
            this.logicaNegocio = logicaNegocio;
            InitializeComponent();
            ComboBoxCarreras.DataContext = this.logicaNegocio;
        }

        private void ButtonAnhadirNuevoAvitu_Click(object sender, RoutedEventArgs e)
        {

            if (indiceCarrera != -1)
            {

                Avituallamiento avitu = new Avituallamiento(logicaNegocio);
                avitu.Show();

            }
        }

        private void ButtonModificarAvi_Click(object sender, RoutedEventArgs e)
        {
            if (TablaAvituallamientos.SelectedIndex != -1)
            {
                AvituallamientoClase avituallamiento = new AvituallamientoClase();
                 avituallamiento = (AvituallamientoClase)TablaAvituallamientos.SelectedItem;//tenemos el producto seleccionado
                 Avituallamiento avituPantalla = new Avituallamiento(logicaNegocio);
                avituPantalla.Show();

            }
            else
            {
                MessageBox.Show("ERROR!! Debes seleccionar un avituallamiento");
            }
        }
    }
}
