using System;

class Age_After_10_Years
{
    static void Main()
    {
        // Reading birhtday
        Console.WriteLine(" Hello, this simple program will calcualte your current age\n and your age after 10 years ");
        Console.Write(" Please intrudoce your birhtday: ");
        string age;
        age = Console.Read();

        DateTime birth = DateTime.Parse(age);
        
        /* 
        
        Console.WriteLine(age);

        /*
        DateTime CurrentDate = DateTime.Now;
        Console.Write("Current Date And Time: ");
        Console.WriteLine("Please type your birhtdate in the following format: dd, mm, yyyy ");

        DateTime BirthDay = Console.ReadLine();
        Console.WriteLine(BirthDay);
        */
    }
}
