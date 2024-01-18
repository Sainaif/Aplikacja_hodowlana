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
        
        public List<Animals> Animals { get; set; }
        public List<Reptiles> Reptiles { get; set; }
        public List<Amphibians> Amphibians { get; set; }
        public List<Arthropods> Arthropods { get; set; }
        public List<Food> Food { get; set; }

        
        private static string defaultFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json");

        public DataBase()
        {
            Animals = new List<Animals>();
            Reptiles = new List<Reptiles>();
            Amphibians = new List<Amphibians>();
            Arthropods = new List<Arthropods>();
            Food = new List<Food>();
        }

        
        public void AddAnimal(Animals animal) => Animals.Add(animal);
        public void AddReptile(Reptiles reptile) => Reptiles.Add(reptile);
        public void AddAmphibian(Amphibians amphibian) => Amphibians.Add(amphibian);
        public void AddArthropod(Arthropods arthropod) => Arthropods.Add(arthropod);
        public void AddFood(Food food) => Food.Add(food);

        
        public void RemoveAnimal(Animals animal) => Animals.Remove(animal);
        public void RemoveReptile(Reptiles reptile) => Reptiles.Remove(reptile);
        public void RemoveAmphibian(Amphibians amphibian) => Amphibians.Remove(amphibian);
        public void RemoveArthropod(Arthropods arthropod) => Arthropods.Remove(arthropod);
        public void RemoveFood(Food food) => Food.Remove(food);

       
        public void EditAnimal(Animals updatedAnimals)
        {
            var animalById = Animals.FirstOrDefault(a => a.Id == updatedAnimals.Id);
            if (animalById != null)
            {
                animalById = updatedAnimals;
            }
            var animalByName = Animals.FirstOrDefault(a => a.Name == updatedAnimals.Name);
            if (animalByName != null)
            {
                animalByName = updatedAnimals;
            }
            var animalByGroup = Animals.FirstOrDefault(a => a.Group == updatedAnimals.Group);
            if (animalByGroup != null)
            {
                animalByGroup = updatedAnimals;
            }
            var animalBySpecies = Animals.FirstOrDefault(a => a.Species == updatedAnimals.Species);
            if (animalBySpecies != null)
            {
                animalBySpecies = updatedAnimals;
            }
            var animalByEnvironment = Animals.FirstOrDefault(a => a.Environment == updatedAnimals.Environment);
            if (animalByEnvironment != null)
            {
                animalByEnvironment = updatedAnimals;
            }
            var animalByActivityTime = Animals.FirstOrDefault(a => a.ActivityTime == updatedAnimals.ActivityTime);
            if (animalByActivityTime != null)
            {
                animalByActivityTime = updatedAnimals;
            }
            //var animalByDateOfLastFeeding = Animals.FirstOrDefault(a => a.DateOfLastFeeding == updatedAnimals.DateOfLastFeeding);
            //if (animalByDateOfLastFeeding != null)
            //{
            //    animalByDateOfLastFeeding = updatedAnimals;
            //}
            //var animalByDateOfBirth = Animals.FirstOrDefault(a => a.DateOfBirth == updatedAnimals.DateOfBirth);
            //if (animalByDateOfBirth != null)
            //{
            //    animalByDateOfBirth = updatedAnimals;
            //}
            var animalByHumidity = Animals.FirstOrDefault(a => a.Humidity == updatedAnimals.Humidity);
            if (animalByHumidity != null)
            {
                animalByHumidity = updatedAnimals;
            }
        }
        public void EditReptile(Reptiles updatedReptile)
        {
            var reptileByMorph = Reptiles.FirstOrDefault(r => r.Morph == updatedReptile.Morph);
            if (reptileByMorph != null)
            {
                reptileByMorph = updatedReptile;
            }
            var reptileByLength = Reptiles.FirstOrDefault(r => r.Lenght == updatedReptile.Lenght);
            if (reptileByLength != null)
            {
                reptileByLength = updatedReptile;
            }
            var reptileByWeight = Reptiles.FirstOrDefault(r => r.Weight == updatedReptile.Weight);
            if (reptileByWeight != null)
            {
                reptileByWeight = updatedReptile;
            }
        }
        public void EditAmphibian(Amphibians updatedAmphibian)
        {
            var amphibianByMorph = Amphibians.FirstOrDefault(a => a.Morph == updatedAmphibian.Morph);
            if (amphibianByMorph != null)
            {
                amphibianByMorph = updatedAmphibian;
            }
            var amphibianByLength = Amphibians.FirstOrDefault(a => a.Lenght == updatedAmphibian.Lenght);
            if (amphibianByLength != null)
            {
                amphibianByLength = updatedAmphibian;
            }
            var amphibianByWeight = Amphibians.FirstOrDefault(a => a.Weight == updatedAmphibian.Weight);
            if (amphibianByWeight != null)
            {
                amphibianByWeight = updatedAmphibian;
            }
            var amphibianBySupplements = Amphibians.FirstOrDefault(a => a.Supplements == updatedAmphibian.Supplements);
            if (amphibianBySupplements != null)
            {
                amphibianBySupplements = updatedAmphibian;
            }
            var amphibianBySupplementDetails = Amphibians.FirstOrDefault(a => a.SupplementDetails == updatedAmphibian.SupplementDetails);
            if (amphibianBySupplementDetails != null)
            {
                amphibianBySupplementDetails = updatedAmphibian;
            }
        }
        public void EditArthropod(Arthropods updatedArthropod)
        {
            var arthropodBySizeDC = Arthropods.FirstOrDefault(a => a.SizeDC == updatedArthropod.SizeDC);
            if (arthropodBySizeDC != null)
            {
                arthropodBySizeDC = updatedArthropod;
            }
            var arthropodByLastMolt = Arthropods.FirstOrDefault(a => a.LastMolt == updatedArthropod.LastMolt);
            if (arthropodByLastMolt != null)
            {
                arthropodByLastMolt = updatedArthropod;
            }
        }
        public void EditFood(Food updatedFood)
        {
            var foodById = Food.FirstOrDefault(f => f.Id == updatedFood.Id);
            if (foodById != null)
            {
                foodById = updatedFood;
            }
            var foodByName = Food.FirstOrDefault(f => f.Name == updatedFood.Name);
            if (foodByName != null)
            {
                foodByName = updatedFood;
            }
            var foodByStock = Food.FirstOrDefault(f => f.Stock == updatedFood.Stock);
            if (foodByStock != null)
            {
                foodByStock = updatedFood;
            }
            var foodBySize = Food.FirstOrDefault(f => f.Size == updatedFood.Size);
            if (foodBySize != null)
            {
                foodBySize = updatedFood;
            }
            var foodByFoodType = Food.FirstOrDefault(f => f.FoodType == updatedFood.FoodType);
            if (foodByFoodType != null)
            {
                foodByFoodType = updatedFood;
            }
            var foodByFeedingInterval = Food.FirstOrDefault(f => f.FeedingInterval == updatedFood.FeedingInterval);
            if (foodByFeedingInterval != null)
            {
                foodByFeedingInterval = updatedFood;
            }
        }


        
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
