// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
namespace Chien
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MesChiens = new int[3];


            for (int i = 0; i < int[]MesChiens - 1; i++)
            {
                Console.WriteLine("Première méthodes");
                Console.WriteLine("Quelle est le nom de votre chien ?");
                string nom = Console.ReadLine();
                Console.WriteLine("Quelle est la race de " + nom + "?");
                string race = Console.ReadLine();
                Console.WriteLine("Quelle est l'âge de " + nom + "?");
                uint age = uint.Parse(Console.ReadLine());
                Console.WriteLine(nom + " est-il en ordre de vaccin ? (O/N)");
                bool enOrdreDeVaccin = bool.Parse(Console.ReadLine());
                if (true)
                {
                    enOrdreDeVaccin = true;
                }
                else
                {
                    enOrdreDeVaccin = false;
                }
                Console.WriteLine(nom + " est-il munit d'une puce ? (O/N)");
                bool puce = bool.Parse(Console.ReadLine());
                if (true)
                {
                    puce = true;
                }
                else
                {
                    puce = false;
                }
                Console.WriteLine(nom + " est-il stérélisé ? (O/N)");
                bool sterelise = bool.Parse(Console.ReadLine());
                if (true)
                {
                    sterelise = true;
                }
                else
                {
                    sterelise = false;
                }
                Console.WriteLine(nom + " est de quel genre ?");
                string genre = Console.ReadLine();
                Console.WriteLine(nom + " est-il aveugle ? (O/N)");
                bool aveugle;
                if (true)
                {
                    aveugle = true;
                }
                else
                {
                    aveugle = false;
                }
                Console.WriteLine(nom + " est-il sourd ? (O/N)");
                bool sourd = bool.Parse(Console.ReadLine());
                if (true)
                {
                    sourd = true;
                }
                else
                {
                    sourd = false;
                }
                Console.WriteLine(nom + " est-il dresser ? (O/N)");
                bool dresser = bool.Parse(Console.ReadLine());
                if (true)
                {
                    dresser = true;
                }
                else
                {
                    dresser = false;
                }

                UnChien chien1 = new UnChien(, race, age, enOrdreDeVaccin, puce, sterelise, genre, aveugle, sourd, dresser);
            }
            UnChien chien2 = new UnChien("Médor", "Berger Allemand", 4, false, true, true, "Masculin", false, false, false);
            UnChien chien3 = new UnChien("Cerbère", "Buldog", 3, true, false, true, "Masculin", false, false, false);

            Console.WriteLine(chien1.AfficherCaractéristiques());
            Console.WriteLine(chien2.AfficherCaractéristiques());
            Console.WriteLine(chien3.AfficherCaractéristiques());

            Console.WriteLine(chien1.Age);
            chien1.Age += 1;
            Console.WriteLine(chien2.Age);  
            chien2.Age += 1;
            Console.WriteLine(chien3.Age);
            chien3.Age += 1;

        }
    }


}