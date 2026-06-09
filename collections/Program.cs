// C# collections
// arrays
string  [] fruits = ["bananas","mangoes","apples"];

Console.WriteLine(fruits[0]);
Console.WriteLine(fruits[1]);
Console.WriteLine(fruits[2]);


int[] myLuckyNumbers = { 3, 6, 9 };

for (int i = 0; i < myLuckyNumbers.Length; i++)
{
    Console.WriteLine($"Lucky number #{i + 1} is {myLuckyNumbers[i]}");
}

// Lists 
List <string> hobbies = new List<string> ();

hobbies.Add("Reading");
hobbies.Add("Sleeping");
hobbies.Add("Preaching");
Console.WriteLine(hobbies.Count);
{
    
};


// Dictiionaries

Dictionary<string, string> countryCapitals = new Dictionary<string, string>
{
    { "Kenya", "Nairobi" },
    { "Uganda", "Kampala" },
    { "Tanzania", "Dodoma" }
};
Console.WriteLine(countryCapitals["Kenya"])

