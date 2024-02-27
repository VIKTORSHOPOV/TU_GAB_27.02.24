using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
                array[i] = i;
            array.ToList().ForEach(x => Console.Write(x + 1 + " "));
            Console.WriteLine();
            array.Reverse().ToList().ForEach(x => Console.Write(x + 1 + " "));
            Console.WriteLine();
        }
    }
}
