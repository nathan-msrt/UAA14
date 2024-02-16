using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace COURSE_LEVRIERS_DYN
{
    class Pari
    {
        private int _montant;

        public int Montant
        {
            get { return _montant; }
            set { _montant = value; }
        }
        private int _numChien;

        public int NumChien
        {
            get { return _numChien; }
            set { _numChien = value; }
        }
        //private Parieur _joueur;

        //public Parieur Joueur
        //{
        //    get { return _joueur; }
        //    set { _joueur = value; }
        //}
        public Pari(int montant, int numChien) 
        {
            _montant = montant;
            _numChien = numChien;
            //_joueur=joueur; 
        }
        //public void GetDescription(TextBlock txtInfos)
        //{
        //    string chaine = "";
        //    if (_montant != 0)
        //    {
        //        chaine =$" {_joueur.Nom} a parié {_montant} sur le chien # {_numChien + 1}" ;
        //    }
        //    else
        //    {
        //        chaine = _joueur.Nom + " n'a pas encore parié ";
        //    }
        //    txtInfos.Text = chaine;
        //}
        public int PrixFinal(int numGagnant)
        {
            int prix = 0;
            if (_numChien == numGagnant)
            {
                prix = 2 * _montant;
            }
            return prix;
        }
    }
}
