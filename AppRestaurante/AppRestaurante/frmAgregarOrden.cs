using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace AppRestaurante
{
    public partial class frmAgregarOrden : Form
    {
        public List<string> Platos;
        public List<string> Entradas;
        public List<string> Bebidas;
        public List<string> Postres;
        public frmAgregarOrden()
        {
            InitializeComponent();
            Platos = new List<string>();
            Entradas = new List<string>();
            Bebidas = new List<string>();
            Postres = new List<string>();
        }

        ServicioMesa mesa = new ServicioMesa();
        ServicioOrden orden = new ServicioOrden();


        private void lblCantidadPersonas_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lblCantidadPersonas.Text == "4")
            {
                MessageBox.Show("Solo se pueden un maximo de 4 personas");
                return;
            }
            mesa.AgregarPersonaMesa(Convert.ToInt32(lblNumeroMesa.Text));
            actualizarCantidadDePersonas();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lblCantidadPersonas.Text == "1") 
            {
                MessageBox.Show("No se pueden quitar mas personas");
                return;
          
            } 
            mesa.QuitarPersonaMesa(Convert.ToInt32(lblNumeroMesa.Text));
            actualizarCantidadDePersonas();

        }
        private void frmAgregarOrden_Load(object sender, EventArgs e)
        {
            actualizarCantidadDePersonas();
        }
        private void actualizarCantidadDePersonas()
        {
            lblCantidadPersonas.Text = mesa.ObtenerMesa(Convert.ToInt32(lblNumeroMesa.Text)).CantidadPersona.ToString();
        }

        private void cmbEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Entradas.Count < Convert.ToInt32(lblCantidadPersonas.Text))
            {

            Entradas.Add(cmbEntradas.SelectedItem.ToString());
                lbEntradas.Text = "Entradas: " + Entradas.Count;
                return;
            }



            MessageBox.Show("has alcanzado el maximo de entradas por persona");
        }

        private void cmbPlatosFuertes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Platos.Count < Convert.ToInt32(lblCantidadPersonas.Text))
            {
                Platos.Add(cmbPlatosFuertes.SelectedItem.ToString());
                lblPlatosFuertes.Text = "Platos Fuertes: " + Platos.Count;
                return;
            }
            MessageBox.Show("Has alcanzado el limite de platos fuertes");
        }
        private void lblPlatosFuertes_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbPostres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Postres.Count < Convert.ToInt32(lblCantidadPersonas.Text))
            {
                Postres.Add(cmbPostres.SelectedItem.ToString());
                lblPostres.Text = "Postres: " + Postres.Count;
                return;
            }

            MessageBox.Show("Has alcanzado el limite de postres");
        }

        private void cmbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Bebidas.Count < Convert.ToInt32(lblCantidadPersonas.Text))
            {
                Bebidas.Add(cmbBebidas.SelectedItem.ToString());
                lblBebidas.Text = "Bebidas: " + Bebidas.Count;
                return;
            }

            MessageBox.Show("Has alcanzado el limite de bebidas");
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim() == "" || Entradas.Count < 0 || Platos.Count < 0 || Postres.Count <  0 || Bebidas.Count < 0)
            {
                MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DialogResult.OK == MessageBox.Show("¿Confirmar?", "Orden", MessageBoxButtons.OKCancel))
            {
                var ordenC = orden.CrearOrden(txtNombre.Text, Entradas, Platos, Postres, Bebidas);
                mesa.AgregarOrden(Convert.ToInt32(lblNumeroMesa.Text),ordenC);
            }
            else
            {
                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
                this.Hide();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pbVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
