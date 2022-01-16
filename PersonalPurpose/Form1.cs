using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalPurpose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxLanguage.SelectedItem.ToString() == "English")
            {
                this.Hide();
                AideEN aideEN = new AideEN();
                aideEN.Show();
            }
            else if(cbxLanguage.SelectedItem.ToString() == "Български")
            {
                this.Hide();
                AideBG aideBG = new AideBG();
                aideBG.Show();
            }
        }
    }
}
