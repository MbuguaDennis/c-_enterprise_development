using System;
using System.Globalization;

namespace MethodAssignment;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Alice", "Bob", "Charlie" };

        string[] lowerNames = Downcase(names);

        Console.WriteLine(String.Join(", ", lowerNames));
        // Output -> alice, bob, charlie
    }

    static string[] Downcase(string[] names)
    {
        string[] result = new string[names.Length];

        for (int i = 0; i < names.Length; i++)
        {
            result[i] = names[i].ToLower();
        }

        return result;
    }

    // wishlist
      List<string> wishList = new List<string>();
      int num =5;
      string userList = Console.ReadLine();
    

};


//