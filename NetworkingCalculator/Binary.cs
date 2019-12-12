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

            //LINQ
            byteArray = (from b in byteSplit
                         select Convert.ToByte(b)).ToArray();

            binaryIP = "";
        }

        private string _decimalInput;
        public string DecimalInput
        {
            get
            {
                return _decimalInput;
            }
            private set
            {
                _decimalInput = value;
            }
        }
        private byte[] byteArray;

        public string binaryIP;
        public void convertToBinary()
        {
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

        public static string convertToBinary(int size, int decimalString)
        {
            string tmp = recursiveBinaryConverter((decimalString));

            while(tmp.Length < size)
            {
                tmp = "0" + tmp;
            }

            return tmp;
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
        private static string recursiveBinaryConverter(int n)
        {
            string s = "";
            int x;
            x = (int)(n % 2);
            n = (int)(n / 2);

            if (n > 0)
            {
                s = recursiveBinaryConverter(n);
            }

            return s + x.ToString();
        }
    }
}
