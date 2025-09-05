using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    public class Tool
    {
        public static bool isNumeric(string input, out double result)
        {
            if (double.TryParse(input, out result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double ConvertCMToMeter(double input)
        {
            input /= 1000;
            return input;
        }
    }
}
