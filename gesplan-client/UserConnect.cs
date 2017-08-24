using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace gesplan_client
{
    partial class UserConnect : DBConnect
    {
        // connexion d'un personnel
        public bool Connect(string uid, string password)
        {
            // transforme le password en MD5
            byte[] asciiBytes = Encoding.ASCII.GetBytes(password);
            byte[] hashedBytes = MD5.Create().ComputeHash(asciiBytes);
            string md5Password = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

            string query = "SELECT Count(*) FROM personnels WHERE login LIKE '" + uid 
                + "' AND password LIKE '" + md5Password + "'";
            int Count = -1;
            
            // ouvre la connexion
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                CloseConnection();
                if (Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
