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

namespace HolaAdios
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Saludos : Window
    {
        public Saludos()
        {
            InitializeComponent();
        }

        private void MuestraBoton_Click(object sender, RoutedEventArgs e)
        {
            if (HolaBoton.IsChecked == true)
            {
                MessageBox.Show("Hola.");
            }
            else if (AdiosBoton.IsChecked == true)
            {
                MessageBox.Show("Adiós.");
            }

        }
    }
}
