using System;
using System.Collections.Generic;
using System.Linq;
using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {
        private static JSONStorage storage = new JSONStorage();

        static void Main(string[] args)
        {
            storage.Load();
            while (true)
            {
                PrintPrompt();
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    continue;

                ProcessCommand(input.Trim());
            }
        }

        static void PrintPrompt()
        {
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");
            Console.WriteLine("<ClassNames> show all ClassNames of objects");
            Console.WriteLine("<All> show all objects");
            Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
            Console.WriteLine("<Create [ClassName]> a new object");
            Console.WriteLine("<Show [ClassName object_id]> an object");
            Console.WriteLine("<Update [ClassName object_id]> an object");
            Console.WriteLine("<Delete [ClassName object_id]> an object");
            Console.WriteLine("<Exit>");
        }

        static void ProcessCommand(string input)
        {
            var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0) return;

            string command = parts[0].ToLower();

            switch (command)
            {
                case "classnames":
                    ShowClassNames();
                    break;

                case "all":
                    if (parts.Length == 1)
                        ShowAll();
                    else
                        ShowAllByClass(parts[1]);
                    break;

                case "create":
                    if (parts.Length < 2)
                        return;
                    Create(parts[1]);
                    break;

                case "show":
                    if (parts.Length < 3)
                        return;
                    Show(parts[1], parts[2]);
                    break;

                case "update":
                    if (parts.Length < 3)
                        return;
                    Update(parts[1], parts[2]);
                    break;

                case "delete":
                    if (parts.Length < 3)
                        return;
                    Delete(parts[1], parts[2]);
                    break;

                case "exit":
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }
        }

        static void ShowClassNames()
        {
            var objects = storage.All();

            var classNames = objects.Keys
                .Select(k => k.Split('.')[0])
                .Distinct();

            foreach (var name in classNames)
                Console.WriteLine(name);
        }

        static void ShowAll()
        {
            foreach (var obj in storage.All())
            {
                Console.WriteLine($"{obj.Key} => {obj.Value}");
            }
        }

        static void ShowAllByClass(string className)
        {
            bool found = false;
            foreach (var obj in storage.All())
            {
                if (obj.Key.StartsWith($"{className}.", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{obj.Key} => {obj.Value}");
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine($"{className} is not a valid object type");
        }

        static void Create(string className)
        {
            Console.WriteLine($"{className} created (stub - implement factory per class)");
        }

        static void Show(string className, string id)
        {
            string key = $"{className}.{id}";

            var obj = storage.All()
                .FirstOrDefault(x => x.Key.Equals(key, StringComparison.OrdinalIgnoreCase));

            if (obj.Key == null)
            {
                Console.WriteLine($"Object {id} could not be found");
                return;
            }
            Console.WriteLine(obj.Value);
        }

        static void Update(string className, string id)
        {
            string key = $"{className}.{id}";

            var dict = storage.All();
            var obj = dict.Keys.FirstOrDefault(k =>
                k.Equals(key, StringComparison.OrdinalIgnoreCase));
            if (obj == null)
            {
                Console.WriteLine($"Object {id} could not be found");
                return;
            }

            Console.WriteLine("Update feature requires class-specific implementation (stub).");
        }

        static void Delete(string className, string id)
        {
            string key = $"{className}.{id}";
            var dict = storage.All();
            var realKey = dict.Keys.FirstOrDefault(k => k.Equals(key, StringComparison.OrdinalIgnoreCase));
            if (realKey == null)
            {
                Console.WriteLine($"Object {id} could not be found");
                return;
            }
            dict.Remove(realKey);
            storage.Save();
        }
    }
}