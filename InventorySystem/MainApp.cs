using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace InventorySystemWinform
{
    public static class MainApp
    {
        public static List<InventoryItem> Inventory = new List<InventoryItem>();

        public static event EventHandler<string>? ErrorOccured;

        public static event EventHandler? InventoryUpdated;

        private static string _saveFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "savefile.json");

        public static void Initialize()
        {
            ReadFromFile();
        }
        public static void AddItem(string Name, int Quantity, decimal Price, string Supplier)
        {
            if (Inventory.FirstOrDefault(i => i.Name == Name) != null)
            {
                ErrorOccured?.Invoke(null, "Item with the same name already exists."); return;
            }
            InventoryItem item = new InventoryItem(Name, Quantity, Price, Supplier);
            item.Id = IdGenerator.GenerateId();
            Inventory.Add(item);   
            InventoryUpdated?.Invoke(null, EventArgs.Empty);
        }

        public static void EditItem(int Id, string Name, int Quantity, decimal Price, string Supplier)
        {
            
            var item = Inventory.FirstOrDefault(i => i.Id == Id + 1);
            if (item == null)
            {
                ErrorOccured?.Invoke(null, "Item with the specified ID does not exist."); return;
            }
            item.Name = Name;
            item.Quantity = Quantity;
            item.Price = Price;
            item.Supplier = Supplier;
            InventoryUpdated?.Invoke(null, EventArgs.Empty);
        }
        public static void DeleteItem(int Id)
        {
            var item = Inventory.FirstOrDefault(i => i.Id == Id + 1);
            if (item == null)
            {
                ErrorOccured?.Invoke(null, "Item with the specified ID does not exist."); return;
            }
            Inventory.Remove(item);
            InventoryUpdated?.Invoke(null, EventArgs.Empty);
        }
        public static InventoryItem? GetItemById(int id)
        {
            return Inventory.FirstOrDefault(i => i.Id == id);
        }
        public static IEnumerable<InventoryItem> GetInventoryItems(string? name = null, string? supplier = null,
            string[]? stockLevels = null)
        {
            foreach(InventoryItem item in Inventory)
            {
                if (!String.IsNullOrWhiteSpace(name) && !item.Name.ToLower().Contains(name.ToLower())) continue;
                if (!String.IsNullOrWhiteSpace(supplier) && !item.Supplier.ToLower().Contains(supplier.ToLower())) continue;
                if (stockLevels != null && !stockLevels.Contains(item.StockLevel)) continue;
                
                yield return item;
            }
        }
        public static void WriteToFile()
        {
            string json = JsonSerializer.Serialize(Inventory, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_saveFilePath, json);
        }

        public static void ReadFromFile()
        {
            if (!File.Exists(_saveFilePath)) return;
            string json = File.ReadAllText(_saveFilePath);
            if (String.IsNullOrWhiteSpace(json)) return;
            var content = JsonSerializer.Deserialize<List<InventoryItem>>(json);
            Inventory = content ?? new List<InventoryItem>();
            foreach (var item in Inventory)
            {
                IdGenerator.AddExistingId(item.Id);
            }
        }
    }

    public class InventoryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Supplier { get; set; }

        public string StockLevel {
            get
            {
                if (Quantity == 0) return "Out of Stock";
                else if (Quantity <= 20) return "Low Stock";
                else return "In Stock";
            }
        }
        public InventoryItem(string name, int quantity, decimal price, string supplier)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Supplier = supplier;
        }
    }
    public static class IdGenerator
    {
        private static HashSet<int> usedIds = new HashSet<int>();
        private static Random random = new Random();

        public static int GenerateId()
        {
            int newId;
            do
            {
                newId = random.Next(1000, 9999); // 4-digit ID (change range as needed)
            }
            while (usedIds.Contains(newId));

            usedIds.Add(newId);
            return newId;
        }

        public static void AddExistingId(int id)
        {
            usedIds.Add(id); // Call this if you already have IDs stored
        }
    }
}
