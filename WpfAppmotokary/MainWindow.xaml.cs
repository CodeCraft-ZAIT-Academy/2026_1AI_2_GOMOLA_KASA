using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppmotokary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal celkovaCena = 0;
        public MainWindow()
        {
            InitializeComponent();
            NovyNakup();
        }
        private void Vypis(string nazov, decimal cena)
        {
            txtBlocik.Text += nazov + "    " + cena + "€" + System.Environment.NewLine;
            celkovaCena += cena;
            lblCena.Content = "Celková cena: " + celkovaCena + "€";
        }
        private void NovyNakup()
        {
            txtBlocik.Text = "----------------------------- Bločik ----------------------------";
            celkovaCena = 0;
            lblCena.Content = "Celková cena: " + celkovaCena + "€";
        }
        private void btnKukla_Click(object sender, RoutedEventArgs e)
        {
           Vypis("Kukla", 2);
        }

        private void btnJazda_Click(object sender, RoutedEventArgs e)
        {
           Vypis("Jazda", 15);
        }

        private void btnKofola_Click(object sender, RoutedEventArgs e)
        {
           Vypis("Kofola", 2);
        }

        private void btnJedlo_Click(object sender, RoutedEventArgs e)
        {
            Vypis("Jedlo", 10);
        }

        private void btnMagnetka_Click(object sender, RoutedEventArgs e)
        {
            Vypis("Magnetka", 5);
        }

        

        private void btnPrenajom_Click(object sender, RoutedEventArgs e)
        {
            Vypis("Prenájom", 120);
        }

        private void btnNovyNakup_Click(object sender, RoutedEventArgs e)
        {
            NovyNakup();
        }
    }
}