using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double h;
            double w;

            h = question("身高");
            h = Tool.ConvertCMToMeter(h);
            w = question("體重");

            double bmi = Calculaor.CalculaeBMI(h, w);
            Console.WriteLine("您的 bmi 是 :" + bmi.ToString());
            Console.ReadKey();

        }

        public static double question(string input)
        {
            Console.WriteLine("請輸入" + input);
            double result;
            if (!Tool.isNumeric(Console.ReadLine(), out result))
            {
                Console.WriteLine(input + "格式錯誤");
                return question(input);
            }
            else
            {
                return result;
            }
        }

    }
}
