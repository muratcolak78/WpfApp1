using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        string zweitenummer = "";
        string temporay = "";
        string operation = "";
        List<string> list=new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _0_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            string buttonText = clickedButton.Content.ToString();
            nummerUndTxtEinstellung(buttonText);
            txtblc2.Text = buttonText;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            string buttonText = clickedButton.Content.ToString();
            einstellungOperation(buttonText);
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
            double zahl1 = double.Parse(list[list.Count() - 2]);


            double zahl2 = double.Parse(list[list.Count() - 1]);

            if (operation == "+") ergebnisDouble = zahl1 + zahl2;
            else if (operation == "-") ergebnisDouble = zahl1 - zahl2;
            else if (operation == "x") ergebnisDouble = zahl1 * zahl2;
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

            if (ErtsteNummer.Length == 0) txtblc.Text = "0";
            else if (list.Count == 0)
            {

                list.Add(ErtsteNummer);
                temporay += oper;
                txtblc.Text = temporay;
                txtblc2.Text = printList();
                zweitenummer = ErtsteNummer;
                ErtsteNummer = "";
                operation = oper;
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