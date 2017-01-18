using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Server
    {
        private String name;
        private String user; 
        private String pass;
        private String adress;

        public Server(String name, String adress, String user, String pass)
        {
            this.name = name;
            this.adress = adress;
            this.user = user;
            this.pass = pass;
        }

        public String getName()
        {
            return name;
        }
        public String getAdress()
        {
            return adress;
        }
        public String getUser()
        {
            return user;
        }
        public String getPass()
        {
            return pass;
        }
    }
}
