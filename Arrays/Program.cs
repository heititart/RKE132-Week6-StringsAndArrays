

//string[] fruits = { "apples", "bananas", "oranges" };


string[] fruit = new string[3];

Console.WriteLine("Enter first fruit:");
fruit[0] = Console.ReadLine();

Console.WriteLine("Enter second fruit:");
fruit[1] = Console.ReadLine();

Console.WriteLine("Enter third fruit:");
fruit[2] = Console.ReadLine();

Console.WriteLine($" {fruit[0]},{fruit[1]},{fruit[2]}" );

int fruitArrayLength = fruit.Length;
Console.WriteLine($"There are: {fruitArrayLength} in your refrigerator" );