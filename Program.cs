using static basic.UC1Pre_Absent;

namespace basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Empwage Program");
            Console.WriteLine("Choose opion \n 1.Check emp abs or pres");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: UC1Pre_Absent.EmployeeAttendance(); break;
            }
        }
    }
    }
