using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NathanM_ActPOO2
{
    internal class Complexe
    {
        private double _imaginaire;
        private double _reel;

        public double Imaginaire
        {
            get { return _imaginaire; }
            set { _imaginaire = value; }
        }
        public double Reel
        {
            get { return _reel; }
            set { _reel = value; }
        }
        public Complexe(double imaginaire, double reel)
        {
            _imaginaire=imaginaire;
            _reel=reel;
        }
    }
}
