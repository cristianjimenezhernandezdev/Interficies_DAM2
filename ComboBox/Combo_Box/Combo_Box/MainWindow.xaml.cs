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

namespace Combo_Box
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Poblacions> llistaPoblacions = new List<Poblacions>();
            llistaPoblacions.Add(new Poblacions() { NomPoblacions = "Osor"});
            llistaPoblacions.Add(new Poblacions() { NomPoblacions = "Angles" });
            llistaPoblacions.Add(new Poblacions() { NomPoblacions = "Amer" });
            llistaPoblacions.Add(new Poblacions() { NomPoblacions = "Girona" });
            Poblacions.ItemsSource = llistaPoblacions;
        }
   
        private void TotesP_UChecked(object sender, RoutedEventArgs e)
        {
            Espanya.IsChecked = false;
            China.IsChecked = false;
            Italia.IsChecked = false;
            UK.IsChecked = false;
            Portugal.IsChecked = false;
        }

        private void TotesP_Checked_1(object sender, RoutedEventArgs e)
        {
            Espanya.IsChecked = true;
            China.IsChecked = true;
            Italia.IsChecked = true;
            UK.IsChecked = true;
            Portugal.IsChecked = true;
        }
        private void Idividual_Checked(object sender, RoutedEventArgs c)
        {
            if(Espanya.IsChecked==true  && UK.IsChecked==true && Italia.IsChecked==true && China.IsChecked==true && Portugal.IsChecked == true)
            {
                TotesP.IsChecked = true;
            }
            else
            {
                TotesP.IsChecked=null;
            }
        }
        private void Idividual_UChecked(object sender, RoutedEventArgs c)
        {
            if (Espanya.IsChecked == false && UK.IsChecked == false && Italia.IsChecked == false && China.IsChecked == false && Portugal.IsChecked == false)
            {
                TotesP.IsChecked = false;
            }
            else
            {
                TotesP.IsChecked = null;
            }
        }
    }
    public class Poblacions
    {
        public string NomPoblacions {  get; set; }

    }
}
