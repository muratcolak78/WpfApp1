using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp2Übungen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ErtsteNummer = "";
        string operation = "";
        string temporary = "";
        List<string> list1=new List<string>();
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            string buttonText = clickedButton.Content.ToString();
            if(txtblc.Text=="0") temporary = buttonText;
            else temporary += buttonText;
            txtblc. Text = temporary;
            ErtsteNummer += buttonText;
           

        }

        private void opration_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            string buttonText = clickedButton.Content.ToString();
            temporary += buttonText;
            txtblc.Text = temporary;
            operation = buttonText;
            if (list1.Count==0) {
                list1.Add(ErtsteNummer);

            } 
            ErtsteNummer = "";
         

        }
        

        private void gleich_Click(object sender, RoutedEventArgs e)
        {
           
            list1.Add(ErtsteNummer);
           
            string ergebniss = Rechnung();
            txtlck2.Text = ergebniss;
           
        }

        private string Rechnung()
        {
            //list1.Add(ErtsteNummer);
            double ergebnisDouble = 0.0;
            double zahl1 = double.Parse(list1[list1.Count()-2 ]);


            double zahl2 = double.Parse(list1[list1.Count()-1]);

            if (operation == "+") ergebnisDouble = zahl1 + zahl2;
            else if (operation == "-") ergebnisDouble = zahl1 - zahl2;
            else if (operation == "x") ergebnisDouble = zahl1 * zahl2;
            else if (operation == "/") ergebnisDouble = zahl1 / zahl2;

            list1.Clear();
            list1.Add(ergebnisDouble.ToString());

            return  ergebnisDouble.ToString();

        }

        private void AC_Click(object sender, RoutedEventArgs e)
        {
          list1.Clear();
            ErtsteNummer = "";
            txtlck2.Text = "0";
            txtblc.Text = "0";
            temporary="0";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text=txtPaledrom.Text;
            if (text!="")
            {
                if (isPaledrom(text))
                {

                    sekillendir(Brushes.Green, "True");

                }
                else
                {
                    sekillendir(Brushes.Red, "False");
                }
            }
           
        }
        private bool isPaledrom(string text)
        {
            char[] list= text.ToCharArray();
            int lastIndex=list.Length-1;
           for (int i=0;i<list.Length/2;i++)
            {
                if (list[i] != list[lastIndex]) return false;
                lastIndex--;
            }

           return true;
           
        }
        private  void sekillendir(SolidColorBrush brus, string text)
        {
            lbltextContent.Content = txtPaledrom.Text;
            lblErgebniss.Foreground = brus;
            lblErgebniss.Content = text;
            txtPaledrom.Text = "";
        }   
    }
}