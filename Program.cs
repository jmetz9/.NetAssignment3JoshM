using System;

namespace Assignment2JoshM
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2019, 1, 22, 11, 1, 27);
            var pi = Math.PI;

            Console.WriteLine("{0:MMMM dd, yyyy}",date);
            Console.WriteLine("{0:yyyy.MM.dd}",date);
            Console.WriteLine("Day {0:dd} of {0:MMMM}, {0:yyyy}",date);
            Console.WriteLine("Year:{0:yyyy}, Month:{0:MM}, Day:{0:dd}",date);
            Console.WriteLine($"{date,17:dddd}");
            Console.WriteLine($"{date,11:h:mm tt}" + $"{date,17:dddd}");
            Console.WriteLine("h:{0:hh}, m:{0:mm}, s:{0:ss}",date);
            Console.WriteLine($"{date:yyyy.MM.dd.hh.mm.ss}");
            Console.WriteLine($"{pi:C}");
            Console.WriteLine($"{pi,15:N3}");
        }
    }
}
