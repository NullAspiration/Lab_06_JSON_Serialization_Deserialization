using Lab_06_JSON_Serialization_Deserialization.Models;
using System.Net;
using System.Text.Json;
using ConsoleTables;

namespace Lab_06_JSON_Serialization_Deserialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creates Directory Variable Fot JSON
            var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            //Points to Data
            var filePath = root + $"{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}Space Exploration.json";
            var dataPath = root + $"{Path.DirectorySeparatorChar}Data";

            //Serialization options (lazy no capitalization)
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            //Reads all .json data
            foreach (string fileName in Directory.GetFiles(dataPath))
            {
                string jsonString = string.Empty;
                using (StreamReader sr = new StreamReader(fileName))
                {
                    jsonString = sr.ReadToEnd();
                }
                //just showing it reads the data folder and all contents
                Console.WriteLine(jsonString);

                var books = JsonSerializer.Deserialize<Book>(jsonString, options);

                Console.WriteLine(books);
            }
        }
    }
}