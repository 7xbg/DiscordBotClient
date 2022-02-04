using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBotClient.ManageUsers
{
    public partial class KickUser : Form
    {
        public delegate void KickUserReasonSetHandler(string reason);
        public event KickUserReasonSetHandler KickUserReasonSet;
        public KickUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KickUserReasonSet?.Invoke(textBox1.Text);
            this.Close();
        }
    }
}
