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

namespace Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void altaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            poster.Opacity = 1;
        }

        private void mediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            poster.Opacity = 0.6;
        }

        private void bajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            poster.Opacity = 0.3;
        }

        private void rellenoUniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            poster.Stretch = Stretch.UniformToFill;
        }

        private void rellenoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            poster.Stretch = Stretch.Fill;
        }

        private void uniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            poster.Stretch = Stretch.Uniform;
        }

        private void sinAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            poster.Stretch = Stretch.None;
        }
    }
}
