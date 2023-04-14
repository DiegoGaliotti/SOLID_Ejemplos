using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_S_SingleResponsability
{
    internal class Item
    {
        public int Cantidad { get; set; }
        public Producto Producto { get; set; }
        public Item (Producto producto, int cantidad)
        {
            this.Producto = producto;
            this.Cantidad = cantidad;
        }
        public double SubTotal()
        {
            double subTotal;
            subTotal = Producto.Precio * Cantidad;
            return subTotal;
        }
    }
}
