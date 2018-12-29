using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace AthenaExternal
{
    public partial class AthenaFirstTimeSetup : Form
    {
        public AthenaFirstTimeSetup()
        {
            InitializeComponent();
        }

        private void AthenaFirstTimeSetup_Load(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);

            
        }

        Point mousedownpoint = Point.Empty;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (mousedownpoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mousedownpoint.X), f.Location.Y + (e.Y - mousedownpoint.Y));

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }

        private void enterpls_Click(object sender, EventArgs e)
        {
            string key = keything.Text;
            WebClient african_child = new WebClient();
            string yespacito = african_child.DownloadString("https://tacticalbfg.com/Athena/clientarea/checkforkey.php?key=" + key);
            if (yespacito == "true")
            {
                label2.Text = "SETTING UP... PLEASE WAIT.";
                Directory.CreateDirectory(Environment.GetEnvironmentVariable("LocalAppData") + "\\Athena");
                 string dir = Environment.GetEnvironmentVariable("LocalAppData") + "\\Athena";
                ProcessStartInfo jef = new ProcessStartInfo();
                jef.FileName = @"Data\\Whitelist.exe";
                jef.Arguments = key;
                Process.Start(jef);
                label2.Text = "DONE WHITELISTING, FINISHING SETUP.";
                
                using (StreamWriter fag = File.CreateText(dir + "\\KEY.txt"))
                {
                    fag.WriteLine(key);
                }
                label2.Text = "SETUP COMPLETE! YOU MAY NOW RESTART\r\nTHIS AND USE ATHENA!";
            } else
            {
                label2.Text = "INCORRECT KEY.";
            }
        }
    }
}
