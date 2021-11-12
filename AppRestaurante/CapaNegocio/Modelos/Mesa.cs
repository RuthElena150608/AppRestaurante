using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Modelos
{
    public class Mesa
    {
        public int NumeroMesa { get; set; }
        public bool Disponibilidad { get; set; } = true;
        public int CantidadPersona { get; set; } = 0;
        public Orden MOrden { get; set; }
    }
}
