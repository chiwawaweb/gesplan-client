using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace visucal_client
{
    partial class UserConnect : DBConnect
    {
        // connexion d'un personnel
        public int Connect(string uid, string password)
        {
            // transforme le password en MD5
            byte[] asciiBytes = Encoding.ASCII.GetBytes(password);
            byte[] hashedBytes = MD5.Create().ComputeHash(asciiBytes);
            string md5Password = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

            string query = "SELECT * FROM personnels WHERE login LIKE '" + uid 
                + "' AND password LIKE '" + md5Password + "' AND actif LIKE 'Y'";
            int userID = -1;
            
            // ouvre la connexion
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    userID = Convert.ToInt32(dataReader["ID"] + "");
                }
                dataReader.Close();
                CloseConnection();
            }
            return userID;
        }

        // rang de l'utilisateur
        public int UserLevel(int userID)
        {
            string query = "SELECT * FROM personnels WHERE actif LIKE 'Y' AND ID = " + userID;

            // ouvre la connexion
            if (OpenConnection() == true)
            {
                int idRang = -1;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read()) // a transformer
                {
                    idRang = Convert.ToInt32(dataReader["ID_rang"] + "");
                }

                dataReader.Close();
                CloseConnection();

                // retourne l'idRang de l'utilisateur
                return idRang;
            }
            else
            {
                // rang non trouvé, problème !
                return -2;
            }
        }

        // nom et prenom de l'utilisateur
        public string UserName(int userID)
        {
            string query = "SELECT * FROM personnels WHERE actif LIKE 'Y' AND ID = " + userID;
            string userName = "";

            // ouvre la connexion
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    userName = dataReader["prenom"] + " " + dataReader["nom"] + "";
                }

                dataReader.Close();
                CloseConnection();

                // retourne le nom et prenom de l'utilisateur de l'utilisateur
                return userName;
            }
            else
            {
                // non trouvé, à gérer !!
                return "###";
            }

        }
         
        // droits de l'utilisateur
        public List<string>[] UserDroits(int userID)
        {
            string query = "SELECT * FROM personnels_droits WHERE ID_personnel = " + userID;

            List<string>[] droits = new List<string>[1];
            droits[0] = new List<string>();

            // ouvre la connexion
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    droits[0].Add(dataReader["ID_droit"] + "");
                }

                // ferme le data reader
                dataReader.Close();

                // close Connection
                CloseConnection();

                // retourne les droits de l'utilisateur
                return droits;
            }
            else
            {
                return droits;
            }
        }

        // site par défaut de l'utilisateur
        public int UserSite(int userID)
        {
            string query = "SELECT * FROM personnels WHERE actif LIKE 'Y' AND ID = " + userID;

            int site = 0;

            // ouvre la connexion
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    site = int.Parse(dataReader["ID_agence"] + "");
                }

                // ferme le data reader
                dataReader.Close();

                // close Connection
                CloseConnection();

                // retourne les droits de l'utilisateur
                return site;
            }
            else
            {
                return site;
            }
        }

    }
}
