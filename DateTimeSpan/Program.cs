﻿using System;

namespace DateTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2020, 10, 25);
            DateTime date2 = new DateTime(2022, 10, 26);
            TimeSpan span1 = date2 - date1;
            //TimeSpan span2 = new TimeSpan(1, 0, 0, 0);
            DateTime difference = DateTime.MinValue + span1;// - span2;
            Console.WriteLine($"Years: {difference.Year-1}, Months: {difference.Month-1}, Days: {difference.Day-1}.");
        }
    }
}
