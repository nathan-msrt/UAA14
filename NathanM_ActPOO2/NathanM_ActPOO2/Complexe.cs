using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        public double Module()
        {
            double module = Math.Sqrt( Math.Pow(_reel, 2) + Math.Pow(_imaginaire, 2));
            return module;
        }
        public void Ajoute(Complexe C)
        {
            _reel = _reel + C._reel;
            _imaginaire = _imaginaire + C._imaginaire;
        }
        public string AfficheComplexe()
        {
            string chaine = " Le complexe : (" + _reel + "," +_imaginaire +") ";
            return chaine;
        }
        public string AfficheModule()
        {
            string chaine = " a pour module :" + Module() +"";
            return chaine;
        }
       
    }
}
