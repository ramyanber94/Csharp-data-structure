using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_N01379722_week6
{
    class Inventory : IEnumerable
    {
        public Dictionary<string, Product> inventory = new Dictionary<string, Product>() {};
        public void addNewProduct(string code ,Product product)
        { 
                inventory.Add(product.Code , product);  
        }
        public IEnumerator GetEnumerator()
        {
            return inventory.GetEnumerator();
        }
        public Product searchForItem(string code)
        {
            foreach (var item in inventory)
            {
                if (item.Key == code)
                {
                    return item.Value;
                }
                
            }
            return null;         
        }
        public void updateQtyInStockAndPrice(double price, int qtyInStock, string code)
        {
            foreach (var item in inventory)
            {
                if (item.Key == code)
                {
                    item.Value.QtyInStock += qtyInStock;
                    item.Value.Price = price;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return inventory.GetEnumerator();
        }
    }
}
