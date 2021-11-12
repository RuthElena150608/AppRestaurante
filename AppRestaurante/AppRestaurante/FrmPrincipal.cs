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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

            ServicioMesa servicioMesa = new ServicioMesa();
        private void Form1_Load(object sender, EventArgs e)
        {
              MesasDisponibles();

        }

        public void MesasDisponibles()
        {
          
            cmbMesasDisponibles.DataSource = servicioMesa.ObtenerMesas().Select(m => m.NumeroMesa).ToArray();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        
        private void cmbMesasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
         
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            frmAgregarOrden frmAgregarOrdenO = new frmAgregarOrden();
            frmAgregarOrdenO.lblNumeroMesa.Text = cmbMesasDisponibles.SelectedItem.ToString();
            frmAgregarOrdenO.Show();
            this.Hide();
          

        }

        private void btnVerOrdenes_Click(object sender, EventArgs e)
        {
            frmOrdenesRealizadas ordenesRealizadas = new frmOrdenesRealizadas();
            ordenesRealizadas.Show();
            this.Hide();
        }
    }
}
