using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_S_SingleResponsability
{
    internal class Program
    {
        static void Main()
        {
            Cliente cliente = new Cliente("Diego", "Galiotti");
            Item i1 = new Item(new Producto(100, "Fiedos"), 3);
            Factura f = new Factura(212, cliente);
            f.Items.Add(i1);
            Console.WriteLine(f.Total());
        }
    }
}
