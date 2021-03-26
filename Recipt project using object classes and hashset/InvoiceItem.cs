using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Assignment3_N01379722_week6
{
    class InvoiceItem 
    {
        private Product product;
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
        private int qty;
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        public double GetSubtotal()
        {
            double subTotal = qty * Product.Price;
            return subTotal;
        }
        public override string ToString()
        {
            return product.Code + " " + product.Name +" "+ product.Price +" " + qty;
        } 
    }
}
