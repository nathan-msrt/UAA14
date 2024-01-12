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

namespace WPF_interDynamique
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ColumnDefinition coldef1 = new ColumnDefinition();
            ColumnDefinition coldef2 = new ColumnDefinition();
            ColumnDefinition coldef3 = new ColumnDefinition();
            gridMain.ColumnDefinitions.Add(coldef1);
            gridMain.ColumnDefinitions.Add(coldef2);
            gridMain.ColumnDefinitions.Add(coldef3);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            gridMain.RowDefinitions.Add(rowDef1);
            gridMain.RowDefinitions.Add(rowDef2);
            gridMain.RowDefinitions.Add(rowDef3);

            TextBlock txtAMonTexte = new TextBlock();
            Grid.SetColumn(txtAMonTexte, 0);
            txtAMonTexte.Background = Brushes.Yellow;
            txtAMonTexte.Foreground = Brushes.Red;
            txtAMonTexte.Text = "TextBlock créé dynamique";
            txtAMonTexte.FontFamily = new FontFamily("Arial");
            txtAMonTexte.FontWeight = FontWeights.Bold;



            Thickness myThickness = new Thickness();
            myThickness.Bottom = 40;
            myThickness.Top = 40;
            txtAMonTexte.Margin = myThickness;


            Grid.SetColumnSpan(txtAMonTexte, 3);
            gridMain.Children.Add(txtAMonTexte);

            Button btn1 = new Button();
            btn1.Content = "Bouton 1";
            btn1.Height = 150;
            btn1.Width = 150;
            Grid.SetRow(btn1, 1);
            Grid.SetColumn(btn1, 0);
            gridMain.Children.Add(btn1);



            Button btn2 = new Button();
            btn2.Content = "Bouton 2";
            btn2.Height = 150;
            btn2.Width = 150;
            Grid.SetRow(btn2, 1);
            Grid.SetColumn(btn2, 1);
            gridMain.Children.Add(btn2);

            Button btn3 = new Button();
            btn3.Content = "Bouton 3";
            btn3.Height = 150;
            btn3.Width = 150;
            Grid.SetRow(btn3, 1);
            Grid.SetColumn(btn3, 2);
            gridMain.Children.Add(btn3);

            StackPanel stkBloc1 = new StackPanel();
            Thickness myThickness2 = new Thickness();
            myThickness2.Top = 30;
            stkBloc1.Margin = myThickness2;


            TextBlock txtBMonTexte = new TextBlock();
            txtBMonTexte.Height = 50;
            txtBMonTexte.Background = Brushes.Yellow;
            txtBMonTexte.Text = "Infos : ";
            txtBMonTexte.FontWeight = FontWeights.Bold;
            stkBloc1.Children.Add(txtBMonTexte);

            TextBox txtBoxAMonTexte = new TextBox();
            txtBoxAMonTexte.Text = "J'attends vos infos ";
            stkBloc1.Children.Add(txtBoxAMonTexte);
            
            


            Grid.SetRow(stkBloc1, 2);
            Grid.SetColumn(stkBloc1, 0);
            Grid.SetColumnSpan(stkBloc1, 2);
            gridMain.Children.Add(stkBloc1);

            ComboBox cmbAMonTexte = new ComboBox();
            Grid.SetRow(cmbAMonTexte, 2);
            Grid.SetColumn(cmbAMonTexte, 2);
            cmbAMonTexte.Items.Add("Jean");
            cmbAMonTexte.Items.Add("Sefedin");
            cmbAMonTexte.Height = 100;
            cmbAMonTexte.Width = 150;
            gridMain.Children.Add(cmbAMonTexte);





















        }

    }
}
