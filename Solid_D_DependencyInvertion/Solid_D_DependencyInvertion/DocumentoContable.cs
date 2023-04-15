using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_D_DependencyInvertion
{
    public abstract class DocumentoContable : IImprimible
    {
        public int Numero { get; set; }
        protected string Name { get; set; }
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public Cliente Cliente { get; set; }
        public List<Item> ListaItems { get; set; }
        public DocumentoContable(int numero, Cliente cliente, DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            ListaItems = new List<Item>();
        }
        public virtual string Descripcion()
        {
            return $"{Name} numero {Numero} de la fecha {Fecha.ToShortDateString()} del cliente {Cliente.Nombre} {Cliente.Apellido}";
        }
        public virtual double Total()
        {
            double total = 0;
            foreach (Item item in ListaItems) { total = total + item.SubTotal(); }
            return total;
        }
        public abstract void Imprimir();
    }
}
