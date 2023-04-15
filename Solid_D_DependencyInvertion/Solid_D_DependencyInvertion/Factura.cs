using Solid_D_DependencyInvertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_D_DependencyInvertion
{
    internal class Factura : DocumentoContable
    {
        public Factura(int numero, Cliente cliente, DateTime fecha) : base(numero, cliente, fecha)
        {
            Name = "Factura";
        }

        public override void Imprimir()
        {
            Console.WriteLine($"PAPEL {Descripcion()}");
        }
    }
}
