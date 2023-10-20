// See https://aka.ms/new-console-template for more information

using System;
using System.Linq.Expressions;

namespace NathanM_ActPOO2
{
	class Program
	{
		static void Main(string[] args)
		{
            
			do
			{
                Console.WriteLine("Quel exercice voulez vous faire ?\n  1. - Cercle \n  2. - Complexe \n  3. - Sandwich");
                string exercice=Console.ReadLine();
                string rep = "";
                switch (exercice)
                {
                    case "1":

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
                        Cercle1.Rayon = rayon / 2;
                        Console.WriteLine(Cercle1.AfficherCaractéristiques());

                        break;

                    case "2":
                    Console.WriteLine("Bienvenue dans ce programme sur le nombre complexe !");
                    Console.ReadLine();
                    Console.WriteLine("Que vaut la partie réelle du complexe de départ ?");
                    double reel = double.Parse(Console.ReadLine());
                    Console.WriteLine("Que vaut la partie imaginaire du complexe de départ ?");
                    double imaginaire = double.Parse(Console.ReadLine());
                    Complexe C1 = new Complexe(reel, imaginaire);
                    Console.WriteLine(C1.Module());
                    Console.WriteLine(C1.AfficheComplexe() + C1.AfficheModule());

                    Console.WriteLine("Que vaut la partie réelle du second complexe ?");
                    double reel2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Que vaut la seconde partie imaginaire du second complexe ?");
                    double imaginaire2 = double.Parse(Console.ReadLine());
                    Complexe C2 = new Complexe(reel, imaginaire);
                    Console.WriteLine(C2.AfficheComplexe());
                    C1.Ajoute(C2);
                    Console.WriteLine(C1.AfficheComplexe());
                    break;


                    default:
                        Console.WriteLine("Cet exercice n'existe pas");
                        break;
                } 
                Console.WriteLine("Voulez-vous tester un autre exercice ? (Tapez sur espace)");
                rep = Console.ReadLine();
            } while (rep =="");



        }
	}
}
