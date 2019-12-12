using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkingCalculator
{
    public class IPAddress
    {
        public IPAddress(string address1, string address2, bool isDecimal)
        {
            if (isDecimal)
            {
                Binary b = new Binary(address1);
                b.convertToBinary();
                _address1 = b.binaryIP;
                b = new Binary(address2);
                b.convertToBinary();
                _address2 = b.binaryIP;
            }
            else
            {
                _address1 = address1;
                _address2 = address2;
            }
        }

        private string _address1;
        protected string Address1
        {
            get
            {
                return _address1;
            }
            private set
            {
                _address1 = value;
            }
        }
        protected string _address2;

        public string subnetAddress;
        public void LogicalAndcalculate()
        {
            string[] inputSplit1 = _address1.Split('.',' ');
            string[] inputSplit2 = _address2.Split('.', ' ');

            subnetAddress = "";

            for(int i = 0; i < 4; i++)
            {
                string tmp;
                tmp = logicalAND(inputSplit1[i], inputSplit2[i]);
                subnetAddress += tmp;
                if (i != 3)
                    subnetAddress += '.';
            }
        }

        private string logicalAND(string top, string bottom)
        {
            string output = "";

            for(int i = 0; i < 8; i++)
            {
                if (top[i] == '1' && bottom[i] == '1')
                    output += 1.ToString();
                else
                    output += 0.ToString();
            }
            return output;
        }
    }
}
