/* ====================================
 * Problem 14.	* Current Date and Time
 * ====================================
 * 
 * Create a console application that prints the current date and time.
 * Find in Internet how.
 */

using System;

class Current_Date_And_Time
{
    static void Main()
    {
        DateTime CurrentDate = DateTime.Now;
        Console.Write("Current Date And Time: ");
        Console.WriteLine(CurrentDate);
    }
}
