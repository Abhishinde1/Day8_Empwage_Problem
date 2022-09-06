using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    internal class UC3
    {
        public static void CalculateDailyPartTimeWage()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 0;
            const int EMP_RATE_ER_HOUR = 20;

            int empHour = 0;
            int empWage = 0;
            Random random = new Random();

            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FULL_TIME)
            {
                empHour = 8;
            }
            else if (empcheck == IS_PART_TIME)
            {
                empHour = 4;
            }
            else
            {
                empHour = 0;
            }
            empWage = empHour * EMP_RATE_ER_HOUR;
            Console.WriteLine("Part time Emp Wage is " + empWage);
        }
    }
}
