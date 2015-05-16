using System;

namespace Project8_SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            Double findRoot = 1;
            Console.Write("Please input a number: ");
            findRoot = int.Parse(Console.ReadLine());
            findRoot = Math.Sqrt(findRoot);
            Console.WriteLine("The square root is: "+ findRoot);
            
        }
    }
}
