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

namespace Sessio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           
            Canvas elMeuCanvas= new Canvas();
            this.Content = elMeuCanvas;

           
            Button btn = new Button();
            Button btn2 = new Button();
            Button btn3 = new Button();

            elMeuCanvas.Children.Add(btn);
            elMeuCanvas.Children.Add(btn2);
            elMeuCanvas.Children.Add(btn3);
            //WrapPanel elMeuWrapPanel = new WrapPanel();
            //Mides
            btn.Height = 50;
            btn.Width = 150;
            //Posicionament
            Canvas.SetLeft(btn, 100);
            Canvas.SetTop(btn, 100);

            btn2.Height = 50;
            btn2.Width = 150;
            Canvas.SetLeft(btn2, 100);
            Canvas.SetTop(btn2, 200);

            btn3.Height = 50;
            btn3.Width = 150;
            Canvas.SetLeft(btn3, 100);
            Canvas.SetTop(btn3, 300);

            
         


            TextBlock Txt1 = new TextBlock();
            Txt1.Text = "Hola";
            Txt1.Foreground=Brushes.Blue;
            //elMeuWrapPanel.Children.Add(Txt1);

            TextBlock Txt2 = new TextBlock();
            Txt2.Text = "Nom Usuari";
            Txt2.Foreground=Brushes.Red;
            //elMeuWrapPanel.Children.Add(Txt2);


            TextBlock Txt3 = new TextBlock();
            Txt3.Text = "Campalans";
            Txt3.Foreground=Brushes.Green;
            //elMeuWrapPanel.Children.Add(Txt3);


            btn.Content = Txt1;
            btn2.Content = Txt2;
            btn3.Content = Txt3;
            
        }
    }
}
