class Program
{
    static void Main()
    {
        string? filePath = "input.json";
        string[] lines = File.ReadAllLines(filePath);

        Dictionary<string, int> cubeCount = new Dictionary<string, int>
        {
            { "blue", 0 },
            { "red", 0 },
            { "green", 0 }
        };

        foreach (string game in lines)
        {
            string[] sets = game.Split(';');

            foreach (string set in sets)
            {
                string[] parts = set.Split(' ');

                string color = parts[1].ToLower();
                int count = int.Parse(parts[0]);

                cubeCount[color] += count;
            }
        }

        foreach (var kvp in cubeCount)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
