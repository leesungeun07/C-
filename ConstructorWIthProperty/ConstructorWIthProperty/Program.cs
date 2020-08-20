using System;

namespace ConstructorWIthProperty
{
    class BirthdayInfo
    {
        public string Name
        {
            get;
            set;
        }
        public DateTime Birthday
        {
            get;
            set;
        }
        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "성은",
                Birthday = new DateTime(2002, 7, 25)
            };
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}
