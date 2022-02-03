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
    public partial class SetBotStatusOther : Form
    {
        public delegate void Notify(UserStatus ustatus);
        public event Notify OnNotify;
        public SetBotStatusOther()
        {
            InitializeComponent();
        }

        private void SetBotStatusOther_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserStatus ustatus;
            if (comboBox1.Text == "Online")
                ustatus = UserStatus.Online;
            else if (comboBox1.Text == "Invisible")
                ustatus = UserStatus.Offline;
            else if (comboBox1.Text == "DND (do not disturb)")
                ustatus = UserStatus.DoNotDisturb;
            else if (comboBox1.Text == "Idle")
                ustatus = UserStatus.Idle;
            else
            {
                MessageBox.Show("Invalid Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OnNotify?.Invoke(ustatus);
            this.Close();
        }

        private void SetBotStatusOther_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
