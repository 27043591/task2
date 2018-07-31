using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {//task C
            float num1, num2;
            Console.WriteLine("please enter a number");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("pleas enter another number");
            num2 = float.Parse(Console.ReadLine());
            Math mathClassInstance = new Math();
            Console.WriteLine("{0} x {1} = {2}", num1, num2, mathClassInstance.MultiplyNumsExtended(num1, num2));

        }
    }
    class Math
    {
        public float MultiplyNumsExtended(float _num1, float _num2)
        {
            return _num1 * _num2;
        }
    }
}
