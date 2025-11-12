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

namespace Sessio5_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty colorFonsProperty =
        DependencyProperty.Register(
            name: "ColorFons",
            propertyType: typeof(bool),
            ownerType: typeof(MainWindow),
            typeMetadata: new FrameworkPropertyMetadata(Brushes.LightBlue, ColorFonsCanviat));
        public Brush colorFons 
        { 
            get { return (Brush)GetValue(colorFonsProperty); }
            set { SetValue(colorFonsProperty, value); } }
        public static void ColorFonsCanviat(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var finestra = d as MainWindow;
            var nouColor=(Brush)e.NewValue;
            finestra.btnCanviColor.Background = nouColor;
            finestra.txtInfo.Text = nouColor.ToString();
        }
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCanviColor_Click(object sender, RoutedEventArgs e)
        {
            if (colorFons == Brushes.LightBlue)
            {
                colorFons = Brushes.IndianRed;
            }
            else 
            {
                colorFons = Brushes.LightBlue;
            }
        }
        
    }
}
