using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace days6
{
    internal class program6
    { 
            public const int Part_Time = 1;
            public const int Full_Time = 2;
            public const int Emprateperhour = 20;
            public const int Noofworkingdays = 2;
        public const int Maxhours = 10;
            public static void Days6()
            {

                //variables
                int Emphrs = 0;
                int Totalworkdays = 0;
                int Totalemphours = 0;
                //computation
                while (Totalemphours <= Maxhours && Totalworkdays < Noofworkingdays)
                //for (int day = 0; day < Noofworkingdays; day++)
                {
                    Totalworkdays++;
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
                    //Empwage = Emphrs * Emprateperhour;
                    Totalemphours += Emphrs;
                    Console.WriteLine("days :" + Totalworkdays + "emphrs :" +Emphrs);
                }
            int totalempwage = Totalemphours * Emprateperhour;
                Console.WriteLine("The total Empployee wage is : " + totalempwage);
            }
        }
    }