using System;
using System.Collections.Generic;
using System.IO;
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

namespace CalcularoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int primerNumero;
        private int segundoNumero;
        private int resultado;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public int optenerResultado() {
                primerNumero = int.Parse(primerNumeroTextBox.Text);
                segundoNumero = int.Parse(segundoNumeroTextBox.Text);
            if (operadorTextBox.Text == "+")
                resultado = primerNumero + segundoNumero;
            else if(operadorTextBox.Text == "-")
                resultado = primerNumero - segundoNumero;
            else if (operadorTextBox.Text == "*")
                resultado = primerNumero * segundoNumero;
            else if (operadorTextBox.Text == "/")
                resultado = primerNumero / segundoNumero;
            return resultado;
        }
       
        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            primerNumeroTextBox.Text = "";
            segundoNumeroTextBox.Text = "";
            operadorTextBox.Text = "";
            resultadoTextBox.Text = "";
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {    
            resultadoTextBox.Text= optenerResultado().ToString();
        }

        private void operadorTextBox_Loaded(object sender, RoutedEventArgs e)
        {

            using (StringReader reader = new StringReader(operadorTextBox.Text))
            {
              // string cadena= reader.Read();

                if (reader.Equals("+"))
                    calcularButton.IsEnabled = true;
                else if (operadorTextBox.Text == "-")
                    resultado = primerNumero - segundoNumero;
                else if (operadorTextBox.Text == "*")
                    resultado = primerNumero * segundoNumero;
                else if (operadorTextBox.Text == "/")
                    resultado = primerNumero / segundoNumero;
            }
        }
    }
}
