/* ==========================
 * Problem 5.	Unicode Value
 * ==========================
 * Declare a character variable and assign it with the symbol that has Unicode code 72, and then print it.
 * Hint: first, use the Windows Calculator to find the hexadecimal representation of 72.
 * The output should be “H”.
*/

using System;

class Unicode_Value
{
    static void Main()
    {
        char CharVariable = 'H';
        Console.WriteLine("The Unicode code {0}, corresponds to char {1}", (int)CharVariable, CharVariable);
    }
}
