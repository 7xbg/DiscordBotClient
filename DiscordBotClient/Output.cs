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
    public partial class Output : Form
    {
        public static Output Instance;

        public Output()
        {
            InitializeComponent();
            this.MinimumSize = new Size(200, 200);
        }

        private void Output_Resize(object sender, EventArgs e)
        {
            richTextBox1.Size = new Size(this.Width - 40, this.Height - 86);
        }

        public void WriteToOutput(LogMessage arg)
        {
            string severity = arg.Severity.ToString();
            richTextBox1.Text = severity + ": " + arg.Message + "\n";
        }

        private void Output_Load(object sender, EventArgs e)
        {

        }

        private void setZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetOutputZoom soz = new SetOutputZoom();
            soz.Notify += Soz_Notify;
            soz.Show();
            this.Hide();
        }

        private void Soz_Notify(int setValue)
        {
            this.Show();
            try
            {
                richTextBox1.ZoomFactor = setValue;
            }
            catch
            {
                MessageBox.Show("Invalid Set Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.ZoomFactor = 1;
            }
        }
    }
}
