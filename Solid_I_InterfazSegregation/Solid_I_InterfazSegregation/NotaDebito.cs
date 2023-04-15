using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_I_InterfazSegregation
{
    internal class NotaDebito : DocumentoContable
    {
        public NotaDebito(int numero, Cliente cliente, DateTime fecha) : base(numero, cliente, fecha)
        {
            Name = "Nota de Debito";
        }
    }
}
