using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_D_DependencyInvertion
{
    internal class Impresora
    {
        public List<DocumentoContable> ListaImpresion { get; set; }
        public Impresora()
        {
            ListaImpresion = new List<DocumentoContable>();
        }
        public string AImprimir()
        {
            string i = "Imprimiendo; ";
            foreach (DocumentoContable cons in ListaImpresion)
                i = i + $"\n { cons.Descripcion()},";
            return i;
        }
        public void Imprimir(IImprimible imprimir)
        {
            imprimir.Imprimir();
        }
    }
}
