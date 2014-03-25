/* ==============================
 * Problem 1.	Declare Variables
 * ==============================
 * Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
 * Choose a large enough type for each number to ensure it will fit in it.
 * Try to compile the code. Submit the source code of your Visual Studio project as part of your homework submission.
 */

using System;

class Declare_Variables
{
    static void Main()
    {
        bool PrintResult = true;
        // ushort - unsigned 16-bit: 0 - 65535
        ushort Number52130 = 52130;
        // sbyte - signed 8-bit: -128 - 127
        sbyte NumberMinus115 = -115;
        // int - signed 32-bit - 
        int Number4825932 = 4825932;
        // byte - signed 8-bit: 0 - 255
        byte Number97 = 97;
        // short - signed 16-bit: -31768 - 32767
        short NumberMinus10000 = -10000;

        if (PrintResult)
        {
            Console.WriteLine(" " + Number52130);
            Console.WriteLine(" " + NumberMinus115);
            Console.WriteLine(" " + Number4825932);
            Console.WriteLine(" " + Number97);
            Console.WriteLine(" " + NumberMinus10000);
        }
    }
}