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

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        private User user;   
        private List<String> aDl = new List<String>();
        private List<Server> listServer = new List<Server>();
        private int indexServ = 0;
        private bool pauseBW = false;
        private bool breakBW = false;
        public Main(User user)
        {
            this.user = user;
            
            InitializeComponent();

            if (user.getId() < 0)
            {
                login.Text = "Guest";
            }
            else
            {
                login.Text = user.getMac();                
            }
            timeLeft.Text = user.getTimeLeftString();
            reloadServer();
         }

        public void reloadServer()
        {
            listServer= BDDConnection.getServer(user);
            server.Items.Clear();
            foreach (Server s in listServer)
            {
                server.Items.Add(s.getName());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        

        private void addServer(object sender, EventArgs e)
        {
            AddServer form = new AddServer(user,this);
            form.Show();
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
            aDl.Clear();
            DirectoryInfo diTop = new DirectoryInfo(@"C:\Users\benoit\Documents\My Games\FarmingSimulator2017\mods");
            foreach (var fi in diTop.EnumerateFiles())
            {
//                total = total + fi.Name + "  " +fi.Length.ToString("N0")+ "\n";
            }
            String path = "public_html/save/";
            Server ser = listServer[indexServ];
            Ftp ftpClient = new Ftp(ser.getAdress(), ser.getUser(), ser.getPass(),this);
//            Ftp ftpClient = new Ftp("ftp://en3rgie5.com", "tellisdu13@en3rgie5.com", "Tellisdu13", this);

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
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
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
            perProgressBar.Text = "";
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
                    long bytes = 0;
                    int totalSize = (int)(fileSize); // Kbytes
                    /* Download the File by Writing the Buffered Data Until the Transfer is Complete */
                    try
                    {
                        while (bytesRead > 0)
                        {
                            while (pauseBW)
                            {
                            }
                            if (breakBW)
                            {
                                breakBW = false;
                                e.Cancel = true;
                                break;
                            }
                            localFileStream.Write(byteBuffer, 0, bytesRead);
                            bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                            bytes += bytesRead;
                            long pourcentage = (bytes * 100 / totalSize);
                            worker.ReportProgress(Convert.ToInt32(pourcentage));
                        }
                        label2.Invoke(new Action(() => { log.AppendText(file + "   OK" + Environment.NewLine); }));
                        label2.Invoke(new Action(() => { log.Refresh(); })); worker.ReportProgress(100);
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


        private void login_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void server_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexServ = ((ListBox)sender).SelectedIndex;
            if(indexServ>=0 && indexServ< listServer.Count()){
                nameServer.Text = listServer[indexServ].getName();
            }
        }

        private void pauseBt_Click(object sender, EventArgs e)
        {
            if (pauseBW)
            {
                pauseBW = false;
                pauseBt.Text = "Pause";
            }
            else
            {
                pauseBW = true;
                pauseBt.Text = "Resume";
            }
        }

        private void breakBt_Click(object sender, EventArgs e)
        {
            breakBW = true;
        }

        
    }
}
