using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    static class  BDDConnection
    {
        static private string server = "137.74.194.232";
        static private string database = "ftp";
        static private string uid = "remoteAcces";
        static private string password= "paozie";
        static private MySqlConnection connection = new MySqlConnection("SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";");

        static public bool openConnection()
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
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        static public bool closeConnection()
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

        static public List<Server> getServer(User user)
        {
            List<Server> retour = new List<Server>();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM server WHERE idUser='" +user.getId()+ "'", connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while(dataReader.Read())
            {
                retour.Add(new Server(dataReader["nameServer"].ToString(), dataReader["adressServer"].ToString(), dataReader["userServer"].ToString(), dataReader["passServer"].ToString()));
            }
            dataReader.Close();
            return retour;

        }
        static public Tuple<int,String,int,DateTime> getInfos(String mac){
            Tuple<int,String,int,DateTime> infos = null;
//            String query = "SELECT * FROM mac,productKey WHERE mac.productKey=productKey.idKey AND adressMac='" + mac + "'";
            String query = "SELECT * FROM mac WHERE adressMac='" + mac + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if(dataReader.Read())
            {
                String date = dataReader["subscription"].ToString();
                DateTime dt = Convert.ToDateTime(date);
                infos = new Tuple<int,string,int,DateTime>(Convert.ToInt32(dataReader["idMac"]),mac,Convert.ToInt16(dataReader["isBan"]),dt);  
            }
            dataReader.Close();
            return infos;
        }

        static public bool isKeyRegister(String mac)
        {
            bool retour=false;
            String query = "SELECT * FROM mac,productKey WHERE mac.productKey=productKey.idKey AND adressMac='" + mac + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                retour = true;
            }
            dataReader.Close();
            return retour;
        }

        static public void addServer(User user, string addressServer, string nameServer, string userServeur, string pass)
        {
            String query = "INSERT INTO server (`nameServer`,`userServer`,`passServer`,`adressServer`,`idUser`) VALUES('" + nameServer + "','" + userServeur + "','" + pass + "','"+addressServer+"','" + user.getId() + "')";
            MySqlCommand cmd = new MySqlCommand(query,connection);
            MessageBox.Show(query);
            cmd.ExecuteNonQuery();
            
        }

        static public bool updateKey(User user, String key)
        {
            int id = -1;
            String query = "SELECT * FROM productKey WHERE textKey='" + key + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                id = Convert.ToInt32(dataReader["idKey"]);
            }
            else
            {
                dataReader.Close();
                return false;
            }
            dataReader.Close();
            if (id>=0)
            {
                query = "UPDATE mac SET productKey='"+id+"' WHERE idMac='"+user.getId()+"'";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        static public bool islog(String mac)
        {
            bool retour = false;
            MySqlCommand cmd = new MySqlCommand("SELECT idMac FROM mac WHERE adressMac='"+mac+"'", connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                retour = true;
            }
            dataReader.Close();
            return retour;
        }

        static public bool isBan(String mac)
        {
            bool retour = false;
            MySqlCommand cmd = new MySqlCommand("SELECT isBan FROM mac WHERE adressMac='" + mac + "'", connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader["isBan"].Equals(1))
                {
                    retour = true;
                }
            }
            dataReader.Close();
            return retour;
        }

        static public DateTime getSubscription(String mac)
        {
            DateTime dt = new DateTime();
            MySqlCommand cmd = new MySqlCommand("SELECT subscription FROM mac WHERE adressMac='" + mac + "'", connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                String date = dataReader["subscription"].ToString();
                dt = Convert.ToDateTime(date);
            }
            dataReader.Close();
            return dt;

        }


    }
}