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
        /// <summary>
        /// 公分轉公尺
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double ConvertCMToMeter(double input)
        {
            input /= 100;
            return input;
        }
    }
}
