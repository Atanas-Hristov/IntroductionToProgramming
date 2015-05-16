using System;

namespace Problem14_CurrentDate
{
    class CurrentDate
    {
        static void Main()
        {
            DateTime CurrentDate = DateTime.Now;

            Console.WriteLine("The current date is: "+ CurrentDate.ToString("dd/MM/yyyy HH:MM"));            
        }
    }
}
