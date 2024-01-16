// See https://aka.ms/new-console-template for more information
using POO_Heritage;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Classes animaux : ");
        Animaux[] mesanimaux = new Animaux[5];

        mesanimaux[0] = new Chat("logobi", DateTime.Parse("20/09/2007"), 1, 179, true);
        mesanimaux[1] = new Chat("bebou", DateTime.Parse("21/08/2007"), 2, 179, false);
        mesanimaux[2] = new Lapin("zbeub", DateTime.Parse("25/09/2007"), 3, 179, true);
        mesanimaux[3] = new Chien("ledaron", DateTime.Parse("05/02/2007"), 4, 179, false);
        mesanimaux[4] = new Chien("lepours", DateTime.Parse("31/07/2007"), 5, 179, true);

        //création animaux avec caracteristiques


        for (int i = 0; i < mesanimaux.Length; i++)
        {
            Console.WriteLine(mesanimaux[i].Affiche());
            Console.WriteLine(mesanimaux[i].Nom + "mange : " + mesanimaux[i].Manger());

            if (mesanimaux[i] is Chat chat)
            {
                Console.WriteLine(chat.Miaule());

            }
            else if (mesanimaux[i] is Chien chien)
            {
                Console.WriteLine(chien.Aboye());
            }
            else if (mesanimaux[i] is Lapin lapin)
            {
                Console.WriteLine(lapin.FaitdesBonds());
            }
        }
        // faire les actions 
    }
}
