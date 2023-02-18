string[] snacks = { "sushi", "Pizza", "burger", "chicken wings", "Asian takaway" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Today we are going to eat: {snacks[randomIndex]}");