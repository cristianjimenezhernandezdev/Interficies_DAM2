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

namespace Sessio_5_plus
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }
        public int laMevaDependencia
        {
            get { return (int)GetValue(laMevaDependenciaProperty); }
            set { SetValue(laMevaDependenciaProperty, value); }
        }
        public static readonly DependencyProperty laMevaDependenciaProperty =
            DependencyProperty.Register(
                name: "laMevaDependencia",
                propertyType: typeof(int),
                ownerType: typeof(MainWindow),
                typeMetadata: new FrameworkPropertyMetadata(0));

    }
}
