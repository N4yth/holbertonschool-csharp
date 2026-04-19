using System;
using System.IO;
using System.Linq;
using InventoryLibrary;
using Xunit;

namespace InventoryManagement.Tests
{
    public class JSONStorageTests
    {
        private JSONStorage GetFreshStorage()
        {
            return new JSONStorage();
        }

        public class Dummy
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        [Fact]
        public void New_AddsObjectToStorage()
        {
            var storage = GetFreshStorage();
            var obj = new Dummy { Id = "1", Name = "Test" };

            storage.New(obj);

            var all = storage.All();

            Assert.Single(all);
            Assert.True(all.ContainsKey("Dummy.1"));
        }

        [Fact]
        public void New_NullObject_DoesNothing()
        {
            var storage = GetFreshStorage();

            storage.New(null);

            Assert.Empty(storage.All());
        }

        [Fact]
        public void New_ObjectWithoutId_ThrowsException()
        {
            var storage = GetFreshStorage();

            var obj = new { Name = "NoIdObject" };

            Assert.Throws<Exception>(() => storage.New(obj));
        }

        [Fact]
        public void All_ReturnsSameDictionaryInstance()
        {
            var storage = GetFreshStorage();

            var dict1 = storage.All();
            var dict2 = storage.All();

            Assert.Equal(dict1, dict2);
        }

        [Fact]
        public void Save_CreatesFile()
        {
            var storage = GetFreshStorage();
            var obj = new Dummy { Id = "2", Name = "SaveTest" };

            storage.New(obj);
            storage.Save();

            Assert.True(File.Exists(Path.Combine("storage", "inventory_manager.json")));
        }

        [Fact]
        public void Load_RestoresData()
        {
            var storage = GetFreshStorage();
            var obj = new Dummy { Id = "3", Name = "LoadTest" };

            storage.New(obj);
            storage.Save();

            var newStorage = GetFreshStorage();
            newStorage.Load();

            var all = newStorage.All();

            Assert.NotEmpty(all);
        }

        [Fact]
        public void KeyFormat_IsCorrect()
        {
            var storage = GetFreshStorage();
            var obj = new Dummy { Id = "10", Name = "KeyTest" };

            storage.New(obj);

            Assert.Contains("Dummy.10", storage.All().Keys);
        }
    }
}