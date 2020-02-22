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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //aqui un boton con contenido distinto para ver como actuar con control de cambios
            //nuevo cambio
            Grid miGrid = new Grid();
            this.Content = miGrid;
            TextBox mitextbox = new TextBox();
            mitextbox.Text = "prueba develop branch";

            
            miGrid.Children.Add(mitextbox);
        }
    }
}
