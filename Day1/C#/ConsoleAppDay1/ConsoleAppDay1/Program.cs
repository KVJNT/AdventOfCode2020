using System;
using System.Collections.Generic;
using  System.IO;
using System.Linq;

namespace ConsoleAppDay1
{
    internal static class Program
    {
        private static void Main()
        {

            var text = File.ReadAllText(@"C:\Users\Kristijan\Desktop\AdventOfCode\Day1\C#\input.txt");

            var list = new List<string>(text.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries));

            var value = "";

            while (value != "0")
            {

                Console.WriteLine("+--------------------+");
                Console.WriteLine("+ 1 for part I       +");
                Console.WriteLine("+ 2 for part II      +");
                Console.WriteLine("+ 0 for EXIT         +");
                Console.WriteLine("+--------------------+");
                value = Console.ReadLine();

                switch (value)
                {
                    case "1":
                        Console.WriteLine("rez = " + PartI(list));
                        break;
                    case "2":
                        Console.WriteLine("rez = " + PartII(list));
                        break;
                }
            }
        }

        private static string PartI(IReadOnlyCollection<string> list)
        {

                foreach (var l1 in list)
                {
                    var value1 = int.Parse(l1);
                    foreach (var value2 in list.Select(int.Parse).Where(value2 => value1 + value2 == 2020))
                    {
                        return (value1 * value2).ToString();
                    }
                }
                return "";
        }

        private static string PartII(IReadOnlyCollection<string> list)
        {

            foreach (var l1 in list)
            {
                var value1 = int.Parse(l1);

                foreach (var l2 in list)
                {
                    var value2 = int.Parse(l2);

                    foreach (var value3 in list.Select(int.Parse).Where(value3 => value1 + value2 + value3 == 2020))
                    {
                        return (value1 * value2 * value3).ToString();
                    }

                }
            }
            return "";
        }
    }
}
