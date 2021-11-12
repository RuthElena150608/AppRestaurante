using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ServicioMesa
    {
        /*
         -- Mesas disponibles
         -- Agregar una Mesa
         -- Editar cantidad de persona de una mesa
         -- Editar disponibilidad
         -- Eliminar una mesa
         -- Cantidad de mesas en el establecimito
        */

        public bool AgregarMesa()
        {
            int numeroMesa = Repositorio.Instancias.Mesas.Count + 1;
            if (numeroMesa > 9) return false;
            var objetoMesa = new Modelos.Mesa()
            {
                NumeroMesa = numeroMesa
                
            };
            Repositorio.Instancias.Mesas.Add(objetoMesa);
            return true;
        }

        public int ObtenerCantidadMesas()
        {
            return Repositorio.Instancias.Mesas.Count;
        }
        public Modelos.Mesa ObtenerMesa(int numeroMesa)
        {
            return Repositorio.Instancias.Mesas[numeroMesa-1];
        }
        public List<Modelos.Mesa> ObtenerMesas()
        {
            return Repositorio.Instancias.Mesas;
        }

        public void AgregarPersonaMesa(int numeroMesa)
        {
            Repositorio.Instancias.Mesas[numeroMesa - 1].CantidadPersona++;
        }

        public void QuitarPersonaMesa(int numeroMesa)
        {
            Repositorio.Instancias.Mesas[numeroMesa - 1].CantidadPersona--;
        }

        public void AgregarOrden(int numeroMesa, Modelos.Orden orden)
        {
            numeroMesa--;
            var mesa = Repositorio.Instancias.Mesas[numeroMesa];
            mesa.MOrden = orden;
            mesa.Disponibilidad = false;
        }

        public List<(string, List<List<string>>)> ObtenerTodasLasOrdenes()
        {
            List<(string, List<List<string>>)> ordenes = new List<(string, List<List<string>>)>();

            Repositorio.Instancias.Mesas.Where(md => md.Disponibilidad == false).ToList().ForEach(m => {
                string persona = m.MOrden.NombrePersona;
                List<List<string>> ordenado = new List<List<string>>();
                ordenado.Add(m.MOrden.Entradas);
                ordenado.Add(m.MOrden.Platos);
                ordenado.Add(m.MOrden.Postres);
                ordenado.Add(m.MOrden.Bebidas);

                ordenes.Add((persona, ordenado));
            });

            return ordenes;
        }
    }
}
