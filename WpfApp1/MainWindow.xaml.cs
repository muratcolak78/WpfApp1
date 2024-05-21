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
        }
        // Tab 1 Code
        private void BTN_Hey_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(TBX_Eingabe.Text);
        }
        // Tab 2 Code 

        private void BTN_AusgabeBox_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(TBX_Eingabe.Text);
        }

        private void BTN_AusgabeBox2_Click(object sender, RoutedEventArgs e)
        {
           TBX_Aufgabe.Text=TBX_Eingabe.Text;
        }
    }
}