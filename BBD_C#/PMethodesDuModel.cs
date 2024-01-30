using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;


namespace BBD_C_
{
    internal class PMethodesDuModel
    {
        static string DefinirCheminBD() // détermine la chaîne de connexion
        {
            return "server=localhost;database=immo;port=3306;User Id=root;password=root";
        }
        public bool ChercheUtilisateurs(out DataSet infos)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnection.Open();

                query = "SELECT * FROM utlisateurs;";

                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnection);
                infos = new DataSet();
                da.Fill(infos, "mesDonnees");
                if (infos.Tables[0].Rows.Count >= 1)
                {
                    ok = true;
                }
                maConnection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return ok;
        }
        public bool AjouteUser(string[] donnees)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnection.Open();
                query= "INSERT INTO utilisateurs (nomUser, prenomUser, loginUser, passWordUser,  role) values ( :nomUser, :prenomUser, :loginUser, :passWordUser, :role)";
                MySqlCommand insertCommand = new MySqlCommand(query, maConnection);

                insertCommand.Parameters.AddWithValue("@nomUser", donnees[0]);
                insertCommand.Parameters.AddWithValue("@prenomUser", donnees[1]);
                insertCommand.Parameters.AddWithValue("@loginUser", donnees[2]);
                insertCommand.Parameters.AddWithValue("@passWordUser", donnees[3]);
                insertCommand.Parameters.AddWithValue("@role", donnees[4]);
                if (insertCommand.ExecuteNonQuery() > 0)
                {
                    ok = true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
            return ok;
        }
        public string AfficheDataUsers(DataSet donnees)
        {
            string infos = "";
            for (int i = 0; i < donnees.Tables[0].Rows.Count; i++)
            {
                infos += donnees.Tables[0].Rows[i]["nomUser"].ToString() + " | "+
                         donnees.Tables[0].Rows[i]["prenomUser"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["loginUser"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["passWordUser"].ToString() + " | " +"\n";
            }
            return infos;
        }
    }
}
