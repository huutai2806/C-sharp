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
            double meter, feet;
            Console.WriteLine("Enter feet :");//nhập giá trị feet 
            int v = Convert.ToInt32(Console.ReadLine());// gán v và hiển thị ra màn hình
            feet = v;// gán feet bằng v 
            meter = feet / 3.2808399;//gán meter = feed / 3.2808399
            Console.WriteLine("\nFeet in meter : " + meter);//hiển thị ra mà hình Feet in meter: meter
            Console.ReadKey();
        }
    }
}
