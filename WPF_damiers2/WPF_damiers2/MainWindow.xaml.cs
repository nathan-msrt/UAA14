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

namespace WPF_damiers2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int tailleGrille = 10;
            Button[,] btn = new Button[tailleGrille, tailleGrille];
            ColumnDefinition[] coldef1 = new ColumnDefinition[tailleGrille];
            RowDefinition[] rowdef1 = new RowDefinition[tailleGrille];
            int compteur = 1;

            for (int i = 0; i < tailleGrille; i++)
            {
                coldef1[i] = new ColumnDefinition();
                GRID.ColumnDefinitions.Add(coldef1[i]);
                rowdef1[i] = new RowDefinition();
                GRID.RowDefinitions.Add(rowdef1[i]);
            }
            for (int i = 0; i < tailleGrille; i++)
            {
                for (int y = 0; y < tailleGrille; y++)
                {
                    btn[i, y] = new Button();
                    btn[i, y].Foreground = Brushes.Red;
                    btn[i, y].Height = 65;
                    btn[i, y].Width = 65;

                    if ((y + i) % 2 == 0)
                    {
                        btn[i, y].Background = Brushes.White;
                    }
                    else
                    {
                        btn[i, y].Background = Brushes.Black;
                    }
                    if (i % 2 == 0)
                    {
                        btn[i, y].Content = compteur;
                    }
                    else
                    {
                        btn[i, y].Content = (tailleGrille * i) + (tailleGrille - 1 - y) + 1;
                    }

                    compteur++;
                    Grid.SetColumn(btn[i, y], y);
                    Grid.SetRow(btn[i, y], i);
                    GRID.Children.Add(btn[i, y]);
                }

            }
        }
    }
}
