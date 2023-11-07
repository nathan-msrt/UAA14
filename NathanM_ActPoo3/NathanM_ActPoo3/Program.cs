using System.Numerics;

namespace NathanM_ActPoo3
{
	class Program
	{
        static void Main(string[] args)
        {
            string rep = "";

            Elephant zazou = new Elephant("Zazou", 82);
            Elephant titi = new Elephant("Titi", 100);
            Console.WriteLine("");
            Console.WriteLine("Bienvenue dans cet échange d'éléphants \n  1. - Pour Afficher les informations de Zazou \n  2. - Pour afficher les informations de Titi  \n  3. - Pour échanger les informations  \n  4. - Pour voir le transfert d'un message de Zazou à Titi  \n  5. - Pour réviser la notion de tableaux et l'appliquer à des objets");
            do
            {
                string exercice = Console.ReadLine();
                switch (exercice)
                {
                    case "1":
                        Console.WriteLine(zazou.AfficheQuiJeSuis());
                        break;

                    case "2":
                        Console.WriteLine(titi.AfficheQuiJeSuis());
                        break;

                    case "3":
                        Elephant tampon = zazou;
                        zazou = titi;
                        titi = tampon;

                        Console.WriteLine("Zazou: ");
                        Console.WriteLine(zazou.AfficheQuiJeSuis());
                        Console.WriteLine("Titi: ");
                        Console.WriteLine(titi.AfficheQuiJeSuis());
                        break;

                    case "4":
                        Console.WriteLine("Quel est votre message ?");
                        string message = Console.ReadLine();
                        zazou.EnvoieMessage(message, titi);
                        
                        break;

                    case "5":
                        Elephant[] elephants = new Elephant[7];
                        elephants[0] = zazou;
                        elephants[1] = titi;
                        elephants[2] = new Elephant("Adam", 147);
                        elephants[3] = new Elephant("Alexandre", 10);
                        elephants[4] = new Elephant("Sefedin", 58);
                        elephants[5] = new Elephant("Jayson", 96);
                        elephants[6] = new Elephant("Aymeric", 69);

                        // Déterminer l'éléphants avec les + grandes oreilles
                        Elephant? max = null;
                        for (int i = 0; i < elephants.Length; i++)
                        {
                            Elephant elephant = elephants[i];
                            if (max == null || elephant.TaillleOreilles > max.TaillleOreilles)
                            {
                                max = elephant;
                            }
                        }

                        // Vérifier que l'éléphant n'est pas null
                        if (max != null)
                        {
                            Console.WriteLine("L'éléphant qui a les plus grandes oreilles est " + max.Nom + " avec oreilles de " + max.TaillleOreilles + "cm.");
                        }
                        break;

                    default:
                        Console.WriteLine("Cet échange n'existe pas");
                        break;
                }
                Console.WriteLine("Voulez-vous recommencer ? (Tapez sur espace)");
                rep = Console.ReadLine();
            } while (rep == "");
        }
    }
}
