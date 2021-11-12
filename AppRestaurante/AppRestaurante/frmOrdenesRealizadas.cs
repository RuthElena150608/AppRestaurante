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
    public partial class frmOrdenesRealizadas : Form
    {
        ServicioMesa servicioMesa = new ServicioMesa();
        public frmOrdenesRealizadas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOrdenesRealizadas_Load(object sender, EventArgs e)
        {
            var source = servicioMesa.ObtenerTodasLasOrdenes();
            source.ForEach(item =>
            {
                DataGridViewComboBoxCell dgvCmb = new DataGridViewComboBoxCell();
                string s2 = "";
                int i = 0;
                item.Item2.ForEach(o =>
                {
                    o.ForEach(el =>
                    {
                        i++;
                        s2 += $"{i}-{el} ";
                    });
                });

                dataGridView1.Rows.Add(item.Item1, s2);
            });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();

        }
    }
}
