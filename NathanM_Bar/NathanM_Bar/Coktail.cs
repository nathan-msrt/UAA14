using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NathanM_Bar
{
    public class Coktail
    {
		private string _nom;

		public  string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}
		private Recette _recetteCoktail;

		public Recette RecetteCoktail
		{
			get { return _recetteCoktail; }
			set { _recetteCoktail = value; }
		}


		public Coktail(string nom, Recette recetteCoktail) 
		{
			_nom = nom;
			_recetteCoktail = recetteCoktail;
		}    
    }
}
