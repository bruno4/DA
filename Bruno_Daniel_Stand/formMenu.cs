using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bruno_Daniel_Stand
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDataHoras.Text = DateTime.Now.ToString();
        }

        private void btnFichCliente_Click(object sender, EventArgs e)
        {
            this.Hide();

            formFichaCliente ffc = new formFichaCliente();

            ffc.Show();
        }

        private void btnOficina_Click(object sender, EventArgs e)
        {
            this.Hide();

            formOficina ffo = new formOficina();

            ffo.Show();
        }

        private void btnAluguer_Click(object sender, EventArgs e)
        {
            this.Hide();

            formAluguer fa = new formAluguer();

            fa.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            this.Hide();

            formVenda fv = new formVenda();

            fv.Show();
        }

        private void btnCarros_Click(object sender, EventArgs e)
        {
            this.Hide();

            formCarros fc = new formCarros();

            fc.Show();
        }
    }
}
