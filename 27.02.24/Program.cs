using System;
using System.Collections.Generic;
using System.Linq;
namespace DZI
{
    class Zad26
    {
        static void Main(string[] args)
        {
            var words = new List<string>();
            var input = Console.ReadLine().Split(' ').ToList();
            while (input[0].ToUpper() != "END")
            {
                switch (input[0])
                {
                    case "Add":
                        words.AddRange(input.Skip(1));
                        break;
                    case "Update":
                        words = words.Select(w => char.ToUpper(w[0]) + w.Substring(1)).ToList();
                        break;
                    case "Remove":
                        words.RemoveAt(int.Parse(input[1]));
                        break;
                    case "Search":
                        var search = input[1];
                        Console.WriteLine(words.Contains(search) ? words[words.IndexOf(search)] : "Not contained.");
                        break;
                    case "Length":
                        var length = int.Parse(input[1]);
                        var result = words.Where(x => x.Length == length).ToList();
                        Console.WriteLine(result.Any() ? string.Join("-", result) : "Not contained.");
                        break;
                    case "Insert":
                        var position = int.Parse(input[1]);
                        var item = input[2];
                        try
                        {
                            words.Insert(position, item);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("There are not enough  items in the list.", ex);
                        }
                        break;
                    case "Print":
                        Console.WriteLine(string.Join("; ", words));
                        break;
                }
                input = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
