internal class Program
{
    private static void Main(string[] args)
    {
        string str = "Hello, World!";
        
        Console.Write("Enter a character: ");
        char character = Console.ReadLine()[0];

        int count = 0;
        
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == character)
            {
                count++;
            }
        }
        
        Console.WriteLine($"Number of occurrences of '{character}' in the string: {count}");
    }
}