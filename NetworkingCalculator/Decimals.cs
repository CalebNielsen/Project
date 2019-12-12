using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkingCalculator
{
    public class Decimals
    {
        public Decimals(string input)
        {
            _binaryInput = input;
            binaryArray = input.Split('.', ' ');
        }

        private string _binaryInput;
        private string[] binaryArray;

        public string decimalIP;
        public void convertToDecimal()
        {
            int tmp;
            for(int i = 0; i < 4; i++)
            {
                tmp = decimalConverter(binaryArray[i]);

                decimalIP = decimalIP + tmp;

                if (i != 3)
                    decimalIP = decimalIP + '.';
            }
        }

        private int decimalConverter(string s)
        {
            int[] binaryLibrary = { 128, 64, 32, 16, 8, 4, 2, 1 };
            int number = 0;
            for (int i = 0; i < 8; i++)
            {
                number += (binaryLibrary[i] * Convert.ToInt32(s[i] + ""));
            }
            return number;
        }


    }
}
