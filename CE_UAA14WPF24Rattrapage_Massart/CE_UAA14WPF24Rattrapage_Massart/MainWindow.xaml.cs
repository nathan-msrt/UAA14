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

namespace CE_UAA14WPF24Rattrapage_Massart
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gbTaille.Visibility = Visibility.Hidden;
            testwpf.Visibility = Visibility.Hidden;
            reset.Click += new RoutedEventHandler(ButtonReset_Click);
            valider.Click += new RoutedEventHandler(Button_Click);
            row.Text += new TextCompositionEventHandler(Verif);
            colonnes.Text += new TextCompositionEventHandler(Verif);
            Marelle.Click += new RoutedEventHandler(Button_Click);
            Solitaire.Click += new RoutedEventHandler(Button_Click);
            BandeLaterale.Click += new RoutedEventHandler(Button_Click);

        }
        private void CreeDamier(int colonnes, int lignes, string disposition)
        {
            for (int i = 0; i < colonnes; i++)
            {
                
                grilleJeu.ColumnDefinitions.Add(new ColumnDefinition());
               
            }
            for (int i = 0; i < lignes; i++)
            {
                grilleJeu.RowDefinitions.Add(new RowDefinition());
            }
        }
        private void Disposition()
        {
            if (Solitaire.IsChecked == true)
            {
                CreeDamier(9, 9, "solitaire");
            }
            else if (Marelle.IsChecked == true)
            {
                CreeDamier(7, 7, "Marelle");
            }
            else if (BandeLaterale.IsChecked== true)
            {
               
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (row.Text)
            //{
            //    testwpf.Text = "veuillez entrer des dimensions entre 1 et 12";
            //}
            Disposition();
            Button button = new Button();
            BitmapImage imageBouton = new BitmapImage();
            imageBouton.BeginInit();
            imageBouton.UriSource = new Uri("images/petitCercleRouge.png", UriKind.Relative);
            imageBouton.EndInit();
            Image imbouton = new Image();
            imbouton.Source = imageBouton;
            imbouton.Stretch = Stretch.Fill;
            button.Content = imbouton;
        }
        private void SupprimerDamier()
        {

        }
        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            SupprimerDamier();
            grilleJeu.Children.Clear();
            grilleJeu.RowDefinitions.Clear();
            grilleJeu.ColumnDefinitions.Clear();
            BandeLaterale.IsChecked= false;
            row.Text = string.Empty;
            colonnes.Text = string.Empty;
            
        }

        private void Verif(object sender, TextCompositionEventArgs e)
        {
            int entier;
            if (int.TryParse(e.Text, out entier))
            {
                testwpf.Visibility = Visibility.Visible;
                testwpf.Text = "Veuillez entrer des entiers svp";
                row.Text = string.Empty;
                colonnes.Text = string.Empty;
            }
        }
        private void RadioButton_Checked (object sender, RoutedEventArgs e)
        {
            if (BandeLaterale.IsChecked == true )
            {
                gbTaille.Visibility = Visibility.Visible;
            }
            else
            {
                gbTaille.Visibility = Visibility.Hidden;
            }
        }
        
        private void VerifError(object sender, RoutedEventArgs e)
        {
            
        }
        private void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = true;
        }
    }
}
