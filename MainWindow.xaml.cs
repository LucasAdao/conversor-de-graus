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

namespace conversor_de_graus
{
    /// <summary>
    /// Controller da view com c#!
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void botaoDaPrimeiraOperacao_Click(object sender, RoutedEventArgs e)
        {
            double celsiusPrimeiroTextBox = double.Parse(textBoxCelsiusToFahrenheit.Text);
            double fahrenheit = celsiusPrimeiroTextBox * 1.8 + 32;
            textBoxResultado1.Text = $"O resultado é: {Math.Round(fahrenheit,2)} °F"; 
        }

        private void botaoDaSegundaOperacao_Click(object sender, RoutedEventArgs e)
        {
            double celsiusSegundoTextBox = double.Parse(textBoxCelsiusToKelvin.Text);
            double kelvin = celsiusSegundoTextBox + 273.15;
            textBoxResultado2.Text = $"O resultado é: {Math.Round(kelvin,2)} °K";
        }
    }
}