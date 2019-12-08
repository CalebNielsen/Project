using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkingCalculator
{
    public static class Format
    {
        public static Binary binaryConverter;
        public static Decimals decimalConverter;
        public static bool validateDecimal(string input)
        {
            string[] inputSplit = input.Split('.', ' ');
            if (inputSplit.Length != 4)
                return false;

            bool canConvert;
            for(int a = 0; a < inputSplit.Length; a++)
            {
                int number;

                canConvert = int.TryParse(inputSplit[a], out number);

                if (!canConvert)
                    return false;
                else if (number < 0 || number > 255)
                    return false;
            }
            return true;
        }

        public static bool validateBinary(string input)
        {
            string[] inputSplit = input.Split('.', ' ');
            if (inputSplit.Length != 4)
                return false;

            for(int i = 0; i < 4; i++)
            {
                if (inputSplit[i].Length != 8)
                    return false;

                for(int j = 0; j < 8; j++)
                {
                    if (inputSplit[i][j] != '1' && inputSplit[i][j] != '0')
                        return false;
                }
            }
            return true;
        }
        public static string setSizeValue(string input)
        {
            int number;
            if (int.TryParse(input, out number))
            {
                if (number >= 10 || number <= 0)
                {
                    if (number <= 0)
                        number = 1;
                    else
                        number = 9;
                }
                return number.ToString();
            }
            else
            {
                return "";
            }
        }
        public static int getSizeValue(string input)
        {
            int number;
            if (int.TryParse(input, out number))
                return number;
            return 1;
            
        }
        
    }
}
