using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_addplayer_Click(object sender, EventArgs e)
        {
            AddPlayerForm f1 = new AddPlayerForm();
            f1.Show();
        }

        private void bt_showplyers_Click(object sender, EventArgs e)
        {
            ShowPlayersForm f1 = new ShowPlayersForm();
            f1.Show();
        }
    }
}
