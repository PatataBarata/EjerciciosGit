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

namespace ActividadesUT2Ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int guardarnumero;

        public int numeroAleatorio()
        {
            Random random = new Random();
            return guardarnumero = random.Next(0, 101);
        }
        public MainWindow()
        {
            InitializeComponent();
            numeroAleatorio();
        }

        private void confirmarButton_Click(object sender, RoutedEventArgs e)
        {
            int numeroIntroducido = int.Parse(insertarTextBox.Text);
            if (numeroIntroducido == guardarnumero)
                resultadoTextBlock.Text = "Has acertado";
            else if (numeroIntroducido < guardarnumero)
                resultadoTextBlock.Text = "Te has quedado corto. El numero es mayor";
            else 
                resultadoTextBlock.Text =  "Te has pasado. El numero es menor";
        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numeroAleatorio();
            resultadoTextBlock.Text = "";
            insertarTextBox.Text = "";
        }

        private void insertarTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
