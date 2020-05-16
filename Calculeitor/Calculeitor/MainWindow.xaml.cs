using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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

namespace Calculeitor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void SumarBtn_Click(object sender, RoutedEventArgs e)
        {
            string n1 = n1Txt.Text.Trim();
            string n2 = n2Txt.Text.Trim();
            int n1Num=0;
            int n2Num=0;
            if(!int.TryParse(n1, out n1Num))
            {
                await this.ShowMessageAsync("Error", "el numero 1 debe ser numero,wei ya!");
            } else if(!int.TryParse(n2, out n2Num))
            {
                await this.ShowMessageAsync("Error", "el numero 2 debe ser numero, wei ya!");
            } else
            {
                int suma = n1Num + n2Num;
                await this.ShowMessageAsync("Bien hecho!", "La suma es " + suma);
            }

            
        }

        private async void RestaBtn_Click(object sender, RoutedEventArgs e)
        {
            string n1 = n1Txt.Text.Trim();
            string n2 = n2Txt.Text.Trim();
            int n1Num = 0;
            int n2Num = 0;
            if (!int.TryParse(n1, out n1Num))
            {
                await this.ShowMessageAsync("Error", "el numero 1 debe ser numero,wei ya!");
            }
            else if (!int.TryParse(n2, out n2Num))
            {
                await this.ShowMessageAsync("Error", "el numero 2 debe ser numero, wei ya!");
            }
            else
            {
                int resta = n1Num - n2Num;
                await this.ShowMessageAsync("Bien hecho!", "La resta es " + resta);
            }

        }

        private async void MultiBtn_Click(object sender, RoutedEventArgs e)
        {
            string n1 = n1Txt.Text.Trim();
            string n2 = n2Txt.Text.Trim();
            int n1Num = 0;
            int n2Num = 0;
            if (!int.TryParse(n1, out n1Num))
            {
                await this.ShowMessageAsync("Error", "el numero 1 debe ser numero,wei ya!");
            }
            else if (!int.TryParse(n2, out n2Num))
            {
                await this.ShowMessageAsync("Error", "el numero 2 debe ser numero, wei ya!");
            }
            else
            {
                int multi = n1Num * n2Num;
                await this.ShowMessageAsync("Bien hecho!", "La multiplicacion es " + multi);
            }

        }

        private async void DivBtn_Click(object sender, RoutedEventArgs e)
        {
            string n1 = n1Txt.Text.Trim();
            string n2 = n2Txt.Text.Trim();
            double n1Num = 0;
            double n2Num = 0;
            if (!double.TryParse(n1, out n1Num))
            {
                await this.ShowMessageAsync("Error", "el numero 1 debe ser numero,wei ya!");
            }
            else if (!double.TryParse(n2, out n2Num))
            {
                await this.ShowMessageAsync("Error", "el numero 2 debe ser numero, wei ya!");
            }else if(n2Num == 0)
            {
                await this.ShowMessageAsync("Error", "oe no se puede dividir por 0");
            }
            else
            {
                double div = n1Num / n2Num;
                await this.ShowMessageAsync("Bien hecho!", "La division es " + div);
            }

        }
    }
}
