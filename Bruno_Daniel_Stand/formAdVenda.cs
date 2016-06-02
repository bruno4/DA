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
    public partial class formAdVenda : Form
    {
        private meuStandRealContainer meustand;

        private Cliente clienteSeleccionado;


        public formAdVenda(Cliente clienteSeleccionado, meuStandRealContainer meustand)
        {
            InitializeComponent();

            this.clienteSeleccionado = clienteSeleccionado;
            this.meustand = meustand;

        }

        private void formAdVenda_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            Venda sale = new Venda();


            sale.Data = txtData.Text;
            sale.Estado = txtEstado.Text;

            Decimal valorAdicionar = 0;
            try
            {
                valorAdicionar = Decimal.Parse(txtValor.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("O valor inserido não é válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sale.Valor = valorAdicionar;



            clienteSeleccionado.Vendas.Add(sale);

            meustand.SaveChanges();

        }
    }
}
