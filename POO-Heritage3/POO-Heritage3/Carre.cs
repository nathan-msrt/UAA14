using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage3
{
    internal class Carre : Forme
    {
        private double _tailleCotes;

        public double TailleCotes
        {
            get { return _tailleCotes; }
            set { _tailleCotes = value; }
        }

        public Carre(double tailleCotes, string couleur) : base(couleur) 
        {
            _tailleCotes = tailleCotes;
            _couleur = couleur;
        }

        public override double Perimetre()
        {
            return 4 * _tailleCotes;
        }

        public override double Surface()
        {
            return _tailleCotes * _tailleCotes;
        }

        public override string Afficher()
        {
            return "Carre [Taille des Cotés:" + _tailleCotes + "/ Couleur:" + _couleur + "/ Perimetre:" + Perimetre() + "/ Surface:" + Surface() + "]";
        }
    }
}
