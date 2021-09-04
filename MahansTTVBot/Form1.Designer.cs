namespace MahansTTVBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.slowModeApply = new System.Windows.Forms.Button();
            this.slowModeTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SOcheckBox = new System.Windows.Forms.CheckBox();
            this.EOcheckBox = new System.Windows.Forms.CheckBox();
            this.FOcheckBox = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ccCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ccAddButton = new System.Windows.Forms.Button();
            this.ccDeleteButton = new System.Windows.Forms.Button();
            this.ccEditButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nukeCheckBox = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slowModeTime)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.slowModeApply);
            this.groupBox1.Controls.Add(this.slowModeTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SOcheckBox);
            this.groupBox1.Controls.Add(this.EOcheckBox);
            this.groupBox1.Controls.Add(this.FOcheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(23, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat Options";
            // 
            // slowModeApply
            // 
            this.slowModeApply.FlatAppearance.BorderSize = 2;
            this.slowModeApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slowModeApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slowModeApply.Location = new System.Drawing.Point(289, 198);
            this.slowModeApply.Name = "slowModeApply";
            this.slowModeApply.Size = new System.Drawing.Size(77, 31);
            this.slowModeApply.TabIndex = 6;
            this.slowModeApply.Text = "Apply";
            this.slowModeApply.UseVisualStyleBackColor = true;
            this.slowModeApply.Click += new System.EventHandler(this.slowModeApply_Click);
            // 
            // slowModeTime
            // 
            this.slowModeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slowModeTime.Location = new System.Drawing.Point(159, 198);
            this.slowModeTime.Name = "slowModeTime";
            this.slowModeTime.Size = new System.Drawing.Size(120, 31);
            this.slowModeTime.TabIndex = 5;
            this.slowModeTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Slow Mode";
            // 
            // SOcheckBox
            // 
            this.SOcheckBox.AutoSize = true;
            this.SOcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOcheckBox.Location = new System.Drawing.Point(148, 120);
            this.SOcheckBox.Name = "SOcheckBox";
            this.SOcheckBox.Size = new System.Drawing.Size(119, 29);
            this.SOcheckBox.TabIndex = 3;
            this.SOcheckBox.Text = "Sub Only";
            this.SOcheckBox.UseVisualStyleBackColor = true;
            this.SOcheckBox.CheckedChanged += new System.EventHandler(this.SOcheckBox_CheckedChanged);
            // 
            // EOcheckBox
            // 
            this.EOcheckBox.AutoSize = true;
            this.EOcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EOcheckBox.Location = new System.Drawing.Point(260, 53);
            this.EOcheckBox.Name = "EOcheckBox";
            this.EOcheckBox.Size = new System.Drawing.Size(142, 29);
            this.EOcheckBox.TabIndex = 2;
            this.EOcheckBox.Text = "Emote Only";
            this.EOcheckBox.UseVisualStyleBackColor = true;
            this.EOcheckBox.CheckedChanged += new System.EventHandler(this.EOcheckBox_CheckedChanged);
            // 
            // FOcheckBox
            // 
            this.FOcheckBox.AutoSize = true;
            this.FOcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOcheckBox.Location = new System.Drawing.Point(11, 53);
            this.FOcheckBox.Name = "FOcheckBox";
            this.FOcheckBox.Size = new System.Drawing.Size(173, 29);
            this.FOcheckBox.TabIndex = 1;
            this.FOcheckBox.Text = "Followers Only";
            this.FOcheckBox.UseVisualStyleBackColor = true;
            this.FOcheckBox.CheckedChanged += new System.EventHandler(this.FOcheckBox_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(425, -12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 29);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Value = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ccCheckedListBox);
            this.groupBox2.Controls.Add(this.ccAddButton);
            this.groupBox2.Controls.Add(this.ccDeleteButton);
            this.groupBox2.Controls.Add(this.ccEditButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(459, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 258);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Commands";
            // 
            // ccCheckedListBox
            // 
            this.ccCheckedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ccCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccCheckedListBox.ForeColor = System.Drawing.Color.White;
            this.ccCheckedListBox.FormattingEnabled = true;
            this.ccCheckedListBox.Location = new System.Drawing.Point(9, 33);
            this.ccCheckedListBox.Name = "ccCheckedListBox";
            this.ccCheckedListBox.ScrollAlwaysVisible = true;
            this.ccCheckedListBox.Size = new System.Drawing.Size(487, 172);
            this.ccCheckedListBox.TabIndex = 12;
            this.ccCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ccCheckedListBox_ItemCheck);
            // 
            // ccAddButton
            // 
            this.ccAddButton.FlatAppearance.BorderSize = 2;
            this.ccAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ccAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccAddButton.Location = new System.Drawing.Point(297, 211);
            this.ccAddButton.Name = "ccAddButton";
            this.ccAddButton.Size = new System.Drawing.Size(77, 31);
            this.ccAddButton.TabIndex = 10;
            this.ccAddButton.Text = "Add";
            this.ccAddButton.UseVisualStyleBackColor = true;
            this.ccAddButton.Click += new System.EventHandler(this.ccAddButton_Click);
            // 
            // ccDeleteButton
            // 
            this.ccDeleteButton.FlatAppearance.BorderSize = 2;
            this.ccDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ccDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccDeleteButton.Location = new System.Drawing.Point(131, 211);
            this.ccDeleteButton.Name = "ccDeleteButton";
            this.ccDeleteButton.Size = new System.Drawing.Size(77, 31);
            this.ccDeleteButton.TabIndex = 8;
            this.ccDeleteButton.Text = "Delete";
            this.ccDeleteButton.UseVisualStyleBackColor = true;
            this.ccDeleteButton.Click += new System.EventHandler(this.ccDeleteButton_Click);
            // 
            // ccEditButton
            // 
            this.ccEditButton.FlatAppearance.BorderSize = 2;
            this.ccEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ccEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccEditButton.Location = new System.Drawing.Point(214, 211);
            this.ccEditButton.Name = "ccEditButton";
            this.ccEditButton.Size = new System.Drawing.Size(77, 31);
            this.ccEditButton.TabIndex = 7;
            this.ccEditButton.Text = "Edit";
            this.ccEditButton.UseVisualStyleBackColor = true;
            this.ccEditButton.Click += new System.EventHandler(this.ccEditButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.nukeCheckBox);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(23, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(938, 173);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nuke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(623, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Keyword";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(724, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 31);
            this.textBox1.TabIndex = 7;
            // 
            // nukeCheckBox
            // 
            this.nukeCheckBox.AutoSize = true;
            this.nukeCheckBox.Location = new System.Drawing.Point(724, 62);
            this.nukeCheckBox.Name = "nukeCheckBox";
            this.nukeCheckBox.Size = new System.Drawing.Size(141, 35);
            this.nukeCheckBox.TabIndex = 6;
            this.nukeCheckBox.Text = "Nuke Off";
            this.nukeCheckBox.UseVisualStyleBackColor = true;
            this.nukeCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(353, 126);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(148, 31);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(154, 126);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(193, 29);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "Custom(Minutes)";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(154, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 29);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "A day";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(11, 126);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 29);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "An hour";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(11, 68);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 29);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "10 Mins";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "It\'s never a bad time to nuke some people";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 493);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(978, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Moderating";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(978, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Help";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(899, 455);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1012, 520);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mahan\'s Bot Interface";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slowModeTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button slowModeApply;
        private System.Windows.Forms.NumericUpDown slowModeTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SOcheckBox;
        private System.Windows.Forms.CheckBox EOcheckBox;
        private System.Windows.Forms.CheckBox FOcheckBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox nukeCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ccAddButton;
        private System.Windows.Forms.Button ccDeleteButton;
        private System.Windows.Forms.Button ccEditButton;
        private System.Windows.Forms.CheckedListBox ccCheckedListBox;
    }
}

