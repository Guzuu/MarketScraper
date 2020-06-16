using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace MarketScraper
{
    public class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        /// <summary>
        /// Contains all of the database credentials.
        /// </summary>
        //Initialize values
        private void Initialize()
        {
            server = "sql7.freemysqlhosting.net";
            database = "sql7348005";
            uid = "sql7348005";
            password = "kRrxlQM87f";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Opens a connection with database 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Closes connection with database
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Inserts order details and client details into the database
        /// </summary>
        /// <param name="klient"></param>
        /// <param name="cenatotal"></param>
        /// <param name="produkty"></param>
        /// <param name="sklep"></param>
        //Insert statement
        public void Insert(Client klient, float cenatotal, Dictionary<PromoScraper.Product, int> produkty, string sklep)
        {
            string query;

            //open connection
            if (this.OpenConnection() == true)
            {
                MySqlParameter parameter = new MySqlParameter("@fileSize", System.Data.SqlDbType.Decimal);
                parameter.Scale = 2;
                parameter.Value = 5;

                query = $"INSERT INTO `Klient` (`id`, `imie`, `nazwisko`, `miasto`, `ulica`, `kod_pocztowy`, `tel`) VALUES (NULL, '{klient.imie}', '{klient.nazwisko}', '{klient.miasto}', '{klient.ulica}', '{klient.KP}', '{klient.tel}');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add(parameter);
                cmd.ExecuteNonQuery();

                query = $"INSERT INTO `Zamowienia` (`id`, `data`, `klientid`, `cena`, `sklep`) VALUES (NULL, '{DateTime.Now.Date.ToString("yyyy-MM-dd")}', '{cmd.LastInsertedId}', '{cenatotal}', '{sklep}');";
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add(parameter);
                cmd.ExecuteNonQuery();

                long zamid = cmd.LastInsertedId;

                foreach(KeyValuePair<PromoScraper.Product, int> produkt in produkty)
                {
                    query = $"INSERT INTO `Produkty` (`zamowienieid`, `zdjecie`, `nazwa`, `cena`, `waga`, `ilosc`) VALUES('{zamid}', '{produkt.Key.imageUrl}', '{produkt.Key.name}', '{produkt.Key.price}', '{produkt.Key.weight}', '{produkt.Value}');";
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.Add(parameter);
                    cmd.ExecuteNonQuery();
                }

                //close connection
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Removes order and its products from database
        /// </summary>
        /// <param name="id"></param>
        //Delete statement
        public void Delete(int id)
        {
            string query = $"DELETE FROM `Zamowienia` WHERE `id`='{id}';";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Selects all active orders from database
        /// </summary>
        /// <returns></returns>
        //Select statements
        public List<Zamowienie> SelectOrders()
        {
            string query = "SELECT * FROM `Zamowienia`";
            List<Zamowienie> zamowienia = new List<Zamowienie>();
            
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
                    zamowienia.Add(new Zamowienie(int.Parse(dataReader["id"] + ""), DateTime.Parse(dataReader["data"] + "").ToShortDateString(), int.Parse(dataReader["klientid"] + ""), dataReader.GetFloat("cena"), dataReader["sklep"] + ""));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return zamowienia;
            }
            else
            {
                return zamowienia;
            }
        }

        /// <summary>
        /// Selects order products of specified order
        /// </summary>
        /// <param name="zamid"></param>
        /// <returns></returns>
        public Dictionary<PromoScraper.Product, int> SelectOrderDetails(int zamid)
        {
            string query = $"SELECT * FROM `Produkty` WHERE `zamowienieid`='{zamid}'";
            Dictionary<PromoScraper.Product, int> produkty = new Dictionary<PromoScraper.Product, int>();

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
                    produkty.Add(new PromoScraper.Product(dataReader["zdjecie"] + "", dataReader["nazwa"] + "", dataReader.GetFloat("cena"), dataReader["waga"] + ""), int.Parse(dataReader["ilosc"] + ""));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return produkty;
            }
            else
            {
                return produkty;
            }
        }

        /// <summary>
        /// Order template
        /// </summary>
        public struct Zamowienie
        {
            public Zamowienie(int id, string data, int klientid, float cena, string sklep)
            {
                this.id = id;
                this.data = data;
                this.klientid = klientid;
                this.cena = cena;
                this.sklep = sklep;
            }
            public int id;
            public string data;
            public int klientid;
            public float cena;
            public string sklep;
        }
    }
}
