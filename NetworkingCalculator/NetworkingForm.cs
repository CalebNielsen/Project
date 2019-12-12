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
        public struct ConverterObjects
        {
            public TextBox input;
            public Label inputLabel;
            public TextBox output;
            public Label outputLabel;
        };
        public struct SubnettingObjects
        {
            public TextBox IpInput;
            public Label IpInputLabel;
            public TextBox SubnetMaskInput;
            public Label SubnetMaskInputLabel;
        }

        public NetworkingForm()
        {
            InitializeComponent();
            ControlGroupsConverter = new List<ConverterObjects>();
            SelectedConverter();
            UnSelectedSubnetting();

        }

        private const string DecimalLabelTextFill = "Insert Decimal";
        private const string BinaryLabelTextFill = "Insert Binary";
        private const int Starting_x = 14;
        private const int Starting_y = 100;

        private List<ConverterObjects> ControlGroupsConverter;
        private SubnettingObjects ControlGroupsSubnetting;

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
            for (int i = 0; i < ControlGroupsConverter.Count(); i++)
            {
                bool valid = Format.validateDecimal(ControlGroupsConverter[i].input.Text);
                if (valid)
                {
                    ControlGroupsConverter[i].inputLabel.ForeColor = Color.Green;
                    Format.binaryConverter = new Binary(ControlGroupsConverter[i].input.Text);
                    Format.binaryConverter.convertToBinary();
                    ControlGroupsConverter[i].output.Text = Format.binaryConverter.binaryIP;
                }
                else
                {
                    ControlGroupsConverter[i].inputLabel.ForeColor = Color.Red;
                    ControlGroupsConverter[i].output.Text = "";
                }
            }
        }
        private void BinaryCalculate()
        {
            for (int i = 0; i < ControlGroupsConverter.Count(); i++)
            {
                bool valid = Format.validateBinary(ControlGroupsConverter[i].input.Text);
                if (valid)
                {
                    ControlGroupsConverter[i].inputLabel.ForeColor = Color.Green;
                    Format.decimalConverter = new Decimals(ControlGroupsConverter[i].input.Text);
                    Format.decimalConverter.convertToDecimal();
                    ControlGroupsConverter[i].output.Text = Format.decimalConverter.decimalIP;
                }
                else
                {
                    ControlGroupsConverter[i].inputLabel.ForeColor = Color.Red;
                    ControlGroupsConverter[i].output.Text = "";
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
            for (int i = 0; i < ControlGroupsConverter.Count(); i++)
            {
                ControlGroupsConverter[i].input.Text = "";
                ControlGroupsConverter[i].output.Text = "";
                ControlGroupsConverter[i].inputLabel.Text = BinaryLabelTextFill;
                ControlGroupsConverter[i].inputLabel.ForeColor = Color.Black;
            }
        }
        private void ResetControlsDecimal()
        {
            for (int i = 0; i < ControlGroupsConverter.Count(); i++)
            {
                ControlGroupsConverter[i].input.Text = "";
                ControlGroupsConverter[i].output.Text = "";
                ControlGroupsConverter[i].inputLabel.Text = DecimalLabelTextFill;
                ControlGroupsConverter[i].inputLabel.ForeColor = Color.Black;
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
            ControlGroupsConverter.Clear();
            //Add number of new things
            int x = Starting_x, y = Starting_y;
            for (int i = 0; i < size; i++)
            {
                ControlGroupsConverter.Add(CreateGroup(x, y));
                y += 50;
            }
            CalculateButton.Location = new Point(480, y-50);
            CalculateButton.Size = new Size(CalculateButton.Size.Width, 39);
        }
        private void RemoveControls()
        {
            for(int i =0; i<ControlGroupsConverter.Count(); i++)
            {
                Controls.Remove(ControlGroupsConverter[i].input);
                Controls.Remove(ControlGroupsConverter[i].inputLabel);
                Controls.Remove(ControlGroupsConverter[i].output);
                Controls.Remove(ControlGroupsConverter[i].outputLabel);
            }
        }
        private void Ip_TextChanged(object sender, EventArgs e)
        {
            string textfield = ((TextBox)sender).Text;
            if (ControlGroupsSubnetting.IpInput.Text.Contains("/"))
            {
                string[] inputSplit = ControlGroupsSubnetting.IpInput.Text.Split('/');
                int x;
                if (int.TryParse(inputSplit[1], out x))
                    ControlGroupsSubnetting.SubnetMaskInput.Text = Format.GetSubnetMask(x);
                //inputSplit[0] contains the ip address, inputSplit[1] contains the subnetting thing
                //Calculate the subnet mask
            }
            if (textfield.Contains(Environment.NewLine))
            {
                ((TextBox)sender).Text = textfield.Trim();
                SubnettingCalculate_Click(sender, e);
            }
        }
        private void SelectedConverter()
        {
            ControlGroupsConverter = new List<ConverterObjects>();
            SetControls(1);
            CalculateButton.Visible = true;
            PanelGroupStuff.Visible = true;
        }
        private void UnSelectedConverter()
        {
            SetControls(0);
            CalculateButton.Visible = false;
            PanelGroupStuff.Visible = false;
        }
        private void SelectedSubnetting()
        {
            CreateSubnettingObjects();
            int y = Starting_y;
            SubnettingPanel.Visible = true;
            SubnettingCalculate.Visible = true;
            SubnetListBox.Visible = true;
            SubnetListBox.Items.Clear();
            SubnettingInput.Text = "2";
            SubnetListBox.Items.Add("#\tSubnet ID");

            SubnettingCalculate.Location = new Point(480, y);
            SubnettingCalculate.Size = new Size(SubnettingCalculate.Size.Width, 39);
        }
        private void UnSelectedSubnetting()
        {
            Controls.Remove(ControlGroupsSubnetting.IpInput);
            Controls.Remove(ControlGroupsSubnetting.IpInputLabel);
            Controls.Remove(ControlGroupsSubnetting.SubnetMaskInput);
            Controls.Remove(ControlGroupsSubnetting.SubnetMaskInputLabel);
            SubnettingPanel.Visible = false;
            SubnettingCalculate.Visible = false;
            SubnetListBox.Visible = false;
        }
        private void CreateSubnettingObjects()
        {
            SubnettingObjects group = new SubnettingObjects();

            int x = Starting_x, y = Starting_y;

            group.IpInput = new TextBox();
            group.IpInputLabel = new Label();
            group.SubnetMaskInput = new TextBox();
            group.SubnetMaskInputLabel = new Label();


            group.IpInput.Location = new System.Drawing.Point(x, y + 15);
            group.IpInput.Multiline = true;
            group.IpInput.Name = "Box";
            group.IpInput.Size = new System.Drawing.Size(225, 22);
            group.IpInput.TabIndex = 0;
            group.IpInput.TextChanged += new System.EventHandler(this.Ip_TextChanged);


            group.IpInputLabel.AutoSize = true;
            group.IpInputLabel.Location = new System.Drawing.Point(x, y);
            group.IpInputLabel.Name = "Lab";
            group.IpInputLabel.Size = new System.Drawing.Size(97, 17);
            group.IpInputLabel.TabIndex = 1;
            group.IpInputLabel.Text = "Enter IP Address";
            group.IpInputLabel.Click += new System.EventHandler(this.Label1_Click);

            group.SubnetMaskInput.Location = new System.Drawing.Point(x + 235, y + 15);
            group.SubnetMaskInput.Multiline = true;
            group.SubnetMaskInput.Name = "Box";
            group.SubnetMaskInput.Size = new System.Drawing.Size(225, 22);
            group.SubnetMaskInput.TabIndex = 0;
            group.SubnetMaskInput.TextChanged += SubnettingText_Changed;

            group.SubnetMaskInputLabel.AutoSize = true;
            group.SubnetMaskInputLabel.Location = new System.Drawing.Point(x + 235, y);
            group.SubnetMaskInputLabel.Name = "Lab";
            group.SubnetMaskInputLabel.Size = new System.Drawing.Size(97, 17);
            group.SubnetMaskInputLabel.TabIndex = 1;
            group.SubnetMaskInputLabel.Text = "Enter Subnet Mask";
            group.SubnetMaskInputLabel.Click += new System.EventHandler(this.Label1_Click);

            Controls.Add(group.IpInput);
            Controls.Add(group.IpInputLabel);
            Controls.Add(group.SubnetMaskInput);
            Controls.Add(group.SubnetMaskInputLabel);

            ControlGroupsSubnetting = group;
        }
        private ConverterObjects CreateGroup(int x, int y)
        {
            string inputText = "";
            if (DecimalRadioButton.Checked)
                inputText = DecimalLabelTextFill;
            else
                inputText = BinaryLabelTextFill;

            ConverterObjects group = new ConverterObjects();
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

        private void IPConverterRadioButton_Click(object sender, EventArgs e)
        {
            SelectedConverter();
            UnSelectedSubnetting();
            IPConverterRadioButton.Checked = true;
            SubnettingRadioButton.Checked = false;
        }

        private void SubnettingRadioButton_Click(object sender, EventArgs e)
        {
            UnSelectedConverter();
            SelectedSubnetting();
            IPConverterRadioButton.Checked = false;
            SubnettingRadioButton.Checked = true;
        }

        private void IPConverterRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SubnettingRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SelectedTabPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void SubnettingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SubnettingText_Changed(object sender, EventArgs e)
        {
            string textfield = ((TextBox)sender).Text;
            if (textfield.Contains(Environment.NewLine))
            {
                ((TextBox)sender).Text = textfield.Trim();
                SubnettingCalculate_Click(sender, e);
            }
        }
        private void SubnettingCalculate_Click(object sender, EventArgs e)
        {
            string[] inputSplit = ControlGroupsSubnetting.IpInput.Text.Split('/');
            ControlGroupsSubnetting.IpInput.Text = inputSplit[0];
            SubnetListBox.Items.Clear();
            if (Format.validateDecimal(ControlGroupsSubnetting.IpInput.Text))
            {
                ControlGroupsSubnetting.IpInputLabel.ForeColor = Color.Green;
                if (Format.validateDecimal(ControlGroupsSubnetting.SubnetMaskInput.Text))
                {
                    ControlGroupsSubnetting.SubnetMaskInputLabel.ForeColor = Color.Green;
                    int SubnetNums;
                    if (int.TryParse(SubnettingInput.Text, out SubnetNums))
                    {
                        Subnet subnetter = new Subnet(ControlGroupsSubnetting.IpInput.Text, ControlGroupsSubnetting.SubnetMaskInput.Text, SubnetNums);
                        if (subnetter.validSubnetAmount())
                        {
                            SubnetListBox.Items.Add("#\tSubnet ID");
                            string[,] results = subnetter.makeSubnets();
                            for (int i = 0; i < results.Length/3; i++)
                            {
                                SubnetListBox.Items.Add(results[i, 0]);
                                SubnetListBox.Items.Add(results[i, 1]);
                                SubnetListBox.Items.Add(results[i, 2]);
                            }
                            SubnetListBox.Items.Add("Bits Stolen: " + subnetter.getBitsStolen());
                            SubnetListBox.Items.Add("Total Hosts: " + subnetter.getTotalNumberOfHosts());
                        }
                        else
                        {
                            SubnettingInput.Text = "2";
                        }

                    }
                    else
                    {
                        SubnettingInput.Text = "2";
                    }

                }
                else
                {
                    ControlGroupsSubnetting.SubnetMaskInputLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                ControlGroupsSubnetting.IpInputLabel.ForeColor = Color.Red;
                ControlGroupsSubnetting.SubnetMaskInputLabel.ForeColor = Color.Black;
            }
        }
    }
}
