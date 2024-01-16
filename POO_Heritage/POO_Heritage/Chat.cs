using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage
{
    internal class Chat : Animaux
    {
       
        public Chat(string nom, DateTime dateDeNaissance, double numeroPuce, double taille, bool animauxConcours) :base (nom, dateDeNaissance, numeroPuce, taille , animauxConcours)
        {
        }

        public override string Affiche()
        {
            string affiche = "Mon statut: \n Nom : " + _nom + ".\nMa date de naissance : " + _dateDeNaissance + "\n Numéro de puce : " + _numeroPuce + "\n Taille : " + _taille + "\n Animal de concours : " + _animauxConcours + ".";
            return affiche;
        }

        public string Miaule()
        {
            string miaule = "Le chat miaule : miawwwww";
            return miaule;  

        }

        public string Ronronne()
        {
            string ronronne = "Le chat ronronne : rrrrrr";
            return ronronne;    
        }



    }
}
