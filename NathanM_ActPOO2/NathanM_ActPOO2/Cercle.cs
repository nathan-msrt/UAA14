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
			double aire = (double)(_rayon *_rayon + Math.PI);
			return aire;
		}
		public double CalculerPerimetre() 
        {
			double perimetre = (double)(2* _rayon + Math.PI);
			return perimetre;
        }
		public string AfficherCaractéristiques()
		{
			double perimetre = this.CalculerPerimetre();
			double aire = this.CalculerAire();
			string chaine = " Le cercle de rayon " + _rayon + " a un perimetre de " + perimetre + " et une aire de " + aire +".";
			return chaine;	
		}
	}
}
