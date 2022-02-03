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
        public delegate void Notify(string status);
        public event Notify notify;
        public SetBotStatus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notify?.Invoke(textBox1.Text);
            this.Close();
        }
    }
}
