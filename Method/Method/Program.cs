using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Calculator
    {
        public static int Plus(int a, int b=0)
        {
            return a + b;
        }

        public static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }

        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        public static int Sum(params int[] args)
        {
            int sum = 0;
            for(int i=0; i<args.Length; i++)
            {
                sum += args[i];
            }
            return sum;
        }
    }

    class Product
    {
        private int price = 100;
        public ref int GetPrice()
        {
            return ref price;
        }
        
        public void PrintPrice()
        {
            Console.WriteLine($"Price : {price}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3; int b = 4;
            int result = Calculator.Plus(a, b);
            Console.WriteLine(result);

            result = Calculator.Minus(5, 2);
            Console.WriteLine(result);

            Console.WriteLine("a = {0}, b = {1}", a, b);
            Calculator.Swap(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a, b);

            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price }");

            result = Calculator.Plus(1, 2, 3);
            Console.WriteLine(result);

            double result2 = Calculator.Plus(1.0, 2.4);
            Console.WriteLine(result);

            Console.WriteLine(Calculator.Sum(1, 23, 4, 65, 46, 8, 48, 46, 894, 64, 65, 4984, 949));
            Console.WriteLine(Calculator.Plus(3));
            Console.WriteLine(Calculator.Plus(3, 4));

            double mean = 0;
            Mean(1, 2, 3, 4, 5, ref mean);
            Console.WriteLine("평균 : {0}", mean);
        }

        public static void Mean(
                double a, double b, double c,
                double d, double e, ref double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
