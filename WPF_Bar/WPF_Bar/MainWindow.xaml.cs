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

namespace WPF_Bar
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // éléments d'interface dynamique
        RadioButton[] listeCoktail = new RadioButton[3];
        TextBlock[] ingredients = new TextBlock[3];

        // intervenants
        Coktail[] nomCoktail = new Coktail[4];
        Parieur[] copains = new Parieur[3];

        // paramètres joueur actif et position chien
        int numJoueurActif = 0;
        int[] positionChien = new int[2]; // en 0 : position left, en 1 position top

        // timer
        DispatcherTimer timer = new DispatcherTimer();
        // témoin course finie
        bool fini;
        public MainWindow()
        {
            InitializeComponent();
            // gestionnaires d'événements
            btnParie.Click += new RoutedEventHandler(btnParie_Click);
            btnLancer.Click += new RoutedEventHandler(btnLancer_Click);
            btnReset.Click += new RoutedEventHandler(btnReset_Click);
            txtNbEcus.PreviewTextInput += new TextCompositionEventHandler(VerifTextInputEntier);
            txtNumChien.PreviewTextInput += new TextCompositionEventHandler(VerifTextInputEntier);
            // Paramétrage du timer
            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += new EventHandler(Timer_Tick);
            // préparation du centre de la fenêtre
            CreeCentre();
            PrepareJeu();
        }
        public void CreeCentre()
        {
            //Définition d'un jeu de marges
            Thickness myThickness = new Thickness();
            myThickness.Bottom = 5;
            myThickness.Left = 5;
            myThickness.Right = 5;
            myThickness.Top = 5;
            // Boutons d'options pour sélection du joueur qui va parier 
            for (int i = 0; i < 3; i++)
            {
                radChoixParieur[i] = new RadioButton();
                radChoixParieur[i].Name = "optJ" + i;
                radChoixParieur[i].GroupName = "Joueurs";
                radChoixParieur[i].Content = "titi possède x écus";
                radChoixParieur[i].Margin = myThickness;
                radChoixParieur[i].Checked += new RoutedEventHandler(opt_Checked);
                stkMonnaie.Children.Add(radChoixParieur[i]);
            }
            // textBlock pour infos sur le pari
            for (int i = 0; i < 3; i++)
            {
                txtInfosParis[i] = new TextBlock();
                txtInfosParis[i].Name = "txtInfosJ" + i;
                txtInfosParis[i].Text = "tit a parié y écus";
                txtInfosParis[i].Margin = myThickness;
                stkParis.Children.Add(txtInfosParis[i]);
            }
        }
    }
}
