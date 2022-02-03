using Discord;
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

namespace DiscordBotClient
{
    public partial class About : Form
    {
        public About(IDiscordClient client)
        {
            try
            {
                string url = client.GetUserAsync(715891837138632744).Result.GetAvatarUrl();

                System.Net.WebRequest request = System.Net.WebRequest.Create(url);
                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();
                Bitmap bitmap = new Bitmap(responseStream);

                InitializeComponent();
                pictureBox1.Image = bitmap;
            }
            catch
            {
                MessageBox.Show("Error Initalizing", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/7xbg");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/7xbg/DiscordBotClient");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/SanjaySunil/BetterDiscordPanel");
        }
    }
}
