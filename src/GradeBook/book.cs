using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade); 
        }


        //line below used to be public void getStatistics(), removed the void in order to make it available for other namespaces
        //line below could of been public int getStatistic(), it would allow for a value to be return. However I am not interested in int
        //or string, i want an type 'object' called statistics. View statistics.cs for more details 
        public statistics getStatistics()
        {
            var result = new statistics();
            result.average = 0.0;
            result.high = double.MinValue;
            result.low = double.MaxValue;

            foreach(double grade in grades)
            {
                result.high = Math.Max(grade, result.high);
                result.low = Math.Min(grade, result.low);
                result.average = result.average + grade;
            }
            result.average =  result.average / grades.Count;
            return result;
        }

        private List<double> grades;
        public string Name;


    }
}