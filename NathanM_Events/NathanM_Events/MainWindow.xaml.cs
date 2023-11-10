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

namespace NathanM_Events
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            txtA.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            txtB.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            txtC.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            calculer.Click += new RoutedEventHandler(Button_Click);
            calculer.MouseEnter += new MouseEventHandler(SurvolBouton);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message;
            double a;
            double b;
            double c;
            double x1 = 0;
            double x2 = 0;
            char type;
            if (double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b) && double.TryParse(txtC.Text, out c))
            {
                ResoudTrinome(a, b, c, out message);
                PageResultat secondePage = new PageResultat();
                secondePage.AffichageReponse.Text = message;
                secondePage.Show();
            }
        }

        private void SurvolBouton(object sender, MouseEventArgs e)
        {
            if (vert.Visibility == Visibility.Hidden)
            {
                vert.Visibility = Visibility.Visible;
            }
            else
            {
                vert.Visibility = Visibility.Hidden;
            }
        }

        private void calculer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(" ");
        }
        static string  ResoudTrinome(double a, double b, double c, out string message)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                message = "Il n'y a pas de solution réelle";

            }
            else if (delta == 0)
            {
                double x1 = -b / (2 * a);
                message = "Il y a une solution " + x1;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                message = "Il y a deux solutions " + x1 + " et " + x2;
            }
            return message;
        }
        private bool EstEntier(string texte)
        {
            return int.TryParse(texte, out int _);
        }
        private void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "," && e.Text != "-" && !EstEntier(e.Text))
            {
                e.Handled = true;
            }
            else if (e.Text == "," || e.Text == "-")
            {
                if (((TextBox)sender).Text.IndexOf(e.Text) > -1)
                {
                    e.Handled = true;
                }
            }
        }
    }
    
    
}
