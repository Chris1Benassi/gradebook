using System;
using System.Collections.Generic;

//for additional information on namespaces and limitations review https://www.geeksforgeeks.org/c-sharp-namespaces/
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {   
            var book = new Book("Chris's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
            var stats = book.getStatistics();

            Console.WriteLine($"The average grade is {stats.average:N2}");
            Console.WriteLine($"The highest grade is {stats.high:N2}");
            Console.WriteLine($"The lowest grade is {stats.low:N2}");
            Console.WriteLine("This is a test sentence.");

            /*the first one is an array however it has limitations, not able to ajust on the fly. So we used list instead
            var numbers = new double[] {12.7, 10.3, 6.11, 4.1};
            for information on collections like list https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections
            */
        }
    }
}
