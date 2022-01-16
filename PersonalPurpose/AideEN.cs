using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalPurpose
{
    public partial class AideEN : Form
    {
        public AideEN()
        {
            InitializeComponent();
        }

        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Videos\English\");

        private void btnInternet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path + @"InternetBlooperGuessingPassword.mp4");
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path + @"Problems-Sound.mp4");
        }

        private void btnMicrophone_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path + @"Problems-Microphone.mp4");
        }
    }
}
