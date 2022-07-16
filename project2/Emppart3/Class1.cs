using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emppart3
{
    class class2
    {
        public static void Part3()
        {
            //declaring constants
            int Part_time = 1;
            int Full_time = 2;
            int Emp_rate_per_hour = 20;
            //declaring variables
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            // computation
            int empcheck = random.Next(0, 3);
            if (empcheck == Part_time)
            {
                emphrs = 4;
            }
            else if (empcheck == Full_time)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;

            }
            empwage = emphrs * Emp_rate_per_hour;
            Console.WriteLine("empwage : " + empwage);

        }

    }
}