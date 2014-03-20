/* ==========================
 * Problem 11.	Employee Data
 * ==========================
 * A marketing company wants to keep record of its employees.
 * Each record would have the following characteristics:
 * •	First name
 * •	Last name
 * •	Age (0...100)
 * •	Gender (m or f)
 * •	Personal ID number (e.g. 8306112507)
 * •	Unique employee number (27560000…27569999)
 * Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
 * Use descriptive names.
 * Print the data at the console.
 */

using System;
class Employee_Data
{
    static void Main()
    {
        string EmployeeFirtsName = "Peter, A.k.a Pesho";
        string EmployeeLastName = "Smith";
        byte EmployeeAge = 33;
        char EmployeeGender = 'M';
        long EmployeeIDNumber = 8306112507;
        ushort EmployeeUniqueNumber = 1234;

        Console.WriteLine("Exployee Firts Name: " + EmployeeFirtsName);
        Console.WriteLine("Employee Last Name: " + EmployeeLastName);
        Console.WriteLine("Employee Age: " + EmployeeAge);
        Console.WriteLine("Employee Gender: " + EmployeeGender);
        Console.WriteLine("Employee Id Number: " + EmployeeIDNumber);
        Console.WriteLine("Employee Unique Number: " + 2756 + EmployeeUniqueNumber);
    }
}