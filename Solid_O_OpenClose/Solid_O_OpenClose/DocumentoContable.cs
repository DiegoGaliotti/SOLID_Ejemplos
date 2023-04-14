using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_O_OpenClose
{
    public abstract class DocumentoContable
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public DocumentoContable(int numero)
        {
            Numero = numero;
        }
        public abstract string Descripcion();
        public abstract double Total();
    }
}
