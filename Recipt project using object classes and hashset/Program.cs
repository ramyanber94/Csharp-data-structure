using System;

namespace Assignment3_N01379722_week6
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            Product p1 = new Product("123", "Tubna", 26, 12);
            Product p2 = new Product("124", "Salmon", 26, 12);
            Product p3 = new Product("125", "Pizza", 26, 12);
            Product p4 = new Product("126", "Cheese", 26, 12);
            Product p5 = new Product("127", "Tabola", 26, 12);
            inventory.addNewProduct("123", p1);
            inventory.addNewProduct("124", p2);
            inventory.addNewProduct("125", p3);
            inventory.addNewProduct("126", p4);
            inventory.addNewProduct("127", p5);

            inventory.updateQtyInStockAndPrice(28, 4, "123");

            foreach (var item in inventory.inventory)
            {
                Console.WriteLine($" Item Code: {item.Key}, Item Name: {item.Value.Name}, Item Price: {item.Value.Price}, Item Quantity : {item.Value.QtyInStock}");
            }
            //112 + 156 + 182
            Invoice invoice = new Invoice();
         
            invoice.AddInvoiceItems(inventory.searchForItem("123"), 4);
            invoice.AddInvoiceItems(inventory.searchForItem("124"), 6);
            invoice.AddInvoiceItems(inventory.searchForItem("125"), 7);
            foreach (var item in invoice)
            {
                //Console.WriteLine(((InvoiceItem)item).ToString() + ((InvoiceItem)item).Qty);
                Console.WriteLine(item.ToString() , ((InvoiceItem)item).Qty);
            }
            Console.WriteLine($" Total is : {invoice.GetTotal()}");
        }
    }
}
