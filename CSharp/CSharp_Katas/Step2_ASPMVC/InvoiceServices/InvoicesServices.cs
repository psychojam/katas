using System;
using System.Collections.Generic;
using System.Linq;

namespace Step2_ASPMVC.InvoiceServices
{
    public class InvoicesServices
    {
        public IList<Invoice> Invoices { get;  } = new List<Invoice>();

        public void Add(Invoice item) => Invoices.Add(item);

        public void Update(Invoice item)
        {
            Remove(item);
            Add(item);
        }

        public void Remove(Invoice item) => Invoices.Remove(item);
    }

    public class Invoice
    {
        public Guid Id { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public double Total => Items.Sum(x => x.Price);
        IList<InvoiceItem> Items {get; set;} = new List<InvoiceItem>();
    }

    public class InvoiceItem
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public double Price { get; set; }
    }
}