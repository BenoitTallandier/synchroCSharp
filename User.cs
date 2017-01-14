using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace WindowsFormsApplication1
{
    class User
    {
        private DateTime sub;
        private int id;
        private String mac;
        private bool isBan;

        public User(String mac)
        {
            this.mac = mac;
            if (BDDConnection.islog(mac))
            {
                Tuple<int,String,int,DateTime> infos = BDDConnection.getInfos(mac);
                id = infos.Item1;
                if (infos.Item3 == 1) { isBan = true; }
                else { isBan = false; }
                sub = infos.Item4;
            }
        }

        public String toString()
        {
            String retour = "id:" + id + ", mac:" + mac + ", sub:" + sub + ", isban:" + isBan;
            return retour;
        }
    }
}
