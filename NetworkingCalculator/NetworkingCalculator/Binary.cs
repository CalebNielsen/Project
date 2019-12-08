using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkingCalculator
{
    public class Binary
    {
        public Binary(string input)
        {
            _decimalInput = input;
            string[] byteSplit = input.Split('.',' ');
            byteArray = new byte[byteSplit.Length];
            for(int i = 0; i < 4; i++)
            {
                byteArray[i] = Convert.ToByte(byteSplit[i]);
            }

            binaryIP = "";
        }

        private string _decimalInput;
        private byte[] byteArray;

        public string binaryIP;
        public void convertToBinary()
        {
            //Iterate for all four values in byte array
            //Convert to binary
            //add leading 0's for ones lenght < 8
            //add them all to a string seperated by a decimal
            for (int i = 0; i < 4; i++)
            {
                string tmp;
                int zeros = 0;
                tmp = recursiveBinaryConverter(byteArray[i]);
                zeros = 8 - tmp.Length;
                for(int j = 0; j < zeros; j++)
                    tmp = "0" + tmp;

                binaryIP = binaryIP + tmp;

                if (i != 3)
                    binaryIP += ".";
            }
        }

        private string recursiveBinaryConverter(byte n)
        {
            string s = "";
            byte x;
            x = (byte)(n % 2);
            n = (byte)(n / 2);

            if (n > 0)
            {
                s = recursiveBinaryConverter(n);
            }

            return s + x.ToString();
        }

    }
}
