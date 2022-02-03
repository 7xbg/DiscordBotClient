using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBotClient
{
    public partial class SetBotWatchingStatus : Form
    {
        public delegate void SetBotWatchingStatusEventHandler(string status, string watching);
        public event SetBotWatchingStatusEventHandler SetBotWatchingStatusNotify;
        public SetBotWatchingStatus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetBotWatchingStatusNotify?.Invoke(textBox1.Text, textBox2.Text);
            this.Close();
        }
    }
}
