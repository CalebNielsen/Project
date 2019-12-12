namespace NetworkingCalculator
{
    partial class NetworkingForm
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.DecimalRadioButton = new System.Windows.Forms.RadioButton();
            this.BinaryRadioButton = new System.Windows.Forms.RadioButton();
            this.InputTypeLabel = new System.Windows.Forms.Label();
            this.HowManyLabel = new System.Windows.Forms.Label();
            this.SizeTextbox = new System.Windows.Forms.TextBox();
            this.PanelGroupStuff = new System.Windows.Forms.Panel();
            this.IPConverterRadioButton = new System.Windows.Forms.RadioButton();
            this.SubnettingRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectedTabPanel = new System.Windows.Forms.Panel();
            this.SubnettingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SubnettingInput = new System.Windows.Forms.TextBox();
            this.SubnettingCalculate = new System.Windows.Forms.Button();
            this.SubnetListBox = new System.Windows.Forms.ListBox();
            this.PanelGroupStuff.SuspendLayout();
            this.SelectedTabPanel.SuspendLayout();
            this.SubnettingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(246, 25);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(93, 50);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // DecimalRadioButton
            // 
            this.DecimalRadioButton.AutoSize = true;
            this.DecimalRadioButton.Checked = true;
            this.DecimalRadioButton.Location = new System.Drawing.Point(22, 28);
            this.DecimalRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.DecimalRadioButton.Name = "DecimalRadioButton";
            this.DecimalRadioButton.Size = new System.Drawing.Size(63, 17);
            this.DecimalRadioButton.TabIndex = 5;
            this.DecimalRadioButton.TabStop = true;
            this.DecimalRadioButton.Text = "Decimal";
            this.DecimalRadioButton.UseVisualStyleBackColor = true;
            this.DecimalRadioButton.CheckedChanged += new System.EventHandler(this.DecimalRadioButton_CheckedChanged);
            this.DecimalRadioButton.Click += new System.EventHandler(this.DecimalRadioButton_Click);
            // 
            // BinaryRadioButton
            // 
            this.BinaryRadioButton.AutoSize = true;
            this.BinaryRadioButton.Location = new System.Drawing.Point(22, 49);
            this.BinaryRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.BinaryRadioButton.Name = "BinaryRadioButton";
            this.BinaryRadioButton.Size = new System.Drawing.Size(54, 17);
            this.BinaryRadioButton.TabIndex = 6;
            this.BinaryRadioButton.Text = "Binary";
            this.BinaryRadioButton.UseVisualStyleBackColor = true;
            this.BinaryRadioButton.CheckedChanged += new System.EventHandler(this.BinaryRadioButton_CheckedChanged);
            this.BinaryRadioButton.Click += new System.EventHandler(this.BinaryRadioButton_Click);
            // 
            // InputTypeLabel
            // 
            this.InputTypeLabel.AutoSize = true;
            this.InputTypeLabel.Location = new System.Drawing.Point(19, 11);
            this.InputTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InputTypeLabel.Name = "InputTypeLabel";
            this.InputTypeLabel.Size = new System.Drawing.Size(58, 13);
            this.InputTypeLabel.TabIndex = 7;
            this.InputTypeLabel.Text = "Input Type";
            this.InputTypeLabel.Click += new System.EventHandler(this.InputTypeLabel_Click);
            // 
            // HowManyLabel
            // 
            this.HowManyLabel.AutoSize = true;
            this.HowManyLabel.Location = new System.Drawing.Point(95, 11);
            this.HowManyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HowManyLabel.Name = "HowManyLabel";
            this.HowManyLabel.Size = new System.Drawing.Size(84, 13);
            this.HowManyLabel.TabIndex = 8;
            this.HowManyLabel.Text = "How Many IP\'s?";
            this.HowManyLabel.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // SizeTextbox
            // 
            this.SizeTextbox.Location = new System.Drawing.Point(98, 27);
            this.SizeTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.SizeTextbox.Name = "SizeTextbox";
            this.SizeTextbox.Size = new System.Drawing.Size(76, 20);
            this.SizeTextbox.TabIndex = 9;
            this.SizeTextbox.Text = "1";
            this.SizeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SizeTextbox.TextChanged += new System.EventHandler(this.SizeTextBox_TextChanged);
            // 
            // PanelGroupStuff
            // 
            this.PanelGroupStuff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelGroupStuff.Controls.Add(this.HowManyLabel);
            this.PanelGroupStuff.Controls.Add(this.SizeTextbox);
            this.PanelGroupStuff.Controls.Add(this.DecimalRadioButton);
            this.PanelGroupStuff.Controls.Add(this.BinaryRadioButton);
            this.PanelGroupStuff.Controls.Add(this.InputTypeLabel);
            this.PanelGroupStuff.Location = new System.Drawing.Point(12, 12);
            this.PanelGroupStuff.Name = "PanelGroupStuff";
            this.PanelGroupStuff.Size = new System.Drawing.Size(200, 79);
            this.PanelGroupStuff.TabIndex = 10;
            this.PanelGroupStuff.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGroupStuff_Paint);
            // 
            // IPConverterRadioButton
            // 
            this.IPConverterRadioButton.AutoSize = true;
            this.IPConverterRadioButton.Checked = true;
            this.IPConverterRadioButton.Location = new System.Drawing.Point(13, 13);
            this.IPConverterRadioButton.Name = "IPConverterRadioButton";
            this.IPConverterRadioButton.Size = new System.Drawing.Size(84, 17);
            this.IPConverterRadioButton.TabIndex = 10;
            this.IPConverterRadioButton.TabStop = true;
            this.IPConverterRadioButton.Text = "IP Converter";
            this.IPConverterRadioButton.UseVisualStyleBackColor = true;
            this.IPConverterRadioButton.CheckedChanged += new System.EventHandler(this.IPConverterRadioButton_CheckedChanged);
            this.IPConverterRadioButton.Click += new System.EventHandler(this.IPConverterRadioButton_Click);
            // 
            // SubnettingRadioButton
            // 
            this.SubnettingRadioButton.AutoSize = true;
            this.SubnettingRadioButton.Location = new System.Drawing.Point(13, 36);
            this.SubnettingRadioButton.Name = "SubnettingRadioButton";
            this.SubnettingRadioButton.Size = new System.Drawing.Size(76, 17);
            this.SubnettingRadioButton.TabIndex = 11;
            this.SubnettingRadioButton.Text = "Subnetting";
            this.SubnettingRadioButton.UseVisualStyleBackColor = true;
            this.SubnettingRadioButton.CheckedChanged += new System.EventHandler(this.SubnettingRadioButton_CheckedChanged);
            this.SubnettingRadioButton.Click += new System.EventHandler(this.SubnettingRadioButton_Click);
            // 
            // SelectedTabPanel
            // 
            this.SelectedTabPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SelectedTabPanel.Controls.Add(this.SubnettingRadioButton);
            this.SelectedTabPanel.Controls.Add(this.IPConverterRadioButton);
            this.SelectedTabPanel.Location = new System.Drawing.Point(463, 12);
            this.SelectedTabPanel.Name = "SelectedTabPanel";
            this.SelectedTabPanel.Size = new System.Drawing.Size(113, 72);
            this.SelectedTabPanel.TabIndex = 12;
            this.SelectedTabPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectedTabPanel_Paint);
            // 
            // SubnettingPanel
            // 
            this.SubnettingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SubnettingPanel.Controls.Add(this.label1);
            this.SubnettingPanel.Controls.Add(this.SubnettingInput);
            this.SubnettingPanel.Location = new System.Drawing.Point(12, 12);
            this.SubnettingPanel.Name = "SubnettingPanel";
            this.SubnettingPanel.Size = new System.Drawing.Size(200, 79);
            this.SubnettingPanel.TabIndex = 11;
            this.SubnettingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SubnettingPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "How Many Subnets?";
            this.label1.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // SubnettingInput
            // 
            this.SubnettingInput.Location = new System.Drawing.Point(47, 27);
            this.SubnettingInput.Margin = new System.Windows.Forms.Padding(2);
            this.SubnettingInput.Name = "SubnettingInput";
            this.SubnettingInput.Size = new System.Drawing.Size(103, 20);
            this.SubnettingInput.TabIndex = 9;
            this.SubnettingInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubnettingCalculate
            // 
            this.SubnettingCalculate.Location = new System.Drawing.Point(365, 25);
            this.SubnettingCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.SubnettingCalculate.Name = "SubnettingCalculate";
            this.SubnettingCalculate.Size = new System.Drawing.Size(93, 50);
            this.SubnettingCalculate.TabIndex = 13;
            this.SubnettingCalculate.Text = "Calculate";
            this.SubnettingCalculate.UseVisualStyleBackColor = true;
            this.SubnettingCalculate.Click += new System.EventHandler(this.SubnettingCalculate_Click);
            // 
            // SubnetListBox
            // 
            this.SubnetListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SubnetListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubnetListBox.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubnetListBox.FormattingEnabled = true;
            this.SubnetListBox.ItemHeight = 21;
            this.SubnetListBox.Location = new System.Drawing.Point(12, 169);
            this.SubnetListBox.Name = "SubnetListBox";
            this.SubnetListBox.Size = new System.Drawing.Size(564, 357);
            this.SubnetListBox.TabIndex = 15;
            // 
            // NetworkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 559);
            this.Controls.Add(this.SubnetListBox);
            this.Controls.Add(this.SubnettingCalculate);
            this.Controls.Add(this.SubnettingPanel);
            this.Controls.Add(this.SelectedTabPanel);
            this.Controls.Add(this.PanelGroupStuff);
            this.Controls.Add(this.CalculateButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NetworkingForm";
            this.Text = "The Calculator";
            this.Load += new System.EventHandler(this.NetworkingForm_Load);
            this.PanelGroupStuff.ResumeLayout(false);
            this.PanelGroupStuff.PerformLayout();
            this.SelectedTabPanel.ResumeLayout(false);
            this.SelectedTabPanel.PerformLayout();
            this.SubnettingPanel.ResumeLayout(false);
            this.SubnettingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.RadioButton DecimalRadioButton;
        private System.Windows.Forms.RadioButton BinaryRadioButton;
        private System.Windows.Forms.Label InputTypeLabel;
        private System.Windows.Forms.Label HowManyLabel;
        private System.Windows.Forms.TextBox SizeTextbox;
        private System.Windows.Forms.Panel PanelGroupStuff;
        private System.Windows.Forms.RadioButton IPConverterRadioButton;
        private System.Windows.Forms.RadioButton SubnettingRadioButton;
        private System.Windows.Forms.Panel SelectedTabPanel;
        private System.Windows.Forms.Panel SubnettingPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubnettingInput;
        private System.Windows.Forms.Button SubnettingCalculate;
        private System.Windows.Forms.ListBox SubnetListBox;
    }
}

