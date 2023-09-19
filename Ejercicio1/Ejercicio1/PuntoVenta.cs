using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class PuntoVenta
    {
        public PuntoVenta() { }
        public String Codigo { get; set; }
        public String Nombre { get; set; }  
        public String Distrito { get; set; }
        public String VentaMensutal {  get; set; }
        public List<Producto> productos { get; set; }
    }
}
