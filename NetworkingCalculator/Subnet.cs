using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkingCalculator
{
    public class Subnet: IPAddress
    {
        public Subnet(string IP, string mask, int subnets) : base(IP, mask, true)
        {
            _IP = IP;
            _mask = mask;
            _subnets = subnets;

            LogicalAndcalculate();
        } 

        private string _IP;
        public string IP
        {
            get
            {
                return _IP;
            }
            private set
            {
                _IP = value;
            }
        }
        private string _mask;
        public string Mask
        {
            get
            {
                return _mask;
            }
            private set
            {
                _mask = value;
            }
        }
        private int _subnets;
        private int _startingLocation;
        private int _byteSpace;
        private const int IPAddressSize = 35;
        private bool _validated = false;
        private string[,] subnetArray;
        private string[] DecimalID;
        private string[] BroadcastID;
        private string[] HostRange;

        public string[,] makeSubnets()
        {
            if (_validated)
            {
                subnetArray = new string[_subnets,3];
                DecimalID = new string[_subnets];
                BroadcastID = new string[_subnets];
                HostRange = new string[_subnets];

                for (int i = 0; i < _subnets; i++)
                {
                    string subnetID = Binary.convertToBinary(_byteSpace, i);
                    int count = 0;
                    subnetArray[i,0] = "";
                    for (int j = 0; j < IPAddressSize; j++)
                    {
                        if (subnetAddress[j] == '.')
                        {
                            subnetArray[i,0] += '.';
                        }
                        else if (j >= _startingLocation + 1 && count < subnetID.Length)
                        {
                            subnetArray[i,0] += subnetID[count];
                            count++;
                        }
                        else
                        {
                            subnetArray[i,0] += subnetAddress[j];
                        }
                    }

                    string[] temp = Format.getFormattedString(subnetArray[i,0], getDecimalSubnet(i), getBroadcast(i), getHostRange(i), i, _subnets); ;
                    subnetArray[i, 0] = temp[0];
                    subnetArray[i, 1] = temp[1];
                    subnetArray[i, 2] = temp[2];
                }
                return subnetArray;
            }
            return null;
        }

        private string getDecimalSubnet(int index)
        {
            Decimals decimalOutput = new Decimals(subnetArray[index,0]);
            decimalOutput.convertToDecimal();
            DecimalID[index] = decimalOutput.decimalIP;
            return decimalOutput.decimalIP;
        }
        private string getBroadcast(int index)
        {
            int bitChangeCount = _startingLocation;

            char[] tmp = subnetArray[index, 0].ToCharArray();

            int counter = 0;
            for(int i = bitChangeCount+1; i < IPAddressSize; i++)
            {
                if (counter >= _byteSpace)
                {
                    if (tmp[i] != '.')
                        tmp[i] = '1';
                }
                if (tmp[i] != '.')
                    counter++;
            }
            Decimals d = new Decimals(new string(tmp));
            d.convertToDecimal();

            BroadcastID[index] = d.decimalIP;
            return d.decimalIP;
        }
        private string getHostRange(int index)
        {
            char[] subnet = subnetArray[index, 0].ToCharArray();

            subnet[IPAddressSize - 1] = '1';

            Binary b = new Binary(BroadcastID[index]);
            b.convertToBinary();

            char[] subnet2 = b.binaryIP.ToCharArray();

            subnet2[IPAddressSize - 1] = '0';

            Decimals d = new Decimals(new string(subnet));
            d.convertToDecimal();

            string lowRange = d.decimalIP;

            Decimals d2 = new Decimals(new string(subnet2));
            d2.convertToDecimal();

            string highRange = d2.decimalIP;

            HostRange[index] = lowRange + " - " + highRange;
            return lowRange + " - " + highRange;
        }
        public string getBitsStolen()
        {
            return _byteSpace.ToString();
        }
        public string getTotalNumberOfHosts()
        {
            int starting = _startingLocation;

            if (starting < 9)
                starting++;
            if (starting < 18)
                starting++;
            if (starting < 27)
                starting++;

            int numberOfHostBits = IPAddressSize - starting - _byteSpace-1;

            int numberOfHosts = (int)Math.Pow(2, numberOfHostBits)-2;

            return numberOfHosts.ToString();
        }

        private int findStartPosition()
        {
            int position = 0;
            for(int i=0; i < _address2.Length; i++)
            {
                if (_address2[i] == '1')
                {
                    position = i;
                    if (i+1 < IPAddressSize && _address2[i + 1] == '.')
                        position++;
                }
            }
            return position;
        }

        public bool validSubnetAmount()
        {
            int startPosition = findStartPosition();

            _startingLocation = startPosition;

            int byteNumber = (int)Math.Ceiling(Math.Log(_subnets, 2));

            _byteSpace = byteNumber;

            if (byteNumber + startPosition > IPAddressSize-1 || _subnets == 1)
                return false;
            _validated = true;
            return true;
        }
    }
}
