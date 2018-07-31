using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //task B
            Console.WriteLine("please enter your first number ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("please enter your second ");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("{0} x {1} = {2}", num1, num2, MultiplyNumsExtended(num1, num2));
        }
        static float MultiplyNumsExtended (float _num1, float _num2)
        {
            return _num1 * _num2;
        }
    }
}
