using Solid_D_DependencyInvertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_D_DependencyInvertion
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
        public override void Imprimir()
        {
            Console.WriteLine($"PAPEL {Descripcion()}");
        }
    }
}
