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

namespace Opacity
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

        private void Grid_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            posterPrimeroImage.Opacity = 1;
        }

        private void Posters_MouseEnter(object sender, MouseEventArgs e)
        {
          string reconocer= (sender as Image).Tag.ToString();
            if (reconocer== "posterPrimeroImage")
                    posterPrimeroImage.Opacity = 1;
            if (reconocer == "posterSegundoImage")
                    posterSegundoImage.Opacity = 1;
            if(reconocer == "posterTerceroImage")
                    posterTerceroImage.Opacity = 1;
        }

        private void Posters_MouseLeave(object sender, MouseEventArgs e)
        {
            posterTerceroImage.Opacity = 0.5;
            posterSegundoImage.Opacity = 0.5;
            posterPrimeroImage.Opacity = 0.5;
        }
        
    }
}
