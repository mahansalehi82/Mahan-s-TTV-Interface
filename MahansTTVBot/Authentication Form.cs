using System;
using System.IO;
using System.Windows.Forms;

namespace MahansTTVBot
{
    public partial class Authentication_Form : Form
    {
        static string settingsPath = "settings.mah";
        public Authentication_Form()
        {
            InitializeComponent();
        }

        private void Authentication_Form_Load(object sender, EventArgs e)
        {
            if (File.Exists(settingsPath))
            {
                string[] settings = File.ReadAllLines(settingsPath);
                if (settings.Length < 3) return;
                textBox1.Text = settings[0];
                textBox2.Text = settings[1];
                textBox3.Text = settings[2];
            }
        }

        private void AuthenticateButton_Click(object sender, EventArgs e)
        {
            Form1.botName = textBox1.Text.ToLower();
            Form1.token = (textBox2.Text.StartsWith("oauth:") ? textBox2.Text: "oauth:" + textBox2.Text);
            Form1.channelName = textBox3.Text;
            File.WriteAllLines(settingsPath , new string[]{ textBox1.Text.ToLower(), textBox2.Text, textBox3.Text.ToLower()});
            Form1 f1 = new Form1();
            Hide();
            f1.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitchapps.com/tmi/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
                textBox2.PasswordChar = '⬤';
            else
                textBox2.PasswordChar = '\0';
        }
    }
}
