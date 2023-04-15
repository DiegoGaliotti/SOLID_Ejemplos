using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_D_DependencyInvertion
{ 
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Cliente (string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
