using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MahansTTVBot
{

    public class CustomCommand :IComparable
    {
        public string Name, Command;
        public int Time, Repeat;
        int Count = 0;
        public bool Active = false;
        Timer timer;
        public static List<CustomCommand> readCCFiles(string path)
        {
            List<CustomCommand> CCs = new List<CustomCommand>();
            if (!File.Exists(path)) return CCs;
            string[] lines = File.ReadAllLines(path);
            for (int i = 1, j = 0; i < lines.Length; j++)
            {
                CCs.Add(new CustomCommand());
                CustomCommand cc = CCs.Last();
                cc.Name = lines[i++];
                cc.Command = "";
                cc.Time = int.Parse(lines[i++]);
                cc.Repeat = int.Parse(lines[i++]);
                
                for (; !lines[i].StartsWith("END OF CC"); i++)
                    cc.Command += lines[i] + "\r\n";
                i++;
            }
            return CCs;
        }

        int IComparable.CompareTo(object obj)
        {
            CustomCommand cc = (CustomCommand)obj;
            return string.Compare(Name, cc.Name);
        }

        public void Activate()
        {
            Active = true;
            timer = new Timer();
            timer.Interval = Time * 1000;
            timer.Tick += Timer_Tick;
            TimerTickF();
            timer.Start();
        }

        public void Deactivate()
        {
            timer.Stop();
            Active = false;
        }

        async void Timer_Tick(object sender, EventArgs e)
        {
            await TimerTickF();
        }


        async Task TimerTickF()
        {
            await Form1.SendMessage(Form1.channelName, Command);
            Count++;
            if (Repeat != 0 && Count == Repeat)
                Deactivate();
        }
        public static void updateCCs(string path, List<CustomCommand> CCs)
        {
            CCs.Sort();
            File.WriteAllText(path, Program.version + "\r\n");
            foreach(CustomCommand cc in CCs)
            {
                File.AppendAllText(path, cc.Name + "\r\n");
                File.AppendAllText(path, cc.Time + "\r\n");
                File.AppendAllText(path, cc.Repeat + "\r\n");
                File.AppendAllText(path, cc.Command + "\r\n");
                File.AppendAllText(path, "END OF CC\r\n");
            }
        }
    }
}
