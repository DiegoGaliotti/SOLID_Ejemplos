using Solid_D_DependencyInvertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_D_DependencyInvertion
{
    internal class NotaCredito : DocumentoContable
    {
        public NotaCredito(int numero, Cliente cliente, DateTime fecha) : base(numero, cliente, fecha)
        {
            Name = "Nota de Credito";
        }
        public override void Imprimir()
        {
            Console.WriteLine($"PAPEL {Descripcion()}");
        }
    }
}
