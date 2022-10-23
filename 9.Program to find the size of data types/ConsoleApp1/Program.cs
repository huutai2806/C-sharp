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
            Console.WriteLine("size of Char : " + sizeof(char));
            Console.WriteLine("size of Short : " + sizeof(short));

            Console.WriteLine("size of int : " + sizeof(int));
            Console.WriteLine("size of long : " + sizeof(long));

            Console.WriteLine("size of float : " + sizeof(float));
            Console.WriteLine("size of double : " + sizeof(double));
            Console.ReadKey();
        }
    }
}
