using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NathanM_Bar
{
    public class Recette
    {
		private Portion[] _ingredients;

		public Portion[] Ingredients
		{
			get { return  _ingredients; }
			set {  _ingredients = value; }
		}

		public Recette(Portion[] ingredients) 
		{
			_ingredients = ingredients;		
		}

    }
}
