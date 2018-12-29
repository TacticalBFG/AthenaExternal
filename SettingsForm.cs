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
    public partial class SettingsForm : Form
    {
        private FlatStyle flat = FlatStyle.Flat;
        private Color transparent = Color.FromArgb(0, 255, 255, 255);

        Form gayForm;

        public SettingsForm(Form lol)
        {
            InitializeComponent();

            openConsole.FlatStyle = flat;
            openConsole.FlatAppearance.BorderColor = transparent;
            openConsole.FlatAppearance.BorderSize = 0;

            gayForm = lol;

            if (gayForm.TopMost)
            {
                topmostpls.Text = "Top Most: True";
            }
            else
            {
                topmostpls.Text = "Top Most: False";
            }
            double fag = gayForm.Opacity * 100;
            opacityW.Text = fag.ToString();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void openConsole_Click(object sender, EventArgs e)
        {
            ConsoleForm cf = new ConsoleForm();
            cf.Show();
        }

        private void topmostpls_Click(object sender, EventArgs e)
        {
            gayForm.TopMost = !gayForm.TopMost;

            if (gayForm.TopMost)
            {
                topmostpls.Text = "Top Most: True";
            }
            else
            {
                topmostpls.Text = "Top Most: False";
            }
        }

        private void changetrans_Click(object sender, EventArgs e)
        {
            gayForm.Opacity = Convert.ToDouble(opacityW.Text)/100;
        }
    }
}
