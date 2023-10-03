using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NathanM_ActPOO2
{
	class Cercle
	{
		private double _rayon;

		public double Rayon
		{
			get { return _rayon; }
			set { _rayon = value; }
		}
		public Cercle(double rayon) { 
		
			_rayon = rayon;
		
		}
		public double CalculerAire()
		{
			double aire = Math.PI * _rayon * _rayon;
			return aire;
		}
		public double CalculerPerimetre() 
        {
			double perimetre = 2 * Math.PI * _rayon ;
			return perimetre;
        }
		public string AfficherCaractéristiques()
		{
			string chaine = " Le cercle de rayon " + _rayon + " a un perimetre de " + CalculerPerimetre() + " et une aire de " + CalculerAire() +".";
			return chaine;	
		}
    }
}
