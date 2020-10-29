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

namespace CaractersLimitados
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

        public void limitarEscritura()
        {
            List <char> caracteres= new List<char>();
            if (caracteres.Count==139)
            {
                recuadroTextBox.AcceptsReturn.ToString();
            }
        }

        private void recuadroTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
