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

        // Add Methods
        public void AddAnimal(Animals animal) => Animals.Add(animal);
        public void AddReptile(Reptiles reptile) => Reptiles.Add(reptile);
        public void AddAmphibian(Amphibians amphibian) => Amphibians.Add(amphibian);
        public void AddArthropod(Arthropods arthropod) => Arthropods.Add(arthropod);
        public void AddFood(Food food) => Food.Add(food);

        // Remove Methods
        public void RemoveAnimal(Animals animal) => Animals.Remove(animal);
        public void RemoveReptile(Reptiles reptile) => Reptiles.Remove(reptile);
        public void RemoveAmphibian(Amphibians amphibian) => Amphibians.Remove(amphibian);
        public void RemoveArthropod(Arthropods arthropod) => Arthropods.Remove(arthropod);
        public void RemoveFood(Food food) => Food.Remove(food);

        // Edit Methods 
        public void EditAnimal(Animals updatedAnimals)
        {
            var animals = Animals.FirstOrDefault(a => a.Id == updatedAnimals.Id);
            if (animals != null)
            {
                Animals[Animals.IndexOf(animals)] = updatedAnimals;
            }
            var animals2 = Animals.FirstOrDefault(a => a.Name == updatedAnimals.Name);
            if (animals2 != null)
            {
                Animals[Animals.IndexOf(animals2)] = updatedAnimals;
            }
            var animals3 = Animals.FirstOrDefault(a => a.Group == updatedAnimals.Group);
            if (animals3 != null)
            {
                Animals[Animals.IndexOf(animals3)] = updatedAnimals;
            }
            var animals4 = Animals.FirstOrDefault(a => a.Species == updatedAnimals.Species);
            if (animals4 != null)
            {
                Animals[Animals.IndexOf(animals4)] = updatedAnimals;
            }
            var animals5 = Animals.FirstOrDefault(a => a.Environment == updatedAnimals.Environment);
            if (animals5 != null)
            {
                Animals[Animals.IndexOf(animals5)] = updatedAnimals;
            }
            var animals6 = Animals.FirstOrDefault(a => a.ActivityTime == updatedAnimals.ActivityTime);
            if (animals6 != null)
            {
                Animals[Animals.IndexOf(animals6)] = updatedAnimals;
            }
            var animals7 = Animals.FirstOrDefault(a => a.DateOfLastFeeding == updatedAnimals.DateOfLastFeeding);
            if (animals7 != null)
            {
                Animals[Animals.IndexOf(animals7)] = updatedAnimals;
            }
            var animals8 = Animals.FirstOrDefault(a => a.DateOfBirth == updatedAnimals.DateOfBirth);
            if (animals8 != null)
            {
                Animals[Animals.IndexOf(animals8)] = updatedAnimals;
            }
        }
        public void EditReptile(Reptiles updatedReptile)
        {
            var reptile = Reptiles.FirstOrDefault(r => r.Morph == updatedReptile.Morph);
            if (reptile != null)
            {
                Reptiles[Reptiles.IndexOf(reptile)] = updatedReptile;
            }
            var reptile1 = Reptiles.FirstOrDefault(r => r.Lenght == updatedReptile.Lenght);
            if (reptile1 != null)
            {
                Reptiles[Reptiles.IndexOf(reptile1)] = updatedReptile;
            }
            var reptile2 = Reptiles.FirstOrDefault(r => r.Weight == updatedReptile.Weight);
            if (reptile2 != null)
            {
                Reptiles[Reptiles.IndexOf(reptile2)] = updatedReptile;
            }
        }
        public void EditAmphibian(Amphibians updatedAmphibian)
        {
            var amphibian = Amphibians.FirstOrDefault(a => a.Morph == updatedAmphibian.Morph);
            if (amphibian != null)
            {
                Amphibians[Amphibians.IndexOf(amphibian)] = updatedAmphibian;
            }
            var amphibian1 = Amphibians.FirstOrDefault(a => a.Lenght == updatedAmphibian.Lenght);
            if (amphibian1 != null)
            {
                Amphibians[Amphibians.IndexOf(amphibian1)] = updatedAmphibian;
            }
            var amphibian2 = Amphibians.FirstOrDefault(a => a.Weight == updatedAmphibian.Weight);
            if (amphibian2 != null)
            {
                Amphibians[Amphibians.IndexOf(amphibian2)] = updatedAmphibian;
            }
            var amphibian3 = Amphibians.FirstOrDefault(a => a.Supplements == updatedAmphibian.Supplements);
            if (amphibian3 != null)
            {
                Amphibians[Amphibians.IndexOf(amphibian3)] = updatedAmphibian;
            }
            var amphibian4 = Amphibians.FirstOrDefault(a => a.SupplementDetails == updatedAmphibian.SupplementDetails);
            if (amphibian4 != null)
            {
                Amphibians[Amphibians.IndexOf(amphibian4)] = updatedAmphibian;
            }
        }
        public void EditArthropod(Arthropods updatedArthropod)
        {
            var arthropod = Arthropods.FirstOrDefault(a => a.SizeDC == updatedArthropod.SizeDC);
            if (arthropod != null)
            {
                Arthropods[Arthropods.IndexOf(arthropod)] = updatedArthropod;
            }
            var arthropod1 = Arthropods.FirstOrDefault(a => a.LastMolt == updatedArthropod.LastMolt);
            if (arthropod1 != null)
            {
                Arthropods[Arthropods.IndexOf(arthropod1)] = updatedArthropod;
            }
        }
        public void EditFood(Food updatedFood)
        {
            var food = Food.FirstOrDefault(f => f.Id == updatedFood.Id);
            if (food != null)
            {
                Food[Food.IndexOf(food)] = updatedFood;
            }
            var food1 = Food.FirstOrDefault(f => f.Name == updatedFood.Name);
            if (food1 != null)
            {
                Food[Food.IndexOf(food1)] = updatedFood;
            }
            var food2 = Food.FirstOrDefault(f => f.Stock == updatedFood.Stock);
            if (food2 != null)
            {
                Food[Food.IndexOf(food2)] = updatedFood;
            }
            var food3 = Food.FirstOrDefault(f => f.Size == updatedFood.Size);
            if (food3 != null)
            {
                Food[Food.IndexOf(food3)] = updatedFood;
            }
            var food4 = Food.FirstOrDefault(f => f.FoodType == updatedFood.FoodType);
            if (food4 != null)
            {
                Food[Food.IndexOf(food4)] = updatedFood;
            }
            var food5 = Food.FirstOrDefault(f => f.FeedingInterval == updatedFood.FeedingInterval);
            if (food5 != null)
            {
                Food[Food.IndexOf(food5)] = updatedFood;
            }
        }


        // Save and Load Methods
        public void SaveToJsonFile(string filePath = null)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = defaultFilePath;
            }
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

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
