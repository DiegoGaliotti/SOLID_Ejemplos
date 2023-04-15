using Solid_L_LiskovSustitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_L_LiskovSustitution
{
    internal class Factura : DocumentoContable
    {
        public Factura(int numero, Cliente cliente, DateTime fecha) : base(numero, cliente, fecha)
        {
            Name = "Factura";
        }
    }
}
