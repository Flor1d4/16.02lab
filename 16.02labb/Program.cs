using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._02labb
{
    struct MyDate
    {
        public DateTime date;
        public MyDate(int d, int m, int y)
        {
            date = new DateTime(y, m, d);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDate d = new MyDate(21, 01, 2004);
            Console.WriteLine("\n---Your day of birthday---");
            Console.WriteLine(d.date.ToString());
            Console.WriteLine(d.date.DayOfWeek);
            Console.WriteLine("\n---Your day of birthday in 2025---");
            MyDate d25 = new MyDate(21, 01, 2025);
            Console.WriteLine(d25.date.ToString());
            Console.WriteLine(d25.date.DayOfWeek);
            Console.WriteLine("\n---Time Untill Birthday---");
            var prevDate = new DateTime(2025, 1, 21);
            var today = DateTime.Now;
            var diffOfDates = prevDate - today;
            Console.WriteLine("Difference in Timespan: {0}", diffOfDates);
            Console.WriteLine("Difference in Days: {0}", diffOfDates.Days);
            Console.WriteLine("Difference in Hours: {0}", diffOfDates.Hours);
            Console.WriteLine("Difference in Miniutes: {0}", diffOfDates.Minutes);
            Console.WriteLine("Difference in Seconds: {0}", diffOfDates.Seconds);
            Console.WriteLine("Difference in Milliseconds: {0}", diffOfDates.Milliseconds);
            Console.WriteLine("Difference in Ticks: {0}", diffOfDates.Ticks);
        }
    }
}
