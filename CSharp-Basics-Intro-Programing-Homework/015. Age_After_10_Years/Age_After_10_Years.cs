/* =================================
 * Problem 15.	* Age after 10 Years
 * =================================
 * Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
 * Your cah check your results here: http://www.mathcats.com/explore/agecalculator.html
 */

using System;

class Age_After_10_Years
{
    static void Main()
    {
        Console.WriteLine(" Hello, this simple program will calcualte your current age\n and your age after 10 years ");
        // Reading birhtday
        Console.Write(" Please introduce your birhtday (MM/dd/yyyy): ");
        DateTime BirhtDay = DateTime.Parse(Console.ReadLine());
        
        // Today's Date
        DateTime TodayIs = DateTime.Today;
        
        // Calculating your age
        int CurrentAge = TodayIs.Year - BirhtDay.Year;
           
        // Calculating how old are you at the moment
        if (TodayIs.Month < BirhtDay.Month)
        {
            Console.WriteLine(" Now your are {0} years old", CurrentAge + 9);
            Console.WriteLine(" After 10 years you will be {0} years old.", CurrentAge + 9);
        }
        else if (TodayIs.Month == BirhtDay.Month)
        {
            if (TodayIs.Day < BirhtDay.Day)
            {
                Console.WriteLine(" Now your are {0} years old", CurrentAge + 9);
                Console.WriteLine(" After 10 years you will be {0} years old.", CurrentAge + 9);
            }
            else if (TodayIs.Day > BirhtDay.Day)
            {
                Console.WriteLine(" Now your are {0} years old", CurrentAge + 10);
                Console.WriteLine(" After 10 years you will be {0} years old.", CurrentAge + 10);
            }
            else if (TodayIs.Day == BirhtDay.Day)
            {
                Console.WriteLine(" After 10 years you will be EXACTLY {0} years old!", CurrentAge + 10);
                Console.WriteLine();
                Console.WriteLine(" And By The Way Today Is Your Birth Day. Congrats!!! \n Please Don't Drink And Drive!!!");
                
            }
        }
        else 
        {
            Console.WriteLine("After 10 years you will be {0} years old.", CurrentAge + 10);
        }
        
    }
}