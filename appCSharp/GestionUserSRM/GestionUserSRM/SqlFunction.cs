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
            database = "articles";
            uid = "root";	//Renseigner
            password = "";	//Renseigner
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
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
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
            string query = "SELECT * FROM user";

            //Create a list to store the result
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();


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
                    list[0].Add(dataReader["idUser"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[3].Add(dataReader["password"] + "");
                    list[3].Add(dataReader["idRole"] + "");
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
            string query = "SELECT * FROM message";

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
                    list[0].Add(dataReader["idMessage"] + "");
                    list[1].Add(dataReader["message"] + "");
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


        public void UpdateRole(string name, int role)
        {

            string query = "UPDATE user SET idRole='" + role + "' WHERE name='" + name + "'";

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

        public void UpdateMessage(string message, int idMessage)
        {

            string query = "UPDATE message SET message='" + message + "' WHERE idMessage='" + idMessage + "'";

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

        public void UpdateUserBanne(int banned, int idUser)
        {

            string query = "UPDATE user SET banned='" + banned + "' WHERE idUser='" + idUser + "'";

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

        public void Insert(string name, int password)
        {
            string query = "INSERT INTO user(name, password) VALUES('" + name + "', '" + password + "')";

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

        public void Delete(string name)
        {
            string query = "DELETE FROM user WHERE name='" + name + "'";

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
            string query = "SELECT idUser, name, password, banned, idrole FROM user where name = @name";
            User user = null;

            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", aLire);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                // 
                while (dataReader.Read())
                {
                    // initialisation des propriétés de la classe avec les données de la db
                    user = new User { name = dataReader.GetString("name"), idUser = dataReader.GetInt32("idUser"), password = dataReader.GetString("password"), banned = dataReader.GetBoolean("banned"), idRole = dataReader.GetInt32("idrole") };
                }

                //close connection
                this.CloseConnection();

                return user;
            }

            return user;
        }

    }
}

