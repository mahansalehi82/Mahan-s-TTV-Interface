using System;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Collections.Generic;

namespace MahansTTVBot
{
    public partial class Form1 : Form
    {

        public static string botName, channelName, token;
        static string ip = "irc.chat.twitch.tv";
        static int port = 6667;
        public static StreamWriter streamWriter;
        public static StreamReader streamReader;
        static TcpClient tcpClient = new TcpClient();
        static string ccPath = "CustomCommands.mah";
        static string keyword = "fhdsohfjdshkfj";
        public static List<CustomCommand> CCs;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Left = (this.ClientSize.Width - progressBar1.Width) / 2;
            progressBar1.Top = (this.ClientSize.Height - progressBar1.Height) / 2;
            CCs = CustomCommand.readCCFiles(ccPath);
            updateCCsListBox();
            Initialize();
        }
        // Emote Only CB
        private async void EOcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                await SendMessage(channelName, "/emoteonly");
                Console.WriteLine($"Emote only : On #{channelName}");
            }
            else
            {
                await SendMessage(channelName, "/emoteonlyoff");
                Console.WriteLine($"Emote only : Off #{channelName}");
            }
        }
        // Followers Only CB
        private async void FOcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                await SendMessage(channelName, "/followers");
                Console.WriteLine($"Followers only : On #{channelName}");
            }
            else
            {
                await SendMessage(channelName, "/followersoff");
                Console.WriteLine($"Followers only : Off #{channelName}");
            }
        }
        // Subscribers Only CB
        private async void SOcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                await SendMessage(channelName, "/subscribers");
                Console.WriteLine($"Subscribers only : On #{channelName}");
            }
            else
            {
                await SendMessage(channelName, "/subscribersoff");
                Console.WriteLine($"Subscribers only : Off #{channelName}");
            }
        }
        // Slowmode Function
        private async void slowModeApply_Click(object sender, EventArgs e)
        {
            if (slowModeTime.Value > 0)
            {
                await SendMessage(channelName, @"/slow {slowModeTime.Value.ToString()}");
                Console.WriteLine($"Slowmode [{slowModeTime.Value.ToString()}] : On #{channelName}");
            }
            else
            {
                await SendMessage(channelName, "/slowoff");
                Console.WriteLine($"Slowmode off [{slowModeTime.Value.ToString()}] : On #{channelName}");
            }
        }
        // Closing the main form aswell
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // Main Bot Function
        async void Initialize()
        {
            try
            {
                //await streamWriter.WriteLineAsync($"ROOMSTATE #mahansbot");
                //await streamWriter.WriteLineAsync("PRIVMSG #mahansbot :Fuck Ya'll");
                await Login(botName, token, channelName, ip, port);
                while (true)
                {
                    await mainFunction();
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Message Mahan the screenshot in order to debug this error : \n" + Ex.Message);
                Application.Restart();
            }
        }
        async Task mainFunction()
        {
            string input = await streamReader.ReadLineAsync();
            Console.WriteLine("TWITCH RESPONSES :: " + input);
            if (input.Length == 0) return;
            string[] text = input.Split(' ');
            if (input.StartsWith("PING"))
            {
                await Pong(text[1]);
                Console.WriteLine("Ping Respond Succesful");
            }
            else if (text.Length > 2 && text[2] == "ROOMSTATE")
            {
                await parseCCs();
                await parseRoomState(text[0]);
            }
            if (text.Length > 4 && text[2] == "PRIVMSG" && getUsername1(text[1]) == "waitiiing")
            {
                await SendMessage(channelName, "@waitiiing cringe");
            }
            else if (nukeCheckBox.Checked && text.Length > 4 && text[2] == "PRIVMSG" && text[4].ToLower().Contains(keyword))
            {
                int banTime = 0;
                if (radioButton1.Checked) banTime = 600;
                else if (radioButton2.Checked) banTime = 3600;
                else if (radioButton3.Checked) banTime = 86400;
                else if (radioButton4.Checked) banTime = (int)numericUpDown1.Value * 60;
                await SendMessage(channelName, @"/timeout {getUsername1(text[1])} {banTime}");
                Console.WriteLine($"/timeout {getUsername1(text[1])} {banTime}");
            }
        }
        // ROOMSTATE parser (For determining the initial UI modules state
        async Task parseRoomState(string roomState)
        {
            if (roomState.Length == 0) return;
            string[] states = roomState.Split(';');
            for (int i = 0; i < states.Length;i++)
            {
                string s = states[i].Trim('@');
                if (s.StartsWith("emote-only"))
                    EOcheckBox.Checked = s[11] == '1';
                if (s.StartsWith("followers-only"))
                    FOcheckBox.Checked = s[15] == '1';
                if (s.StartsWith("subs-only"))
                    SOcheckBox.Checked = s[10] == '1';
                if (s.StartsWith("slow"))
                    slowModeTime.Value = int.Parse(s.Substring(s.IndexOf('=') + 1, s.Length - s.IndexOf('=') - 1));
            }
            progressBar1.Visible = false;
            tabControl1.Visible = true;
        }
        // Gets Username from format @username!
        static string getUsername1(string Username)
        {
            return Username.Substring(1, Username.IndexOf('!') - 1).ToLower();
        }
        // Gets CCs from the ccPath file
        async Task parseCCs()
        {
            if (!File.Exists(ccPath)) return;
            string[] customCs = File.ReadAllLines(ccPath);
        }
        // Executes the specified CC
        async void executeCC(int i)
        {
            //await streamWriter.WriteLineAsync($"PRIVMSG #{channelName} :{CCs[i]}");
            //Console.WriteLine($"CC {CCs[i]} was executed");
            //File.WriteAllLines(ccPath, CCs);
        }

        private void ccAddButton_Click(object sender, EventArgs e)
        {
            AddCCForm accf = new AddCCForm();
            accf.ShowDialog();
            CustomCommand.updateCCs(ccPath, CCs);
            updateCCsListBox();
        }

        private void updateCCsListBox()
        {
            ccCheckedListBox.Items.Clear();
            for (int i = 0; i < CCs.Count; i++)
                ccCheckedListBox.Items.Add(CCs[i].Name, CCs[i].Active);
            
        }

        private void ccEditButton_Click(object sender, EventArgs e)
        {
            int index = ccCheckedListBox.SelectedIndex;
            if (index == -1) {
                MessageBox.Show("There is either nothing to edit or you haven't selected anything");
                return;
            }
            if (CCs[index].Active)
            {
                MessageBox.Show("Deactivate the command before editing");
                return;
            }
            EditCCForm eccf = new EditCCForm(CCs[index]);
            eccf.ShowDialog();
            CustomCommand.updateCCs(ccPath, CCs);
            updateCCsListBox();
        }

        private void ccDeleteButton_Click(object sender, EventArgs e)
        {
            int index = ccCheckedListBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("There is either nothing to delete or you haven't selected anything");
                return;
            }
            if (CCs[index].Active)
            {
                MessageBox.Show("Deactivate the command before deleting");
                return;
            }
            CCs.RemoveAt(index);
            CustomCommand.updateCCs(ccPath, CCs);
            updateCCsListBox();
        }

        bool nukeCheckBoxMC = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(nukeCheckBoxMC)
            {
                nukeCheckBoxMC = false;
                return;
            }
            if (textBox1.Text.Length < 3)
            {
                MessageBox.Show("The keyword must be at least 3 letters");
                nukeCheckBoxMC = true;
                nukeCheckBox.Checked = false;
            }
            
            if (nukeCheckBox.Checked)
            {
                nukeCheckBox.Text = "Nuke On";
                keyword = textBox1.Text.ToLower();
            }
            else
                nukeCheckBox.Text = "Nuke Off";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = radioButton4.Checked;
        }

        public static async Task SendMessage(string channelName, string message)
        {
            await streamWriter.WriteLineAsync("PRIVMSG #" + channelName + " :" + message);
        }

        private void ccCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int index = e.Index;
            if(e.NewValue == CheckState.Checked)
                CCs[index].Activate();
            else
                CCs[index].Deactivate();
        }

        public static async Task Login(string botName, string token, string channelName, string ip, int port)
        {
            await tcpClient.ConnectAsync(ip, port);
            streamReader = new StreamReader(tcpClient.GetStream());
            streamWriter = new StreamWriter(tcpClient.GetStream()) { NewLine = "\r\n", AutoFlush = true };
            await streamWriter.WriteLineAsync("CAP REQ :twitch.tv/tags twitch.tv/commands");
            await streamWriter.WriteLineAsync($"PASS {token}");
            await streamWriter.WriteLineAsync($"NICK {botName}");
            await streamWriter.WriteLineAsync($"JOIN #{channelName}");
        }

        public static async Task Pong(string text)
        {
            await streamWriter.WriteLineAsync("PONG " + text);
        }
    }
}
