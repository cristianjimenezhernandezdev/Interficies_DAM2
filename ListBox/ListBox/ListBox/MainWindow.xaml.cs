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

namespace ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Poblacions> llistaPob = new List<Poblacions>();
            llistaPob.Add(new Poblacions()
            {
                poblacio1 = "Angles",
                temperatura1 = 19,
                poblacio2 = "Osor",
                temperatura2 = 15,
                barra=4,

            }



                );
            llistaPob.Add(new Poblacions()
            {
                poblacio1 = "Girona",
                temperatura1 = 20,
                poblacio2 = "Celra",
                temperatura2 = 10,
                barra=10,

            }
                );
            llistaPob.Add(new Poblacions()
            {
                poblacio1 = "Blanes",
                temperatura1 = 19,
                poblacio2 = "Sarria",
                temperatura2 = 15,
                barra=4,

            }
                );
            llistaPob.Add(new Poblacions()
            {
                poblacio1 = "Bescano",
                temperatura1 = 19,
                poblacio2 = "Cellera",
                temperatura2 = 15,
                barra=4,

            }
                );
            llistaPoblacions.ItemsSource = llistaPob;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show((llistaPoblacions.SelectedItem as Poblacions).poblacio1 + " " +
                     (llistaPoblacions.SelectedItem as Poblacions).temperatura1 + " ºC" + " " +
                     (llistaPoblacions.SelectedItem as Poblacions).poblacio1 + " " +
                     (llistaPoblacions.SelectedItem as Poblacions).temperatura1 + " ºC");
            }
            catch (Exception )
            {
                
            }
            
                    ;
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                MessageBox.Show((llistaPoblacions.SelectedItem as Poblacions).poblacio1 + " " +
                     (llistaPoblacions.SelectedItem as Poblacions).temperatura1 + " ºC" + " " +
                     (llistaPoblacions.SelectedItem as Poblacions).poblacio1 + " " +
                     (llistaPoblacions.SelectedItem as Poblacions).temperatura1 + " ºC");
            }
            catch (Exception)
            {

            }
        }
    }
    public class Poblacions
    {
        public string poblacio1 { get; set; }
        public int temperatura1 { get; set; }
        public string poblacio2 { get; set; }
        public int temperatura2 { get; set; }
        public int barra {  get; set; }
 
    }
}
