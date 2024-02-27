using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 20);
            }

            Console.WriteLine("Array1: ");
            array.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine("Array2: ");
            foreach (int i in array.Where(x => x < 0))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
