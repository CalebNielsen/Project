using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkingCalculator
{
    public partial class NetworkingForm : Form
    {
        public struct GroupObjects
        {
            public TextBox input;
            public Label inputLabel;
            public TextBox output;
            public Label outputLabel;
        };
        public NetworkingForm()
        {
            InitializeComponent();
            ControlGroups = new List<GroupObjects>();
            SetControls(1);
        }

        private const string DecimalLabelTextFill = "Insert Decimal";
        private const string BinaryLabelTextFill = "Insert Binary";
        private const int Starting_x = 14;
        private const int Starting_y = 100;

        private List<GroupObjects> ControlGroups;

        private void NetworkingForm_Load(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (DecimalRadioButton.Checked)
            {
                DecimalCalculate();
            }
            else
            {
                BinaryCalculate();
            }
        }

        private void DecimalCalculate()
        {
            for (int i = 0; i < ControlGroups.Count(); i++)
            {
                bool valid = Format.validateDecimal(ControlGroups[i].input.Text);
                if (valid)
                {
                    ControlGroups[i].inputLabel.ForeColor = Color.Green;
                    Format.binaryConverter = new Binary(ControlGroups[i].input.Text);
                    Format.binaryConverter.convertToBinary();
                    ControlGroups[i].output.Text = Format.binaryConverter.binaryIP;
                }
                else
                {
                    ControlGroups[i].inputLabel.ForeColor = Color.Red;
                    ControlGroups[i].output.Text = "";
                }
            }
        }
        private void BinaryCalculate()
        {
            for (int i = 0; i < ControlGroups.Count(); i++)
            {
                bool valid = Format.validateBinary(ControlGroups[i].input.Text);
                if (valid)
                {
                    ControlGroups[i].inputLabel.ForeColor = Color.Green;
                    Format.decimalConverter = new Decimals(ControlGroups[i].input.Text);
                    Format.decimalConverter.convertToDecimal();
                    ControlGroups[i].output.Text = Format.decimalConverter.decimalIP;
                }
                else
                {
                    ControlGroups[i].inputLabel.ForeColor = Color.Red;
                    ControlGroups[i].output.Text = "";
                }
            }
        }

        private void DecimalRadioButton_Click(object sender, EventArgs e)
        {
            DecimalRadioButton.Checked = true;
            BinaryRadioButton.Checked = false;
            ResetControlsDecimal();
        }

        private void BinaryRadioButton_Click(object sender, EventArgs e)
        {
            BinaryRadioButton.Checked = true;
            DecimalRadioButton.Checked = false;
            ResetControlsBinary();
        }
        private void ResetControlsBinary()
        {
            for (int i = 0; i < ControlGroups.Count(); i++)
            {
                ControlGroups[i].input.Text = "";
                ControlGroups[i].output.Text = "";
                ControlGroups[i].inputLabel.Text = BinaryLabelTextFill;
                ControlGroups[i].inputLabel.ForeColor = Color.Black;
            }
        }
        private void ResetControlsDecimal()
        {
            for (int i = 0; i < ControlGroups.Count(); i++)
            {
                ControlGroups[i].input.Text = "";
                ControlGroups[i].output.Text = "";
                ControlGroups[i].inputLabel.Text = DecimalLabelTextFill;
                ControlGroups[i].inputLabel.ForeColor = Color.Black;
            }
        }

        private void DecimalToBinaryTextBox_TextChanged(object sender, EventArgs e)
        {
            
            string textfield = ((TextBox)sender).Text;
            if(textfield.Contains(Environment.NewLine))
            {
                ((TextBox)sender).Text = textfield.Trim();
                CalculateButton_Click(sender, e);
            }
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SizeTextBox_TextChanged(object sender, EventArgs e)
        {
            SizeTextbox.Text = Format.setSizeValue(SizeTextbox.Text);
            if(SizeTextbox.Text !="")
            {
                SetControls(Format.getSizeValue(SizeTextbox.Text));
            }
        }
        private void SetControls(int size)
        {
            //Remove all the existing controls from the list
            RemoveControls();
            //Clear the list
            ControlGroups.Clear();
            //Add number of new things
            int x = Starting_x, y = Starting_y;
            for (int i = 0; i < size; i++)
            {
                ControlGroups.Add(CreateGroup(x, y));
                y += 50;
            }
            CalculateButton.Location = new Point(480, y-50);
            CalculateButton.Size = new Size(CalculateButton.Size.Width, 39);
        }
        private void RemoveControls()
        {
            for(int i =0; i<ControlGroups.Count(); i++)
            {
                Controls.Remove(ControlGroups[i].input);
                Controls.Remove(ControlGroups[i].inputLabel);
                Controls.Remove(ControlGroups[i].output);
                Controls.Remove(ControlGroups[i].outputLabel);
            }
        }
        private GroupObjects CreateGroup(int x, int y)
        {
            string inputText = "";
            if (DecimalRadioButton.Checked)
                inputText = DecimalLabelTextFill;
            else
                inputText = BinaryLabelTextFill;

            GroupObjects group = new GroupObjects();
            group.input = new TextBox();
            group.inputLabel = new Label();
            group.output = new TextBox();
            group.outputLabel = new Label();


            group.input.Location = new System.Drawing.Point(x, y+15);
            group.input.Multiline = true;
            group.input.Name = "Box";
            group.input.Size = new System.Drawing.Size(225, 22);
            group.input.TabIndex = 0;
            group.input.TextChanged += new System.EventHandler(this.DecimalToBinaryTextBox_TextChanged);


            group.inputLabel.AutoSize = true;
            group.inputLabel.Location = new System.Drawing.Point(x, y);
            group.inputLabel.Name = "Lab";
            group.inputLabel.Size = new System.Drawing.Size(97, 17);
            group.inputLabel.TabIndex = 1;
            group.inputLabel.Text = inputText;
            group.inputLabel.Click += new System.EventHandler(this.Label1_Click);

            group.output.Location = new System.Drawing.Point(x+235, y + 15);
            group.output.Multiline = true;
            group.output.Name = "Box";
            group.output.Size = new System.Drawing.Size(225, 22);
            group.output.TabIndex = 0;


            group.outputLabel.AutoSize = true;
            group.outputLabel.Location = new System.Drawing.Point(x+235, y);
            group.outputLabel.Name = "Lab";
            group.outputLabel.Size = new System.Drawing.Size(97, 17);
            group.outputLabel.TabIndex = 1;
            group.outputLabel.Text = "Output";
            group.outputLabel.Click += new System.EventHandler(this.Label1_Click);

            Controls.Add(group.input);
            Controls.Add(group.inputLabel);
            Controls.Add(group.output);
            Controls.Add(group.outputLabel);

            return group;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelGroup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DecimalRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InputTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void BinaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PanelGroupStuff_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
