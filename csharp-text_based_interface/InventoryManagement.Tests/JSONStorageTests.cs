using System;
using System.Linq;
using InventoryLibrary;
using Xunit;

namespace InventoryManagement.Tests
{
    public class JSONStorageTests
    {
        public class Dummy
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        [Fact]
        public void New_AddsObjectCorrectly()
        {
            var storage = new JSONStorage();
            var obj = new Dummy { Id = "1", Name = "Test" };

            storage.New(obj);

            var all = storage.All();

            Assert.Contains("Dummy.1", all.Keys);
        }

        [Fact]
        public void New_NullObject_DoesNotCrash()
        {
            var storage = new JSONStorage();

            storage.New(null);

            Assert.Empty(storage.All());
        }

        [Fact]
        public void All_ReturnsDictionary()
        {
            var storage = new JSONStorage();

            Assert.NotNull(storage.All());
        }

        [Fact]
        public void MultipleObjects_AreStoredCorrectly()
        {
            var storage = new JSONStorage();

            storage.New(new Dummy { Id = "1", Name = "A" });
            storage.New(new Dummy { Id = "2", Name = "B" });

            var all = storage.All();

            Assert.Equal(2, all.Count);
        }

        [Fact]
        public void KeyFormat_IsCorrect()
        {
            var storage = new JSONStorage();

            storage.New(new Dummy { Id = "99", Name = "X" });

            Assert.Contains("Dummy.99", storage.All().Keys);
        }
    }
}