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
    public partial class WaitInit : Form
    {
        public int secsLeft = 9;
        public WaitInit()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void WaitInit_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(secsLeft <= 0)
            {
                this.Close();
            }
            else
            {
                waitingLabel.Text = secsLeft + "s";
                secsLeft--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
