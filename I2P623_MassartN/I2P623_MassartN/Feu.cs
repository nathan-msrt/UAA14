using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2P623_MassartN
{
    internal class Feu
    {
        private int  _couleur ;
        private string _identifiant;
        string etat;
        string chaineEtat;
        string chaineCligno;
        string chaineCouleur;
        int[] CouleurTab = new int[2];
        int[] EteintAllumerTab = new int[1];

        public int Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        public string Identifiant
        {
            get { return _identifiant; }
            set { _identifiant = value; }
        }

        public void Change(int couleur, string identifiant, int[]CouleurTab, string chaineCouleur)
        {
           
            for (int i = 0; 5 < CouleurTab[2]; i++)
            {
                if (CouleurTab[2] == 0)
                {
                    couleur = 1;
                    if (couleur == 1)
                    {
                        chaineCouleur = "Vert";
                    }
                }
                else if (CouleurTab[2] == 1)
                {
                    couleur = 2;
                    if (couleur == 2)
                    {
                        chaineCouleur = "Orange";
                    }
                }
                else if (CouleurTab[2] == 2)
                {
                    couleur = 3;
                    if (couleur == 3)
                    {
                        chaineCouleur = "Rouge";
                    }

                }
            }

        }
        public void Clignote( int[]EteintAllumerTab, string etat,string chaineCligno)
        {
            for (int i = 0; 5 < EteintAllumerTab[1]; i++)
            {
                if (EteintAllumerTab[1] == 0)
                {
                    etat = "éteint";

                }
                else
                {
                    etat = "allumé";
                }
            }
            chaineCligno = "007 est " + etat;

        }
        public void AfficherEtat(string chaineEtat, int couleur, int[] CouleurTab)
        {
            for (int i = 0; 5 < CouleurTab[2]; i++)
            {
                if (CouleurTab[2] == 0)
                {
                    chaineEtat = "Le feu de signialisation est vert";
                }
                else if (CouleurTab[2] == 1)
                {
                    chaineEtat = "Le feu de signialisation est orange";
                }
                else if (CouleurTab[2] == 2)
                {
                    chaineEtat = "Le feu de signialisation est rouge";
                }
            }
        }
    }
}
