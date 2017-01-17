using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Microsoft.VisualBasic;
using System.Net.NetworkInformation;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public User user;   
        private List<String> aDl = new List<String>();

        public Form1()
        {
            var macAddr =(
                    from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()
                ).FirstOrDefault();
            user = new User(macAddr);
            InitializeComponent();
         }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void addServer(object sender, EventArgs e)
        {
            AddServer form = new AddServer(user);
            form.Show();
        }

        private void button_Click_1(object sender, EventArgs e)
        {

            DirectoryInfo diTop = new DirectoryInfo(@"C:\Users\benoit\Documents\My Games\FarmingSimulator2017\mods");
            String total = "";
            foreach (var fi in diTop.EnumerateFiles())
            {
                total = total + fi.Name + "  " +fi.Length.ToString("N0")+ "\n";
            }        
            contentFtp.Text = total;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void synchronize_MouseEnter(object sender, EventArgs e){
            ((Button)sender).BackColor = SystemColors.ControlDark;
        }
        private void synchronize_MouseOut(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = SystemColors.ControlDarkDark;
        }

        private void synchronize_Click(object sender, EventArgs e)
        {
            DirectoryInfo diTop = new DirectoryInfo(@"C:\Users\benoit\Documents\My Games\FarmingSimulator2017\mods");
            foreach (var fi in diTop.EnumerateFiles())
            {
//                total = total + fi.Name + "  " +fi.Length.ToString("N0")+ "\n";
            }
            String path = "public_html/save/";
            Ftp ftpClient = new Ftp("ftp://en3rgie5.com", "tellisdu13@en3rgie5.com", "Tellisdu13",this);

            string[] simpleDirectoryListing = ftpClient.directoryListSimple(path);
            Boolean find = false;


            foreach(String file in simpleDirectoryListing)
            {
                find = false;
                if(file.EndsWith(".zip")){
                    foreach (var fi in diTop.EnumerateFiles())
                    {
                        if (fi.Name.Equals(file))
                        {
                            long size = ftpClient.getFileSize(path +"/"+ file);
                            if (size == fi.Length)
                            {
                                find = true;
                                break;
                            }
                        }
                    }
                    if (!find)
                    {
                        aDl.Add(file);
                    }
                }
            }
            String total = "";
            if (ftpClient != null)
            {
                foreach (String s in aDl)
                {
                    total = total + s + "\n";
                }
                contentFtp.Text = total;
            }
        }





        private void telechargement_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void changeProgressBar(int per)
        {
            progressBar1.Value = per;
            perProgressBar.Text = per + " %";
        }
        public void resetProgressBar()
        {
            progressBar1.Value = 0;
            perProgressBar.Text = "100 %";
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            String pathFS = "C:\\Users\\benoit\\Documents\\My Games\\FarmingSimulator2017\\mods";
            String path = "public_html/save/";
            Ftp ftpClient = new Ftp("ftp://en3rgie5.com", "tellisdu13@en3rgie5.com", "Tellisdu13", this);
            String host = "ftp://en3rgie5.com";
            String user = "tellisdu13@en3rgie5.com";
            String pass = "Tellisdu13";

            String remoteFile = "";
            String localFile = "";
            int bufferSize = 2048;
            foreach (string file in aDl)
            {
                try
                {
                    remoteFile = path + "/" + file;
                    localFile = pathFS + "/" + file;
                    long fileSize = ftpClient.getFileSize(remoteFile);
                    /* Create an FTP Request */
                    FtpWebRequest ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + remoteFile);
                    /* Log in to the FTP Server with the User Name and Password Provided */
                    ftpRequest.Credentials = new NetworkCredential(user, pass);
                    /* When in doubt, use these options */
                    ftpRequest.UseBinary = true;
                    ftpRequest.UsePassive = true;
                    ftpRequest.KeepAlive = true;
                    /* Specify the Type of FTP Request */
                    ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                    /* Establish Return Communication with the FTP Server */
                    FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                    /* Get the FTP Server's Response Stream */
                    Stream ftpStream = ftpResponse.GetResponseStream();
                    /* Open a File Stream to Write the Downloaded File */
                    FileStream localFileStream = new FileStream(localFile, FileMode.Create);
                    /* Buffer for the Downloaded Data */
                    byte[] byteBuffer = new byte[bufferSize];
                    int bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                    int bytes = 0;
                    int totalSize = (int)(fileSize); // Kbytes
                    /* Download the File by Writing the Buffered Data Until the Transfer is Complete */
                    try
                    {
                        while (bytesRead > 0)
                        {
                            localFileStream.Write(byteBuffer, 0, bytesRead);
                            bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                            bytes += bytesRead;
                            int pourcentage = (bytes * 100 / totalSize);
                            worker.ReportProgress(pourcentage);
                        }
                        
                        worker.ReportProgress(100,file);
                    }
                    catch (Exception ex) { MessageBox.Show(""+ex); }
                    /* Resource Cleanup */
                    localFileStream.Close();
                    ftpStream.Close();
                    ftpResponse.Close();
                    ftpRequest = null;
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }            
            }
            //aDl.Clear();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            resetProgressBar();
        }

        public void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            changeProgressBar(e.ProgressPercentage);
        }
        
    }
}
