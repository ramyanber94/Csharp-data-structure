using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_N01379722_week6
{
    class Product
    {
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private int qtyInStock;
        
        public int QtyInStock
        {
            get { return qtyInStock; }
            set { qtyInStock = value; }
        }
        public Product(string code, string name, double price, int qtyInStock)
        {
            Code = code;
            Name = name;
            Price = price;
            QtyInStock = qtyInStock;
        }

    }
}
