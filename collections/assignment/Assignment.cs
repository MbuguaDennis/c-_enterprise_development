using System;
using System.Collections.Generic;

namespace Assignment;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> countryCapital = new Dictionary<string, string>
        {
            {"Kenya", "Nairobi"},
            {"Tanzania", "Dar es Salaam"},
            {"Burundi", "Bujumbura"}
        };

        foreach (KeyValuePair<string, string> capital in countryCapital)
        {
            Console.WriteLine($"{capital.Key}: {capital.Value}");
        }

        Console.WriteLine("Enter a country's Name");
        string userInput = Console.ReadLine();

        if (countryCapital.TryGetValue(userInput, out var capitalName))
        {
            Console.WriteLine($"The capital city of {userInput} is {capitalName}");
        }
        else
        {
            Console.WriteLine("Country Not Found!");
        }
    }
}