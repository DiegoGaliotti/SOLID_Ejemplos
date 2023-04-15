using Solid_O_OpenClose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_O_OpenClose
{
    internal class NotaCredito : DocumentoContable
    {
        public int Numero { get; set; }
        public DateOnly Date { get; set; }
        public Cliente Cliente { get; set; }
        public List<Item> Items { get; set; }
        public NotaCredito(int numero, Cliente cliente) : base(numero)
        {
            Numero = numero;
            Cliente = cliente;
            Items = new List<Item>();
        }

        public override double Total()
        {
            double total = 0;
            foreach (Item item in Items) { total = total + item.SubTotal(); }
            return total;
        }
        public override string Descripcion()
        {
            return $"Nota de credito {Numero}";
        }
    }
}
