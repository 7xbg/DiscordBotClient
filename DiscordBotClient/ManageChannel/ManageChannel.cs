using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBotClient.ManageChannel
{
    public partial class ManageChannel : Form
    {
        private IDiscordClient _client;
        private SocketGuildChannel _channel;
        public ManageChannel(IDiscordClient client, SocketGuildChannel channel)
        {
            InitializeComponent();
            channelName.Text = channel.Name;
            channelDescription.Text = (channel as SocketTextChannel).Topic;
            _client = client;
            _channel = channel;

            if (channel.GetUser(client.CurrentUser.Id).GuildPermissions.ManageChannels)
            {
                setNameButton.Enabled = true;
                setDescriptionButton.Enabled = true;
                setTimeoutButton.Enabled = true;
            }
        }

        private void ManageChannel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _channel.ModifyAsync(prop => prop.Name = channelName.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SocketTextChannel channel = _channel as SocketTextChannel;
            channel.ModifyAsync(prop => prop.Topic = channelDescription.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                int.Parse(timeoutTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter Valid Integer", "Int Parse Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SocketTextChannel channel = _channel as SocketTextChannel;
            channel.ModifyAsync(prop => prop.SlowModeInterval = int.Parse(timeoutTextBox.Text));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SocketTextChannel channel = _channel as SocketTextChannel;
            channel.ModifyAsync(prop => prop.IsNsfw = nsfwCheckBox.Checked);
        }
    }
}
