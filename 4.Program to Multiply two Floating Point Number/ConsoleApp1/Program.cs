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
            double num1;
            double num2;
            double total;

            Console.WriteLine("Enter first number :");//nhập vào first number và hiển thị ra màn hình
            num1 = Convert.ToDouble(Console.ReadLine());//gán giá trị num1
            Console.WriteLine("Enter second number :");// nhập second number và hiển thị ra màn hình
            num2 = Convert.ToDouble(Console.ReadLine());//gán giá trị num2

            total = num2 * num1;// gán total = num2 * num1

            Console.WriteLine("\n total is : " + total);//hiển thị ra màn hình total is : + giá trị của total=num2 * num1
            Console.ReadKey();
        }
    }
}
