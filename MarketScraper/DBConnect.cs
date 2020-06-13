using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MarketScraper
{
    class DBConnect
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

        //Insert statement
        public void Insert(Klient klient, float cenatotal, Dictionary<PromoScraper.Product, int> produkty)
        {
            string query;

            //open connection
            if (this.OpenConnection() == true)
            {
                query = $"INSERT INTO `Klient` (`id`, `imie`, `nazwisko`, `miasto`, `ulica`, `kod_pocztowy`, `tel`) VALUES (NULL, '{klient.imie}', '{klient.nazwisko}', '{klient.miasto}', '{klient.ulica}', '{klient.KP}', '{klient.tel}');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                query = $"INSERT INTO `Zamowienia` (`id`, `data`, `klientid`, `cena`) VALUES (NULL, '{DateTime.Now.Date.ToString("yyyy-MM-dd")}', '{cmd.LastInsertedId}', '{cenatotal}');";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                long zamid = cmd.LastInsertedId;

                foreach(KeyValuePair<PromoScraper.Product, int> produkt in produkty)
                {
                    query = $"INSERT INTO `Produkty` (`zamowienieid`, `zdjecie`, `nazwa`, `cena`, `waga`, `ilosc`) VALUES('{zamid}', '{produkt.Key.imageUrl}', '{produkt.Key.name}', '{produkt.Key.price}', '{produkt.Key.weight}', '{produkt.Value}');";
                    cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(int id)
        {
            string query = "DELETE FROM Zamowienia WHERE id='"+id+"'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /*//Select statement
        public List<PromoScraper.Product>[] Select()
        {
        }

        //Count statement
        public int Count()
        {
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }*/

        public struct Klient
        {
            public Klient(string imie, string nazwisko, string miasto, string ulica, string KP, int tel)
            {
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.miasto = miasto;
                this.ulica = ulica;
                this.KP = KP;
                this.tel = tel;
            }

            public string imie;
            public string nazwisko;
            public string miasto;
            public string ulica;
            public string KP;
            public int tel;
        }
    }
}
