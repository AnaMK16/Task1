using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

class Program
{
    private static void Main(string[] args)
    {
        // სავარჯიშო 1
        
        Console.WriteLine("Enter your name and last name");
        string fullName = Console.ReadLine();
        Console.WriteLine(fullName);
        // სავარჯიშო 2 
        Console.WriteLine("Enter first number:");
        string firstNumber = Console.ReadLine();
        Console.WriteLine("Enter second number:");
        string secondNumber = Console.ReadLine();

        int first = int.Parse(firstNumber);
        int second = int.Parse(secondNumber);

        int x = first + second;

        int y = first * second;

        int z = first - second;

        int m = first % second;
        Console.WriteLine($"sum {x}, multiplication :{y}, substraction:{z}, remainder  :{m}");
        //სავარჯიშო 4
        Console.WriteLine("Enter first number");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number ");
        int second  = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 3rd number");
        int third = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 4th number");
        int fourthNumber = int.Parse(Console.ReadLine());

        Console.WriteLine((first + second + third + fourthNumber) / 4);
        //სავარჯიშო 6
        Console.WriteLine("Enter number");
        int firstNumber = int.Parse(Console.ReadLine());
        if (firstNumber > 0)
        {
            Console.WriteLine("Number is positive");
        }
        //სავარჯიშო 7


        Console.WriteLine("Enter first Number");
        int first  = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");

        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number");
        int third = int.Parse(Console.ReadLine());

        if (first > second && first > third )
        {
            Console.WriteLine(first);

        }
        else if (second > third)
        {
            Console.WriteLine(second);
        }
        else 
                {
            Console.WriteLine(third);
        } 


        if (first < second && first < third)
        {
            Console.WriteLine(first);

        }
        else if (second < third)
        {
            Console.WriteLine(second);
        }
        else
        {
            Console.WriteLine(third);
        } 
        
        //სავარჯიშო 8
        Console.WriteLine("Enter first number");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int second = int.Parse(Console.ReadLine());
        if (first == second)
        {
            first = first * 3;
            second = second * 3;
            Console.WriteLine(first);
            Console.WriteLine(second);

        }
        else
        {
            Console.WriteLine("firstnumber is not equal to second number");
        } 

        //სავარჯიშო 9
        Console.WriteLine("Enter Number");
        int first = int.Parse(Console.ReadLine());
        
        if (first % 7 == 0)
        {
            Console.WriteLine("is multiple");
        }
        else
        {
            Console.WriteLine("is not multiple");
        }
        
        
        //სავარჯიშო 10 
        Console.WriteLine("Enter first number ");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number ");
        int second = 5;
        bool result = first.ToString().Contains(second.ToString());
        if (result) {
            Console.WriteLine("Number contains 5");

        } else
        {
            Console.WriteLine("Number does not contain 5");
        } 

        Console.WriteLine("Enter number");
        int first = int.Parse(Console.ReadLine());
        string number = first.ToString();
        
        foreach (char c in number)
        {
            Console.Write($"{c} ");
        }
        

        //სავარჯიშო 3
        Console.WriteLine("Enter first number:");

        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int y = int.Parse(Console.ReadLine());
        int swap;
       
        
        swap=x;
        x=y;
        y = swap;



        Console.WriteLine(x);
        Console.WriteLine(y); 
        //სავარჯიშო 5
        double kelvin = 40;

        double celsius;
        celsius = kelvin - 273.15;
        Console.WriteLine(celsius);

    }
}