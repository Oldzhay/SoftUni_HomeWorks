/* =============================
 * Problem 2.	Float or Double?
 * =============================
 * Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
 * Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */

using System;

class Float_or_double
{
    static void Main()
    {
        //34.567839023, 12.345, 8923.1234857, 3456.091
        double Number34_567839023 = 34.567839023;
        double Number12_345 = 12.345;
        double Number8923_1234857 = 8923.1234857;
        double Number3456_091 = 3456.091;

       // Printing results
       Console.WriteLine(" " + Number34_567839023);
       Console.WriteLine(" " + Number12_345);
       Console.WriteLine(" " + Number8923_1234857);
       Console.WriteLine(" " + Number3456_091);
       
    }
}