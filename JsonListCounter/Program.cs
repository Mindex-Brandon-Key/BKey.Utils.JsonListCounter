using System;
using Newtonsoft.Json.Linq; // You need to install Newtonsoft.Json package

namespace BKey.Utils.JsonListCounter;

internal class Program
{
    public static void Main(string[] args)
    {
        string jsonData = "";

        // Check if a file path is provided in command line arguments
        if (args.Length > 0)
        {
            string filePath = args[0];
            jsonData = System.IO.File.ReadAllText(filePath);
        }
        else
        {
            Console.WriteLine("Please enter the JSON data or file path:");
            string input = Console.ReadLine();

            // Check if input is a file path
            if (System.IO.File.Exists(input))
            {
                jsonData = System.IO.File.ReadAllText(input);
            }
            else
            {
                jsonData = input;
            }
        }

        try
        {
            // Parse JSON data
            JArray jsonArray = JArray.Parse(jsonData);

            // Count and display the number of items
            Console.WriteLine($"Number of items in JSON list: {jsonArray.Count}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred: {ex.Message}");
        }
    }
}
