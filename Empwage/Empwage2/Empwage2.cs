using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empwage
{
    internal class Empwage2
    {
        public static void wage2()
        {
            int Full_Time = 1;
            int Emprphr = 20;

            //variables
            int Emphr = 0;
            int Empwage = 0;
            Random random = new Random();

            //implementation
            int empchk = random.Next(0, 2);
            if (empchk == Full_Time)
            {
                Emphr = 8;

            }
            else
            {
                Emphr = 0;
            }
            Empwage = Emphr * Emprphr;
            Console.WriteLine("The Empployee wage is : " + Empwage);
        }

    }
}