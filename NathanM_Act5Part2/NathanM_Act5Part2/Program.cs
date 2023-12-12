// See https://aka.ms/new-console-template for more information
using System;
using System.Linq.Expressions;
namespace NathanM_Act5Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random alea = new Random();
            Console.WriteLine("Bienvenue dans ce petit programme de calcul mental.");
            Calcul q = new  Calcul((int)alea.Next(2) == 1);
            while (true)
            {
                Console.Write($"{q.N1}{q.Op}{q.N2} = ");
                string rep = Console.ReadLine();
                int repEntiere;
                // mauvaise entrée utilisateur
                if (!int.TryParse(rep, out repEntiere))
                {
                    Console.WriteLine("Merci d'avoir joué");
                    return;
                }
                // vérification de la réponse
                else if (q.VerifOpe(repEntiere))
                {
                    Console.WriteLine("Correct !");
                    q = new Calcul((int)alea.Next(2) == 1);
                }
                // mauvaise réponse au calcul
                else
                {
                    Console.WriteLine("Erreur, recommencez !");
                }
            }
        }

    }
}