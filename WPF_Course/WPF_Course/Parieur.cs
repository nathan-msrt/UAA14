using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Course
{
    internal class Parieur
    {
        protected string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }

        }
        protected Pari _monPari;

        public Pari MonPari
        {
            get { return _monPari; }
            set { _monPari = value; }
        }

        protected int _cash;

        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }


        protected TextBlock _textBlockEtatPari;

        public TextBlock TextBlockEtatPari
        {
            get { return _textBlockEtatPari; }
            set { _textBlockEtatPari = value; }
        }
        public Parieur(string nom, Pari monPari, int cash, TextBlock textBlockEtatPari)
        {
            _nom = nom;
            _monPari = monPari;
            _cash = cash;
            _textBlockEtatPari = textBlockEtatPari;
        }
        public void AjouterPortefeuille(int ecus)
        {
            _cash += ecus;
        }

        public bool RetirerPortefeuille(int ecus)
        {
            if (_cash >= ecus)
            {
                _cash -= ecus;
                return true;
            }
            return false;
        }

        public bool Parier(int ecus, Chien chien)
        {
            if (_cash< ecus)
            {
                return false;
            }
            _pariActuel = new Pari(ecus, chien);
            return true;
        }
    }
}
