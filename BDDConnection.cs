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

        static public Tuple<int,String,int,DateTime> getInfos(String mac){
            Tuple<int,String,int,DateTime> infos = null;
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM mac WHERE adressMac='" + mac + "'", connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if(dataReader.Read())
            {
                String date = dataReader["subscription"].ToString();
                DateTime dt = Convert.ToDateTime(date);
                infos = new Tuple<int,string,int,DateTime>(Convert.ToInt32(dataReader["idMac"]),mac,Convert.ToInt16(dataReader["isBan"]),dt);  
            }
            return infos;
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