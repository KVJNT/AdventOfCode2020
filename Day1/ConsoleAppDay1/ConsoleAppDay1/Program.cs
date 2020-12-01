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
            var text = File.ReadAllText(@"C:\Users\Kristijan\Desktop\AdventOfCode\Day1\input.txt");

           var list = new List<string>(text.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries));


            var val1 = 0;
            var val2 = 0;

            while (val1 == 0 && val2 == 0)
            {
                foreach (var l1 in list)
                {
                    var value1 = int.Parse(l1);
                    foreach (var value2 in list.Select(int.Parse).Where(value2 => value1 + value2 == 2020))
                    {
                        val1 = value1;
                        val2 = value2;
                    }
                }
            }

            Console.WriteLine("rez = "+val1 * val2);

            val1 = 0;
            val2 = 0;
            var val3 = 0;

            while (val1 == 0 && val2 == 0 && val3 == 0)
            {
                foreach (var l1 in list)
                {
                    var value1 = int.Parse(l1);

                    foreach (var l2 in list)
                    {
                        var value2 = int.Parse(l2);

                        foreach (var value3 in list.Select(int.Parse).Where(value3 => value1 + value2 +value3== 2020))
                        {
                            val1 = value1;
                            val2 = value2;
                            val3 = value3;
                        }
                        
                    }
                }
            }

            Console.WriteLine("rez2 = "+val1 * val2 * val3);

            Console.Read();
        }
    }
}
