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
            textBox.Text += "Nosnost v kg: " + nakladak.Nosnost.ToString() + "\n";
            textBox.Text +="Objem Nadrze v l: " + nakladak.ObjemNadrze.ToString() + "\n";
            textBox.Text +="Spotreba Paliva l/km: " + nakladak.SpotrebaPaliva.ToString() + "\n";
            textBox.Text +="Celkova UjetaVzdalenost: " + nakladak.CelkovaUjetaVzdalenost.ToString() + "\n";
            textBox.Text +="Naklad: " + nakladak.Naklad.ToString() + "\n";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mercedes.Nalozit();
            Zobraz(mercedes, txtBox1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            renault.Nalozit();
            Zobraz(renault, txtBox2);   
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mercedes.Vylozit();
            Zobraz(mercedes, txtBox1);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            renault.Vylozit();
            Zobraz(renault, txtBox2);
        }
    }
}
