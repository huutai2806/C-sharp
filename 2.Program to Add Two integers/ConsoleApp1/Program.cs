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
            int num1;
            int num2;
            int total;

            Console.WriteLine("Enter first nunber :");//nhập vào first number
            num1 = Convert.ToInt32(Console.ReadLine());// gán giá trị num1 
            Console.WriteLine("Enter second number :");//nhập vào second number
            num2 = Convert.ToInt32(Console.ReadLine());//gán giá trị num2
            total = num2 + num1;//gán total = num2 + num1
            Console.WriteLine("Total is : " + total);//viết ra màn hình Total is: + với total = num2 + num1
            Console.ReadKey();
        }
    }
}
