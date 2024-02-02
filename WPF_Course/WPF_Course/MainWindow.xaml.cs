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

namespace WPF_Course
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            numerochien.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            ecuspari.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            J1.Click += new RoutedEventHandler(Button_Click);
            B2.Click += new RoutedEventHandler(Button_Click);
            B3.Click += new RoutedEventHandler(Button_Click);
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (J1.Name=="J1")
            {
                quipari.Text = "Joe";
            }else if (B2.Name =="B1")
            {
                quipari.Text = "Bob";
            }
            else
            {
                quipari.Text = "Bill";
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
