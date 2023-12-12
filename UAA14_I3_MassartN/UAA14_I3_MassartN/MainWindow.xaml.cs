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
            reset.Click += reset_Click;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier que l'utilisateur à bien encoder les nombres, le reste des vérifications sont faites pendant que l'utilisateur encode les nombres
            if (nb1.Text.Length == 0)
            {
                MessageBox.Show("Vous devez encoder le nombre 1 !");
                return;
            }

            if (nb2.Text.Length == 0)
            {
                MessageBox.Show("Vous devez encoder le nombre 2 !");
                return;
            }

            MethodesDuProjet methodes = new MethodesDuProjet();

            // Préparer les inputs pour le calcul
            ushort[] inputNumber1Tab = methodes.RemplirTableau(nb1.Text);
            ushort[] inputNumber2Tab = methodes.RemplirTableau(nb2.Text);

            // Initaliser les variables du résultat
            ushort[] res;
            bool ok = false;

            if (addition.IsChecked == true)
            {
                methodes.Additionne(inputNumber1Tab, inputNumber2Tab, out res, out ok);
            }
            else if (soustrait.IsChecked == true)
            {
                ok = methodes.Soustrait(inputNumber1Tab, inputNumber2Tab, out res);
            }
            else
            {
                MessageBox.Show("Il faut préciser une opération !");
                return;
            }

            // Affichage du résultat
            if (ok)
            {
                reset.Text = methodes.Concatene(res);
            }
            else
            {
                reset.Text = "Calcul impossible";
            }
        }

        // Evenement click du bouton reset
        private void reset_Click(object sender, RoutedEventArgs e)
        {
            // Remettre tout les contrôles à leur état initial
            reset.Text = "";
            nb1.Text = "";
            nb2.Text = "";
            addition.IsChecked = true;
            soustrait.IsChecked = false;
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