using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AthenaExternal
{
    public partial class ConsoleForm : Form
    {
        public ConsoleForm()
        {
            InitializeComponent();
        }

        private void write(string str)
        {
            console.Text = console.Text + str + "\r\n";
        }



        private void command(string cmd)
        {
            write(cmd);

            if (cmd == "cmds" || cmd == "commands" || cmd=="help")
            {

            }
            else
            {
                write("Invalid command!");
            }
        }

        private void consoleCmd_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                command(consoleCmd.Text);
            }
        }

        private void consoleCmd_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
