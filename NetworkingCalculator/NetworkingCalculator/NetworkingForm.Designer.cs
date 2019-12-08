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
            this.PanelGroupStuff.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(483, 11);
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
            // NetworkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 559);
            this.Controls.Add(this.PanelGroupStuff);
            this.Controls.Add(this.CalculateButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NetworkingForm";
            this.Text = "The Calculator";
            this.Load += new System.EventHandler(this.NetworkingForm_Load);
            this.PanelGroupStuff.ResumeLayout(false);
            this.PanelGroupStuff.PerformLayout();
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
    }
}

