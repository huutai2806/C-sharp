using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp1
{
    class Program
    {
        static void Main(string[] args)
        {
                //khai báo biến
                int num1;
                int num2;
                int sum, sub, mult, mod;
                float div;

                Console.WriteLine("Enter first number :");//nhập vào giá trị first number
                num1 = Convert.ToInt32(Console.ReadLine());//gán giá trị 1 
                Console.WriteLine("Enter second number :");//nhập vào giá trị second number
                num2 = Convert.ToInt32(Console.ReadLine());//gán giá trị 2

                sum = num1 + num2;//gán sum = num1 + num2
                sub = num1 - num2;//gán sub = num1 - num2 
                mult = num1 * num2;//gán mult = num1 * num2
                mod = num1 % num2;//gán mod = num1 % num2
                div = (float)num1 / num2;//gán div = num1/num2

                Console.WriteLine("\nSum of number1 and number2 : " + sum);//hiển thi ra màn hình kết quả của sum 
                Console.WriteLine("Difference of number1 and number2 : " + sub);//hiển thị ra màn hình kết quả của sub
                Console.WriteLine("Product of number1 and number2 : " + mult);//hiện thị ra màn hình kết quả của mult 
                Console.WriteLine("Modulus of number1 and number2 : " + mod);//hiển thị ra màn hình kết quả của mod
                Console.WriteLine("Quotient of number1 and number2 : " + div);//hiển thị ra màn hình kết quả div 
                Console.ReadKey();
         
        }

    }
}
