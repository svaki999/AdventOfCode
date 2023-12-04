class Program
{
    static void Main()
    {
        string? filePath = "input.json";

        int sum = 0;

        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            // Initialize variables to store the first and last digits
            char firstDigit = '\0';
            char lastDigit = '\0';

            // Find the first numeric character
            foreach (char c in line)
            {
                if (char.IsDigit(c))
                {
                    firstDigit = c;
                    break;
                }
            }

            // Find the last numeric character
            for (int i = line.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(line[i]))
                {
                    lastDigit = line[i];
                    break;
                }
            }

            // Check if both digits are found and parse to an int
            if (firstDigit != '\0' && lastDigit != '\0')
            {
                string twoDigitNumberStr = $"{firstDigit}{lastDigit}";
                int twoDigitNumber = int.Parse(twoDigitNumberStr);

                // Add to the sum
                sum += twoDigitNumber;
            }
        }

        Console.WriteLine($"The sum of the two-digit numbers is: {sum}");
    }
}
