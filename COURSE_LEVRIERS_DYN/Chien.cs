using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace COURSE_LEVRIERS_DYN
{
    class Chien
    {
        private int _longueurPiste;

        public int LongueurPiste
        {
            get { return _longueurPiste; }
            set { _longueurPiste = value; }
        }
        private int _numChien;

        public int NumChien
        {
            get { return _numChien; }
            set { _numChien = value; }
        }

        private Image _imageChien;
        public Image ImageChien
        {
            get { return _imageChien; }
            set { _imageChien = value; }
        }
        
        private int[] _positionCourante;

        public int[] PositionCourante
        {
            get { return _positionCourante; }
            set { _positionCourante = value; }
        }
        private bool _gagne;

        public bool Gagne
        {
            get { return _gagne; }
            set { _gagne = value; }
        }

        public Chien(int numeroChien, int[] position, int longueurPiste)
        {
            _longueurPiste = longueurPiste;
            _numChien = numeroChien;
            _positionCourante = new int[2];
            _positionCourante[0] = position[0];
            _positionCourante[1] = position[1];
            _gagne = false;
            MainWindow plateau = (COURSE_LEVRIERS_DYN.MainWindow)App.Current.MainWindow;
            // création de l'image
            BitmapImage imageChien = new BitmapImage();
            imageChien.BeginInit();
            imageChien.UriSource = new Uri("/assets/dog.png", UriKind.Relative);
            imageChien.EndInit();

            _imageChien = new Image();
            _imageChien.Source = imageChien;
            _imageChien.Stretch = System.Windows.Media.Stretch.None;

            Canvas.SetLeft(_imageChien, position[0]);
            Canvas.SetTop(_imageChien, position[1]);
            plateau.piste.Children.Add(_imageChien);

        }
        public void Court()
        {
           // MainWindow plateau = (COURSE_LEVRIERS_DYN.MainWindow)App.Current.MainWindow;

            // détermine longueur d'un pas
            int pas = (int)( _longueurPiste / 40);
            // randomize position
            Random alea = new Random();
            // On fait avancer le chien d'un multiple aléatoire de 10 pixels
            int nbPas;
            nbPas = alea.Next(1, 10);
            _positionCourante[0] += nbPas * pas;
            // si on est à moins de 75 pixels du bord droit de la piste, on mémorise le fait que le chien a gagné
            if (_positionCourante[0] >= _longueurPiste - 75)
            {
                _positionCourante[0] = _longueurPiste - 75;
                _gagne = true;
            }
            //avance l'image
            Canvas.SetLeft(_imageChien, _positionCourante[0]);
            Canvas.SetTop(_imageChien, _positionCourante[1]);
        }
        
    }
}
