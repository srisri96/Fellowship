using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wagesformonth5
{
    internal class Program5
    {
        public const int Part_Time = 1;
        public const int Full_Time = 2;
        public const int Emprateperhour = 20;
        public const int Noofworkingdays = 2;
        public static void Days()
        {

            //variables
            int Emphrs = 0;
            int Empwage = 0;
            int totalempwage = 0;
            //computation
            for (int day = 0; day < Noofworkingdays; day++) 
            {
                Random random = new Random();

                //implementation
                int empchk = random.Next(0, 3);
                switch (empchk)
                {
                    case Part_Time:
                        Emphrs = 4;
                        break;

                    case Full_Time:
                        Emphrs = 8;
                        break;

                    default:
                        Emphrs = 0;
                        break;

                }
                Empwage = Emphrs * Emprateperhour;
                totalempwage += Empwage;
                Console.WriteLine("The Empployee wage is : " + Empwage);
            }
            Console.WriteLine("The total Empployee wage is : " + totalempwage);
        }
    }
}