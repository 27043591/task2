using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplyNums();
        }
        static void MultiplyNums()
        {
            Console.WriteLine("please enter your first input");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter your second input");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
        }
    }
}
