namespace MahansTTVBot
{
    partial class AddCCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCCForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ccAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ccRepeatNumeric = new System.Windows.Forms.NumericUpDown();
            this.ccTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.ccTextTextBox = new System.Windows.Forms.TextBox();
            this.ccNameTextBox = new System.Windows.Forms.TextBox();
            this.rbSec = new System.Windows.Forms.RadioButton();
            this.rbMin = new System.Windows.Forms.RadioButton();
            this.rbHour = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccRepeatNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccTimeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbHour);
            this.groupBox2.Controls.Add(this.rbMin);
            this.groupBox2.Controls.Add(this.rbSec);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ccAddButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ccRepeatNumeric);
            this.groupBox2.Controls.Add(this.ccTimeNumeric);
            this.groupBox2.Controls.Add(this.ccTextTextBox);
            this.groupBox2.Controls.Add(this.ccNameTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 408);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Custom Command";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Repeat for  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Repeat every :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Command/Text :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "CC Name :";
            // 
            // ccAddButton
            // 
            this.ccAddButton.FlatAppearance.BorderSize = 2;
            this.ccAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ccAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccAddButton.Location = new System.Drawing.Point(280, 351);
            this.ccAddButton.Name = "ccAddButton";
            this.ccAddButton.Size = new System.Drawing.Size(105, 44);
            this.ccAddButton.TabIndex = 11;
            this.ccAddButton.Text = "Add";
            this.ccAddButton.UseVisualStyleBackColor = true;
            this.ccAddButton.Click += new System.EventHandler(this.ccAddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Set to 0 for infinite repeat";
            // 
            // ccRepeatNumeric
            // 
            this.ccRepeatNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccRepeatNumeric.Location = new System.Drawing.Point(183, 301);
            this.ccRepeatNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ccRepeatNumeric.Name = "ccRepeatNumeric";
            this.ccRepeatNumeric.Size = new System.Drawing.Size(120, 31);
            this.ccRepeatNumeric.TabIndex = 3;
            // 
            // ccTimeNumeric
            // 
            this.ccTimeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccTimeNumeric.Location = new System.Drawing.Point(183, 264);
            this.ccTimeNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ccTimeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ccTimeNumeric.Name = "ccTimeNumeric";
            this.ccTimeNumeric.Size = new System.Drawing.Size(120, 31);
            this.ccTimeNumeric.TabIndex = 2;
            this.ccTimeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ccTextTextBox
            // 
            this.ccTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccTextTextBox.Location = new System.Drawing.Point(183, 74);
            this.ccTextTextBox.Multiline = true;
            this.ccTextTextBox.Name = "ccTextTextBox";
            this.ccTextTextBox.Size = new System.Drawing.Size(398, 184);
            this.ccTextTextBox.TabIndex = 1;
            // 
            // ccNameTextBox
            // 
            this.ccNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccNameTextBox.Location = new System.Drawing.Point(183, 37);
            this.ccNameTextBox.Name = "ccNameTextBox";
            this.ccNameTextBox.Size = new System.Drawing.Size(221, 31);
            this.ccNameTextBox.TabIndex = 0;
            // 
            // rbSec
            // 
            this.rbSec.AutoSize = true;
            this.rbSec.Checked = true;
            this.rbSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSec.Location = new System.Drawing.Point(314, 268);
            this.rbSec.Name = "rbSec";
            this.rbSec.Size = new System.Drawing.Size(90, 24);
            this.rbSec.TabIndex = 15;
            this.rbSec.TabStop = true;
            this.rbSec.Text = "Seconds";
            this.rbSec.UseVisualStyleBackColor = true;
            // 
            // rbMin
            // 
            this.rbMin.AutoSize = true;
            this.rbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMin.Location = new System.Drawing.Point(410, 268);
            this.rbMin.Name = "rbMin";
            this.rbMin.Size = new System.Drawing.Size(83, 24);
            this.rbMin.TabIndex = 16;
            this.rbMin.Text = "Minutes";
            this.rbMin.UseVisualStyleBackColor = true;
            // 
            // rbHour
            // 
            this.rbHour.AutoSize = true;
            this.rbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHour.Location = new System.Drawing.Point(499, 268);
            this.rbHour.Name = "rbHour";
            this.rbHour.Size = new System.Drawing.Size(70, 24);
            this.rbHour.TabIndex = 17;
            this.rbHour.Text = "Hours";
            this.rbHour.UseVisualStyleBackColor = true;
            // 
            // AddCCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(669, 432);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "AddCCForm";
            this.Text = "Add Custom Command";
            this.Load += new System.EventHandler(this.AddCCForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccRepeatNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccTimeNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ccNameTextBox;
        private System.Windows.Forms.NumericUpDown ccRepeatNumeric;
        private System.Windows.Forms.NumericUpDown ccTimeNumeric;
        private System.Windows.Forms.TextBox ccTextTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ccAddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbHour;
        private System.Windows.Forms.RadioButton rbMin;
        private System.Windows.Forms.RadioButton rbSec;
    }
}