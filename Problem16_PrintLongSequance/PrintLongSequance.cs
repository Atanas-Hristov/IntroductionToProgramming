using System;

namespace Problem9_PrintSequance
{
    class PrintSequance
    {
        static void Main()
        {
            for (int i = 2; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                else Console.Write(-i + ", ");
            }
        }
    }
}
