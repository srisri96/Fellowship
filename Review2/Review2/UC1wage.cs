using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    class UC1wage
    {
        public static void Empsal()
        {
            //constant declaration
            int Full_Time = 1;
            Random random = new Random();
            //computation
            int empcheck = random.Next(0, 2);
            if (empcheck == Full_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Emloyee is absent");
            }
        }
    }
}