using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double hpr, hours, gross, withhold, net;

            Console.Write("Hourly pay rate: ");
            input = Console.ReadLine();
            hpr = Convert.ToDouble(input);

            Console.Write("hours worked: ");
            input = Console.ReadLine();
            hours = Convert.ToDouble(input);

            gross = hpr * hours;
            Console.WriteLine("Gross pay:                    {0}", gross.ToString("C"));

            if (gross <= 300)
            {
                withhold = gross * .10;
                Console.WriteLine("withholding tax:               {0}", withhold.ToString("C"));
            }
            else
            {
                withhold = gross * .12;
                Console.WriteLine("withholding tax:               {0}", withhold.ToString("C"));
            }

            net = gross - withhold;
            Console.WriteLine("Net:                          {0}", net.ToString("C"));
        }
    }
}
