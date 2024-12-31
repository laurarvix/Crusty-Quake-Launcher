using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace Doom_Loader
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            if (GetType().Assembly.GetName().Version.MinorRevision == 1) // If the version of Minty Launcher is a pre-release version
                version.Text = "PRE-RELEASE Version " +
                    $"{GetType().Assembly.GetName().Version.Major}." +
                    $"{GetType().Assembly.GetName().Version.Minor}." +
                    $"{GetType().Assembly.GetName().Version.Build}";

            else
                version.Text = "Version " +
                    $"{GetType().Assembly.GetName().Version.Major}." +
                    $"{GetType().Assembly.GetName().Version.Minor}." +
                    $"{GetType().Assembly.GetName().Version.Build}";
        }

        // Little Easter Egg
        private void label2_Click(object sender, EventArgs e)
        {
            new extraCredits().ShowDialog();
        }
    }
}
