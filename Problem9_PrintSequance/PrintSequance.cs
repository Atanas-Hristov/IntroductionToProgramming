using System;

namespace Problem9_PrintSequance
{
    class PrintSequance
    {
        static void Main()
        {

            for (int i = 2; i < 12; i++)        //Creates a loop counting from 2 to 12 (10 values)
            {
                if (i % 2 == 0)                 //If the remainder of the division is 0
                {
                    Console.Write(i+", ");      //display the number to the console
                }
                else Console.Write(-i + ", ");  //otherwise display the number multiplied by -1

            }   //end of for loop

        }   //end of main

    }   //end of class

}   //end of namespase
