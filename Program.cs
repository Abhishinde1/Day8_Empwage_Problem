using static basic.UC1Pre_Absent;

namespace basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Empwage Program");
            Console.WriteLine("Choose opion \n 1.Check emp abs or pres \n 2.Calculate daily wage\n 3. Part time wage \n 4. Emp Wage Using Case");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: UC1Pre_Absent.EmployeeAttendance(); break;
                case 2: UC2DailyWage.CalculateDailyWage(); break;
                case 3: UC3.CalculateDailyPartTimeWage(); break;
                case 4: UC4.CalculateDailyWageUsingCase(); break;
                case 5: UC5.MonthWage(); break;
                case 6: UC6.CalculateWage(); break;
            }
        }
    }
    }
