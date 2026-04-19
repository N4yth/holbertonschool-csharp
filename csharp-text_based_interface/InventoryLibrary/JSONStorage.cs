using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        private Dictionary<string, object> objects = new Dictionary<string, object>();

        private readonly string filePath =
            Path.Combine("storage", "inventory_manager.json");

        public Dictionary<string, object> All()
        {
            return objects;
        }

        public void New(object obj)
        {
            if (obj == null)
                return;

            var type = obj.GetType();
            var idProperty = type.GetProperty("Id");

            if (idProperty == null)
                throw new Exception("Object must have an Id property");

            var idValue = idProperty.GetValue(obj)?.ToString();

            if (string.IsNullOrEmpty(idValue))
                throw new Exception("Id cannot be null");

            string key = $"{type.Name}.{idValue}";
            objects[key] = obj;
        }

        public void Save()
        {
            Directory.CreateDirectory("storage");

            string json = JsonConvert.SerializeObject(objects, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void Load()
        {
            if (!File.Exists(filePath))
            {
                objects = new Dictionary<string, object>();
                return;
            }

            string json = File.ReadAllText(filePath);

            var loaded = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

            objects = loaded ?? new Dictionary<string, object>();
        }
    }
}