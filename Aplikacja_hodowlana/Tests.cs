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

        // Add similar tests for Reptiles, Amphibians, Arthropods, and Food

        [Fact]
        public void SaveToJsonFile_SavesToFile()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.json");
            _dataBase.SaveToJsonFile(filePath);

            Assert.True(File.Exists(filePath));
        }

        [Fact]
        public void LoadFromJsonFile_LoadsFromFile()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.json");
            _dataBase.SaveToJsonFile(filePath);

            var loadedDataBase = DataBase.LoadFromJsonFile(filePath);

            Assert.NotNull(loadedDataBase);
        }
    }
}
