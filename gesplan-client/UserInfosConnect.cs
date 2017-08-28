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
        // informations du personnel
        public int UserLevel(int userID)
        {
            string query = "SELECT * FROM personnels WHERE ID = userID";

            // ouvre la connexion
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

            }
                return 0;
        }
    }
}
