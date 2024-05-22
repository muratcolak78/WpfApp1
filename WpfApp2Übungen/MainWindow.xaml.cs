using System.Collections.Generic;
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
        string ErtsteNummer = "";
        string zweitenummer = ";";
        string temporay = "";
        string operation = "";
        List<string> list=new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _0_Click(object sender, RoutedEventArgs e)
        {
            nummerUndTxtEinstellung("0");
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            nummerUndTxtEinstellung("1");
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            nummerUndTxtEinstellung("2");
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            nummerUndTxtEinstellung("3");
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            nummerUndTxtEinstellung("4");
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            nummerUndTxtEinstellung("5");
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            nummerUndTxtEinstellung("6");
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            nummerUndTxtEinstellung("7");
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            nummerUndTxtEinstellung("8");
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            nummerUndTxtEinstellung("0");
        }

        private void koma_Click(object sender, RoutedEventArgs e)
        {
            nummerUndTxtEinstellung(".");
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            einstellungOperation("+");
        }
        private void minus_Click(object sender, RoutedEventArgs e)
        {
            einstellungOperation("-");
        }

        private void mal_Click(object sender, RoutedEventArgs e)
        {
            einstellungOperation("*");
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            einstellungOperation("/");
        }

        private string  printList()
        {
            string x = "";
            list.ForEach(p=>
            {
                x += p;
            });
            return x;
        }

        private void gleich_Click(object sender, RoutedEventArgs e)
        {
            temporay += "=";
            temporay += Rechnung();
            txtblc.Text= temporay;
           
        }
        private string Rechnung()
        {

            list.Add(ErtsteNummer);
            double ergebnisDouble = 0.0;
            double zahl1 = double.Parse(list[list.Count() - 1]);


            double zahl2 = double.Parse(list[list.Count() - 2]);

            if (operation == "+") ergebnisDouble = zahl1 + zahl2;
            else if (operation == "-") ergebnisDouble = zahl1 - zahl2;
            else if (operation == "*") ergebnisDouble = zahl1 * zahl2;
            else if (operation == "/") ergebnisDouble = zahl1 / zahl2;
            
            txtblc2.Text = printList();
            list.Clear();
            list.Add(ergebnisDouble.ToString());
            txtblc2.Text = printList();
            
            return  ergebnisDouble.ToString();

        }

        private void AC_Click(object sender, RoutedEventArgs e)
        {
          list.Clear();
            ErtsteNummer = "";
            temporay = "";
            txtblc.Text = "0";
        }

       
        private void einstellungOperation(string oper)
        {
            list.Add(ErtsteNummer);
            temporay += oper;
            txtblc.Text = temporay;
            txtblc2.Text = printList();
            ErtsteNummer = "";
            operation = oper;
            if (list.Count==2)
            {
                temporay += "=";
                temporay += Rechnung();
                txtblc.Text = temporay;
            }
        }
        private void nummerUndTxtEinstellung(string zeigen)
        {
            ErtsteNummer += zeigen;
            temporay += zeigen;
            txtblc.Text = temporay;
        }
    }
}