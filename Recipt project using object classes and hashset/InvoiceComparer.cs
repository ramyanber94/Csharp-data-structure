using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Assignment3_N01379722_week6
{
    internal class InvoiceComparer : IEqualityComparer<InvoiceItem>
    {
        public bool Equals(InvoiceItem x, InvoiceItem y)
        {
            return x.Product.Code.Equals(y.Product.Code);
        }

        public int GetHashCode(InvoiceItem obj)
        {
            return obj.Product.Code.GetHashCode();
        }
    }
}