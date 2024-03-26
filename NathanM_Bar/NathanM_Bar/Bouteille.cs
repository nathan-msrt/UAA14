using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NathanM_Bar
{
    public class Bouteille
    {
		private string _contenu;

		public string Contenu
		{
			get { return _contenu; }
			set { _contenu = value; }
		}

		private double _contenance;

		public double Contenance
		{
			get { return _contenance; }
			set { _contenance = value; }
		}
		public Bouteille(string contenu, double contenance)
		{
			_contenance= contenance;
			_contenu = contenu;
		}

		public string Verser()
		{
			string
		}
	}
}
