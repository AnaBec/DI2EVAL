
using Avituallamientos.modelo;
using Avituallamientos.vista;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Avituallamientos
{
 
    public partial class MainWindow : Window
    {
        public LogicaNegocio logicaNegocio;

        public MainWindow()
        {
            InitializeComponent();
            logicaNegocio = new LogicaNegocio();
        }

        private void ButtonProductos_Click(object sender, RoutedEventArgs e)
        {
            Productos2 productos2 = new Productos2(logicaNegocio);
            productos2.Show();
        }

        private void ButtonAvitu_Click(object sender, RoutedEventArgs e)
        {
            GestionAvituallamientos gestAvit = new GestionAvituallamientos(logicaNegocio);
            gestAvit.Show();
        }
    }
}
