/* ===================================
 * Problem 13.	Null Values Arithmetic
 * ===================================
 * Create a program that assigns null values to an integer and to a double variable.
 * Try to print these variables at the console.
 * Try to add some number or the null literal to these variables and print the result.
 */

using System;

class Null_Values_Arithmetic
{
    static void Main()
    {
        int? integerVariable = null;
        double? doubleVariable = null;

        Console.WriteLine("integer Variable: " + integerVariable);
        Console.WriteLine("double Variable: " + doubleVariable);
        Console.WriteLine("null plus number: " + (null + 3.14159));
    }
}
