using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace WindowsFormsApplication1
{
    public class User
    {
        private DateTime sub;
        private int id;
        private String mac;
        private bool isBan;
        private bool keyRegister;
        public User(String mac)
        {
            this.mac = mac;
            if (BDDConnection.islog(mac) )
            {
                Tuple<int, String, int, DateTime> infos = BDDConnection.getInfos(mac);
                sub = infos.Item4;
                TimeSpan reste = sub - DateTime.Now;
                id = infos.Item1;
                if (infos.Item3 == 1) { isBan = true; }
                else { isBan = false; }
                if (BDDConnection.isKeyRegister(mac))
                {
                    keyRegister = true;
                }
                else
                {
                    keyRegister = false;
                }
            }
            else
            {
                this.id = -1;
            }
        }

        public int getId()
        {
            return id;
        }
        public bool isKeyRegister()
        {
            return keyRegister;
        }
        public DateTime getSub()
        {
            return sub;
        }
        public TimeSpan getTimeLeft()
        {
            TimeSpan reste = sub - DateTime.Now;
            return reste;
        }
        public String getTimeLeftString()
        {
            TimeSpan reste = getTimeLeft();
            String retour;
            if (reste.Days > 0)
            {
                retour = reste.Days + " jour(s)";
            }
            else if (reste.Hours > 0)
            {
                retour = reste.Hours + " heure(s)";
            }
            else
            {
                retour = reste.Days + " minute(s)";
            }
            return retour;
        }

        public String getMac()
        {
            return mac;
        }

        public String toString()
        {
            String retour = "id:" + id + ", mac:" + mac + ", sub:" + sub + ", isban:" + isBan;
            return retour;
        }
    }
}
