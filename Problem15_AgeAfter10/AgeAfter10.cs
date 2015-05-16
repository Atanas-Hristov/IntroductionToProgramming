using System;

namespace Problem15_AgeAfter10
{
    class AgeAfter10
    {
        static void Main()
        {
            DateTime BirthDate;
            int After10;

            Console.Write("Please input your birthday: ");
            BirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Your age is: " + (DateTime.Today.Year - BirthDate.Year));

            After10 = (DateTime.Today.Year - BirthDate.Year) + 10;
            Console.WriteLine("Your age after 10 years will be: " + After10);
        }
    }
}
