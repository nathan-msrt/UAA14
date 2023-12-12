// See https://aka.ms/new-console-template for more information
using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace CeUAA14Partie2_dec23_Massart
{
	class Program
	{
		static void Main(string[] args)
		{
            string rep = "";
            Console.WriteLine("Bienvenue dans ce jeu de tir... Vous démarrez avec 30 balles");
			Console.WriteLine("============================================================");
			Console.WriteLine("Vous avez un total de 30 balles dans votre poche et 0 balle dans votre chargeur ! Attention le chargeur est vide donc!");

			PaintBallGun paintBallGun = new PaintBallGun(0,0,30);
			Console.WriteLine("");

			do
			{
				Console.WriteLine(" - Espace pour tirer,\n -R pour recharger, \n - + pour reprendre des munitions, \n - Q pour quitter, \n - A pour afficher les statistiques de l'arme.");
				string option = Console.ReadLine();
				switch (option)
				{
					case "":
						Console.WriteLine(paintBallGun.Tirer());
						break;

					case "R" :
						Console.WriteLine(paintBallGun.Recharger());
						break;

					case "+" :
						paintBallGun.Restock();
						break;
					case "A":
						Console.WriteLine(paintBallGun.AfficherArme()); 
						break;
					case "Q":
						rep = "null";
						break;
                    default:
                        Console.WriteLine("Cet option n'existe pas");
                        break;
                }

            } while (rep == "kk");

			





        }
	}
}