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

namespace Wpf_DynamiqueCreation
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            ColumnDefinition[] coldef = new ColumnDefinition[3];
            RowDefinition[] rowDef = new RowDefinition[3];
            for (int i = 0; i < 3; i++)
            {
                coldef[i] = new ColumnDefinition();
                Grid.ColumnDefinitions.Add(coldef[i]);
                rowDef[i] = new RowDefinition();
                Grid.RowDefinitions.Add(rowDef[i]);
            }
            //créer le textblock du haut
            TextBlock txtBlock1 = new TextBlock();
            Thickness marginBlock1 = new Thickness();
            marginBlock1.Top = 50;
            txtBlock1.Margin = marginBlock1;
            txtBlock1.Text = "TextBlock créé dynamiquement";
            txtBlock1.Background = Brushes.Yellow;
            txtBlock1.FontSize = 18;
            txtBlock1.Foreground = Brushes.Red;
            txtBlock1.FontWeight = FontWeights.UltraBold;
            txtBlock1.FontFamily = new FontFamily("NomDePolice");
            Grid.SetRow(txtBlock1, 0);
            Grid.SetColumnSpan(txtBlock1, 3);
            Grid.Children.Add(txtBlock1);

            Button[] button = new Button[3];
            for (int i = 0; i < 3; i++)
            {
                button[i] = new Button();
                button[i].Height = 100;
                button[i].Width = 100;
                button[i].Content = "BOUTON " + (i + 1);
                Grid.SetColumn(button[i], i);
                Grid.SetRow(button[i], 1);
                Grid.Children.Add(button[i]);
            }
            TextBlock txtBlock2 = new TextBlock();
            Thickness marginBlockbas = new Thickness();
            marginBlockbas.Bottom = 80;
            txtBlock2.Margin = marginBlockbas;
            txtBlock2.Text = "Infos : ";
            txtBlock2.FontSize = 14;
            txtBlock2.Foreground = Brushes.Black;
            txtBlock2.Background = Brushes.Yellow;
            txtBlock2.FontFamily = new FontFamily("NomDePolice");
            Grid.SetRow(txtBlock2, 2);
            Grid.SetColumnSpan(txtBlock2, 2);
            Grid.Children.Add(txtBlock2);
            TextBox txtBox1 = new TextBox();
            txtBox1.Height = 20;
            txtBox1.Text = "J'attend vos infos";
            Grid.SetRow(txtBox1, 2);
            Grid.SetColumnSpan(txtBox1, 2);
            Grid.Children.Add(txtBox1);
            ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("gerard");
            comboBox.Items.Add("sebastien");
            comboBox.VerticalAlignment = VerticalAlignment.Center;
            comboBox.HorizontalAlignment = HorizontalAlignment.Center;
            comboBox.Height = 80;
            comboBox.Width = 150;
            Grid.SetRow(comboBox, 3);
            Grid.SetColumn(comboBox, 3);
            Grid.Children.Add(comboBox);
        }
    }
}
