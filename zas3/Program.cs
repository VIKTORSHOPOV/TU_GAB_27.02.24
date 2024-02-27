using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        int year = DateTime.Now.Year;
        List<(string Month, int Days)> daysInMonth = new List<(string, int)>();

        for (int month = 1; month <= 12; month++)
        {
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
            int days = DateTime.DaysInMonth(year, month);
            daysInMonth.Add((monthName, days));
        }

        foreach (var (monthName, days) in daysInMonth)
        {
            Console.WriteLine($"{monthName}: {days} days");
        }
    }
}
