using System.Collections.Generic;

namespace GESTION_BAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //supposition : un verre contient 14cl => on fait un peu plus : 20cl par cocktail
            string choixUser;   // récupération info user
            #region instanciations
            // instanciations des éléments du Bar, et des Recettes

            // Création des Liquides disponibles (via ChatGpt)
            List<Liquide> liquidesBar = new List<Liquide>();

            liquidesBar.Add(new Liquide("Water", "Pure"));
            liquidesBar.Add(new Liquide("Milk", "Dairy"));
            liquidesBar.Add(new Liquide("Orange Juice", "Fruit"));
            liquidesBar.Add(new Liquide("Cola", "Soda"));
            liquidesBar.Add(new Liquide("Coffee", "Hot"));
            liquidesBar.Add(new Liquide("Tea", "Hot"));
            liquidesBar.Add(new Liquide("Lemonade", "Fruit"));
            liquidesBar.Add(new Liquide("Wine", "Alcoholic"));
            liquidesBar.Add(new Liquide("Beer", "Alcoholic"));
            liquidesBar.Add(new Liquide("Vodka", "Alcoholic"));
            liquidesBar.Add(new Liquide("Whiskey", "Alcoholic"));
            liquidesBar.Add(new Liquide("Rum", "Alcoholic"));
            liquidesBar.Add(new Liquide("Olive Oil", "Cooking"));
            liquidesBar.Add(new Liquide("Vinegar", "Cooking"));

            // test Vérification des instanciations des liquides : affichage des liquides disponibles
            Console.WriteLine("Liste des liquides");
            foreach (Liquide liquide in liquidesBar)
            {
                Console.WriteLine($"Nom: {liquide.Nom}, Type: {liquide.Type}");
            }

            // Création des Bouteilles du bar
            List<Bouteille> bouteillesBar = new List<Bouteille>();

            // On crée une bouteille par liquide disponible
            foreach (Liquide liquide in liquidesBar)
            {
                // Assuming each bottle has a capacity of 75cl tout est exprimé en litres
                Bouteille bouteille = new Bouteille(liquide, 0.75);
                bouteillesBar.Add(bouteille);
            }

            //Création du bar : on place les bouteilles dans le bar

            Bar barAsty = new Bar(bouteillesBar);

            // test Vérification des instanciations : affichage des Bouteilles disponibles

            Console.WriteLine("Liste des bouteilles");
            foreach (Bouteille bouteille in bouteillesBar)
            {
                Console.WriteLine($"Contenu: {bouteille.Contenu.Nom}, Contenance: {bouteille.Contenance} litre(s)");
            }


            // création de 5 recettes (via ChatGpt)
            List<Cocktail> cocktails = new List<Cocktail>();

            // Cocktail 1: Screwdriver
            // liste de portions
            List<Portion> screwdriverPortions = new List<Portion>
            {
            new Portion(liquidesBar[2], 0.5),  // Orange Juice
            new Portion(liquidesBar[9], 0.5)   // Vodka
            };
            // attribution de la liste à une recette
            Recette screwdriverIngredients = new Recette(screwdriverPortions);
            // ajout de la recette à un cocktail
            cocktails.Add(new Cocktail("Screwdriver",screwdriverIngredients));

            // Cocktail 2: Rum and Coke
            List<Portion> rumAndCokePortions = new List<Portion>
            {
            new Portion(liquidesBar[11], 0.5),  // Rum
            new Portion(liquidesBar[3], 0.5)    // Cola
            };
            Recette rumAndCokeIngredients = new Recette(rumAndCokePortions);
            cocktails.Add(new Cocktail("rumAndCoke",rumAndCokeIngredients));

            // Cocktail 3: White Russian
            List<Portion> whiteRussianPortions = new List<Portion>
            {
            new Portion(liquidesBar[9], 0.5),   // Vodka
            new Portion(liquidesBar[1], 0.25),  // Milk
            new Portion(liquidesBar[12], 0.25)  // Coffee
            };
            Recette whiteRussianIngredients = new Recette(whiteRussianPortions);
            cocktails.Add(new Cocktail("whiteRussian",whiteRussianIngredients));

            // Cocktail 4: Whiskey Sour
            List<Portion> whiskeySourPortions = new List<Portion>
            {
            new Portion(liquidesBar[10], 0.5),  // Whiskey
            new Portion(liquidesBar[6], 0.25),  // Lemonade
            new Portion(liquidesBar[0], 0.25)   // Water
            };
            Recette whiskeySourIngredients = new Recette(whiskeySourPortions);
            cocktails.Add(new Cocktail("whiskeySourPortions",whiskeySourIngredients));

            // Cocktail 5: Beer Margarita
            List<Portion> beerMargaritaPortions = new List<Portion>
            {
            new Portion(liquidesBar[8], 0.25),  // Beer
            new Portion(liquidesBar[7], 0.25),  // Wine
            new Portion(liquidesBar[12], 0.25), // Coffee
            new Portion(liquidesBar[5], 0.25)   // Tea
            };
            Recette beerMargaritaIngredients = new Recette(beerMargaritaPortions);
            cocktails.Add(new Cocktail("beerMargarita",beerMargaritaIngredients));

            // test Vérification des instanciations : affichage des Cocktails disponibles
            //----------------------------------------------------------------------------

            foreach (Cocktail cocktail in cocktails)
            {
                Console.WriteLine(cocktail.AfficherRecette());
            }

            //création du shaker
            //-------------------------

            Shaker monShaker = new Shaker(0.5d);

            //Création du Barman
            //-------------------------

            Barman john = new Barman("John");

            #endregion

            #region fonctionnement du bar
            // Fonctionnement du bar :
            //-------------------------

            Console.WriteLine("\nBienvenue au Bar Asty-Moulin !");
            Console.WriteLine("==============================");
            do
            {
                // Préparer le menu
                string menu = "";
                int i = 1;
                foreach (Cocktail cocktail in cocktails)
                {
                    menu += i + ". Cocktail " + cocktail.Nom + "\n";
                    i++;
                }

                //Prendre la commande
                int numCocktail = john.Commander(menu, cocktails.Count) - 1;

                //Voir la recette du cocktail choisi
                Console.WriteLine(cocktails[numCocktail].AfficherRecette());

                //créer le cocktail
                bool fabriqueOk = john.Fabriquer(cocktails[numCocktail], ref monShaker, barAsty);
                if (fabriqueOk)
                {
                    monShaker.MelangerContenu();
                }
                //servir
                Console.WriteLine(john.Servir(cocktails[numCocktail], fabriqueOk, ref monShaker));

                //nouvelle commande ?
                Console.WriteLine("\nUn autre cocktail ? (oui = espace, non  autre)");
                choixUser = Console.ReadLine();
            } while (choixUser == " ");
            #endregion
        }
    }
}