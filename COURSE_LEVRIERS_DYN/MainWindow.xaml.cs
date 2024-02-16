using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
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
using System.Windows.Threading;
using System.Xml.Linq;

namespace COURSE_LEVRIERS_DYN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // éléments d'interface dynamique
        RadioButton[] radChoixParieur = new RadioButton[3];
        TextBlock[] txtInfosParis = new TextBlock[3];

        // intervenants
        Chien[] coureurs = new Chien[4];
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
        //Instanciation des éléments du jeu : joueurs et coureurs
        protected void PrepareJeu()
        {
            // instanciation des chiens et positionnement
            positionChien[0] = 20;
            positionChien[1] = 15;
            for (int i = 0; i < 4; i++)
            {
                coureurs[i] = new Chien(i + 1, positionChien, 800);
                positionChien[1] += 70;
            }
            // instantiation des parieurs en leur affectant un bouton d'option et un textblock pour mise à jour des infos
            copains[0] = new Parieur(25, radChoixParieur[0], txtInfosParis[0], "Joe");
            copains[1] = new Parieur(50, radChoixParieur[1], txtInfosParis[1], "Bob");
            copains[2] = new Parieur(75, radChoixParieur[2], txtInfosParis[2], "Bill");

            // mise à jour de l'affichage du contenu des boutons d'options et des textBlock
            for (int i = 0; i < 3; i++)
            {
                copains[i].MajInfos();
                txtInfosParis[i].Text = copains[i].Nom + " n'a pas encore parié.";
            }
            btnReset.IsEnabled = false; 
            btnLancer.IsEnabled=false;
        }
        // Vérification de l'encodage : seul un entier est accepté
        private void VerifTextInputEntier(object sender, TextCompositionEventArgs e)
        {
            int entier;
            if  (!int.TryParse(e.Text, out entier))
            {
                e.Handled = true;
            }           
        }
        // remplissage de la texBock prénom
        protected void opt_Checked(object sender, RoutedEventArgs e)
        {
            // récupération du numéro du bouton d'option concerné (son nom est optJ0 par exemple) et donc du numéro du joueur actif
            numJoueurActif = Convert.ToInt32(((RadioButton)sender).Name.Substring(4, 1));
            txtPrenom.Text = copains[numJoueurActif].Nom;
            //numJoueurActif = numOpt + 1;
        }
        // validation du pari : vérification par rapport aux avoirs des joueurs, récupération du numéro du chien
        protected void btnParie_Click(object sender, RoutedEventArgs e)
        {
            // Récupération et vérification des données du joueur :
            // Pari ne doit pas excéder la valeur possédée par le joueur et au moins 5 écus
            // Le numéro du chien doit être compris entre 1 et 4
            int entreeUserPari;
            int entreeUserNChien;

            if (int.TryParse(txtNbEcus.Text, out entreeUserPari) && int.TryParse(txtNumChien.Text, out entreeUserNChien))
            {
                if ((entreeUserPari > 0 && entreeUserPari <= copains[numJoueurActif].Cash) && (entreeUserNChien >= 1 && entreeUserNChien <= 4))
                {
                    // Création du pari, mise à jour des informations du joueur
                    copains[numJoueurActif].Parie(entreeUserPari, entreeUserNChien - 1);
                    copains[numJoueurActif].MajInfos();
                    copains[numJoueurActif].GetDescriptionPari(copains[numJoueurActif].TextBlockEtatPari);
                    txtNbEcus.Text = "";
                    txtNumChien.Text = "";
                    btnLancer.IsEnabled = true;
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un pari inférieur ou égal à vos avoirs et un numéro de chien compris entre 1 et 4 !!!");
            }
        }
        private void PositionneChiensDepart()
        {
            // position du premier chien [0] = décalage à gauche, [1] = décalage en hauteur
            positionChien[0] = 20;
            positionChien[1] = 15;

            // Positionnement sur le Canvas déjà placé sur la fenêtre
            for (int i = 0; i < 4; i++)
            {
                coureurs[i].PositionCourante[0] = positionChien[0];
                coureurs[i].PositionCourante[1] = positionChien[1];
                // positionnement du chiendans le Canvas
                Canvas.SetLeft(coureurs[i].ImageChien, coureurs[i].PositionCourante[0]);
                Canvas.SetTop(coureurs[i].ImageChien, coureurs[i].PositionCourante[1]);
                // modification de l'ordonnée pour le chien suivant
                positionChien[1] += 70;
            }
        }
        protected void btnLancer_Click(object sender, RoutedEventArgs e)
        {
            // Si tous les joueurs ont parié, on peut lancer la course
           
            
            if (copains[0].MonPari != null && copains[1].MonPari != null && copains[2].MonPari != null)
            {
                timer.Start();
            }
            else
            {
                MessageBox.Show("Tous les joueurs doivent parier avant la course !");
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //A chaque pas du timer, on fait avancer les chiens jusqu'à ce qu'au moins un d'entre eux atteigne la ligne d'arrivée
            
            fini = false;  // passe à vrai si un chien a dépassé la ligne
            int j = 0;          // pointeur de joueur
            int numGagnant; // numéro du joueur gagnant

            while (j < 4 && !fini)
            {
                coureurs[j].Court();
                // vérification : coureur arrivé
                if (coureurs[j].Gagne)
                {
                    numGagnant = j;
                    fini = true;
                    timer.Stop();
                    
                    MessageBox.Show($"Nous avons un gagnant : le chien numéro {j + 1}");

                    //  paiement des joueurs gagnants
                    for (int i = 0; i < 3; i++)
                    {
                        copains[i].Cash += copains[i].MonPari.PrixFinal(numGagnant);
                        copains[i].MajInfos();
                    }

                    btnReset.IsEnabled = true;
                }
                j++;
            }

        }
        protected void btnReset_Click(object sender, RoutedEventArgs e)
        {
            // si la course est finie, on permet de poursuivre avec une autre course ou on réinitialise tout le jeu, porte feuille joueur y compris
            if ((string)btnReset.Content == "PREPARER UNE NOUVELLE COURSE")
            {
                // assez d'argent pour parier !
                if (copains[0].Cash >= 5 && copains[1].Cash >= 5 && copains[2].Cash >= 5)
                {
                    PrepareCourse();
                }
                // Fin du jeu
                else
                {
                    MessageBox.Show("Le jeu est fini ! \nRéinitialiser le jeu pour recommencer !");
                    btnReset.Content = "REINITIALISER LE JEU !";
                    btnLancer.IsEnabled = false;
                }
            }
            else
            {
                InitialiseCourse();
            }

        }
        // Ramène les chiens au départ de la piste, supprime les anciens paris, rafraîchi les zones de texte
        protected void PrepareCourse()
        {
            PositionneChiensDepart();
            for (int i = 0; i < 3; i++)
            {
                copains[i].ResetPari();
                copains[i].MajInfos();
                copains[i].TextBlockEtatPari.Text = copains[i].Nom + " n'a pas encore parié ";
            }
            for (int i = 0; i < 4; i++)
            {
                coureurs[i].Gagne = false;
            }
            btnReset.IsEnabled = false;
        }
        // Réinitialise les portefeuilles des joueurs, prépare la course, rafraichi le bouton reset
        protected void InitialiseCourse()
        {
            int cash = 25;
            
            for (int i = 0; i < 3; i++)
            {
                copains[i].Cash = cash;
                cash += 25;
            }
            PrepareCourse();
            btnReset.Content = "PREPARER UNE NOUVELLE COURSE";
            btnReset.IsEnabled = false;
        }

    }
}
