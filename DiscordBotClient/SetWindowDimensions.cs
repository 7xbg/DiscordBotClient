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
    public partial class SetWindowDimensions : Form
    {
        public delegate void Notify(int w, int h);
        public event Notify notify;
        public SetWindowDimensions(int width, int height)
        {
            InitializeComponent();
            textBox1.Text = width.ToString();
            textBox2.Text = height.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(textBox1.Text);
            }
            catch
            {
                textBox1.Text = "";
                MessageBox.Show("Invalid Width Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(textBox2.Text);
            }
            catch
            {
                textBox2.Text = "";
                MessageBox.Show("Invalid Height Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool replacedValue = false;
                if (int.Parse(textBox1.Text) < 450)
                {
                    textBox1.Text = "450";
                    MessageBox.Show("Invalid Width Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    replacedValue = true;
                }

                if (int.Parse(textBox2.Text) < 300)
                {
                    textBox2.Text = "300";
                    MessageBox.Show("Invalid Height Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    replacedValue = true;
                }

                if (replacedValue)
                    return;

                notify?.Invoke(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                this.Close();
            }
            catch
            {

            }
        }
    }
}
