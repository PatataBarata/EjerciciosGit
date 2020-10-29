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

namespace Formato
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

        private void azulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            salidaTextBlock.Text = entradaTextBox.Text;
            salidaTextBlock.Foreground = Brushes.Blue;
         }

        private void rojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {

            salidaTextBlock.Text = entradaTextBox.Text;
            salidaTextBlock.Foreground = Brushes.Red;
        }


        private void verdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            salidaTextBlock.Text = entradaTextBox.Text;
            salidaTextBlock.Foreground = Brushes.Green;


        }

        private void cursibaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            salidaTextBlock.Text = entradaTextBox.Text;
            salidaTextBlock.FontFamily =;

        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        { 
            salidaTextBlock.Text = entradaTextBox.Text;
           // salidaTextBlock.FontStyle =

        }
    }
}
