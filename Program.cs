using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string fileName = "../data.txt";
        try
        {
            string content = await ReadFileAsync(fileName);
            if (content != null)
            {
                Console.WriteLine($"Content from {fileName}: {content}");
            }
            else
            {
                Console.WriteLine($"File {fileName} is empty.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadLine(); // Wait for user input to exit
    }

    static async Task<string> ReadFileAsync(string fileName)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            return await reader.ReadToEndAsync();
        }
    }
}
