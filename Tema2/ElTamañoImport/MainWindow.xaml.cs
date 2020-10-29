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

namespace ElTamañoImport
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            String chequeo = (sender as CheckBox).Tag.ToString();

            if (chequeo== "PequeñoRadioButton")
            {
                textoaCambiarTextBock.FontSize = 36;
            }
            if (chequeo == "MedianoRadioButton")
            {
                textoaCambiarTextBock.FontSize = 56;
            }
            if (chequeo == "GrandeRadioButton")
            {
                textoaCambiarTextBock.FontSize = 72;
            }

        }

        
    }
}
