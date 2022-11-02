using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CC5
{
    internal class PayCalculation
    {
        public static double GetGrossPay(int hours)
        {
            double grossPay;
            if (hours <= 56)
            {
                grossPay = hours * 80;
            }
            else
            {
                double extraRate = 1.5 * hours;
                grossPay = 56 * 80;
                int extraHours = hours - 56;
                grossPay = grossPay + (extraHours * extraRate);
            }
            return grossPay;
        }

        public static double CalculateTax(double grossPay)
        {
            double tax = (2 * grossPay) / 100;
            return tax;
        }
        public static double CalculateNetPay(int hours)
        {
            double grossPay = GetGrossPay(hours);
            double tax = CalculateTax(grossPay);
            double netPay = grossPay - tax;
            return netPay;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of hours worked : ");
            int hours = Convert.ToInt32(Console.ReadLine());

            double netPay = CalculateNetPay(hours);
            Console.WriteLine($"The calculated Net Pay is ${netPay}.");
        }
    }
}
