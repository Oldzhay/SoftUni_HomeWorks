/* =============================
 * Problem 3.	Comparing Floats
 * ============================
 * Write a program that safely compares floating-point numbers with precision eps = 0.000001.
 * Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic.
 * Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
 * Examples:
 * |Number a	|Number b	|Equal (with precision eps=0.000001)    |Explanation
 * |5.3         |6.01	    |false	                                |The difference of 0.71 is too big (> eps)
 * |5.00000001	|5.00000003	|true                                   |The difference 0.00000002 < eps
 * | -0.0000007	|0.00000007	|true	                                |The difference 0.00000077 < eps
 * |-4.999999	|-4.999998	|false	                                |Border case. The difference 0.000001 == eps. We consider the numbers are different.
*/
using System;

class Comparing_Floats
{
    static void Main()
    {
        // define constant. Chanbgeable by the user;
        float eps = 0.000001f;

        Console.WriteLine("Please introduce firts number:");
        double FirstNumber = Math.Abs(double.Parse(Console.ReadLine()));
        Console.WriteLine("Please introduce the second number:");
        double SecondNumber = Math.Abs(double.Parse(Console.ReadLine()));
        Console.WriteLine("Default constant is 0.000001. Please type a new constant, if you want to change it and hit Enter: ");
        float Constant = Math.Abs(float.Parse(Console.ReadLine()));
        
        double result = FirstNumber - SecondNumber;
        if (Math.Abs(result) < eps)
        {
            Console.WriteLine("Number in range: true");
        }
        else
        {
            Console.WriteLine("Number out of range: false" );
        }
     }
}