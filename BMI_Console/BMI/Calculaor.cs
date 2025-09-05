using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    public class Calculaor
    {
        public static double CalculaeBMI(double height, double weight)
        {
            return weight / (Math.Pow(height, 2));
        }
    }
}
