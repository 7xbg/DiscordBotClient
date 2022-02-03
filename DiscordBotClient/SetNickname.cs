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
    public partial class SetNickname : Form
    {
        public delegate void Notify(string nickname);
        public event Notify notify;
        public SetNickname()
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
