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

namespace Tema2_CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numP;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cajaTexto_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(numP < 140)
            {
                numP++;
                contador1.Text = numP.ToString();
            }
            else
            {
                cajaTexto.IsEnabled = false;
            }
        }
    }
}
