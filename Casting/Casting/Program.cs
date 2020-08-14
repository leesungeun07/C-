using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Mammal
    {
        public Mammal()
        {
        Console.WriteLine("Hellow Mammal");
        }

        public void Nurse()
        {
          Console.WriteLine("동물을 길러요.");
        }
    }

    class Dog : Mammal
    {
        public Dog()
        {
            Console.WriteLine("Hello Dog");
        }
        public void Bark()
        {
            Console.WriteLine("멍멍~");
        }
    }

    class Cat : Mammal
    {
        public Cat()
        {
            Console.WriteLine("Hello Cat");
        }

        public void Meow()
        {
            Console.WriteLine("냐옹~");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mammal m = new Mammal();
            Dog d = new Dog();
            m.Nurse();
            d.Nurse();  d.Bark();

            Mammal mc = new Cat(); //다운 캐스트
            mc.Nurse(); //mc.Meow();

            //Cat cm = new Mammal(); //업 캐스트 안됨
        }
    }
}
