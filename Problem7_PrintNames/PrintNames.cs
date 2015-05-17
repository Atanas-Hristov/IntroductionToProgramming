using System;


namespace Problem7_PrintNames
{
    class PrintNames
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, \n Today we shall print some names:\n");      //Printing some text to the console.
            Console.WriteLine("John Atanasov");                                     //The first WriteLine uses an escape sequance for new line -> \n
            Console.WriteLine("Vincent Best");                                      //The next 3 lines to the same, but without escape sequance.
            Console.WriteLine("Massimo Bonzi");
        }
    }
}
