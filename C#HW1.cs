//Homework 1.1.1

using System;

class WeatherProgram
{
    static void Main()
    {

        Console.WriteLine("Enter the temperature: ");
        int temperature = int.Parse(Console.ReadLine());

        if (temperature < 0)
        {
            Console.WriteLine("Freezing weather");
        }

        else if (temperature < 10)
        {
            Console.WriteLine("cold weather");
        }

        else if (temperature < 20)
        {
            Console.WriteLine("normal weather");
        }

        else if (temperature < 30)
        {
            Console.WriteLine("Moderate weather");
        }

        else
        {
            Console.WriteLine("Hot weather");
        }
    }
}




//Homework 1.1.2

using System;

class AgeGroup
{
    static void Main()
    {

        Console.WriteLine("Enter your age");
        int age = int.Parse(Console.ReadLine());

        if (age < 13)
        {
            Console.WriteLine("You are child");
        }

        if (age > 13 && age < 19)
        {
            Console.WriteLine("You are teenager");
        }

        if (age > 19)
        {
            Console.WriteLine("You are adult");
        }
    }
}





//Homework 1.1.3

using System;

class TemperatureConverter
{
    static void Main()
    {

        Console.WriteLine("Welcome to Temperature Converter");
        Console.WriteLine("Choose 1 (farenheit) or 2(Celsius): ");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("Write the Temperature");
        float temp = float.Parse(Console.ReadLine());

        if (choice == 1)
        {
            temp = (temp - 32) * 5 / 9;
        }

        else if (choice == 2)
        {
            temp = temp * 9 / 5 + 32;
        }

        Console.WriteLine(temp);
    }
}





//Homework 1.2.1

using System;

class ArrayMinMaxFinder
{
    static void Main()
    {
        // Example array
        int[] numbers = { 5, 2, 8, 1, 7, 4, 3, 9, 6 };
        Console.WriteLine("Array: " + string.Join(", ", numbers));

        // Sort the array
        Array.Sort(numbers);
        Console.WriteLine("Array: " + string.Join(", ", numbers));

        // Find maximum and minimum elements
        int max = numbers[numbers.Length - 1];
        int min = numbers[0];

        // Display results
        Console.WriteLine("Maximum Element: " + max);
        Console.WriteLine("Minimum Element: " + min);
    }
}



//Homework 1.2.2

using System;

class ArrayMinMaxFinder
{
    static void Main()
    {
        // Example array
        int[] numbers = { 5, 2, 8, 1, 7, 4, 3, 9, 6 };
        Console.WriteLine("Array: " + string.Join(", ", numbers));

        int length = numbers.Length;

        for (int i = 0; i < length / 2; i++)
        {

            // Swap elements at positions i and length - 1 - i
            int temp = numbers[i];
            numbers[i] = numbers[length - 1 - i];
            numbers[length - 1 - i] = temp;
        }

        Console.WriteLine("Array: " + string.Join(", ", numbers));

    }
}






//Homework 1.2.3

using System;

class ArrayMinMaxFinder
{
    static void Main()
    {
        // Example array
        int[] numbers = { 5, 2, 8, 1, 7, 4, 3, 9, 6 };
        Console.WriteLine("Array: " + string.Join(", ", numbers));

        int length = numbers.Length;

        Array.Sort(numbers);
        Console.WriteLine("Array: " + string.Join(", ", numbers));

        Console.WriteLine(numbers[length - 1]);
    }
}