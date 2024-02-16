using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace COURSE_LEVRIERS_DYN
{
    class Parieur
    {
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private Pari _monPari;

        public Pari MonPari
        {
            get { return _monPari; }
            set { _monPari = value; }
        }
        private int _cash;

        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }
        private RadioButton _optParieur;

        public RadioButton OptParieur
        {
            get { return OptParieur; }
            set { OptParieur = value; }
        }
        private TextBlock _textBlockEtatPari;

        public TextBlock TextBlockEtatPari
        {
            get { return _textBlockEtatPari; }
            set { _textBlockEtatPari = value; }
        }


        public Parieur(int cash, RadioButton opt, TextBlock tbP, string nom)
        {
            _optParieur = opt;
            _textBlockEtatPari = tbP;
            _cash = cash;
            _nom = nom;
        }
        // mise à jour du texte du bouton d'option du joueur
        public void MajInfos()
        {
            _optParieur.Content = _nom + " possède " + _cash + " écus";
        }
        public void Parie(int valeurPari, int numChien)
        {
            //création de l'objet pari + décompte de la valeur du pari dans le prote feuille du joueur
            _monPari = new Pari(valeurPari, numChien);
            _cash -= valeurPari;
        }
        // met à jour la zone de texte d'état du pari si on a parié
        public void GetDescriptionPari(TextBlock txtInfos)
        {
            string chaine = "";
            if (_monPari.Montant != 0)
            {
                chaine = $" {this.Nom} a parié {_monPari.Montant} sur le chien # {_monPari.NumChien + 1}";
            }
            else
            {
                chaine = this.Nom + " n'a pas encore parié ";
            }
            txtInfos.Text = chaine;
        }
        public void ResetPari()
        {
            _monPari = null;
        }

    }
}
