using System;

namespace DiaDaSemanaIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
             var mes = DateTime.Now.DayOfWeek;

            if (mes == DayOfWeek.Sunday)
            {
                Console.WriteLine($"Today is {DayOfWeek.Sunday}");
            }
            else if (mes == DayOfWeek.Monday)
            {
                Console.WriteLine($"Today is {DayOfWeek.Monday}");
            }
            else if (mes == DayOfWeek.Tuesday)
            {
                Console.WriteLine($"Today is {DayOfWeek.Tuesday}");
            }
            else if (mes == DayOfWeek.Wednesday)
            {
                Console.WriteLine($"Today is {DayOfWeek.Wednesday}");
            }
            else if (mes == DayOfWeek.Thursday)
            {
                Console.WriteLine($"Today is {DayOfWeek.Thursday}");
            }
            else if (mes == DayOfWeek.Friday)
            {
                Console.WriteLine($"Today is {DayOfWeek.Friday}");
            }
            else if (mes == DayOfWeek.Saturday)
            {
                Console.WriteLine($"Today is {DayOfWeek.Saturday}");
            }
        }
    }
}
