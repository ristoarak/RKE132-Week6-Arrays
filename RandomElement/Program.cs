string[] snacks = { "sushi", "pizza", "chiken", "burger", "Asian" };
Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"tonigt we are going to eat: {snacks[randomIndex]}.");

