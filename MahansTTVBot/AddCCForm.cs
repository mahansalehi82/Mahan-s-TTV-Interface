using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MahansTTVBot
{
    public partial class AddCCForm : Form
    {
        public AddCCForm()
        {
            InitializeComponent();
        }

        private void ccAddButton_Click(object sender, EventArgs e)
        {
            CustomCommand cc = new CustomCommand() {
                Name = ccNameTextBox.Text,
                Command = ccTextTextBox.Text
            };
            cc.Time = (int)ccTimeNumeric.Value;
            if (rbMin.Checked) cc.Time *= 60;
            else if (rbHour.Checked) cc.Time *= 1440;
            cc.Repeat = (int)ccRepeatNumeric.Value;
            Form1.CCs.Add(cc);
            Close();
        }

        private void AddCCForm_Load(object sender, EventArgs e)
        {

        }
    }
}
