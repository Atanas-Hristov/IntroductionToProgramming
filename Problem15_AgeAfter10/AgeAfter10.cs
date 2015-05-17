using System;

namespace Problem15_AgeAfter10
{
    class AgeAfter10
    {
        static void Main()
        {
            DateTime BirthDate;     //Variable for storing the birthday of the user
            TimeSpan AgeInDays;
            int ageNow;        //Variable for storing the current age of the user
            int After10;            //Variable for storing the age of the user after 10 years

            Console.Write("Please input your birthday: ");      //Asking the user for input
            BirthDate = DateTime.Parse(Console.ReadLine());     //Reading the input of the user, converting it to type DateTime and assining it to a variable

            AgeInDays = DateTime.Today.Subtract(BirthDate);     //Subtracting the birthdate from the current date
            ageNow = AgeInDays.Days / 365;                      //Calculatin the age of the user in years

            Console.WriteLine("Your age is: " + ageNow);        //Displays the current age of the user in the console

            After10 = ageNow + 10;                              //Calculating the age after 10 years

            Console.WriteLine("Your age after 10 years will be: " + After10); //Displays the user age after 10 years
        }
    }
}
