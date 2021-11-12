using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaNegocio
{
    public sealed class Repositorio
    {
        public List<Modelos.Mesa> Mesas = new List<Modelos.Mesa>();
        public static Repositorio Instancias { get;  } = new Repositorio();

        public Repositorio() { }
    }
}








