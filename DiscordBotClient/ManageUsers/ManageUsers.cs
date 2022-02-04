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

namespace DiscordBotClient.ManageUsers
{
    public partial class ManageUsers : Form
    {
        SocketGuild Guild;
        public ManageUsers(SocketGuild guild)
        {
            Guild = guild;
            InitializeComponent();
            ReloadUsers();
            timer1.Start();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {

        }

        private void ReloadUsers()
        {
            usersList.Items.Clear();
            foreach (var item in Guild.Users)
            {
                usersList.Items.Add(item.Username + " [" + item.Id + "]");
            }
        }

        private void usersList_DoubleClick(object sender, EventArgs e)
        {
            if(usersList.SelectedItems.Count > 0)
            {
                string userId = usersList.SelectedItem.ToString().Split('[').Last().Remove(
                     usersList.SelectedItem.ToString().Split('[').Last().Length - 1);
                if (Guild.GetUser(ulong.Parse(userId)) != null)
                {
                    ManageUser mu = new ManageUser(Guild.GetUser(ulong.Parse(userId)));
                    mu.FormClosing += Mu_FormClosing;
                    mu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error Getting User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Mu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong id;
            try
            {
                id = ulong.Parse(idTextBox.Text);
            }
            catch
            {
                MessageBox.Show("ID In Incorrect Format", "Parse ulong Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Guild.GetUser(id) != null)
            {
                ManageUser mu = new ManageUser(Guild.GetUser(id));
                mu.FormClosing += Mu_FormClosing;
                mu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error Getting User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (usersList.SelectedItems.Count <= 0)
                ReloadUsers();
        }

        private void idTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            ulong id;
            try
            {
                id = ulong.Parse(idTextBox.Text);
            }
            catch
            {
                MessageBox.Show("ID In Incorrect Format", "Parse ulong Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Guild.GetUser(id) != null)
            {
                ManageUser mu = new ManageUser(Guild.GetUser(id));
                mu.FormClosing += Mu_FormClosing;
                mu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error Getting User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReloadUsers();
        }
    }
}
