// See https://aka.ms/new-console-template for more information

using System;
using System.Linq.Expressions;

namespace NathanM_ActPOO2
{
	class Program
	{
		static void Main(string[] args)
		{
            switch (methode)
            {
                case 1:
                    // code block
                    break;
                case 2:
                    // code block
                    break;
                default:
                    Console.WriteLine("Cette numéro de methode n'existe pas");
                    break;
            }
            string rep = "";
            do
            {
                Console.WriteLine("Bienvenue dans ce programme sur le cercle !");
                Console.ReadLine();
                Console.WriteLine("Quel est le rayon de votre cercle ?");
                double rayon = double.Parse(Console.ReadLine());
                Cercle Cercle1 = new Cercle(rayon);
                Console.WriteLine(Cercle1.CalculerPerimetre());
                Console.WriteLine(Cercle1.CalculerAire());
                Console.WriteLine(Cercle1.AfficherCaractéristiques());


                Console.WriteLine("Avec un cercle de rayon diminué de moitié :");
                Console.WriteLine("-------------------------------------------");
                Cercle1.Rayon=rayon/2;
                Console.WriteLine(Cercle1.AfficherCaractéristiques());
                Console.WriteLine("Voulez-vous tester un autre cercle ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
	}
}
