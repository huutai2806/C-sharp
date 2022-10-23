using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai báo biến
            double celsius, fahrenheit;
            Console.WriteLine("Enter Temperature in Celsius : ");//nhâp vào Teperature in celsius
            celsius = Convert.ToDouble(Console.ReadLine());//gán celsius và hiển thị ra màn hình
            fahrenheit = (1.8 * celsius) + 32;//gán fahrenheit =
            Console.WriteLine("Temperature in Fahrenheit : " + fahrenheit);//hiển thị ra màn hình + kết quả của fahrenheit
            Console.ReadKey();
        }
    }
}
