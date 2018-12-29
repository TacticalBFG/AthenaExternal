using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO.Pipes;
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.IO.Compression;

namespace AthenaExternal
{

    public partial class Form1 : Form
    {

        private FlatStyle flat = FlatStyle.Flat;
        private Color transparent = Color.FromArgb(0, 255, 255, 255);

        //List<string> globals = new List<string>();
        string[] globals = {"local" };
        public Form1()
        {

             /* LoadForm lf = new LoadForm();
              lf.Show();*/
            

              string dir = @"Data\\Globals.Athena";
            bool updated = true;


            // string version = @"Data\\VERSION.txt";
            string appdatanshit = Environment.GetEnvironmentVariable("LocalAppData");
            if (Directory.Exists(appdatanshit + "\\Athena"))
            {

            }
            else
            {
                AthenaFirstTimeSetup pp = new AthenaFirstTimeSetup();
                pp.Show();
                //Thread.Sleep(500);
                //this.Close();
            }

            string appdata = Environment.GetEnvironmentVariable("LocalAppData");
            string blox = appdata + "\\Roblox\\Versions\\";
            if (Directory.Exists(blox))
            {
                string[] africans = Directory.GetDirectories(blox);
                foreach (string african in africans)
                {
                    if (File.Exists(african + "\\RobloxPlayerLauncher.exe"))
                    {
                        if (!File.Exists(african + "\\Athena.dll"))
                        {
                            string nig = Application.StartupPath;
                            File.Copy(nig + "\\Athena.dll", african + "\\Athena.dll");
                            File.Copy(nig + "\\Data\\VMProtectSDK32.dll", african + "\\VMProtectSDK32.dll");
                            File.Copy(nig + "\\Data\\lua5.1.dll", african + "\\lua5.1.dll");
                            File.Copy(nig + "\\Data\\msvcp140d.dll", african + "\\msvcp140d.dll");
                            File.Copy(nig + "\\Data\\ucrtbased.dll", african + "\\ucrtbased.dll");
                            File.Copy(nig + "\\Data\\vcruntime140d.dll", african + "\\vcruntime140d.dll");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Roblox directory does not exist. Try re-installing Roblox.");
            }

           
            if (updated)
            {
                InitializeComponent();
            }
            using (StreamReader sr = new StreamReader(dir))
            {
                String fuck = sr.ReadToEnd();
                foreach (string die in fuck.Split(' '))
                {
                    Array.Resize(ref globals, globals.Length + 1);
                    globals[globals.Length - 1] = die;
                }
                //globals.Add(line);
            }




            // loltemp.Text = "";



            // SETUP FILES

            

        }

        private bool isInjected = false;
     
        private void scintilla1_Click(object sender, EventArgs e)
        {

        }
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool WaitNamedPipe(string name, int timeout);

        public static bool namedPipeExist(string pipeName)
        {
            try
            {
                int timeout = 0;
                string normalizedPath = System.IO.Path.GetFullPath(
                    string.Format(@"\\.\pipe\{0}", pipeName));
                bool exists = WaitNamedPipe(normalizedPath, timeout);
                if (!exists)
                {
                    int error = Marshal.GetLastWin32Error();
                    if (error == 0) // pipe does not exist
                        return false;
                    else if (error == 2) // win32 error code for file not found
                        return false;
                    // all other errors indicate other issues
                }
                return true;
            }
            catch (Exception)
            {
                return false; // assume it doesn't exist
            }
        }

        private bool check_inject()
        {
            if (namedPipeExist("scriptpipe"))
            {
                return true;
            } else
            {
                //MessageBox.Show("Athena must be injected before executing a script!");
                return false;
            }
        }

     

        private void clr_Click(object sender, EventArgs e)
        {
           // loltemp.Text = " ";
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(this);
            sf.Show();
        }

        private void openScr_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "lua files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            string scriptFilePath = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            scriptFilePath = openFileDialog1.FileName;
                        }

                        if (File.Exists(scriptFilePath))
                        {
                            StreamReader sr = new StreamReader(scriptFilePath);
                           // loltemp.Text = sr.ReadToEnd();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. " + ex.Message);
                }
            }
        }

