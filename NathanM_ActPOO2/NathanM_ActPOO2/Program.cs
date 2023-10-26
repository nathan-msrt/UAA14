// See https://aka.ms/new-console-template for more information

using System;
using System.Linq.Expressions;

namespace NathanM_ActPOO2
{
	class Program
	{
		static void Main(string[] args)
		{
            string rep = "";
            do
			{
                Console.WriteLine("Quel exercice voulez vous faire ?\n  1. - Cercle \n  2. - Complexe \n  3. - Sandwich \n  4. - Transaction");
                string exercice=Console.ReadLine();
                
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
                        Console.WriteLine(C1.AfficheComplexe() + C1.AfficheModule());

                        Console.WriteLine("Que vaut la partie réelle du second complexe ?");
                        double reel2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Que vaut la seconde partie imaginaire du second complexe ?");
                        double imaginaire2 = double.Parse(Console.ReadLine());
                        Complexe C2 = new Complexe(reel2, imaginaire2);
                        C1.Ajoute(C2);
                        Console.WriteLine(C2.AfficheComplexe());
                        Console.WriteLine("Le premier complexe devient :"+ C1.AfficheComplexe()+ "après ajout du second");
                   
                    break;

                    case "3":
                        string reponse = "";
                        Console.WriteLine("Bienvenue dans notre concepteur de sandwich!\nTaper sur enter pour générer un sandwich,n'importe quelle touche pour quitter !");
                        SandwichMaker sandwichMaker = new SandwichMaker();
                        reponse = Console.ReadLine();
                        while (reponse == "")
                        {
                            Console.Write(sandwichMaker.Compose());
                            reponse = Console.ReadLine();
                        }
                        break;

                    case "4":
                        string reponse2;
                        double argentTempo;
                        bool boucleArgent = true;

                        boucleArgent = true;
                        Console.WriteLine("Bienvenue dans notre gestionnaire de porte monnaie !");
                        Console.WriteLine("Première personne, quel est votre nom ? ");
                         string nom = Console.ReadLine();
                        Console.WriteLine("Tapez une somme d'argent en euros.");
                       double  argent = double.Parse(Console.ReadLine());
                        Personne personne1 = new Personne(nom, argent);
                        Console.WriteLine("Deuxième personne, quel est votre nom ? ");
                        string nom2 = Console.ReadLine();
                        Console.WriteLine("Tapez une somme d'argent en euros.");
                        double argent2 = double.Parse(Console.ReadLine());
                        Personne personne2 = new Personne(nom2, argent2);
                        Console.WriteLine();
                        Console.WriteLine(personne1.AfficherPersonne());
                        Console.WriteLine(personne2.AfficherPersonne());

                        while (boucleArgent)
                        {
                            Console.WriteLine("Quel est votre but ? \n1 = Ajoutez de l'argent \n2 = Transférez de l'argent \n3 = Arreter la simulation");
                            reponse = Console.ReadLine();
                            switch (reponse)
                            {
                                case "1":
                                    Console.WriteLine();
                                    Console.WriteLine("A qui voulez vous ajoutez de l'argent ?\n1 = " + personne1.Nom + "\n2 = " + personne2.Nom + "");
                                    reponse = Console.ReadLine();
                                    Console.WriteLine("Combien voulez vous ajoutez ?");
                                    argentTempo = double.Parse(Console.ReadLine());
                                    switch (reponse)
                                    {
                                        case "1":

                                            personne1.AjouterArgent(argentTempo);
                                            break;
                                        case "2":
                                            personne2.AjouterArgent(argentTempo);
                                            break;
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine(personne1.AfficherPersonne());
                                    Console.WriteLine(personne2.AfficherPersonne());
                                    break;


                                case "2":
                                    Console.WriteLine("A qui voulez vous transférez de l'argent ?\n1 = " + personne1.Nom + "\n2 = " + personne2.Nom +"");
                                    reponse = Console.ReadLine();
                                    Console.WriteLine("Combien voulez vous transférez ?\n");
                                    argentTempo = double.Parse(Console.ReadLine());
                                    if (personne1.TransfererArgent(argentTempo))
                                    {
                                        switch (reponse)
                                        {
                                            case "1":
                                                personne1.AjouterArgent(argentTempo);
                                                break;
                                            case "2":
                                                personne2.AjouterArgent(argentTempo);
                                                break;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine(personne1.AfficherPersonne());
                                        Console.WriteLine(personne2.AfficherPersonne());
                                    }
                                    else
                                    {
                                        Console.WriteLine(personne1.Nom + " n'a pas assez d'argent");
                                    }
                                    break;
                                case "3":
                                    boucleArgent = false;
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Cette option n'existe pas");
                        break;
                } 
                Console.WriteLine("Voulez-vous tester un autre exercice ? (Tapez sur enter)");
                rep = Console.ReadLine();

            } while (rep == "");



        }
	}
}
