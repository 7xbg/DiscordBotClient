using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DiscordBotClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm(maskedTextBox1.Text, checkBox1.Checked);
            mf.OnExit += Mf_OnExit;
            mf.Show();
            this.Hide();
        }

        private void Mf_OnExit()
        {
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Token File";
            ofd.Multiselect = false;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                MainForm mf = new MainForm(File.ReadAllText(ofd.FileName), checkBox1.Checked);
                mf.OnExit += Mf_OnExit;
                mf.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.PasswordChar = checkBox2.Checked ? '\0' : 'x';
        }
    }
}
