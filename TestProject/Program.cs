using System;

namespace Testproject;

    public class Addition
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter the first Number: ");
        int first_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second Number: ");
        int second_num = Convert.ToInt32(Console.ReadLine());
        int final_number = first_num + second_num;
        Console.WriteLine("The Addition of two numbers:- " + final_number);
        }
    }

