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

namespace KrystofNakladak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nakladak mercedes;
        Nakladak renault;
        public MainWindow()
        {
            InitializeComponent();
            mercedes = new Nakladak();
            mercedes.Jmeno = "mercedes";
            Zobraz(mercedes, txtBox1);

            renault = new Nakladak();
            renault.Jmeno = "renault";
            Zobraz(renault, txtBox2);
        }
        public void Zobraz (Nakladak nakladak, TextBox textBox)
        {
            textBox.Text = nakladak.Jmeno + " \n";
            textBox.Text += "Nosnost" + nakladak.Nosnost.ToString() + "\n";
            textBox.Text +="ObjemNadrze" + nakladak.ObjemNadrze.ToString() + "\n";
            textBox.Text +="SpotrebaPaliva" + nakladak.SpotrebaPaliva.ToString() + "\n";
            textBox.Text +="CelkovaUjetaVzdalenost" + nakladak.CelkovaUjetaVzdalenost.ToString() + "\n";
        }
    }
}
