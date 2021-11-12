using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace AppRestaurante
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServicioMesa servicioMesa = new ServicioMesa();

            servicioMesa.AgregarMesa();
            servicioMesa.AgregarMesa();
            servicioMesa.AgregarMesa();
            servicioMesa.AgregarMesa();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
        }
    }
}
