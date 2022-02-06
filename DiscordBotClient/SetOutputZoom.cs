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
    public partial class SetOutputZoom : Form
    {
        public delegate void SetNotifty(int setValue);
        public event SetNotifty Notify;
        public SetOutputZoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!comboBox1.Text.EndsWith("x")) return;

            int set;
            try
            {
                set = int.Parse(comboBox1.Text.Split('x')[0]);
            }
            catch
            {
                MessageBox.Show("Invalid Value", "Parse Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Notify?.Invoke(set);
            this.Close();
        }
    }
}
