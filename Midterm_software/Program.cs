public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double Newprice)
    {
        // TODO: Update the item's price with the new price.
        Price = Newprice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock = QuantityInStock + additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        if (quantitySold <= QuantityInStock)
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine("Stock is not available.");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        if(QuantityInStock > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine($"Item Name is : {ItemName}");
        Console.WriteLine($"Item ID is: {ItemId}");
        Console.WriteLine($"Price of the Item is: ${Price} ");
        Console.WriteLine($"Quantity of items in Stock: {QuantityInStock}");
        Console.WriteLine("-----------------------------------------------");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);
        InventoryItem item3 = new InventoryItem("Iwatch", 103, 300, 12);
        InventoryItem item4 = new InventoryItem("Airtag", 104, 78, 3);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        Console.WriteLine("Details of Item 1: ");
        item1.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Details of Item 2: ");
        item2.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Details of Item 3: ");
        item3.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Details of Item 4: ");
        item4.PrintDetails();
        Console.WriteLine();

        // 2. Sell some items and then print the updated details.
        item3.SellItem(2);
        Console.WriteLine("After selling 2 Iwatches from Item 3:");
        item3.PrintDetails();
        Console.WriteLine();

        //selling of 3 Airtags
        item4.SellItem(3);
        Console.WriteLine("After selling 3 Airtag from Item 4:");
        item4.PrintDetails();
        Console.WriteLine();

        // 3. Restock an item and print the updated details.
        item2.RestockItem(10);
        Console.WriteLine("After restocking 10 smartphones in item 2:");
        item2.PrintDetails();
        Console.WriteLine();  

        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine($"Check if item 1 is in stock or not? {item1.IsInStock()}");
        Console.WriteLine($"Check if item 2 is in stock or not? {item2.IsInStock()}");
        Console.WriteLine($"Check if item 3 is in stock or not? {item3.IsInStock()}");
        Console.WriteLine($"Check if item 4 is in stock or not? {item4.IsInStock()}");
    }
}