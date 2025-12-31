using System;

/* This program manages a space mission inventory:
   it stores item names and quantities, checks inventory size, 
   updates items, and displays the inventory in different orders */

namespace SpaceMission
{
    class Program
    {
        // Class to hold an inventory item and its quantity
        class InventoryItem
        {
            public string Name { get; set; }
            public int Quantity { get; set; }

            public InventoryItem(string name, int quantity)
            {
                Name = name;
                Quantity = quantity;
            }
        }

        static void Main(string[] args)
        {
            // Initialize inventory with items and their quantities
            InventoryItem[] spaceInventory = new InventoryItem[]
            {
                new InventoryItem("Space Suits", 10),
                new InventoryItem("Oxygen Tanks", 8),
                new InventoryItem("Food Supplies", 15),
                new InventoryItem("Medical Kits", 5),
                new InventoryItem("Communication Devices", 6),
                new InventoryItem("Fuel Canisters", 9),
                new InventoryItem("Navigation Tools", 4),
                new InventoryItem("Repair Tools", 7)
            };

            int numItems = spaceInventory.Length;

            // Check inventory size
            if (numItems == 8)
            {
                Console.WriteLine("Space Inventory is ready to go!");
            }
            else if (numItems > 8)
            {
                Console.WriteLine("Too many items!");
            }
            else
            {
                Console.WriteLine("Add more items!");
            }

            // Display the second item in the inventory
            var item = spaceInventory[1];
            Console.WriteLine($"\nThe second item in the inventory is {item.Name} with a quantity of {item.Quantity}");

            // Update the last item
            spaceInventory[7].Name = "Scientific Instruments";
            spaceInventory[7].Quantity = 5;

            // Find the first item with quantity 5
            int index = Array.FindIndex(spaceInventory, i => i.Quantity == 5);
            Console.WriteLine($"\nThe first item with quantity 5 is at position {index} (0-based index)");

            // Reverse the inventory
            Array.Reverse(spaceInventory);
            Console.WriteLine($"\nFirst item in reversed inventory: {spaceInventory[0].Name}");
            Console.WriteLine($"Last item in reversed inventory: {spaceInventory[spaceInventory.Length - 1].Name}");

            // Sort inventory alphabetically by item name
            Array.Sort(spaceInventory, (a, b) => a.Name.CompareTo(b.Name));
            Console.WriteLine($"\nFirst item alphabetically: {spaceInventory[0].Name}");
            Console.WriteLine($"Last item alphabetically: {spaceInventory[spaceInventory.Length - 1].Name}");
        }
    }
}