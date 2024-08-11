using System;

class Program
{
    static void Main()
    {
        // Input number
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Check if the number is odd or even
        if (num % 2 == 0)
        {
            Console.WriteLine("{0} is an even number.", num);
        }
        else
        {
            Console.WriteLine("{0} is an odd number.", num);
        }
    }
}