using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace gesplan_client
{
    partial class UserInfosConnect : DBConnect
    {
        public string idRang;

        // informations du personnel
        public int UserLevel(int userID)
        {
            string query = "SELECT * FROM personnels WHERE ID = " + userID;

            // création d'une liste pour stocker le résultat
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            
           
            // ouvre la connexion
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    idRang = dataReader["ID_rang"] + "" ;
                    list[0].Add(dataReader["ID_rang"] + "");
                    list[1].Add(dataReader["nom"] + "");
                    list[2].Add(dataReader["prenom"] + "");
                }

                // ferme le data reader
                dataReader.Close();

                // close Connection
                CloseConnection();

                int rang = Convert.ToInt32(idRang);

                // retourne la liste à afficher
                return rang;

            }
            else
            {
                // rang non trouvé, problème !
                return 0;
            }
            
        }
    }
}
