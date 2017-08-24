using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MySql.Data.MySqlClient;

namespace gesplan_client
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int numMag; // numéro du magasin par défaut

        // constructeur
        public DBConnect()
        {
            Initialize();
        }

        // initialisation des valeurs
        private void Initialize()
        {
            numMag = 1;
            server = "chiwawaweb.com";
            database = "gesplan";
            uid = "gesplan";
            password = "a77q3az9"; // à modifier
            string connectionString;
            connectionString = "SERVER=" + server 
                + ";" + "DATABASE=" + database 
                + ";" + "UID=" + uid + ";" 
                + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        // ouvre la connexion à la base
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Impossible de se connecter au serveur");
                        break;

                    case 1045:
                        MessageBox.Show("User/pass invalides");
                        break;
                }
                return false;
            }
        }

        // ferme la connexion
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // sélection : les personnels
        public List<string>[] Select()
        {
            string query = "SELECT * FROM personnels";

            // création d'une liste pour stocker le résultat
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            // ouvre la connexion
            if (this.OpenConnection() == true)
            {
                // crée la commande
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // crée un data reader et exécute la commande
                MySqlDataReader dataReader = cmd.ExecuteReader();

                // lit les données et les stocke dans la liste
                while(dataReader.Read())
                {
                    list[0].Add(dataReader["ID"] + "");
                    list[1].Add(dataReader["nom"] + "");
                    list[2].Add(dataReader["prenom"] + "");
                }

                // ferme le data reader
                dataReader.Close();

                // close Connection
                this.CloseConnection();

                // retourne la liste à afficher
                return list;
            }
            else
            {
                return list;
            }
        }

        // compte les personnels
        public int Count()
        {
            string query = "SELECT Count(*) FROM personnels";
            int Count = -1;

            // ouvre la connexion
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
