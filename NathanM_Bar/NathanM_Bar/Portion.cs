using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NathanM_Bar
{
   public class Portion
    {
        private string _contenu;

        public string Contenu
        {
            get { return _contenu; }
            set { _contenu = value; }
        }

        private double _quantite;

        public double Quantite
        {
            get { return _quantite; }
            set { _quantite = value; }
        }
        public Portion(string contenu, double quantite)
        {
            _quantite = quantite;
            _contenu = contenu;
        }
        
    }
}
