using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBotClient
{
    public partial class MainForm : Form
    {
        public delegate void Notify();
        public event Notify OnExit;
        private static string TOKEN;
        private static bool LOGINCHECK = true;
        public MainForm(string token, bool loginCheck)
        {
            TOKEN = token;
            if (loginCheck)
                LOGINCHECK = false;

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(450, 300);
            Thread thr = new Thread(new ThreadStart(startbot));
            thr.Start();

            Thread.Sleep(1500);
            if (LOGINCHECK)
            {
                if (_client.CurrentUser == null)
                {
                    MessageBox.Show("Invalid Token", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Process.GetCurrentProcess().Kill();
                }
                else
                {
                    foreach (SocketGuild sg in _client.Guilds)
                    {
                        serverList.Items.Add(sg.Name + " [" + sg.Id + "]");
                    }
                }
            }
        }

        private void startbot()
        {
            RunBotAsync().GetAwaiter().GetResult();
        }

        private DiscordSocketClient _client;
        private CommandService _commands;
        private IServiceProvider _services;

        public async Task RunBotAsync()
        {
            _client = new DiscordSocketClient();
            _commands = new CommandService();

            _services = new ServiceCollection()
                .AddSingleton(_client)
                .AddSingleton(_commands)
                .BuildServiceProvider();

            string token = TOKEN;

            _client.Log += _client_Log;

            await RegisterCommandsAsync();
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
            await Task.Delay(-1);
        }

        private Task _client_Log(LogMessage arg)
        {
            return Task.CompletedTask;
        }

        public async Task RegisterCommandsAsync()
        {
            _client.MessageReceived += HandleCommandAsync;
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _services);
        }

        private async Task HandleCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;
            var context = new SocketCommandContext(_client, message);
            if (message.Author.IsBot) return;

            int argPos = 0;
            if (message.HasStringPrefix("!", ref argPos))
            {
                var result = await _commands.ExecuteAsync(context, argPos, _services);
                if (!result.IsSuccess) Console.WriteLine(result.ErrorReason);
                if (result.Error.Equals(CommandError.UnmetPrecondition)) await message.Channel.SendMessageAsync(result.ErrorReason);
            }

            chatBox.BeginInvoke(new Action(() =>
            {
                if (context.User.IsBot)
                    chatBox.AppendText("[" + context.User.Username + " [BOT]]: " + context.Message + "\n");
                else
                    chatBox.AppendText("[" + context.User.Username + "]: " + context.Message + "\n");
            }));
        }

        private SocketGuild selectedGuild;
        private SocketGuildChannel selectedChannel;
        private void serverList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedGuild == null)
            {
                foreach (SocketGuild sg in _client.Guilds)
                {
                    if (serverList.SelectedItem != null)
                    {
                        if (serverList.SelectedItem.ToString() == sg.Name + " [" + sg.Id + "]")
                            selectedGuild = sg;
                    }
                }

                if (selectedGuild != null)
                    selectedServerLabel.Text = selectedGuild.Name + "'s Channels";

                serverList.Items.Clear();

                if (selectedGuild != null)
                {
                    foreach (SocketGuildChannel sgc in selectedGuild.Channels)
                    {
                        if (sgc.GetChannelType() == ChannelType.Text || sgc.GetChannelType() == ChannelType.Group || sgc.GetChannelType() == ChannelType.DM)
                            serverList.Items.Add(sgc.Name + " [" + sgc.Id + "]");
                    }
                }
                else
                {
                    MessageBox.Show("Error Showing Channels\n(just try a few more times)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    foreach (SocketGuild sg in _client.Guilds)
                    {
                        serverList.Items.Add(sg.Name + " [" + sg.Id + "]");
                    }
                }

                backButton.Enabled = true;
            }
            else if (selectedChannel == null)
            {
                foreach (SocketGuildChannel sgc in selectedGuild?.Channels)
                {
                    if (serverList.SelectedItem != null)
                    {
                        if (serverList.SelectedItem.ToString() == sgc.Name + " [" + sgc.Id + "]")
                            selectedChannel = sgc;
                    }
                }

                serverList.Items.Clear();
                serverList.Items.Add("Channel Selected!");
                sendButton.Enabled = true;
            }
            else
            {

            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (_client == null) return;
            if (selectedGuild == null) return;
            if (selectedChannel == null) return;

            selectedGuild.GetTextChannel(selectedChannel.Id).SendMessageAsync(messageBox.Text);
            chatBox.BeginInvoke(new Action(() =>
            {
                chatBox.AppendText("[" + _client.CurrentUser.Username + " [BOT]]: " + messageBox.Text + "\n");
            }));

            messageBox.BeginInvoke(new Action(() =>
            {
                messageBox.Text = "";
            }));
        }

        private void messageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (selectedGuild == null) return;
                if (selectedChannel == null) return;

                selectedGuild.GetTextChannel(selectedChannel.Id).SendMessageAsync(messageBox.Text);
                chatBox.BeginInvoke(new Action(() =>
                {
                    chatBox.AppendText("[" + _client.CurrentUser.Username + " [BOT]]: " + messageBox.Text + "\n");
                }));

                messageBox.BeginInvoke(new Action(() =>
                {
                    messageBox.Text = "";
                }));
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to keep this running in the background\n(keeps bot online)?", "Before you leave", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
                this.Hide();
            else if (dr == DialogResult.No)
                OnExit?.Invoke();
            else if (dr == DialogResult.Cancel)
                e.Cancel = true;

            //Process.GetCurrentProcess().Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedChannel != null)
            {
                selectedChannel = null;
                sendButton.Enabled = false;
                chatBox.BeginInvoke(new Action(() =>
                {
                    chatBox.Text = "";
                }));

                serverList.Items.Clear();

                if (selectedGuild != null)
                {
                    foreach (SocketGuildChannel sgc in selectedGuild.Channels)
                    {
                        if (sgc.GetChannelType() == ChannelType.Text || sgc.GetChannelType() == ChannelType.Group || sgc.GetChannelType() == ChannelType.DM)
                            serverList.Items.Add(sgc.Name + " [" + sgc.Id + "]");
                    }
                }
                else
                {
                    MessageBox.Show("Error Showing Channels\n(just try a few more times)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    foreach (SocketGuild sg in _client.Guilds)
                    {
                        serverList.Items.Add(sg.Name + " [" + sg.Id + "]");
                    }
                }
            }
            else if (selectedGuild != null)
            {
                selectedGuild = null;
                sendButton.Enabled = false;
                backButton.Enabled = false;
                selectedServerLabel.Text = "Servers:";
                chatBox.BeginInvoke(new Action(() =>
                {
                    chatBox.Text = "";
                }));

                serverList.Items.Clear();
                foreach (SocketGuild sg in _client.Guilds)
                {
                    serverList.Items.Add(sg.Name + " [" + sg.Id + "]");
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*_client.LogoutAsync();
            serverList.Items.Clear();
            _commands = null;
            _services = null;
            selectedGuild = null;
            selectedChannel = null;
            TOKEN = string.Empty;
            OnExit?.Invoke();*/
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            sendButton.Location = new System.Drawing.Point(this.Width - 107, this.Height - 71);
            messageBox.Size = new System.Drawing.Size(this.Width - 333, 20);
            chatBox.Size = new System.Drawing.Size(this.Width - 252, this.Height - 125);

            serverList.Size = new System.Drawing.Size(199, this.Height - 126);
            messageBox.Location = new System.Drawing.Point(221, this.Height - 71);
            backButton.Location = new System.Drawing.Point(11, this.Height - 69);

            this.Text = "dbc main - w = " + this.Width + " | h = " + this.Height + "";
        }

        private void setChatBoxZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetZoom sz = new SetZoom();
            sz.Notify += Sz_Notify;
            sz.Show();
        }

        private void Sz_Notify(int setValue)
        {
            try
            {
                chatBox.ZoomFactor = setValue;
            }
            catch
            {

            }
        }

        private void Sbs_notify(string status)
        {
            _client.SetGameAsync(status);
        }

        private void Sbws_SetBotWatchingStatusNotify(string status, string watching)
        {
            _client.SetGameAsync(status, watching);
        }

        private void Sbs_OnNotify(UserStatus ustatus)
        {
            _client.SetStatusAsync(ustatus);
        }

        private void Sn_notify(string nickname)
        {
            if (selectedGuild != null)
            {
                var user = selectedGuild.GetUser(_client.CurrentUser.Id);
                user.ModifyAsync(x =>
                {
                    x.Nickname = nickname;
                });
            }
            else
            {
                MessageBox.Show("Server not selected", "Error Setting Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setWindowDimensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetWindowDimensions swd = new SetWindowDimensions(this.Width, this.Height);
            swd.notify += Swd_notify;
            swd.ShowDialog();
        }

        private void Swd_notify(int w, int h)
        {
            this.Width = w;
            this.Height = h;
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setBotStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBotStatus sbs = new SetBotStatus();
            sbs.notify += Sbs_notify;
            sbs.ShowDialog();
        }

        private void setBotWatchingStatusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetBotWatchingStatus sbws = new SetBotWatchingStatus();
            sbws.SetBotWatchingStatusNotify += Sbws_SetBotWatchingStatusNotify;
            sbws.ShowDialog();
        }

        private void setBotStatusOtherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetBotStatusOther sbs = new SetBotStatusOther();
            sbs.OnNotify += Sbs_OnNotify;
            sbs.ShowDialog();
        }

        private void setBotNicknameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (selectedGuild != null)
            {
                SetNickname sn = new SetNickname();
                sn.notify += Sn_notify;
                sn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Server not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abt = new About(_client);
            abt.FormClosing += Abt_FormClosing;
            abt.Show();
            this.Hide();
        }

        private void Abt_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
