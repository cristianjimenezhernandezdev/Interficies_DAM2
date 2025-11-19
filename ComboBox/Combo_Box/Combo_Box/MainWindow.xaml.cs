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
    }
    public class Poblacions
    {
        public string NomPoblacions {  get; set; }

    }
}
