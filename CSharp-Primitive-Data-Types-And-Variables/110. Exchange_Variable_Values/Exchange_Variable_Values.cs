/* =====================================
 * Problem 10.	Exchange Variable Values
 * =====================================
 * Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values.
 * Print the variable values before and after the exchange.
 */

using System;

class Exchange_Variable_Values
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int TemporaryVariable;
        Console.WriteLine("Variable values before: a={0} and b={1}", a, b);
        Console.WriteLine("Exchanging...");
        TemporaryVariable = a;
        a = b;
        b = TemporaryVariable;
        Console.WriteLine("Variable values after: a={0} and b={1}", a, b);
    }
}