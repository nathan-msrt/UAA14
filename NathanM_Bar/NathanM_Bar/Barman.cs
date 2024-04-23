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
		
		public int Commander(string menu, int nbRecettes)
		{
			string choixUser;
			int numeroCoktail;
			do
			{
				do
				{
					Console.WriteLine("Bonjour je suis " + _nom + " que puis-je faire pour vous ?");
					Console.WriteLine("");
					Console.WriteLine(menu);
					choixUser = Console.ReadLine();
				} while (!int.Parse(choixUser, out numeroCoktail));
			} while (numeroCoktail < 0 || numeroCoktail > nbRecettes);
			return numeroCoktail;
		}
		public bool Fabriquer(Coktail coktail, Shaker shaker, Bar monbar)
		{
			bool ok = true;
            foreach (Portion portion in coktail.RecetteCoktail.Ingredients)
            {
				int numeroBouteille;
				if (monbar.PrendreBouteille(ingredient, out numeroBouteille))
				{
					if (portion.TesterPortion(shaker, monbar.Bouteilles[numeroBouteille]))
					{
						monbar.Bouteilles[numeroBouteille].Verser(portion);
						shaker.AjouterPortion(portion);
						Console.WriteLine("->" + ingedient.Nom + "ajouté.");
					}
					else
					{
						Console.WriteLine("Attention !!!! \n Quantité non suffisante...");
						Console.WriteLine(monbar.Bouteille.Nom).Jeter(numeroBouteille);
						ok = false;
					}
				}
				else
				{
				
				}
            }
        }
		public string Servir(Coktail coktail , bool fabricationCkt, ref Shaker shaker)
		{
			string chaine = "";
			if (fabricationCkt)
			{
				chaine = "Voici votre " + coktail.Nom;

			}
			else
			{
				chaine = "Pas de creation";
			}
			shaker.Vider();
			return chaine;
		}
	}
}
