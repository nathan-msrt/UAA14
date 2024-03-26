using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NathanM_Bar
{
    public class Barman
    {
		private string _nom;

		public string Nom
		{
			get { return _nom; }
			
		}
		
		public Barman(string nom)
		{
			_nom = nom;
		}
	}
}
