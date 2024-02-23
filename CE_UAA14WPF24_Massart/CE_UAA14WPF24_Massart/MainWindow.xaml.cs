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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Image = System.Windows.Controls.Image;


namespace CE_UAA14WPF24_Massart
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BitmapImage imageBouton = new BitmapImage();
        Image imBouton = new Image();
        int[,] bTNiMAGE;
        public MainWindow()
        {
            InitializeComponent();
            //txtL.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            //txtC.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);

            S.Click += new RoutedEventHandler(CheckBox);
            M.Click += new RoutedEventHandler(CheckBox);
            BL.Click += new RoutedEventHandler(CheckBox);
            //BL.Click += new RoutedEventHandler(Buton_Click);


            S.FontWeight = FontWeights.Bold;
            M.FontWeight = FontWeights.Bold;
            BL.FontWeight = FontWeights.Bold;
            txtL.FontWeight = FontWeights.Bold;
            txtC.FontWeight = FontWeights.Bold;
        }
        //public void Buton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (BL.Name != "Bl")
        //    {
        //        stk2.ContextMenu = TextHidden;
        //    }
        //    else
        //    {
        //        stk2.ContextMenu = H;
        //    }
        //}
        public void CheckBox(object sender, RoutedEventArgs e)
        {
           
            if (S.Name == "S")
            {
                for (int i = 0; i < bTNiMAGE[9,i]; i++)
                {
                    for (int y = 0; y < bTNiMAGE[9,y]; y++)
                    {
                        Button btnB = new Button();
                        btnB.Height = 50;
                        btnB.Width = 50;
                        btnB.Content = "o";
                        STKBTN.Children.Add(btnB);
                    }
                }
            }
            else if (M.Name == "M")
            {
                for (int i = 0; i < bTNiMAGE[7, i]; i++)
                {
                    for (int y = 0; y < bTNiMAGE[7, i]; y++)
                    {
                        Button btnB = new Button();
                        btnB.Height = 50;
                        btnB.Width = 50;
                        STKBTN.Children.Add(btnB);
                    }
                }
            }
            else
            {

            }
        }
        //private void VerifTextInput(object sender, TextCompositionEventArgs e)
        //{
        //    if (e.Text != "," && e.Text != "-" && !EstEntier(e.Text))
        //    {
        //        e.Handled = true;
        //    }
        //    else if (e.Text == "," || e.Text == "-")
        //    {
        //        e.Handled = true;
        //    }
        //}
        //bool EstEntier(object sender, TextCompositionEventArgs texte)
        //{
        //    return int.TryParse(texte, out int_);
        //    e.Handled = true;


        //}
    }
}
