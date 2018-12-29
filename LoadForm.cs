using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AthenaExternal
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }



        private void LoadForm_Load(object sender, EventArgs e)
        {
            /*string exploit_dir = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Athena";
            if (!Directory.Exists(exploit_dir))
            {
                Directory.CreateDirectory(exploit_dir);
            }

            if (!Directory.Exists(exploit_dir + "\\bin"))
            {
                Directory.CreateDirectory(exploit_dir + "\\bin");
            }

            //if (!Directory.Exists("c:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Athena\\bin\\VMProtectSDK32.dll"))
              //  new WebClient().DownloadFile("https://tacticalbfg.com/Athena/bin/VMProtectSDK32.dll", "c:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Athena\\bin\\VMProtectSDK32.dll");
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;*/
            // cheeky
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
