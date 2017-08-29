using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;

namespace gesplan_client
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
                
                return userID;
            }
            else
            {
                return -1;
            }
        }

        // rang de l'utilisateur
        public int UserLevel(int userID)
        {
            string query = "SELECT * FROM personnels WHERE ID = " + userID;

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
    }
}
