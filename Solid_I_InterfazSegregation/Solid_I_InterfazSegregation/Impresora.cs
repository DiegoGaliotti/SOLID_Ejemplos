using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_I_InterfazSegregation
{
    internal class Impresora
    {
        public List<DocumentoContable> ListaImpresion { get; set; }
        public Impresora()
        {
            ListaImpresion = new List<DocumentoContable>();
        }
        public string Imprimir()
        {
            string i = "Imprimiendo; ";
            foreach (DocumentoContable cons in ListaImpresion)
                i = i + $"\n { cons.Descripcion()},";
            return i;
        }
    }
}
