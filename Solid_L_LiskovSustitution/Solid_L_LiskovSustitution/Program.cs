using Solid_L_LiskovSustitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_L_LiskovSustitution
{ 
    internal class Program
    {
        static void Main()
        {
            Cliente cliente = new Cliente("Diego", "Galiotti");
            Item i1 = new Item(new Producto(100, "Fiedos"), 3);

            DocumentoContable f = new Factura(212, cliente, DateTime.Now);
            f.ListaItems.Add(i1);
            //Console.WriteLine($"La {f.Descripcion()} tiene un total de {f.Total()}");

            DocumentoContable n = new NotaCredito(121, cliente, DateTime.Now);
            n.ListaItems.Add(i1);
            //Console.WriteLine($"La {n.Descripcion()} tiene un total de {n.Total()}");

            DocumentoContable d = new NotaDebito(111, cliente, DateTime.Now);
            d.ListaItems.Add(i1);
            Console.WriteLine($"La {d.Descripcion()} tiene un total de {d.Total()}");

            Impresora i = new Impresora();
            i.ListaImpresion.Add(f);
            i.ListaImpresion.Add(n);
            i.ListaImpresion.Add(d);
            Console.WriteLine(i.Imprimir());

            Console.ReadKey();
        }
    }
}
