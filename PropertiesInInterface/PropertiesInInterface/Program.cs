using System;

namespace PropertiesInInterface
{
    interface INamedValue
    {
        string Name
        {
            get;
            set;
        }
        string Value
        {
            get;
            set;
        }
    }
    class NamedValue : INamedValue
    {
        public string Name
        {
            get;
            set;
        }
        public string Value
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            { Name = "이름", Value = "이성은" };

            NamedValue height = new NamedValue()
            { Name = "키", Value = "172Cm" };

            NamedValue weight = new NamedValue()
            { Name = "몸무게", Value = "56Kg" };

            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");
        }
    }
}
