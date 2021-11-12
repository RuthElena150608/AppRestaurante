using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Modelos
{
    public class Orden
    {
        public string NombrePersona { get; set; }
        public List<string> Platos { get; set; }
        public List<string> Entradas { get; set; }
        public List<string> Bebidas { get; set; }
        public List<string> Postres { get; set; }
    }
}
