using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            BDDConnection.openConnection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var macAddr = (
                 from nic in NetworkInterface.GetAllNetworkInterfaces()
                 where nic.OperationalStatus == OperationalStatus.Up
                 select nic.GetPhysicalAddress().ToString()
             ).FirstOrDefault();
            User user = new User(macAddr);
            MessageBox.Show("mac : " + macAddr);
            if (!user.isKeyRegister())
            {
                Application.Run(new askKey(user));
            }
            Application.Run(new Main(user));
            BDDConnection.closeConnection();
         
        }
    }
}
