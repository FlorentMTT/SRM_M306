using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;   //Ajouter la dll pour pouvoir l'utiliser
using System.Windows.Forms;

namespace GestionUserSRM
{
    class SQLfunction
    {

        private MySql.Data.MySqlClient.MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public SQLfunction()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "m306_srm_db";
            uid = "root";    //Renseigner
            password = "";    //Renseigner
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/ or password.
                MySqlException msEx = ex as MySqlException;
                if (ex.GetType() == msEx.GetType())
                {
                    switch (msEx.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server. Contact administrator");
                            break;

                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                }

                return false;
            }
        }

        //Close connection
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

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM users";

            //Create a list to store the result
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["email"] + "");
                    list[2].Add(dataReader["password"] + "");
                    list[3].Add(dataReader["name"] + "");
                    list[4].Add(dataReader["profilPictureURL"] + "");
                    list[5].Add(dataReader["active"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SelectMessage()
        {
            string query = "SELECT * FROM messages";

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();



            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["content"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SelectReportedMessages()
        {
            string query = "SELECT `r`.`id` AS 'reportID', `r`.`description` AS 'reportDescription', `m`.`id` AS 'messageID', `m`.`content` AS 'messageContent', `su`.`id` AS 'senderID', `su`.`name` AS 'senderName', (CASE WHEN `m`.`receiveruserid` IS NOT NULL THEN concat('user', `ru`.`id`) ELSE concat('group ', `rg`.`id`) END) AS 'receiverID', (CASE WHEN `m`.`receiveruserid` IS NOT NULL THEN concat('user', `ru`.`name`) ELSE concat('group ', `rg`.`name`) END) AS 'receiverName' FROM `reports` AS r LEFT JOIN `messages` AS m ON `r`.`targetedMessageID` = `m`.`id` LEFT JOIN `users` AS su ON `m`.`senderUserID` = `su`.`id` LEFT JOIN `users` AS ru ON `m`.`receiverUserID` = `ru`.`id` LEFT JOIN `groups` AS rg ON `m`.`receiverGroupID` = `rg`.`id`";

            //Create a list to store the result
            List<string>[] list = new List<string>[8];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["reportID"] + "");
                    list[1].Add(dataReader["reportDescription"] + "");
                    list[2].Add(dataReader["messageID"] + "");
                    list[3].Add(dataReader["messageContent"] + "");
                    list[4].Add(dataReader["senderID"] + "");
                    list[5].Add(dataReader["senderName"] + "");
                    list[6].Add(dataReader["receiverID"] + "");
                    list[7].Add(dataReader["receiverName"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //public void UpdateRole(string name, int role)
        //{

        //    string query = "UPDATE users SET idRole='" + role + "' WHERE name='" + name + "'";

        //    //Open connection
        //    if (this.OpenConnection() == true)
        //    {
        //        //create mysql command
        //        MySqlCommand cmd = new MySqlCommand();
        //        //Assign the query using CommandText
        //        cmd.CommandText = query;
        //        //Assign the connection using Connection
        //        cmd.Connection = connection;

        //        //Execute query
        //        cmd.ExecuteNonQuery();

        //        //close connection
        //        this.CloseConnection();
        //    }

        //}

        //public void UpdateMessage(string message, int idMessage)
        //{

        //    string query = "UPDATE message SET message='" + message + "' WHERE idMessage='" + idMessage + "'";

        //    //Open connection
        //    if (this.OpenConnection() == true)
        //    {
        //        //create mysql command
        //        MySqlCommand cmd = new MySqlCommand();
        //        //Assign the query using CommandText
        //        cmd.CommandText = query;
        //        //Assign the connection using Connection
        //        cmd.Connection = connection;

        //        //Execute query
        //        cmd.ExecuteNonQuery();

        //        //close connection
        //        this.CloseConnection();
        //    }

        //}
        public void UpdateMessageBan(int active, int id)
        {

            string query = "UPDATE messages SET active='" + active + "' WHERE id='" + id + "'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }

        }

        public void UpdateUserBan(int active, int id)
        {

            string query = "UPDATE users SET active='" + active + "' WHERE id='" + id + "'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }

        }
        public void UpdateGroupBan(int active, int id)
        {

            string query = "UPDATE groups SET active='" + active + "' WHERE id='" + id + "'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }

        }

        public void Insert(string email, int password)
        {
            string query = "INSERT INTO users(email, password) VALUES('" + email + "', '" + password + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void Delete(string email)
        {
            string query = "DELETE FROM users WHERE email='" + email + "'";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public User lireUtilisateur(string aLire)
        {
            string query = "SELECT id, email, password, active FROM users where email = @email";
            User user = null;

            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@email", aLire);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                // 
                while (dataReader.Read())
                {
                    // initialisation des propriétés de la classe avec les données de la db
                    user = new User { email = dataReader.GetString("email"), id = dataReader.GetInt32("id"), password = dataReader.GetString("password"), active = dataReader.GetBoolean("active") };
                }

                //close connection
                this.CloseConnection();

                return user;
            }

            return user;
        }

        public Messages lireMessage(string aLire)
        {
            string query = "SELECT id, date, content, senderUserID, receiverUserID, receiverGroupID, receiverChannelID, active FROM users where content = @content";
            Messages messages = null;

            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@content", aLire);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                // 
                while (dataReader.Read())
                {
                    // initialisation des propriétés de la classe avec les données de la db
                    messages = new Messages { id = dataReader.GetInt32("id"), date = dataReader.GetString("id"), content = dataReader.GetString("content"), senderUserID = dataReader.GetInt32("senderUserID"), receiverUserID = dataReader.GetInt32("receiverUserID"), receiverGroupID = dataReader.GetInt32("receiverGroupID"), receiverChannelID = dataReader.GetInt32("receiverChannelID"), active = dataReader.GetBoolean("active") };
                }

                //close connection
                this.CloseConnection();

                return messages;
            }

            return messages;
        }

        public List<Report> lireReports()
        {

            List<Report> reportsList = new List<Report>();
            string query = "SELECT `r`.`id` AS 'reportID', `r`.`description` AS 'reportDescription', `m`.`id` AS 'messageID', `m`.`content` AS 'messageContent', `su`.`id` AS 'senderID', `su`.`name` AS 'senderName', (CASE WHEN `m`.`receiveruserid` IS NOT NULL THEN `ru`.`id` ELSE `rg`.`id` END) AS 'receiverID', (CASE WHEN `m`.`receiveruserid` IS NOT NULL THEN concat('user', `ru`.`name`) ELSE concat('group ', `rg`.`name`) END) AS 'receiverName' FROM `reports` AS r LEFT JOIN `messages` AS m ON `r`.`targetedMessageID` = `m`.`id` LEFT JOIN `users` AS su ON `m`.`senderUserID` = `su`.`id` LEFT JOIN `users` AS ru ON `m`.`receiverUserID` = `ru`.`id` LEFT JOIN `groups` AS rg ON `m`.`receiverGroupID` = `rg`.`id`";

            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                // 
                while (dataReader.Read())
                {
                    // initialisation des propriétés de la classe avec les données de la db
                    
                        Report rep = new Report(dataReader.GetInt32("reportID"), dataReader.GetString("reportDescription"), dataReader.GetInt32("messageID"), dataReader.GetString("messageContent"), dataReader.GetInt32("senderID"), dataReader.GetString("senderName"), dataReader.GetInt32("receiverID"), dataReader.GetString("receiverName"));
                    reportsList.Add(rep);
                }

                //close connection
                this.CloseConnection();
            }

            return reportsList;
        }

    }
}

