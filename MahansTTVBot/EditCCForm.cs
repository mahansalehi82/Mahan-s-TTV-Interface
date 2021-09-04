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
    public partial class EditCCForm : Form
    {
        CustomCommand CC;
        public EditCCForm(CustomCommand CC)
        {
            this.CC = CC;
            InitializeComponent();
        }

        private void EditCCForm_Load(object sender, EventArgs e)
        {
            ccNameTextBox.Text = CC.Name;
            ccTextTextBox.Text = CC.Command;
            if (CC.Time % 1440 == 0)
            {
                rbHour.Checked = true;
                ccTimeNumeric.Value = CC.Time / 1440;
            }
            else if (CC.Time % 60 == 0)
            {
                rbMin.Checked = true;
                ccTimeNumeric.Value = CC.Time / 60;
            }
            else 
                ccTimeNumeric.Value = CC.Time;
            ccRepeatNumeric.Value = CC.Repeat;
        }

        private void ccAddButton_Click(object sender, EventArgs e)
        {
            CC.Name = ccNameTextBox.Text;
            CC.Command = ccTextTextBox.Text;
            CC.Time = (int)ccTimeNumeric.Value;
            if (rbMin.Checked) CC.Time *= 60;
            else if (rbHour.Checked) CC.Time *= 1440;
            CC.Repeat = (int)ccRepeatNumeric.Value;
            Close();
        }
    }
}
