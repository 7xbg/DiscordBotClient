using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBotClient.ManageUsers
{
    public partial class ManageUser : Form
    {
        private SocketGuildUser _user;
        private string avatarURL;
        public ManageUser(SocketGuildUser user)
        {
            InitializeComponent();
            try
            {
                if (user == null)
                {
                    MessageBox.Show("Invalid User Passed Through", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _user = user;

                string url = user.GetAvatarUrl();
                avatarURL = url;

                System.Net.WebRequest request = System.Net.WebRequest.Create(url);
                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();
                Bitmap bitmap = new Bitmap(responseStream);


                timer1.Interval = 1000;
                timer1.Start();

                this.Text = "Manage " + user.Username;
                userIdLabel.Text = user.Id.ToString();
                if(user.Nickname != null)
                    nicknameLabel.Text = "Nickname: " + user.Nickname.ToString();

                createdAtLabel.Text = "Account Created At: " + user.CreatedAt.ToString();
                if (user.IsBot)
                {
                    botLabel.Text = "Is Bot";
                    botLabel.BackColor = System.Drawing.Color.Red;
                }

                foreach (var perm in user.GuildPermissions.ToList())
                {
                    permissionsList.Items.Add(perm);
                }

                ReloadRoles();

                pictureBox1.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(avatarURL);
        }

        private void userIdLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(userIdLabel.Text);
            MessageBox.Show("Copied ID to Clipboard", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReloadRoles()
        {
            roleList.Items.Clear();
            foreach (var role in _user.Roles.ToList())
            {
                roleList.Items.Add(role.Name + " [" + role.Id + "]");
            }
        }

        private void roleList_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if (roleList.SelectedItems.Count <= 0) return;

                ContextMenu menu = new ContextMenu();
                MenuItem removeItem = new MenuItem();
                removeItem.Text = "Remove";
                removeItem.Click += RemoveItem_Click;
                menu.MenuItems.Add(removeItem);
                menu.Show(this, new Point(e.X, e.Y));
            }
        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            if (roleList.SelectedItems.Count <= 0) return;

            string roleId = roleList.SelectedItem.ToString().Split('[').Last().Remove(
                roleList.SelectedItem.ToString().Split('[').Last().Length - 1);
            _user.RemoveRoleAsync(ulong.Parse(roleId));
            ReloadRoles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KickUser ku = new KickUser();
            ku.KickUserReasonSet += Ku_KickUserReasonSet;
            ku.Show();
            this.Hide();
        }

        private void Ku_KickUserReasonSet(string reason)
        {
            this.Show();
            KickUser(reason);
        }

        private async void KickUser(string reason)
        {
            try
            {
                await _user.KickAsync(reason);
                MessageBox.Show("Kicked User", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error Kicking User (higher role then you?)", "Kick Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(roleList.SelectedItems.Count <= 0)
                ReloadRoles();
        }

        private void roleList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
