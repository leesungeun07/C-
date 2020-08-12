using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StringFormatBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            string result1 = string.Format("ABC{0, 10}GHI", "DEF");
            string result2 = string.Format("ABC{0, -10}GHI", "DEF");
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            string fmt = "{0, -20}{1, -15}{2, 30}";
            Console.WriteLine(fmt, "Phublisher", "Author", "Title");
            Console.WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            Console.WriteLine(fmt, "Hanbit", "Sanghyun Park", "C# 7.0 programming");

            Console.WriteLine("10진수 : {0:D}", 123);
            Console.WriteLine("10진수 : {0:D5}", 123);
            Console.WriteLine("16진수 : {0:X}", 0xFF1234);
            Console.WriteLine("16진수 : {0:X8}", 0xFF1234);
            Console.WriteLine("숫자 : {0:N}", 123456789);
            Console.WriteLine("숫자 : {0:N0}", 123456789);
            Console.WriteLine("고정소숫점 : {0:F}", 123.45);
            Console.WriteLine("고정소숫점 : {0:F5}", 123.45);
            Console.WriteLine("지수 : {0:E}", 123.456789);

            DateTime dt = new DateTime(2020, 8, 12, 11, 4, 22);
            Console.WriteLine("12 시간 : {0:yyyy-mm-dd tt hh:mm:ss (ddd)}", dt);
            Console.WriteLine("24 시간 : {0:yyyy-mm-dd HH:mm:ss (dddd)}", dt);

            CultureInfo ciko = new CultureInfo("ko-KR");
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciko));
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciko));

            int number = 30214;
            string name = "성은";
            Console.WriteLine($"{number:D} {name, 10}");
        }
    }
}
