using Solid_I_InterfazSegregation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_I_InterfazSegregation
{
    public class FacturaElectronica : DocumentoContable, IImeileable
    {
        public FacturaElectronica(int numero, Cliente cliente, DateTime fecha) : base(numero, cliente, fecha)
        {
            Name = "Factura Electronica";
        }

        public string EnviarPorEmail()
        {
            return $"Enviando {Name} numero {Numero} de la fecha {Fecha.ToShortDateString()} del cliente {Cliente.Nombre} {Cliente.Apellido}";
        }
    }
}
