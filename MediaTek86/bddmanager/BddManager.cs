using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace MediaTek86.bddmanager
{
    /// <summary>
    /// Singleton : connexion à la base de données et exécution des requêtes
    /// </summary>
    public class BddManager
    {
        private MySqlDataReader reader;
        private MySqlCommand command;


        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static BddManager instance = null;
        /// <summary>
        /// objet de connexion à la BDD à partir d'une chaîne de connexion
        /// </summary>
        private readonly MySqlConnection connection;

        /// <summary>
        /// Constructeur pour créer la connexion à la BDD et l'ouvrir
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        private BddManager(string stringConnect)
        {
            connection = new MySqlConnection(stringConnect);
            connection.Open();
        }

        /// <summary>
        /// Création d'une seule instance de la classe
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        /// <returns>instance unique de la classe</returns>
        public static BddManager GetInstance(string stringConnect)
        {
            if (instance == null)
            {
                instance = new BddManager(stringConnect);
            }
            return instance;
        }

        /// <summary>
        /// Exécution d'une requête de type LCT (begin transaction...)
        /// </summary>
        /// <param name="stringQuery">requête</param>
        public void ReqControle(string stringQuery)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Exécution d'une requête de type LMD (insert, update, delete)
        /// </summary>
        /// <param name="stringQuery">requête</param>
        /// <param name="parameters">dictionnire contenant les parametres</param>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (!(parameters is null))
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Execution d'une requête de type LID (select)
        /// </summary>
        /// <param name="stringQuery">requête</param>
        /// <param name="parameters">dictoinnaire contenant les parametres</param>
        /// <returns>liste de tableaux d'objets contenant les valeurs des colonnes</returns>
        public void ReqSelect(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// fonction booléenne Read
        /// </summary>
        /// <returns></returns>
        public bool Read()
        {
            if (reader is null)
            {
                return false;
            }
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Méthode Close
        /// </summary>
        public void Close()
        {
            if (!(reader is null))
            {
                reader.Close();
            }
        }
        /// <summary>
        /// Fonction Field
        /// </summary>
        /// <param name="nameField"></param>
        /// <returns></returns>
        public object Field(string nameField)
        {
            if (reader is null)
            {
                return null;
            }
            try
            {
                return reader[nameField];
            }
            catch
            {
                return null;
            }
        }



    }
}
