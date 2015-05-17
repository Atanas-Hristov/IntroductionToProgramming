using System;

namespace Project8_SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            Double findRoot;            //Variable for storing the initial number provided from the user.
            Double ansRoot;             //Variable for storing the answer

            Console.Write("Please input a number: ");       //Ask the user for input
            findRoot = int.Parse(Console.ReadLine());       //Parse the input to integer type and assign it to variable of type double

            ansRoot = Math.Sqrt(findRoot);                  //Find the square root and assign it to variable

            Console.WriteLine("\nThe square root of " + findRoot +" is:   "+ ansRoot);      //Print your findings to the user
            
        }
    }
}
