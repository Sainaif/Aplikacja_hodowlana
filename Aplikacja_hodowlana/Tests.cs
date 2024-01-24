using System;
using Xunit;
using Aplikacja_hodowlana;
using System.IO;

namespace Aplikacja_hodowlana.Tests
{
    public class DataBaseTests
    {
        private readonly DataBase _dataBase;

        public DataBaseTests()
        {
            _dataBase = new DataBase();
        }

        [Fact]
        public void AddAnimal_AddsAnimalToList()
        {
            var animal = new Animals();
            _dataBase.AddAnimal(animal);

            Assert.Contains(animal, _dataBase.Animals);
        }

        [Fact]
        public void RemoveAnimal_RemovesAnimalFromList()
        {
            var animal = new Animals();
            _dataBase.AddAnimal(animal);
            _dataBase.RemoveAnimal(animal);

            Assert.DoesNotContain(animal, _dataBase.Animals);
        }

        [Fact]
        public void AddReptile_AddsReptileToList()
        {
            var reptile = new Reptiles();
            _dataBase.AddReptile(reptile);

            Assert.Contains(reptile, _dataBase.Reptiles);
        }

        [Fact]
        public void AddAmphibian_AddsAmphibianToList()
        {
            var amphibian = new Amphibians();
            _dataBase.AddAmphibian(amphibian);

            Assert.Contains(amphibian, _dataBase.Amphibians);
        }

        [Fact]
        public void AddArthropod_AddsArthropodToList()
        {
            var arthropod = new Arthropods();
            _dataBase.AddArthropod(arthropod);

            Assert.Contains(arthropod, _dataBase.Arthropods);
        }

        [Fact]
        public void AddFood_AddsFoodToList()
        {
            var food = new Food();
            _dataBase.AddFood(food);

            Assert.Contains(food, _dataBase.Food);
        }

        [Fact]
        public void SaveToJsonFile_SavesToFile()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.json");
            _dataBase.SaveToJsonFile(filePath);

            Assert.True(File.Exists(filePath));
            File.Delete(filePath); // Clean up after test
        }

        [Fact]
        public void LoadFromJsonFile_LoadsFromFile()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.json");
            _dataBase.SaveToJsonFile(filePath);

            var loadedDataBase = DataBase.LoadFromJsonFile(filePath);

            Assert.NotNull(loadedDataBase);
            File.Delete(filePath); // Clean up after test
        }
    }
}
