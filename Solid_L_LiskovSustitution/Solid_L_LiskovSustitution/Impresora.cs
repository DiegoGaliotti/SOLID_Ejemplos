using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_L_LiskovSustitution
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
            string i = "";
            foreach (DocumentoContable cons in ListaImpresion)
                i = i + $" {cons.Descripcion()},";
            return i;
        }
    }
}
