/* ==============================
 * Problem 8.	Quotes in Strings
 * ==============================
 * Declare two string variables and assign them with following value:
 * The "use" of quotations causes difficulties.
 * Do the above in two different ways: with and without using quoted strings.
 * Print the variables to ensure that their value was correctly defined.
 */
using System;

class Quotes_In_Strings
{
    static void Main()
    {
        string StringVariableWOQuotetString = "The \"use\" of quotations causes difficulties.";
        string StringVariableWithQuotedString = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(StringVariableWOQuotetString);
        Console.WriteLine(StringVariableWithQuotedString);
    }
}