        private bool inject()
        {
            string modulepath = Directory.GetCurrentDirectory() + "\\Athena.dll";
            switch (Memory.DllInjector.GetInstance.Inject("RobloxPlayerBeta", modulepath))
            {
                case Memory.DllInjectionResult.DllNotFound:
                    int num1 = (int)MessageBox.Show("No Athena DLL found! Try disabling your anti-virus and restarting the cliet.");
                    return false;
                case Memory.DllInjectionResult.GameProcessNotFound:
                    int num2 = (int)MessageBox.Show("No roblox process found.");
                    return false;
                case Memory.DllInjectionResult.InjectionFailed:
                    int num3 = (int)MessageBox.Show("Injection failed.");
                    return false;
                default:
                    isInjected = true;
                    isInjected = true;
                    isInjected = true;
                    isInjected = true;
                    return true;
            }
           // Process.Start(Directory.GetCurrentDirectory() + "\\Data\\AthenaInjector.exe");
     
        }

        private void boye(string skid)
        {
            if (check_inject())
            {
                using (NamedPipeClientStream pipeClientStream = new NamedPipeClientStream(".", "scriptpipe", PipeDirection.Out))
                {
                    pipeClientStream.Connect();
                    using (StreamWriter streamWriter = new StreamWriter((Stream)pipeClientStream))
                    {
                        streamWriter.Write(skid);
                        streamWriter.Dispose();
                    }
                    pipeClientStream.Dispose();
                }
            }
            else
            {
                inject();
            }
        }

        private void injectBtn_Click(object sender, EventArgs e)
        {
            
            
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

        private void exeScr_Click(object sender, EventArgs e)
        {
          //  boye(loltemp.Text);
        }

        private void ssCmds_Click(object sender, EventArgs e)
        {
            boye("gui()");
        }

        private void devui_Click(object sender, EventArgs e)
        {
            boye("dgui()");
        }

        private void close_form_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  button1.BackColor = Color.FromArgb(255, 44, 62, 80);
            //   close_form.BackColor = Color.FromArgb(255, 44, 62, 80);

            hitormissbatman.BeginUpdate();
            string[] scriptstoadd = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\scripts", "*.txt", SearchOption.AllDirectories);

            foreach (string f in scriptstoadd)
            {
                string splithere = Directory.GetCurrentDirectory() + "\\scripts\\";
                int splitlen = splithere.Length;
                string hef = f.Substring(splitlen);

                if (!hef.Contains("AutoExecute\\"))
                hitormissbatman.Items.Add(hef);
            }
                

            hitormissbatman.EndUpdate();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void script_shit_Load(object sender, EventArgs e)
        {
           
          
        }
        static FontStyle style = FontStyle.Regular;
        TextStyle blue = new TextStyle(Brushes.LightBlue, null, style);
        TextStyle red = new TextStyle(Brushes.Red, null, style);
        TextStyle green = new TextStyle(Brushes.Green, null, style);

        FastColoredTextBoxNS.Style CommentStyle = new TextStyle(Brushes.White, null, FontStyle.Italic);
        FastColoredTextBoxNS.Style BoldStyle = new TextStyle(Brushes.LightBlue, null, FontStyle.Bold);
        FastColoredTextBoxNS.Style StringStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        FastColoredTextBoxNS.Style NumberStyle = new TextStyle(Brushes.Yellow, null, FontStyle.Regular);

        FastColoredTextBoxNS.Style GlobalStyle = new TextStyle(Brushes.LightSkyBlue, null, FontStyle.Regular);

        private void setglobal(string name, TextChangedEventArgs e)
        {
            e.ChangedRange.SetStyle(GlobalStyle, name);
        }
        

        private void script_shit_TextChanged(object sender, TextChangedEventArgs e)
        {

            e.ChangedRange.ClearFoldingMarkers();
            //set folding markers
            e.ChangedRange.SetFoldingMarkers("do", "end");
            e.ChangedRange.SetFoldingMarkers(@"then\b", @"end\b");
            e.ChangedRange.SetFoldingMarkers(@"function\b", @"end\b");


            //comment highlighting
           // e.ChangedRange.ClearStyle(Co

            e.ChangedRange.SetStyle(CommentStyle, @"--.*$", RegexOptions.Singleline);

            //autoindent
            e.ChangedRange.SetStyle(StringStyle, @"^\s*[\w\.]+\s*(?<range>=)\s*(?<range>[^;]+);", RegexOptions.Singleline);

            //string highlighting
            e.ChangedRange.SetStyle(StringStyle, @"^\s*[\w\.]+\s*(?<range>\"")\s*(?<range>[^;]+);", RegexOptions.Singleline);

            // global highlighting
            foreach (string gay in globals)
                setglobal(gay, e);


           //  e.ChangedRange.SetStyle(NumberStyle, @"([^\d]|^)\d{1,2},\d{3}([^\d]|$)");
        }

        private void shit_Click(object sender, EventArgs e)
        {

        }

        private void trueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.TopMost = true;
        //    falseToolStripMenuItem.Checked = false;
        //    trueToolStripMenuItem.Checked = true;
        }

