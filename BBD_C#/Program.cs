using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Diagnostics;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace BBD_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] donnees = new string[5];
            DataSet immoUsers;
            PMethodesDuModel MonModele = new PMethodesDuModel();
            Console.WriteLine("Listes des Utilisateurs");
            Console.WriteLine("-----------------------");
            if (MonModele.ChercheUtilisateurs(out immoUsers))
            {
                string listeUser = MonModele.AfficheDataUsers(immoUsers);
                Console.WriteLine(listeUser);
            }
            else
            {
                Console.WriteLine("Pb lors de la lecture des données");
            }
            Console.WriteLine("Ajout d'un utilisateur :");
            Console.WriteLine("------------------------");
            Console.WriteLine("Nom ?");
            donnees[0]= Console.ReadLine


            
           
            

        }
    }
}