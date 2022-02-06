using Discord;
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
    public partial class SetBotStatus : Form
    {
        public delegate void Notify(string status, string streamURL, ActivityType type);
        public event Notify notify;
        public SetBotStatus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivityType type;
            if (comboBox1.Text == "Listening")
                type = ActivityType.Listening;
            else if (comboBox1.Text == "Watching")
                type = ActivityType.Watching;
            else if (comboBox1.Text == "Playing")
                type = ActivityType.Playing;
            else
            {
                MessageBox.Show("Invalid Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            notify?.Invoke(textBox1.Text, null, type);
            this.Close();
        }
    }
}
