/* =====================
 * Print the ASCII Table
 * =====================
 * Find online more information about ASCII (American Standard Code for Information Interchange) 
 * and write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255).
 * Note that some characters have a special purpose and will not be displayed as expected.
 * You may skip them or display them differently. You may need to use for-loops (learn in Internet how).
 */

using System;

class PrintASCIITable
{
    static void Main()
    {
        Console.WriteLine("Writing ASCII characters one per line: ");
        for (int i = 1; i < 128; i++)
        {
            if (i == 0 || i == 7 || i == 8 || i == 9 || i == 10 || i == 13 || i == 32)
            {
                Console.WriteLine(i + ". is non printable ASCII Character");
            }
            else
            {
                Console.WriteLine(i + ". ASCII: " + (char)i);
            }
        }
        Console.WriteLine("Beeping twice, just for fun :-)");
        Console.Write((char)7);
        Console.Write((char)7);
    }
}