        private void falseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.TopMost = false;
        //    falseToolStripMenuItem.Checked = true;
         //   trueToolStripMenuItem.Checked = false;
        }

        private void injectpls_Click(object sender, EventArgs e)
        {
            inject();
         //  toplabel.Text = "Athena - Injected!";
         //   toplabel.Text = "Athena";
        }

        private void serverSideScriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fEGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boye("gui()");
        }

        private void remoteSpyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boye("loadstring(geturl('https://pastebin.com/raw/CdgDBC6w'))()");
        }

        private void fEDevGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boye("dgui()");
        }

        private void clr_Click_1(object sender, EventArgs e)
        {
            script_shit.Text = "";
            
        }

        private void opn_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "lua files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            string scriptFilePath = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            scriptFilePath = openFileDialog1.FileName;
                        }

                        if (File.Exists(scriptFilePath))
                        {
                            StreamReader sr = new StreamReader(scriptFilePath);
                            script_shit.Text = sr.ReadToEnd();
                            sr.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. " + ex.Message);
                }
            }
        }

        private void exc_Click(object sender, EventArgs e)
        {
            boye(script_shit.Text);
        }

        private void dabNonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            int G = rand.Next(0, 255);
           
            if (Form1.ActiveForm == this)
            {
                Form1.ActiveForm.BackColor = Color.FromArgb(255, R, G, B);
                Form1.ActiveForm.BackgroundImage = null;
              //  exc.BackgroundImage = null;
              //  opn.BackgroundImage = null;
             //   clr.BackgroundImage = null;
             //   injectpls.BackgroundImage = null;
                close_form.BackgroundImage = null;
                button1.BackgroundImage = null;
                script_shit.BackgroundImage = null;
              //  toolStrip1.BackgroundImage = null;

             //   exc.BackColor = Color.FromArgb(255, R, G, B);
              //  opn.BackColor = Color.FromArgb(255, R, G, B);
              //  clr.BackColor = Color.FromArgb(255, R, G, B);
              //  injectpls.BackColor = Color.FromArgb(255, R, G, B);
                close_form.BackColor = Color.FromArgb(255, R, G, B);
                button1.BackColor = Color.FromArgb(255, R, G, B);
                script_shit.BackColor = Color.FromArgb(255, R, G, B);
               // toolStrip1.BackColor = Color.FromArgb(255, R, G, B);
            }


        }

        private void rainbowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("This is probably gonna hurt your eyes. Are you sure?", "attention u sensitive skid", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                timer1.Start();
            }
            }
        
        private int[] getClr(string[] datapls)
        {
            int r = Convert.ToInt32(datapls[1].Split(',')[0]);
            int g = Convert.ToInt32(datapls[1].Split(',')[1]);
            int b = Convert.ToInt32(datapls[1].Split(',')[2]);
            List<int> megaholy = new List<int>();
            megaholy.Add(r); megaholy.Add(b); megaholy.Add(g);

            return megaholy.ToArray();

        }

        private void loadtheme(string name)
        {
            timer1.Stop();
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(name+ "\\THEME DATA.athema");
            while ((line = file.ReadLine()) != null)
            {
                string[] datapls = line.Split(' ');
                if (datapls[0] == "toplabel-color")
                {
                    int[] gay = getClr(datapls);
                //    toplabel.ForeColor = Color.FromArgb(255,gay[0],gay[1],gay[2]);
                }

                if (datapls[0] == "execute-color")
                {
                    int[] gay = getClr(datapls);
                 //   exc.ForeColor = Color.FromArgb(255, gay[0], gay[1], gay[2]);
                }

                if (datapls[0] == "clear-color")
                {
                    int[] gay = getClr(datapls);
               //     clr.ForeColor = Color.FromArgb(255, gay[0], gay[1], gay[2]);
                }

                if (datapls[0] == "open-color")
                {
                    int[] gay = getClr(datapls);
               //     opn.ForeColor = Color.FromArgb(255, gay[0], gay[1], gay[2]);
                }
                if (datapls[0] == "inject-color")
                {
                    int[] gay = getClr(datapls);
                //    injectpls.ForeColor = Color.FromArgb(255, gay[0], gay[1], gay[2]);
                }
                if (datapls[0] == "close-color")
                {
                    int[] gay = getClr(datapls);
                    close_form.ForeColor = Color.FromArgb(255, gay[0], gay[1], gay[2]);
                }
                if (datapls[0] == "minimize-color")
                {
                    int[] gay = getClr(datapls);
                    button1.ForeColor = Color.FromArgb(255, gay[0], gay[1], gay[2]);
                }
                if (datapls[0] == "globals-color")
                {
                 //   int[] gay = getClr(datapls);
                //    toplabel.ForeColor = Color.FromArgb(255, gay[0], gay[1], gay[2]);
                }

                if (datapls[0] == "comments-color")
                {
                  //  int[] gay = getClr(datapls);
                  //  toplabel.ForeColor = Color.FromArgb(255, gay[0], gay[1], gay[2]);
                }
                if (datapls[0] == "scriptcolor-color")
                {
                    int[] gay = getClr(datapls);
                    script_shit.ForeColor = Color.FromArgb(255, gay[0], gay[1], gay[2]);
                }

                if (datapls[0] == "main-theme")
                {
                    Image megaholy = Image.FromFile(name+"\\"+datapls[1]);
                    Form1.ActiveForm.BackgroundImage = megaholy;
               //     exc.BackgroundImage = megaholy;
               //     opn.BackgroundImage = megaholy;
                //    clr.BackgroundImage = megaholy;
                //    injectpls.BackgroundImage = megaholy;
                    close_form.BackgroundImage = megaholy;
                    button1.BackgroundImage = megaholy;
                    script_shit.BackgroundImage = megaholy;
               //     toolStrip1.BackgroundImage = megaholy;
                }

                if (datapls[0] == "script-theme")
                {
                    Image megaholy = Image.FromFile(name + "\\" + datapls[1]);
                    script_shit.BackgroundImage = megaholy;
                }
                if (datapls[0] == "button-theme")
                {
                    Image megaholy = Image.FromFile(name + "\\" + datapls[1]);
                   
                 //   exc.BackgroundImage = megaholy;
                 //   opn.BackgroundImage = megaholy;
                 //   clr.BackgroundImage = megaholy;
                 //   injectpls.BackgroundImage = megaholy;
                    close_form.BackgroundImage = megaholy;
                    button1.BackgroundImage = megaholy;
                }
                if (datapls[0] == "topbar-theme")
                {
                    Image megaholy = Image.FromFile(name + "\\" + datapls[1]);
                  //  toolStrip1.BackgroundImage = megaholy;
                }
                if (datapls[0] == "background-theme")
                {
                    Image megaholy = Image.FromFile(name + "\\" + datapls[1]);
                    Form1.ActiveForm.BackgroundImage = megaholy;
                }
            }

            file.Close();
        }

        private void dynamicThemeStripHandler(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripItem)sender;
            loadtheme("Themes\\" + item.Text);
        }

    private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadtheme("Themes\\Default");
        }

        private void themesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] subdirectoryEntries = Directory.GetDirectories("Themes");
            foreach (string subdirectory in subdirectoryEntries)
            {
                if (subdirectory.Substring(7) != "Default")
                {
                 /*   ToolStripItem[] memes = themesToolStripMenuItem.DropDownItems.Find(subdirectory.Substring(7), true);
                    foreach (ToolStripItem dead in memes)
                        themesToolStripMenuItem.DropDownItems.Remove(dead);

                    ToolStripItem faguet = themesToolStripMenuItem.DropDownItems.Add(subdirectory.Substring(7));
                    faguet.Click += new EventHandler(dynamicThemeStripHandler);*/
                }
            }
        }

        private void ChathookThing_Click(object sender, EventArgs e)
        {

        }

        private void commandToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void C_SCR_SRT_Click(object sender, EventArgs e)
        {
            boye("_G.ChathookSCRAlive=true; _G.ChathookCMDAlive=false");
        }

        private void C_SCR_STP_Click(object sender, EventArgs e)
        {
            boye("_G.ChathookSCRAlive = false");
        }

        private void C_CMD_SRT_Click(object sender, EventArgs e)
        {
            boye("_G.ChathookSCRAlive=false; _G.ChathookCMDAlive=true");
        }

        private void C_CMD_STP_Click(object sender, EventArgs e)
        {
            boye("_G.ChathookCMDAlive = false");
        }

        private void grabKnifeV4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox16_Click(object sender, EventArgs e)
        {
            boye("SS.RockNRoll()");
        }

        private void toolStripTextBox15_Click(object sender, EventArgs e)
        {
            boye("SS.JohnDoe()");
        }

        private void toolStripTextBox14_Click(object sender, EventArgs e)
        {
            boye("SS.KFC()");
        }

        private void toolStripTextBox13_Click(object sender, EventArgs e)
        {
            boye("SS.McDonalds()");
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            boye("SS.BombVest()");
        }

        private void toolStripTextBox10_Click(object sender, EventArgs e)
        {
            boye("SS.DualUltima()");
        }

        private void toolStripTextBox9_Click(object sender, EventArgs e)
        {
            boye("SS.Flamethrower()");
        }

        private void toolStripTextBox8_Click(object sender, EventArgs e)
        {
            boye("SS.ChatHax()");
        }

        private void toolStripTextBox7_Click(object sender, EventArgs e)
        {
            boye("SS.GrabKnife1()");
        }

        private void toolStripTextBox6_Click(object sender, EventArgs e)
        {
            boye("SS.GrabKnife2()");
        }

        private void toolStripTextBox5_Click(object sender, EventArgs e)
        {
            boye("SS.GrabKnife3()");
        }

        private void toolStripTextBox12_Click(object sender, EventArgs e)
        {
            boye("SS.GrabKnife4()");
        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {
            boye("SS.KitchenGun()");
        }

        private void toolStripTextBox11_Click(object sender, EventArgs e)
        {
            boye("SS.Bong()");
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            boye("SS.Jihad()");
        }

        private void toolStripTextBox20_Click(object sender, EventArgs e)
        {
            boye("SS.MML()");
        }

        private void toolStripTextBox19_Click(object sender, EventArgs e)
        {
            boye("SS.Kuro()");
        }

        private void toolStripTextBox18_Click(object sender, EventArgs e)
        {
            boye("SS.Voluntris()");
        }

        private void secretServiceAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boye("SS.SecretService()");

        }

        private void rescan_Click(object sender, EventArgs e)
        {
            if (isInjected)
            {
                using (NamedPipeClientStream pipeClientStream = new NamedPipeClientStream(".", "cmdpipe", PipeDirection.Out))
                {
                    pipeClientStream.Connect();
                    using (StreamWriter streamWriter = new StreamWriter((Stream)pipeClientStream))
                    {
                        streamWriter.Write("rescan");
                        streamWriter.Dispose();
                    }
                    pipeClientStream.Dispose();
                }
            }
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            boye("SS.Rocket()");
        }

        private void hitormissbatman_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(hitormissbatman.SelectedItem.ToString());
           if (hitormissbatman.SelectedItem != null)
           boye(File.ReadAllText(Directory.GetCurrentDirectory() + "\\scripts\\" + hitormissbatman.SelectedItem.ToString()));
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            inject();
            flatButton3.Text = "Inject";
        }

        private void excpls_Click(object sender, EventArgs e)
        {
            boye(script_shit.Text);
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "lua files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            string scriptFilePath = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            scriptFilePath = openFileDialog1.FileName;
                        }

                        if (File.Exists(scriptFilePath))
                        {
                            StreamReader sr = new StreamReader(scriptFilePath);
                            script_shit.Text = sr.ReadToEnd();
                            sr.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. " + ex.Message);
                }
            }
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            script_shit.Text = "";
        }

        /*
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
         */

        Point jefspacito = Point.Empty;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            jefspacito = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (jefspacito.IsEmpty)
                return;
            Form f = Form1.ActiveForm;
            f.Location = new Point(f.Location.X + (e.X - jefspacito.X), f.Location.Y + (e.Y - jefspacito.Y));
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            jefspacito = Point.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hitormissbatman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                for (int i=0; i<hitormissbatman.SelectedItems.Count; i++)
                {
                    string blyat = hitormissbatman.SelectedItems[i].ToString();
                    boye(File.ReadAllText(Directory.GetCurrentDirectory() + "\\scripts\\" + blyat));

                }
            }
        }

        private void fix_it_felix_Click(object sender, EventArgs e)
        {
            Process[] dirtyroadblocks = Process.GetProcesses();
            bool is_skidblox = false;
            foreach (Process nigger in dirtyroadblocks)
            {
                string f = nigger.MainWindowTitle;
                if (f == "Roblox")
                {
                    is_skidblox = true;
                    nigger.Kill();
                    is_skidblox = false;
                }
            }
            Thread.Sleep(100);
            Process[] dirtyroadblocks1 = Process.GetProcesses();
            foreach (Process nigger in dirtyroadblocks1)
            {
                string f = nigger.MainWindowTitle;
                if (f == "Roblox")
                {
                    is_skidblox = true;
                    MessageBox.Show("Please exit out of Roblox and re-trying injection fixer.");
                }
            }


            if (!is_skidblox)
            {
               

                string appdata = Environment.GetEnvironmentVariable("LocalAppData");
                string blox = appdata + "\\Roblox\\Versions\\";
                if (Directory.Exists(blox))
                {
                    string[] africans = Directory.GetDirectories(blox);
                    foreach (string  african in africans)
                    {
                        if (File.Exists(african+"\\RobloxPlayerLauncher.exe"))
                        {
                            string nig = Application.StartupPath;
                            File.Copy(nig + "\\Athena.dll", african + "\\Athena.dll");
                            File.Copy(nig + "\\Data\\VMProtectSDK32.dll", african + "\\VMProtectSDK32.dll");
                            File.Copy(nig + "\\Data\\lua5.1.dll", african + "\\lua5.1.dll");
                            File.Copy(nig + "\\Data\\msvcp140d.dll", african + "\\msvcp140d.dll");
                            File.Copy(nig + "\\Data\\ucrtbased.dll", african + "\\ucrtbased.dll");
                            File.Copy(nig + "\\Data\\vcruntime140d.dll", african + "\\vcruntime140d.dll");
                        }
                    }
                } else
                {
                    MessageBox.Show("Roblox directory does not exist. Try re-installing Roblox.");
                }
                //System.Diagnostics.Process.Start("InjectionFixer.bat").WaitForExit();
                MessageBox.Show("Done! Try injecting. If it still has issues injecting, please DM support.");
            }
        }
    }
}
