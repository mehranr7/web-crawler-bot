using Newtonsoft.Json.Linq;
using web_crawler_bot.Models; // Ensure you have Newtonsoft.Json package installed

class Program
{
    static void Main(string[] args)
    {
        // Read the JSON file
        string jsonFile = File.ReadAllText("appsettings.json");

        // Parse JSON content
        JObject config = JObject.Parse(jsonFile);

        // Access variables
        var configurations = config["AppSettings"]!.ToObject<List<Query>>();
        
        // Display the values
        Console.WriteLine($"Variable1: ");

        // Your code using these variables goes here
    }
}