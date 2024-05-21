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

namespace WpfApp2Übungen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ertsteNummer = "";
        List<string> nummern=new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _0_Click(object sender, RoutedEventArgs e)
        {
            ertsteNummer += "0";
            txtblc.Text=ertsteNummer;
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            ertsteNummer += "1";
            txtblc.Text = ertsteNummer;
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            ertsteNummer += "2";
            txtblc.Text = ertsteNummer;
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            ertsteNummer += "3";
            txtblc.Text = ertsteNummer;
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            ertsteNummer += "4";
            txtblc.Text = ertsteNummer;
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            ertsteNummer += "5";
            txtblc.Text = ertsteNummer;
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            ertsteNummer += "6";
            txtblc.Text = ertsteNummer;
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            ertsteNummer += "7";
            txtblc.Text = ertsteNummer;
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            ertsteNummer += "8";
            txtblc.Text = ertsteNummer;
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            ertsteNummer += "9";
            txtblc.Text = ertsteNummer;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            nummern.Add(ertsteNummer);
            nummern.Add("+");
            ertsteNummer = "";
        }

        private void gleich_Click(object sender, RoutedEventArgs e)
        {
            nummern.Add(ertsteNummer);
            ertsteNummer = "";
            txtblc.Text = rechnung(nummern);

        }
        private string rechnung(List<string> list)
        {
            string ergebnis = "";
            if (list.Contains("+"))
            {
                list.Remove("+");
                double zahl1 = double.Parse(list[0]);
                double zahl2 = double.Parse(list[1]);
                double ergebnisDouble=zahl1+ zahl2;
                ergebnis=ergebnisDouble.ToString();

            }

            return ergebnis;
        }


    }
}