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
            int temp;

            Console.WriteLine("Type value of number 1 :");//nhập vào number1
            num1 = Convert.ToInt32(Console.ReadLine());//gán giá trị num1 
            Console.WriteLine("Type value of number 2 :");//nhập vào number2
            num2 = Convert.ToInt32(Console.ReadLine());//gán giá trị num 2

            temp = num1;//gán temp = num1
            num1 = num2;// gán num1 = num2
            num2 = temp;// gán num2 = temp

            Console.WriteLine("\nAfter swapping values");//hiển thị ra màn hình After Swapping values
            Console.WriteLine("Value of number 1 : " + num1);//hiển thị ra value of number1 sau khi tráo đổi
            Console.WriteLine("Value of number 2 : " + num2);//hiển thị ra value of number2 sau khi tráo đổi
            Console.ReadKey();

        }
    }
}
