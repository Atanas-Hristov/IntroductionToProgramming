using System;

namespace Problem14_CurrentDate
{
    class CurrentDate
    {
        static void Main()
        {
            DateTime CurrentDate = DateTime.Now;        //Creates a variable of DateTime type and assigns to it the current day and time

            Console.WriteLine("The current date is: "+ CurrentDate.ToString("dd/MM/yyyy HH:MM"));     //Displays the current date into the specified format to the user       
        }
    }
}
