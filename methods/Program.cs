class Program
{
   static void Main(string[]args)
{
	static void SayHello()
	{
		Console.WriteLine("Hello World");
	}
    
    SayHello();
    static void Greet(string name)
    {
        Console.WriteLine($"Hello {name}");
    }

    Greet("Megan");
    Greet("Eric");
    static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    Console.WriteLine($"1 + 1 = {Add(1, 1)}");
    Console.WriteLine($"1 + 2 = {Add(1, 2)}");

    int sum = Add(24, 67);
    Console.WriteLine($"24 + 67 = {sum}");
    static void Print(string content)
    {
        Console.WriteLine(content);
    }

    static int AddIntegers(int num1, int num2)
    {
        return num1 + num2;
    }

    static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    int num1 = AddIntegers(5, 10);
    int num2 = Subtract(100, num1);
    Print(num2.ToString());

    
} 


}

