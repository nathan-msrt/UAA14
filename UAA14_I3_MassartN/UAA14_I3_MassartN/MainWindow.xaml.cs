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

namespace UAA14_I3_MassartN
{
    public partial class MainWindow : Window
    {
         
        public MainWindow()
        {
            InitializeComponent();
            nb1.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            nb2.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            calculer.Click += new RoutedEventHandler(Button_Click);
            addition.Click += new RoutedEventHandler(additione_Click);
            soustrait.Click += new RoutedEventHandler(soustrait_Click);
        }
        private void soustrait_Click(object sender, RoutedEventArgs e)
        {

        }
        private void additione_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message;
            double a;
            double b;

            if (double.TryParse(nb1.Text, out a) && double.TryParse(nb2.Text, out b))
            {
                PageResultat secondePage = new PageResultat();
                secondePage.AffichageReponse.Text = message;
                secondePage.Show();
            }
            
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