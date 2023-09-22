using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace NathanM_MatchingGame
{
    
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }
       

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
            "🐈","🐈",
            "🐷","🐷",
            "🐐","🐐",
            "🦊","🦊",
            "🐴","🐴",
            "🦨","🦨",
            "🦉","🦉",
            "🐀","🐀",
            };

            foreach (TextBlock textBlock in grdMain.Children.OfType<TextBlock>())
            {
                Random nbAlea = new Random();   
                int index = nbAlea.Next(animalEmoji.Count); // index est de type int
                                                        // nbalea est un objet de type Random()
                string nextEmoji = animalEmoji[index]; // nextEmoji est de type string
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index); // on retire un animal de la liste pour ne pas l’attribuer à nouveau.
            }


        }
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            bool trouvePaire;
           
            TextBlock derniereTBClique = sender as TextBlock;  
            TextBlock textBlockActif = sender as TextBlock;
            if (!trouvePaire)
            {
                textBlockActif.Visibility = Visibility.Hidden;
                derniereTBClique = textBlockActif;
                trouvePaire = true;
            }
            else if (textBlockActif.Text == derniereTBClique.Text)
            {
                textBlockActif.Visibility = Visibility.Hidden;
                trouvePaire = false;
            }
            else
            {
                derniereTBClique.Visibility = Visibility.Visible;
                trouvePaire = false;
            }
        }
    }
}
