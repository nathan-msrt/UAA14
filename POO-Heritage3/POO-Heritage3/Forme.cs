using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage3
{
    
        internal abstract class Forme
        {
            protected string _couleur;

            public string Couleur
            {
                get { return _couleur; }
                set { _couleur = value; }
            }
            public Forme(string couleur)
            { 
             _couleur= couleur;
            }
            public abstract double Surface();
            public abstract double Perimetre();
            public abstract string Afficher();
        }
    
}
