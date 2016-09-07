using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fibonacci Squence finder. Type in the number you want in the sequence");
            var wantednumber = Console.ReadLine();

            
            var returnednumber = Factorial(int.Parse(wantednumber));
            Console.ReadKey();
        }
        //static int Factorial(int number)
        //{
        //    if (number == 1)
        //        return 1;
        //    Console.WriteLine(number);
        //    return number * Factorial(number - 1);
        //}
        //static int Fibonacci (int number)
        //{

        //    if (number == 1 || number ==2)
        //    {
        //        return 1;
        //    }
        //    Console.Write(number);

        //    return 1;
        //}
        static int Factorial(decimal timesToCalculate,int timesrun = 0,  int LastNumber = 0, int SecondLastNumber = 0)
        {
            if (timesrun >= timesToCalculate)
            {
                return 1;
            }
            timesrun++;
            if (timesToCalculate == 1 || timesToCalculate == 2 || timesrun > 10)
            {
                return 1;
            }
            if (LastNumber == 0)
            {
                SecondLastNumber = 1;
            }
            var currentnumber = LastNumber + SecondLastNumber;
            Console.WriteLine(currentnumber);
            return LastNumber + Factorial(timesToCalculate, timesrun, currentnumber, LastNumber);
        }
    }
}
