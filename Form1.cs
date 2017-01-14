using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        private List<String> aDl = new List<String>();

        public Form1()
        {
            InitializeComponent();
         }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo diTop = new DirectoryInfo(@"C:\Users\benoit\Documents\My Games\FarmingSimulator2017\mods");
            foreach (var fi in diTop.EnumerateFiles())
            {
//                total = total + fi.Name + "  " +fi.Length.ToString("N0")+ "\n";
            }
            String path = "public_html/save/";
            Ftp ftpClient = new Ftp("ftp://en3rgie5.com", "tellisdu13@en3rgie5.com", "Tellisdu13");

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





        private void button2_Click_1(object sender, EventArgs e)
        {
            String pathFS = "C:\\Users\\benoit\\Documents\\My Games\\FarmingSimulator2017\\mods";
            String path = "public_html/save/";
            Ftp ftpClient = new Ftp("ftp://en3rgie5.com", "tellisdu13@en3rgie5.com", "Tellisdu13");
                
            foreach(string file in aDl){
                ftpClient.download(path + "/" + file, pathFS + "\\" + file);
                textBox1.AppendText("Fichier "+file+" téléchargé : OK \n");                
            }
            aDl.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
