using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line
{
    internal class Class1
    {
        public static void LineComputation()
        {
            int x1, y1, x2, y2;

            Console.WriteLine("Enter x1");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y1");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x2");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y2");
            y2 = Convert.ToInt32(Console.ReadLine());

            var line1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

            Console.WriteLine("line1 :" + line1);
        }
    }
}
