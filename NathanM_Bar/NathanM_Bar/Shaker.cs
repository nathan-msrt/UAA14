using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NathanM_Bar
{
    public class Shaker
    {
		private double _contenanceMax;

		public  double ContenanceMax
		{
			get { return _contenanceMax; }
			set { _contenanceMax = value; }
		}
		private Portion[] _quantite;

		public Portion[] Quantite
		{
			get { return _quantite; }
			set { _quantite = value; }
		}


		public Shaker(double contenanceMax, Portion[] quantite) 
		{ 
			_contenanceMax= contenanceMax;
			_quantite = quantite;
		} 
    }
}
