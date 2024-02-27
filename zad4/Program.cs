using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

class Program
{
    static void Main()
    {

        //NuGet Package HtmlAgilityPack required for data scraping
        //Solution > Right Click > Manage NuGet Packages > Search for HtmlAgilityPack > install 
        Console.OutputEncoding = Encoding.UTF8;

        var url = "https://meteo.bg/bg/izmervania/tochki";
        var web = new HtmlWeb();
        var doc = web.Load(url);
        var table = doc.DocumentNode.SelectSingleNode("//table");
        List<string> stations = new List<string>();
        List<int> temps = new List<int>();
        if (table != null)
        {
            foreach (var row in table.SelectNodes(".//tr"))
            {
                var columns = row.SelectNodes(".//td");
                if (columns != null && columns.Count >= 3)
                {
                    var stationName = columns[0].InnerText.Trim();
                    var temperature = columns[2].InnerText.Trim();
                    stations.Add(stationName);
                    temps.Add(int.Parse(temperature));
                    Console.WriteLine($"Station: {stationName,-18}, Temp: {temperature}");
                }
            }
            Console.WriteLine();

            int maxTemp = temps.Max();
            int minTemp = temps.Min();

            Console.WriteLine($"Max Temp: {maxTemp}");
            Console.WriteLine("Location/s with Max Temp:");
            for (int i = 0; i < temps.Count; i++)
            {
                if (temps[i] == maxTemp)
                {
                    Console.WriteLine($"- {stations[i]}");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Min Temp: {minTemp}");
            Console.WriteLine("Location/s with Min Temp:");
            for (int i = 0; i < temps.Count; i++)
            {
                if (temps[i] == minTemp)
                {
                    Console.WriteLine($"- {stations[i]}");
                }
            }
        }
        else
        {
            Console.WriteLine("Table not found.");
        }
    }
}
