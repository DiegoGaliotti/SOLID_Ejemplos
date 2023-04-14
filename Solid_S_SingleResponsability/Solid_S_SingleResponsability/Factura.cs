using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_S_SingleResponsability
{
    internal class Factura
    {
        public int Numero { get; set; }
        public DateOnly Date { get; set; }
        public Cliente Cliente { get; set; }
        public List<Item> Items { get; set; }

        public Factura (int numero, Cliente cliente)
        {
            Numero = numero;
            Cliente = cliente;
            Items = new List<Item> ();
        }

        public double Total()
        {
            double total = 0;
            foreach (Item item in Items) { total = total + item.SubTotal(); }
            return total;
        }
    }
}
