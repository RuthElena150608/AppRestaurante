using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ServicioOrden
    {
        public Modelos.Orden CrearOrden(string nombrePersona, List<string> entradas,List<string> platos, List<string> bebidas, List<string> postres)
        {
            return new Modelos.Orden()
            {
                NombrePersona = nombrePersona,
                Entradas = entradas,
                Platos = platos,
                Bebidas = bebidas,
                Postres = postres

            };
        }
    }
}
