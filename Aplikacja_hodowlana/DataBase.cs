using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Aplikacja_hodowlana
{
    public class DataBase
    {
        // Database class, contains lists of all animals, reptiles, amphibians, arthropods and food
        public List<Animals> Animals { get; set; }
        public List<Reptiles> Reptiles { get; set; }
        public List<Amphibians> Amphibians { get; set; }
        public List<Arthropods> Arthropods { get; set; }
        public List<Food> Food { get; set; }
        

        // Need to create methods to add, remove and edit animals, reptiles, amphibians, arthropods and food and to save and load data from a JSON file
        // Default file path
        private static string defaultFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json");

        public DataBase()
        {
            Animals = new List<Animals>();
            Reptiles = new List<Reptiles>();
            Amphibians = new List<Amphibians>();
            Arthropods = new List<Arthropods>();
            Food = new List<Food>();
        }

        // Method to save data to a JSON file
        public void SaveToJsonFile(string filePath = null)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = defaultFilePath;
            }
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        // Method to load data from a JSON file
        public static DataBase LoadFromJsonFile(string filePath = null)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = defaultFilePath;
            }

            if (!File.Exists(filePath))
            {
                return new DataBase();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<DataBase>(json);
        }
    }
}
