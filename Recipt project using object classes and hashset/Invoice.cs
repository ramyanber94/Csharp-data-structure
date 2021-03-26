using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_N01379722_week6
{
    class Invoice : IEnumerable<InvoiceItem>
    {
        HashSet<InvoiceItem> invoices = new HashSet<InvoiceItem>(new InvoiceComparer());
        double total = 0;

        public void AddInvoiceItems(Product p, int qty)
        {
            InvoiceItem invoice = new InvoiceItem();
            invoice.Product = p;
            invoice.Qty = qty;

            invoices.Add(invoice);
        }
        public double GetTotal()
        {
            foreach (var item in invoices)
            {
                total += item.GetSubtotal();
            }
            return total;
        }


        IEnumerator<InvoiceItem> IEnumerable<InvoiceItem>.GetEnumerator()
        {
            return invoices.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return invoices.GetEnumerator();
        }
    }  
}
