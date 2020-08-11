using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting+"\n");

            WriteLine(greeting.IndexOf("o"));
            WriteLine(greeting.LastIndexOf("o"));

            WriteLine(greeting.Contains("Evening"));
            WriteLine(greeting.Contains("Morning"));

            WriteLine(greeting.Replace("Morning", "Evening"));

            WriteLine(greeting.ToLower());
            WriteLine(greeting.ToUpper());
            WriteLine(greeting.Insert(4, "Sunday"));
            WriteLine(greeting.Remove(4, 8));
            WriteLine("    Hello World    ".Trim());

            WriteLine(greeting.Substring(0, 5));
            WriteLine(greeting.Substring(5));

            string[] arr = greeting.Split(new string[] { " " }, System.StringSplitOptions.None);
            foreach (string element in arr)
                WriteLine(element);

            Console.Read();
        }
    }
}
